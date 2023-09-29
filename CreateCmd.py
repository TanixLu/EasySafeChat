import base64
from zipfile import ZipFile, ZIP_LZMA
import os

project_name = 'EasySafeChat'
exe_name = project_name + '.exe'
exe_path = 'bin/release/' + exe_name
zip_path = project_name + '.zip'
cmd_path = 't.cmd'

MAX_CHAR_NUM = 2231

with ZipFile(zip_path, 'w', compression=ZIP_LZMA, compresslevel=9) as zip_obj:
    zip_obj.write(exe_path, exe_name)

lines = []
with open(zip_path, 'rb') as f:
    file_bytes = f.read()
    base64_text = base64.b64encode(file_bytes).decode()
    while len(base64_text) > MAX_CHAR_NUM:
        lines.append(base64_text[:MAX_CHAR_NUM])
        base64_text = base64_text[MAX_CHAR_NUM:]

os.remove(zip_path)

with open(cmd_path, 'w') as f:
    f.write('@echo off\nset f=EasySafeChat\n')
    f.write(f'echo {lines[0]}> "%f%.txt"\n')
    for i in range(1, len(lines)):
        f.write(f'echo {lines[i]}>> "%f%.txt"\n')
    f.write(r'''certutil -decode "%f%.txt" "%f%.zip"
del "%f%.txt"
tar -xf "%f%.zip"
del "%f%.zip"''')
