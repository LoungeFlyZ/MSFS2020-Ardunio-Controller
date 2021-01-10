using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFSConnector
{
    class HornerScheme
    {
        public static uint Bcd2Dec(uint num)
        {
            return Apply(num, 0x10, 10);
        }

        /// Converts from integer to binary coded decimal /// /// ///
        public static uint Dec2Bcd(uint num)
        {
            return Apply(num, 10, 0x10);
        }
        static private uint Apply(uint Num, uint Divider, uint Factor)
        {
            uint Remainder = 0,
                Quotient = 0,
                Result = 0;

            Remainder = Num % Divider;
            Quotient = Num / Divider;

            if (!(Quotient == 0 && Remainder == 0))
                Result += Apply(Quotient, Divider, Factor) * Factor + Remainder;

            return Result;
        }


    }
}
