using System;
using System.Collections.Generic;
using System.Linq;

namespace MSILED
{


    public class LightControl
    {


        public LightControl()
        {
        }


        public string LightControlInit()
        {

            string error = "";


            // Initialize API
            if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_Initialize(), out error))
            {
                return "Initialize Error: " + error;
            }


            return (error) ?? "";
        }




        public string GetRGBDevices(out RGBDevice[] rgbdevices)
        {
            rgbdevices = null;
            string error = "";


            string[] devTypes;
            string[] ledCount;

            // Fetch devices
            if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_GetDeviceInfo(out devTypes, out ledCount), out error))
            {
                return "GetDeviceInfo Error: " + error;
            }



            List<RGBDevice> rgbdevList = new List<RGBDevice>();

            for (int i = 0; i < devTypes.Length; i++)
            {
                string _devtype = devTypes[i];
                uint _ledCount = UInt32.Parse(ledCount[i]);
                string _devName = "";


                //get device name
                if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_GetDeviceNameEx(_devtype, Convert.ToUInt32(i), out _devName), out error))
                {
                    return "GetDeviceNameEx Error: " + error;
                }


                //set leddevice
                List<LEDDevice> ledList = new List<LEDDevice>();

                for (uint ledIndex = 0; ledIndex < _ledCount; ledIndex++)
                {
                    ledList.Add(new LEDDevice(_devtype, ledIndex));
                }

                LEDDevice[] ledarr = ledList.ToArray();


                RGBDevice rgbdev = new RGBDevice();
                rgbdev.DevType = _devtype;
                rgbdev.ledCount = _ledCount;
                rgbdev.DevName = _devName;
                rgbdev.leddevices = ledarr;

                rgbdevList.Add(rgbdev);
            }

            rgbdevices = rgbdevList.ToArray();

            return (error) ?? "";
        }



        public string GetDevLed_Color(RGBDevice rgbdev, int ledidx, out RGBColor color)
        {
            // get device specific led color
            color = null;
            string error = "";

            try
            {
                if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_GetLedColor(rgbdev.DevType, Convert.ToUInt32(ledidx), out uint R, out uint G, out uint B), out error))
                    return "GetLedColor Error: " + error;

                color = new RGBColor(R, G, B);
            }
            catch {  }

            return (error) ?? "";
        }


        public string GetDevLed_Style(RGBDevice rgbdev, int ledidx, out string style)
        {
            // get device specific led style
            style = "";
            string error = "";

            try
            {
                if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_GetLedStyle(rgbdev.DevType, Convert.ToUInt32(ledidx), out string _currentStyle), out error))
                    return "GetLedStyle Error: " + error;

                style = _currentStyle;
            }
            catch { }

            return (error) ?? "";
        }


        public string GetDevLed_Speed(RGBDevice rgbdev, int ledidx, out uint speed)
        {
            // get device specific led style
            speed = 0;
            string error = "";

            try
            {
                if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_GetLedSpeed(rgbdev.DevType, Convert.ToUInt32(ledidx), out uint _speed), out error))
                    return "GetLedSpeed Error: " + error;

                speed = _speed;
            }
            catch { }

            return (error) ?? "";
        }


        public string GetDevLed_Brightness(RGBDevice rgbdev, int ledidx, out uint brightness)
        {
            // get device specific led brightness
            brightness = 0;
            string error = "";

            try
            {
                if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_GetLedBright(rgbdev.DevType, Convert.ToUInt32(ledidx), out uint _brightness), out error))
                    return "GetLedBright Error: " + error;

                brightness = _brightness;
            }
            catch { }

            return (error) ?? "";
        }



        public string SetDevLed_Brightness(RGBDevice rgbdev, int ledidx, uint brightness)
        {
            // set device specific led brightness
            string error = "";

            if (brightness <= rgbdev.leddevices[ledidx].MaxBrightness)
            {
                try
                {
                    if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_SetLedBright(rgbdev.DevType, Convert.ToUInt32(ledidx), brightness), out error))
                        return "SetLedBright Error: " + error;
                }
                catch { }
            }
            else
            {
                return "SetLedBright Error: " + String.Format("Max brightness is {0}", rgbdev.leddevices[ledidx].MaxBrightness);
            }

            return (error) ?? "";
        }


        public string SetDevLed_Speed(RGBDevice rgbdev, int ledidx, uint speed)
        {
            // set device specific led speed
            string error = "";

            if (speed <= rgbdev.leddevices[ledidx].MaxSpeed)
            {
                try
                {
                    if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_SetLedSpeed(rgbdev.DevType, Convert.ToUInt32(ledidx), speed), out error))
                        return "SetLedSpeed Error: " + error;
                }
                catch { }
            }
            else
            {
                return "SetLedSpeed Error: " + String.Format("Max speed is {0}", rgbdev.leddevices[ledidx].MaxSpeed);
            }

            return (error) ?? "";
        }


        public string SetDevLed_Style(RGBDevice rgbdev, int ledidx, string style)
        {
            // set device specific led style
            string error = "";

            if (rgbdev.leddevices[ledidx].StyleList.Contains(style))
            {
                try
                {
                    if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_SetLedStyle(rgbdev.DevType, Convert.ToUInt32(ledidx), style), out error))
                        return "SetLedStyle Error: " + error;
                }
                catch { }
            }
            else
            {
                return "SetLedStyle Error: Style not supported";
            }

            return (error) ?? "";
        }


        public string SetDevLed_Color(RGBDevice rgbdev, int ledidx, RGBColor color)
        {
            // set device specific led color
            string error = "";

            try
            {
                if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_SetLedColor(rgbdev.DevType, Convert.ToUInt32(ledidx), color.R, color.G, color.B), out error))
                    return "SetLedColor Error: " + error;
            }
            catch { }

            return (error) ?? "";
        }

    }



}
