# MSILED
Test c# windows form application to use MysticLight_SDK.dll to control MSI RGB led.  
In the project contains a little test form to test rgb led functions.

# Works only in administrator mode!
Run as administrator, otherwise MLAPI_initialize timeout occured.

# Usage:
LightControl lc = null;  
RGBDevice[] rgbDevices = null;  

lc = new LightControl();  
lc.LightControlInit();  
lc.GetRGBDevices(out rgbDevices);  

//get current style (device, ledidx)  
string currstyle = "";  
lc.GetDevLed_Style(rgbDevices[0], 0, out currstyle);  

//set current style (device, ledidx)  
string style = rgbDevices[0].leddevices[0].StyleList[6];  
lc.SetDevLed_Style(rgbDevices[0], 0, style);  
