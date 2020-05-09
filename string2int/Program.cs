using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input text of number :");
            string inputStr = Console.ReadLine();
            
            converter(inputStr);

            Console.ReadKey();
        }
        public static int converter(string s)
        {
            //get only numeric text.
            string numberStr = "0123456789";
            string resultStr = "";
            for (int i = 0; i < s.Length; i++)
            {
                string n = s.Substring(i, 1);
                if (numberStr.Contains(n))
                {
                    resultStr += n;
                }
            }


            return strToInt(resultStr);
        }

        public static int strToInt(string s)
        {
            int r = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int v = 0;
                string n = s.Substring(i, 1);
                //หาตำแหน่งของตัวเลขว่าอยู่ลำดับที่เท่าไหร่ เพื่อหาค่าประจำหลักจากตำแหน่งนั้น
                int pos = s.Length - i;
                //คำนวนหาค่าประจำหลัก
                int indexValue = getIndexValue(pos);
                switch (n)
                {
                    case "0": v = 0; break;
                    case "1": v = 1; break;
                    case "2": v = 2; break;
                    case "3": v = 3; break;
                    case "4": v = 4; break;
                    case "5": v = 5; break;
                    case "6": v = 6; break;
                    case "7": v = 7; break;
                    case "8": v = 8; break;
                    case "9": v = 9; break;
                }
                r += v * indexValue;
            }
            Console.WriteLine(r);
            return r;
        }

        public static int getIndexValue(int pos)
        {
            int result = 1;
            if (pos > 1)
            {
                for (int i = 1; i < pos; i++)
                {
                    result *= 10;
                }

            }
            return result;
        }
    }
}
