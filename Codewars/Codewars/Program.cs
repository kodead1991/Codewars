using System;
using System.Linq;

namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Jaden Casing Strings 8 kyu

            //Jaden Smith, the son of Will Smith, is the star of films such as
            //The Karate Kid(2010) and After Earth(2013).Jaden is also known for
            //some of his philosophy that he delivers via Twitter.When writing on
            //Twitter, he is known for almost always capitalizing every word.
            //For simplicity, you'll have to capitalize each word, check out
            //how contractions are expected to be in the example below.
            //Your task is to convert strings to how they would be written by Jaden Smith.
            //The strings are actual quotes from Jaden Smith, but they are not capitalized
            //in the same way he originally typed them.
            //Example:
            //Not Jaden - Cased: "How can mirrors be real if our eyes aren't real"
            //Jaden - Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"

            //Console.WriteLine(ToJadenCase("How can mirrors be real if our eyes aren't real"));

            #endregion

            #region Sum Arrays 8 kyu

            //Write a function that takes an array of numbers and returns
            //the sum of the numbers. The numbers can be negative or non - integer.
            //If the array does not contain any numbers then you should return 0.

            //Examples

            //Input: [1, 5.2, 4, 0, -1]
            //Output: 9.2

            //Input: []
            // Output: 0

            //Input: [-2.398]
            //Output: -2.398

            //Assumptions
            //You can assume that you are only given numbers.
            //You cannot assume the size of the array.
            //You can assume that you do get an array and if the array is empty, return 0.

            //Console.WriteLine(SumArray(new double[] { 1, 5.2, 4, 0, -1 }));

            #endregion

            #region Beginner Series #2 Clock 8 kyu

            //Clock shows h hours, m minutes and s seconds after midnight.

            //Your task is to write a function which returns the time since midnight in milliseconds.

            //Example:
            //h = 0
            //m = 1
            //s = 1

            //result = 61000
            //Input constraints:

            //0 <= h <= 23
            //0 <= m <= 59
            //0 <= s <= 59

            //Console.WriteLine(Past(0, 1, 1));

            #endregion

            #region Count the number of days between two dates

            Console.WriteLine(GetDaysAlive(2000, 1, 1, 2000, 1, 10));

            #endregion
        }

        static string ToJadenCase(string phrase)
        {
            return String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));
        }

        static double SumArray(double[] array)
        {
            return array.Sum(i => i);
        }

        public static int Past(int h, int m, int s)
        {
            //return (h == 23 && m == 59 && s == 59) ? 0 : h * 60 * 60 * 1000 + m * 60 * 1000 + s * 1000;
            return (int)(new TimeSpan(h, m, s).TotalMilliseconds);
        }

        public static long GetDaysAlive(int year, int month, int day, int year2, int month2, int day2)
        {
            //var d1 = new DateTime(year, month, day);
            //var d2 = new DateTime(year2, month2, day2);
            
            return new DateTime(year2, month2, day2).Subtract(new DateTime(year,month,day)).Days;
        }
    }
}
