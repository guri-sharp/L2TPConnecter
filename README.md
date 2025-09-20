L2TPConnecter
Note: This tool only supports L2TP/IPsec connections using pre-shared keys with username and password authentication.
Due to limitations in YAMAHA's connection tools (maximum 20 configurations), I created this for personal use.
It uses PowerShell for control, so it should work on Windows until L2TP/IPsec becomes unsupported.
To-do list
• 	Make the UI cooler
• 	Add an icon
• 	~~Multilingual support~~
• 	~~Mutex~~
• 	~~High DPI support~~


[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F1F11LHAIN)  

Overview
L2TPConnecter is a desktop application for managing and operating VPN connections in Windows.
It allows you to save multiple VPN configurations and easily connect, disconnect, and check connection status.
Main Features
• 	Register, edit, and delete multiple VPN configurations
• 	Connect/disconnect/check status using PowerShell
• 	Real-time connection status display (with color indicators)
• 	Detailed logs for connection/disconnection events
• 	Save/load configuration data as JSON files
How to Use
1. 	Launch the application and add VPN configurations.
2. 	Select the VPN you want to connect to from the list and click the connect/disconnect button.
3. 	Check progress and results in the dialog log.
4. 	Settings are saved automatically and restored on next launch.
Requirements
• 	Windows 10/11
• 	.NET Framework 4.8
• 	PowerShell (standard installation)
Notes
• 	Administrator privileges may be required for VPN connections.
• 	Since PowerShell commands are used, please be cautious about security policies.
License
This software is released under the MIT License.
  
