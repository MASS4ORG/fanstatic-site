document.addEventListener('DOMContentLoaded', () => {
    const terminal = document.querySelector('.terminal-body');
    if (!terminal) return;

    const lines = [
        { type: 'input', text: 'fanstatic new-site ./my-blog' },
        { type: 'output', text: '✓ Created site at ./my-blog' },
        { type: 'input', text: 'cd my-blog && fanstatic serve' },
        { type: 'output', text: '✓ Serving at http://localhost:2341' },
        { type: 'output', text: '✓ Watching for changes...' },
        { type: 'cursor', text: '█' }
    ];

    terminal.innerHTML = '';
    let lineIndex = 0;

    function typeLine() {
        if (lineIndex >= lines.length) return;

        const line = lines[lineIndex];
        const p = document.createElement('p');
        
        if (line.type === 'input') {
            const prompt = document.createElement('span');
            prompt.className = 'term-prompt';
            prompt.textContent = '$ ';
            p.appendChild(prompt);
            terminal.appendChild(p);
            
            let charIndex = 0;
            const interval = setInterval(() => {
                p.appendChild(document.createTextNode(line.text[charIndex]));
                charIndex++;
                if (charIndex >= line.text.length) {
                    clearInterval(interval);
                    lineIndex++;
                    setTimeout(typeLine, 500);
                }
            }, 50);
        } else if (line.type === 'output') {
            p.className = 'term-out';
            if (line.text.includes('http')) {
                const parts = line.text.split('http');
                p.textContent = parts[0];
                const link = document.createElement('span');
                link.className = 'term-link';
                link.textContent = 'http' + parts[1];
                p.appendChild(link);
            } else {
                p.textContent = line.text;
            }
            terminal.appendChild(p);
            lineIndex++;
            setTimeout(typeLine, 700);
        } else if (line.type === 'cursor') {
            const cursor = document.createElement('span');
            cursor.className = 'term-cursor';
            cursor.textContent = line.text;
            p.appendChild(cursor);
            terminal.appendChild(p);
        }
    }

    setTimeout(typeLine, 1000);
});
