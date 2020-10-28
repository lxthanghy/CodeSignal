using System;
using System.Collections.Generic;
using System.Text;

namespace CodeLearn
{
    public class Bai04FE01
    {
        public int usc(int a, int b)
        {
            if (a % b == 0) return b;
            else return usc(b, a % b);
        }

        public void cauB()
        {
            for (int i = 10; i <= 99; ++i)
            {
                string tmp = i + "";
                //12 => tmp = "12"
                //11 22 33 44
                if (tmp[0] != tmp[1])
                {
                    // x là cái số đảo ngược
                    //10 20 30 40
                    //13 31
                    //3+""+1=>31
                    //"3"+1=>"31"
                    int x = tmp[1] == '0' ? int.Parse(tmp[0] + "") : int.Parse(tmp[1] + "" + tmp[0]);
                    if (usc(i, x) == 1)
                        Console.WriteLine("{0}", i);
                }
            }
        }
    }
}