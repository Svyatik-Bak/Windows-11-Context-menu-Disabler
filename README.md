# Windows-11-Context-menu-Disabler
This tool allows you to change the context menu of Windows 11

![Screenshot_2022-08-35-22-17-27-47-612](https://user-images.githubusercontent.com/89962566/185959279-0482777e-b684-4a27-aaf5-5d25dd7e9342.png)

# Command Prompt
Disable Windows 11 context menu: reg.exe add HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32 /f /ve

Enable Windows 11 context menu: reg delete HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2} /f
