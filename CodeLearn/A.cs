using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CodeLearn
{
    public class B
    {
        static B()
        {
            Console.WriteLine("Static Constructor của B");
        }

        public B()
        {
            Console.WriteLine("Constructor B");
        }
    }

    public class D : B
    {
        static D()
        {
            Console.WriteLine("Static Constructor của D");
        }

        public D()
        {
            Console.WriteLine("Constructor của D");
        }
    }
}