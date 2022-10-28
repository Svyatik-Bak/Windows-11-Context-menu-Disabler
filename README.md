# Windows-11-Context-menu-Disabler
This tool allows you to change the context menu of Windows 11

![2022-10-28-13-38-57-095](https://user-images.githubusercontent.com/89962566/198568372-b4b3e8bf-9878-47b3-92e1-bd3bedf715b7.jpg)

Disable Windows 11 context menu: 

```reg.exe add HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32 /f /ve```


Enable Windows 11 context menu: 

```reg delete HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2} /f```
