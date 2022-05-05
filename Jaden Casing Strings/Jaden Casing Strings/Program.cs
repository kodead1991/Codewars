using System;
using System.Linq;

namespace Jaden_Casing_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToJadenCase("How can mirrors be real if our eyes aren't real"));
        }

        static string ToJadenCase(string phrase)
        {
            return String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));
        }
    }
}
