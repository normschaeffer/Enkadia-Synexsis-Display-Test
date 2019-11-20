## Enkadia Synexsis Display Test - Windows UWP
A simple application to check if displays are powering on and off using the Synexsis Displays module. This sample demostrates
using Synexsis to control the displays of two different manufacturers.

### Devices and software used for this project:
  * Dell Inspiron laptop with touch screen
  * Windows 10
  * 2 - Sharp 70" LC series displays
  * 1 - Samsung 82" Q60 series display
  * 1 - USR-IOT USR-TCP232-302 (Ethernet to serial adapter)
  * Netgear 8 port switch
  
### Synexsis NuGet packages used - Available at the NuGet Repository (search Enkadia and check prerelease)
  * Enkadia.Synexsis.Components.Displays
  * Enkadia.Synexsis.ComponentFramework
  
### Additional Microsoft NuGet packages used
  * Microsoft.Extensions.DependencyInjection;
  
### Windows Target environments
   * Minimum Windows 10, version 1803
   * Maximum Windows 10, version 1809
   
### Configuring the Sharp displays for IP Control
  1. Set IP from Initial Setup | Internet Setup menu on TV
  2. Control Port - 10002
  3. Leave username and password blank
  4. Using Putty or similar terminal program send this one-time command-->>  RSPW2---   (--- = 3 spaces)
  5. Enable Quick start under TV Power menu
  
### Configuring the Ethernet to Serial adapter for use with Samsung ExLink
  1. Connect a network cable between your computer and the USR-IOT adapter
  2. Set your network card based on the IP address found on the USR-IOT adapter. (Example: Adapter is often set to 192.168.0.1, computer network card set to 192.168.0.10)
  3. Open a browser and connect to the adapter 
  4. Click the Local IP Config button on the left navigation bar
  5. Set a static IP address on your control network
  6. Select Serial port and set:
     * Baud rate: 9600
     * Data size: 8
     * Parity: None
     * Stop bits: 1
     * Local Port Number: 23
     * Remote Port Number: n/a
     * Work Mode: TCP Server
     * Leave other items as is
   7. Select Misc Config
     * change if desired
     * **Note username and password are limited to five characters
   8. Select Reboot and restart the adapter.
   9. Reconfigure the network card on your computer to your control network and plug the serial adapter into your control network.
  10. Connect the DB9 to 3.5mm cable into the Serial adapter and ExLink port of the display
   
#### NOTE THIS TEST PLATFORM REQUIRES THE USE OF AN ENKADIA TEST LICENSE. TO REQUEST A LICENSE PLEASE SEE [enkadia.com](https://www.enkadia.com)
---
### Configuring your components
Synexsis builds your components by reading values from an `appsettings.json` file, located at the root of your program's runtime directory. Place your Synexsis Test License in the same folder.

```text
Place the appsettings.json file and license key in this folder.
This is an example for a release version running on a laptop:

   ApplicationName\bin\x86\Debug\AppX

```
#### Troubleshooting
If the application fails to start, verify the license and appsettings.json files are in the correct folder.

---
### Creating the appsettings.json file
This sample appsettings file demonstrates the configuration information needed to support a Vaddio Roboshot camera.

#### Sample appsettings.json
```json
{
    	"FrontDisplay": {
		"IPAddress": "192.168.1.82",
		"Port": 23,
	},
	"Rear1": {
		"IPAddress": "192.168.1.81",
		"Port":10002,
	},
	"Rear2": {
		"IPAddress": "192.168.1.81",
		"Port":10002,
	},
	"License": {
		"OfflineActivation": "true",
		"LicenseFileName": "SynexsisBetaKey.skm"
	}
}
```

