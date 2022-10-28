# Windows-11-Context-menu-Disabler
This tool allows you to change the context menu of Windows 11

coming son

# Command Prompt
Disable Windows 11 context menu: ```reg.exe add HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32 /f /ve```

Enable Windows 11 context menu: ```reg delete HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2} /f```
