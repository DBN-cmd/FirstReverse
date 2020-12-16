using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReverse
{
    class Program
    {
        public static string FirstReverse(string str)
        {

            // code goes here  
            int strCount = str.Count();
            string revstr;
            var sb = new StringBuilder();
            int n = 0;

            for (int i = strCount; i > 0; i--)
            {
                sb.Append(str[strCount - 1]);
                n += 1;
                strCount -= 1;

            }
            revstr = sb.ToString();
            str = revstr;
            return str;

        }

        static void Main(string[] args)
        {
            // keep this function call here
            Console.WriteLine(FirstReverse(Console.ReadLine()));
        }
    }
}
