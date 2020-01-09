using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fnt20200102
{
    class Program
    {
        static string MilitaryTimeToRegulayTime(string militaryTime)
        {
            if (militaryTime.Length != 5) return "error";
            string[] SplitInput = militaryTime.Split(':');
            if (SplitInput.Length != 2) return "error";
            if (militaryTime[2] != ':') return "error";
            int Hour = 0, Minute = 0;
            if (!int.TryParse(SplitInput[0], out Hour)) return "error";
            if (!int.TryParse(SplitInput[1], out Minute)) return "error";
            if (Hour >= 24 | Hour < 0) return "error";
            if (Minute >= 60 | Minute < 0) return "error";
            bool IsAM = true;
            if (Hour >= 12) IsAM = false;
            if (Hour >= 12) Hour -= 12;
            if (Hour == 0) Hour = 12;
            string RegulayTime = Hour.ToString() + ":" + (Minute / 10).ToString() + (Minute % 10).ToString();
            if (IsAM) RegulayTime += " AM";
            else RegulayTime += " PM";
            return RegulayTime;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("請輸入時間");
                Console.WriteLine(MilitaryTimeToRegulayTime(Console.ReadLine()));
            }
        }
    }
}