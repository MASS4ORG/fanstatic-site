using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

// Configuration
string csprojPath = "../fanstatic/Fanstatic/Fanstatic.csproj";
string apiIndexPath = "content/api/index.md";
string projectPath = "../fanstatic";

if (!File.Exists(csprojPath))
{
    Console.WriteLine($"Error: {csprojPath} not found.");
    return;
}

// 1. Extract Version from .csproj
string csprojContent = File.ReadAllText(csprojPath);
var versionMatch = Regex.Match(csprojContent, @"<Version>(.*?)<\/Version>");
if (!versionMatch.Success)
{
    Console.WriteLine("Error: Version tag not found in csproj.");
    return;
}
string version = versionMatch.Groups[1].Value;
Console.WriteLine($"Detected Version: {version}");

// 2. Run fanstatic api command
string outputFolder = $"api/{version}";
string command = "fanstatic";
string commandArgs = $"api --project {projectPath} --output {outputFolder}";

Console.WriteLine($"Executing: {command} {commandArgs}");
var startInfo = new ProcessStartInfo
{
    FileName = command,
    Arguments = commandArgs,
    RedirectStandardOutput = true,
    RedirectStandardError = true,
    UseShellExecute = false,
    CreateNoWindow = true
};

using var process = Process.Start(startInfo);
if (process == null)
{
    Console.WriteLine("Error: Failed to start Fanstatic process.");
    return;
}

process.OutputDataReceived += (s, e) => { if (e.Data != null) Console.WriteLine(e.Data); };
process.ErrorDataReceived += (s, e) => { if (e.Data != null) Console.Error.WriteLine(e.Data); };

process.BeginOutputReadLine();
process.BeginErrorReadLine();
process.WaitForExit();

if (process.ExitCode != 0)
{
    Console.WriteLine($"Error: Fanstatic command failed with exit code {process.ExitCode}");
    return;
}

// 3. Update Title in generated _index.md
string versionIndexFile = Path.Combine("content", "api", version, "_index.md");
if (File.Exists(versionIndexFile))
{
    string content = File.ReadAllText(versionIndexFile);
    // Replace Title: "API" with Title: "version"
    string updatedContent = content.Replace("Title: \"API\"", $"Title: \"{version}\"");
    File.WriteAllText(versionIndexFile, updatedContent);
    Console.WriteLine($"Successfully updated Title in {versionIndexFile} to \"{version}\"");
}
else
{
    Console.WriteLine($"Warning: {versionIndexFile} not found. Skipping title update.");
}

// 4. Update content/api/index.md
if (File.Exists(apiIndexPath))
{
    var lines = File.ReadAllLines(apiIndexPath).ToList();
    string link = $"- [{version}](/api/{version})";

    if (!lines.Any(l => l.Contains(link)))
    {
        // Find the end of the YAML front matter
        int frontMatterEnd = -1;
        int dashCount = 0;
        for (int i = 0; i < lines.Count; i++)
        {
            if (lines[i].Trim() == "---")
            {
                dashCount++;
                if (dashCount == 2)
                {
                    frontMatterEnd = i;
                    break;
                }
            }
        }

        // Insert the new version link at the top of the list
        int insertPos = frontMatterEnd + 1;
        while (insertPos < lines.Count && string.IsNullOrWhiteSpace(lines[insertPos]))
        {
            insertPos++;
        }

        lines.Insert(insertPos, link);
        File.WriteAllLines(apiIndexPath, lines);
        Console.WriteLine($"Successfully updated {apiIndexPath} with {version}");
    }
    else
    {
        Console.WriteLine($"Version {version} is already listed in {apiIndexPath}");
    }
}
else
{
    Console.WriteLine($"Warning: {apiIndexPath} not found. Skipping index update.");
}

Console.WriteLine("API update completed successfully.");
