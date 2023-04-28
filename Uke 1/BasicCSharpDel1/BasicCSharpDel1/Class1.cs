using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpDel1
{
    internal class Class1
    {
        static void Something()
        {
            // To string
            // anta variabel x
            var x = true;
            string s = " " + x;
            double d = 99.1234;
            string s2 = d.ToString("F");

            // To int
            int i = Convert.ToInt32(d);

            float f = Convert.ToSingle(i);
            float f2 = Convert.ToSingle(d);

            double d2 = Convert.ToDouble(s2);

        }
    }
}
