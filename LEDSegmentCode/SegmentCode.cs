using System;
using System.Collections.Generic;

namespace LEDSegmentCode
{
    public class SegmentCode
    {
        public Dictionary<char, int> dic = new Dictionary<char, int>();
        public Ode ode;

        public SegmentCode()
        {
            ode = Ode.anode;
            for(int i = 0; i < 8; i++)
            {
                dic[(char)(97 + i)] = 0;
            }
        }

        public String getCode()
        {
            Int32 date = 0x00;
            for (int i = 7; i >= 0; i--)
            {
                date <<= 1;
                date |= dic[(char)(97 + i)];
            }

            if (ode.Equals(Ode.anode))
            {
                date = ~date; 
            }
            String s = Convert.ToString(date, 16);
            return s.Substring(s.Length - 2, 2);
        }
    }
    public enum Ode
    {
        anode,
        cathode
    }
}
