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

            #region Count the number of days between two dates 7 kyu

            //Console.WriteLine(GetDaysAlive(2000, 1, 1, 2000, 1, 10));

            #endregion

            #region Multiples of 3 or 5 6 kyu

            //If we list all the natural numbers below 10 that are
            //multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of
            //these multiples is 23.

            //Find the sum of all the multiples of 3 or 5 below 1000.

            //Console.WriteLine(Solution(10));

            #endregion

            #region Highest and Lowest 7 kyu

            //In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

            //Examples
            //Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
            //Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
            // Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
            // Notes
            // All numbers are valid Int32, no need to validate them.
            //There will always be at least one number in the input string.
            //Output string must be two numbers separated by a single space, and highest number is first.

            //Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));

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
            //return new DateTime(year2, month2, day2).Subtract(new DateTime(year,month,day)).Days;
            return (long)(new DateTime(year2, month2, day2) - new DateTime(year, month, day)).TotalDays;
        }

        public static int Solution(int value)
        {
            //if (value < 3) return 0;

            //int sum = 0;
            //for (int i = 3; i < value; i++)
            //    if (i % 3 == 0 || i % 5 == 0) 
            //        sum += i;

            //return sum;
            return Enumerable.Range(0, value).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        }

        public static string HighAndLow(string numbers)
        {
            // Code here or
            var q = numbers.Split(' ').Select(int.Parse);

            return string.Concat(q.Max(),' ',q.Min());
        }
    }
}
