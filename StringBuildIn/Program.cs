using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuildIn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compare strings
            string name = "Claudia";
            string secondName = "Claudia";
            int c = string.Compare(name, secondName);
            Console.WriteLine(c);

            //Concatenate strings
            string one = "Hello";
            string two = ", ";
            string three = "World";
            string four = "!";
            string concatenare = string.Concat(one, two, three, four);
            Console.WriteLine(concatenare);

            //Empty string
            string empty = string.Empty;

            //Check if string in null or empty
            string str = null;
            bool checkString = string.IsNullOrEmpty(str);
            Console.WriteLine(checkString);

            //Format string
            string day = "12";
            string month = "12";
            string year = "2018";
            string result = string.Format("{0}/{1}/{2:yyyy}", day, month, year);
            Console.WriteLine(result);

            //Start with, End with
            string str3 = "I need more sleep";
            bool testString = str3.StartsWith("more");
            bool testString2 = str3.EndsWith("ep");
            Console.WriteLine(testString);
            Console.WriteLine(testString2);


            //Contain substring
            string str2 = "Pentastagiu week 3";
            bool testSubstring = str2.Contains("Penta");
            Console.WriteLine(testSubstring);



        }
    }
}
