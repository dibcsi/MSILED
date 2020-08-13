using System;
using System.Collections.Generic;


namespace MSILED
{
    public class LEDDevice
    {

        public uint MaxSpeed { get; }
        public uint MaxBrightness { get; }
        public string[] StyleList { get => _stylelist.ToArray(); }
        private readonly List<string> _stylelist = new List<string>();


        public LEDDevice(string devicetype, uint index)
        {
            
            // get Max speed
            try
            {
                if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_GetLedMaxSpeed(devicetype, index, out uint maxSpeed), out string error))
                    throw new Exception("get max speed error " + error);
                MaxSpeed = maxSpeed;
            }
            catch { MaxSpeed = 0; }


            // get Max brightness
            try
            {
                if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_GetLedMaxBright(devicetype, index, out uint maxBright), out string error))
                    throw new Exception("get Max brightness error " + error);
                MaxBrightness = maxBright;
            }
            catch { MaxBrightness = 0; }


            // get Led styles
            try
            {
                if (!SDK_Class.API_RESULT(SDK_Class.MLAPI_GetLedInfo(devicetype, index, out string _, out string[] styles), out string error))
                    throw new Exception("get Led styles error " + error);
                _stylelist = new List<string>(styles);
            }
            catch { _stylelist = new List<string>(); }

        }


    }


}
