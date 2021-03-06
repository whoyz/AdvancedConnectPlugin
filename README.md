# AdvancedConnectPlugin
AdvancedConnect is a plugin for [KeePass](http://keepass.info) password manager which gives you the possibility to provide different applications for direct connections.


## Requirements

- Microsoft Windows with .NET/[Mono](http://www.mono-project.com/download/) 2.0 or newer.
- Unix/Linux with [Mono](http://www.mono-project.com/download/) 2.0 or newer.
- [KeePass](http://keepass.info) version 2.28 or newer.


## Installation

- Download the [latest](https://github.com/aalbng/AdvancedConnectPlugin/releases/latest) release.
- Copy the AdvancedConnectPlugin.plgx in your KeePass directory and restart the application.

## Usage

- The plugin adds a new menu item named **AdvancedConnect** under **Tools** menu.
- Use the **Main** tab in the **Options** dialog to configure the custom fields from which the plugin gets the connection method and the connection options field (overrides default options). <br /><br />
On windows operation system the native remote desktop client have no option to provide the username and password via command-line. The built-in rdp support is a little workaround wich provides this functionality. You have to configure the keepass connection field (containing ip or hostname), a connection method (e.g. rdp) and you can set additional parameters (e.g. /w:1440 /h:900).<br />
- Use the **Applications** tab in the **Options** dialog to configure your connection applications. <br />
The **Path** and **Commandline Options** column is also supporting keepass placeholders and OS environment variables.
- To use a **portable configuration** you have to create an emtpy file named **AdvancedConnect.xml** next to **KeePass.exe**. <br />
(If a portable\admin configuration file is available, the default configuration *%appdata%\Keepass\AdvancedConnect.xml* will be ignored)


## Example
- Configure Method in URL
<p align="center"><img src="https://github.com/whoyz/AdvancedConnectPlugin/blob/master/Doc/AdvancedConnect_Options-MethodURL.png"/></p>

- Enabel/Disable Protocol
<p align="center"><img src="https://github.com/whoyz/AdvancedConnectPlugin/blob/master/Doc/AdvancedConnect_Options-Enbale&Disable.png"/></p>

- SimplifiedConfiguration
<p align="center"><img src="https://github.com/whoyz/AdvancedConnectPlugin/blob/master/Doc/AdvancedConnect_Options-SimplifiedConfiguration.png"/></p>

- Add your applications
<p align="center"><img src="https://github.com/aalbng/AdvancedConnectPlugin/blob/master/Doc/AdvancedConnect_Options-Applications.png"/></p>

- Start your applications directly from keepass
<p align="center"><img src="https://github.com/aalbng/AdvancedConnectPlugin/blob/master/Doc/Keepass_ContexMenu.png"/></p>

## Security

Please take note that launching applications via command-line can expose your password arguments in the taskmanager.

## Repository

The main repository is hosted on [GitHub](https://github.com/aalbng/AdvancedConnectPlugin).

## License

The source code in this repository is released under the Apache License, Version 2.0 license. <br />
See the [LICENSE](https://github.com/aalbng/AdvancedConnectPlugin/blob/master/AdvancedConnectPlugin/LICENSE.txt) file for details.


____
The AdvancedConnect plugin is inspired by [QuickConnect](https://github.com/cristianst85/QuickConnectPlugin) 
