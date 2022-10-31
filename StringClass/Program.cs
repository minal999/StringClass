using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello Welcome";
            string str2 = "Kajol";
            Console.WriteLine(str1.Length);
            Console.WriteLine(str2.Length);
            Console.WriteLine("----------------------");
            string str3 = str1.Substring(6);
            Console.WriteLine(str3);
            Console.WriteLine("----------------------");
            string str4 = String.Concat(str1 +" "+ str2);
            Console.WriteLine(str4);
            Console.WriteLine("----------------------");
            char[] chars = str1.ToCharArray(0,5);
            foreach(var c in chars)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine(str1.ToLower());
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine("----------------------");
            //str1.Trim();
            //str1.TrimStart();
            //str1.TrimEnd();
            bool result = str1.Contains("Welcome");
            Console.WriteLine(result);
            bool result2 = str1.Contains("Miss");
            Console.WriteLine(result2);
            Console.WriteLine("----------------------");
            string str5 = str1;
            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str5.GetHashCode());
            Console.WriteLine(str2.GetHashCode());
            Console.WriteLine("----------------------");
            bool result5=str1.Equals(str5);
            Console.WriteLine(result5);
            bool result6 = str1.Equals(str2);
            Console.WriteLine(result6);
        }
    }
}
