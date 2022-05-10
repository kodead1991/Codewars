using System;
using System.Linq;
using System.Collections.Generic;

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

            #region DNA 7 kyu

            //In DNA strings, symbols "A" and "T" are complements of each other,
            //as "C" and "G".You function receives one side of the DNA(string, except
            //for Haskell) ; you need to return the other complementary side.DNA strand
            //is never empty or there is no DNA at all(again, except for Haskell).

            //More similar exercise are found here: http://rosalind.info/problems/list-view/ (source)

            //Example: (input-- > output)

            //"ATTGC"-- > "TAACG"
            //"GTAT"-- > "CATA"
            //dnaStrand[]        `shouldBe` []
            //dnaStrand[A, T, G, C] `shouldBe` [T, A, C, G]
            //dnaStrand[G, T, A, T] `shouldBe` [C, A, T, A]
            //dnaStrand[A, A, A, A] `shouldBe` [T, T, T, T]

            //Console.WriteLine("ATTGC" + "-" + MakeComplement("ATTGC"));

            #endregion

            #region Get the Middle Character 7 kyu

            //You are going to be given a word. Your job is to return
            //the middle character of the word.If the word's length is odd,
            //return the middle character. If the word's length is even,
            //return the middle 2 characters.

            //# Examples:
            //Kata.getMiddle("test") should return "es"
            //Kata.getMiddle("testing") should return "t"
            //Kata.getMiddle("middle") should return "dd"
            //Kata.getMiddle("A") should return "A"

            //#Input
            //A word(string) of length 0 < str < 1000
            //(In javascript you may get slightly more than 1000 in some test
            //cases due to an error in the test cases).You do not need to test
            //for this.This is only here to tell you that you do not need to
            //worry about your solution timing out.

            //#Output
            //The middle character(s) of the word represented as a string.

            //Console.WriteLine(GetMiddle("T"));
            //Console.WriteLine(GetMiddle("test"));
            //Console.WriteLine(GetMiddle("testing"));

            #endregion

            #region Sum of positive 8 kyu

            //You get an array of numbers, return the sum of all of the positives ones.

            //Example[1, -4, 7, 12] => 1 + 7 + 12 = 20

            //Note: if there is nothing to sum, the sum is default to 0.

            //Console.WriteLine(PositiveSum(new int[] { -1, 2, 3, 4, -5 }));

            #endregion

            #region Remove String Spaces 8 kyu

            //Simple, remove the spaces from the string, then return the resultant string.
            //Console.WriteLine(NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"));

            #endregion

            #region Convert a String to a Number! 8 kyu

            //We need a function that can transform a string
            //into a number. What ways of achieving this do you know?

            //Note: Don't worry, all inputs will be strings, and every
            //string is a perfectly valid representation of an integral number.

            //Examples
            //"1234"-- > 1234
            //"605"-- > 605
            //"1405"-- > 1405
            //"-7"-- > -7

            //Console.WriteLine(StringToNumber("-12345"));
            //Console.WriteLine(StringToNumber("54321"));

            #endregion

            #region Beginner Series #3 Sum of Numbers 7 kyu

            //Given two integers a and b, which can be positive or negative,
            //find the sum of all the integers between and including them and
            //return it.If the two numbers are equal return a or b.

            //Note: a and b are not ordered!

            //Examples(a, b)-- > output(explanation)
            //(1, 0)-- > 1(1 + 0 = 1)
            //(1, 2)-- > 3(1 + 2 = 3)
            //(0, 1)-- > 1(0 + 1 = 1)
            //(1, 1)-- > 1(1 since both are same)
            //(-1, 0)-- > -1(-1 + 0 = -1)
            //(-1, 2)-- > 2(-1 + 0 + 1 + 2 = 2)

            //Console.WriteLine("(1,0)-- > 1(1 + 0 = 1) = {0}", GetSum(1, 0));
            //Console.WriteLine("(1,2)-- > 3(1 + 2 = 3) = {0}", GetSum(1, 2));
            //Console.WriteLine("(0,1)-- > 1(0 + 1 = 1) = {0}", GetSum(0, 1));
            //Console.WriteLine("(1,1)-- > 1(1 since both are same) = {0}", GetSum(1, 1));
            //Console.WriteLine("(-1,2)-- > 2(-1 + 0 + 1 + 2 = 2) = {0}", GetSum(-1, 2));

            #endregion

            #region Number of People in the Bus 7 kyu

            //There is a bus moving in the city, and it takes
            //and drop some people in each bus stop.
            //You are provided with a list(or array) of integer pairs.
            //Elements of each pair represent number of people get
            //into bus(The first item) and number of people get off
            //the bus(The second item) in a bus stop.
            //Your task is to return number of people who are still
            //in the bus after the last bus station(after the last array).
            //Even though it is the last bus stop, the bus is not empty
            //and some people are still in the bus, and they are probably
            //sleeping there: D
            //Take a look on the test cases.
            //Please keep in mind that the test cases ensure that the
            //number of people in the bus is always >= 0.So the return
            //integer can't be negative. The second value in the first

            //Console.WriteLine(Number(new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } }));

            #endregion
        }

        public static int Number(List<int[]> peopleListInOut)
        {
            // Happy Coding
            return peopleListInOut.Sum(i=> i[0] - i[1]);
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

            return string.Concat(q.Max(), ' ', q.Min());
        }

        public static string MakeComplement(string dna)
        {
            //var d = "";
            //for (int i = 0; i < dna.Length; i++)
            //{
            //    switch (dna[i])
            //    {
            //        case 'A': d += "T"; break;
            //        case 'T': d += "A"; break;
            //        case 'C': d += "G"; break;
            //        case 'G': d += "C"; break;
            //    }
            //}
            //return d;

            return string.Join("", dna.Select(i => "AGCT"["TCGA".IndexOf(i)]));
        }

        public static string GetMiddle(string s)
        {
            //Code goes here!
            if (string.IsNullOrEmpty(s) || s.Length == 0)
                return "";

            return (s.Length % 2 == 0) ? s.Substring((s.Length - 1) / 2, 2) : s.Substring(s.Length / 2, 1);
        }

        public static int PositiveSum(int[] arr)
        {
            // Your code here
            //return arr.Sum(i => i > 0 ? i : 0);
            return arr.Where(i => i > 0).Sum();
        }

        public static string NoSpace(string input)
        {
            //Code it!
            //return string.Concat(input.Split(' '));
            return input.Replace(" ", "");
        }

        public static int StringToNumber(string str)
        {
            //TODO: Convert str into a number
            return int.Parse(str);
        }

        public static int GetSum(int a, int b)
        {
            //Good Luck!
            int s = 0;
            if (a > b) s = a - b;
            else s = b - a;

            //return (a <= b) ? Enumerable.Range(a, b - a + 1).Sum(i => i) : Enumerable.Range(b, a - b + 1).Sum(i => i);
            return Enumerable.Range(a < b ? a : b, Math.Abs(a - b) + 1).Sum();
        }
    }
}
