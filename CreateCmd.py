import base64

zip_path = 'EasySafeChat.zip'
cmd_path = 't.cmd'

MAX_CHAR_NUM = 2231

lines = []
with open(zip_path, 'rb') as f:
    file_bytes = f.read()
    base64_text = base64.b64encode(file_bytes).decode()
    while len(base64_text) > MAX_CHAR_NUM:
        lines.append(base64_text[:MAX_CHAR_NUM])
        base64_text = base64_text[MAX_CHAR_NUM:]

with open(cmd_path, 'w') as f:
    f.write('@echo off\nset f=EasySafeChat\n')
    f.write(f'echo {lines[0]}> "%f%.txt"\n')
    for i in range(1, len(lines)):
        f.write(f'echo {lines[0]}>> "%f%.txt"\n')
    f.write(r'''certutil -decode "%f%.txt" "%f%.zip"
del "%f%.txt"
tar -xf "%f%.zip"
del "%f%.zip"''')
