using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeLearn
{
    public class Bai01FE02
    {
        public void bai01()
        {
            StreamReader sr = File.OpenText(@"E:\bai01_fe02_input.txt");
            string st = sr.ReadLine();
            string st1 = sr.ReadLine();
            int lengthSt1 = st1.Length;
            int length = st.Length - lengthSt1;
            int count = 0;
            string res = "";
            for (int i = 0; i <= length; ++i)
            {
                string tmp = st.Substring(i, lengthSt1);
                if (tmp == st1)
                {
                    ++count;
                    res += (i + 1) + "\t";
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(res);
        }
    }
}