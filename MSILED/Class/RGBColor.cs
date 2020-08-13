using System;


namespace MSILED
{


    public class RGBColor
    {
      
        private uint _r, _g, _b;

            
        public RGBColor(uint r, uint g, uint b)
        {
            R = r; G = g; B = b;
        }

        
       
        public uint R
        {
            get => _r;
            set
            {
                if (value <= 255)
                    _r = value;
            }
        }

       
        public uint G
        {
            get => _g;
            set
            {
                if (value <= 255)
                    _g = value;
            }
        }

       
        public uint B
        {
            get => _b;
            set
            {
                if (value <= 255)
                    _b = value;
            }
        }

      
        public override string ToString() {
            return String.Format("({0}, {1}, {2})", R, G, B);
        }

    }
}
