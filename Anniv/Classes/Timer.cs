using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace Anniv.Classes
{
    
    public static class Timer
    {
        public class ValidKey
        {
            public const int Day = 08;
            public const int Month = 05;
            public const int Year = 1392;
        }

        public static bool IsValid(int d,int m ,int y)
        {
            if (d==ValidKey.Day&&m==ValidKey.Month&&y==ValidKey.Year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}