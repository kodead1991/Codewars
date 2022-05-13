using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

            #region Printer Errors 7 kyu

            //In a factory a printer prints labels for boxes.
            //For one kind of boxes the printer has to use colors
            //which, for the sake of simplicity, are named with
            //letters from a to m. The colors used by the printer
            //are recorded in a control string.For example a "good"
            //control string would be aaabbbbhaijjjm meaning that
            //the printer used three times color a, four times color
            //b, one time color h then one time color a...
            //Sometimes there are problems: lack of colors, technical
            //malfunction and a "bad" control string is produced
            //e.g.aaaxbbbbyyhwawiwjjjwwm with letters not from a to m.
            //You have to write a function printer_error which
            //given a string will return the error rate of the
            //printer as a string representing a rational whose
            //numerator is the number of errors and the denominator
            //the length of the control string.Don't reduce this
            //fraction to a simpler expression. The string has a
            //length greater or equal to one and contains only letters from ato z.

            //Examples:

            //s = "aaabbbbhaijjjm"
            //printer_error (s) => "0/14"

            //s = "aaaxbbbbyyhwawiwjjjwwm"
            //printer_error (s) => "8/22"

            //Console.WriteLine(PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));

            #endregion

            #region Disemvowel Trolls 7 kyu

            //Trolls are attacking your comment section!
            //A common way to deal with this situation is
            //to remove all of the vowels from the trolls'
            //comments, neutralizing the threat. Your task
            //is to write a function that takes a string
            //and return a new string with all vowels removed.
            //For example, the string "This website is for
            //losers LOL!" would become "Ths wbst s fr lsrs LL!".
            //Note: for this kata y isn't considered a vowel.

            //Console.WriteLine(Disemvowel("This website is for losers LOL!"));
            //Console.WriteLine(Disemvowel("What are you, a communist?"));
            //Console.WriteLine(Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));

            #endregion

            #region Twice linear 4 kyu

            //Consider a sequence u where u is defined as follows:
            //The number u(0) = 1 is the first one in u.
            //For each x in u, then y = 2 * x + 1 and z = 3 * x + 1 must be in u too.
            //There are no other numbers in u.
            //Ex: u = [1, 3, 4, 7, 9, 10, 13, 15, 19, 21, 22, 27, ...]
            //1 gives 3 and 4, then 3 gives 7 and 10, 4 gives 9 and 13, then 7 gives 15 and 22 and so on...

            //Task:
            //Given parameter n the function dbl_linear(or dblLinear...) returns the element u(n)
            //of the ordered(with <) sequence u(so, there are no duplicates).

            //Example:
            //dbl_linear(10) should return 22

            //Note: Focus attention on efficiency

            //Console.WriteLine(DblLinear(10));
            //Console.WriteLine(DblLinear(20));
            //Console.WriteLine(DblLinear(30));
            //Console.WriteLine(DblLinear(50));

            #endregion

            #region 1/n- Cycle

            //Let be n an integer prime with 10 e.g. 7.

            //1 / 7 = 0.142857 142857 142857....We see that the
            //decimal part has a cycle: 142857.The length of
            //this cycle is 6.In the same way:

            //1 / 11 = 0.09 09 09....Cycle length is 2.

            //Task
            //Given an integer n(n > 1) the function cycle(n)
            //returns the length of the cycle if there is one otherwise
            //(n and 10 not coprimes) return -1.

            //Examples:
            //cycle(5) = -1
            //cycle(13) = 6-> 0.076923 076923 0769
            //cycle(21) = 6-> 0.047619 047619 0476
            //cycle(27) = 3-> 0.037 037 037 037 0370
            //cycle(33) = 2-> 0.03 03 03 03 03 03 03 03
            //cycle(37) = 3-> 0.027 027 027 027 027 0
            //cycle(94) = -1
            //Notes
            ///cycle(22) = -1 since 1 / 22 ~0.0 45 45 45 45...

            //Console.WriteLine(Running(33) + " 2");
            //Console.WriteLine(Running(18118) + " -1");
            //Console.WriteLine(Running(69) + " 22");
            //Console.WriteLine(Running(197) + " 98");
            //Console.WriteLine(Running(65) + " -1");

            #endregion

            #region A Rule of Divisibility by 7

            //A number m of the form 10x + y is divisible by 7
            //if and only if x − 2y is divisible by 7.In other
            //words, subtract twice the last digit from the number
            //formed by the remaining digits. Continue to do this
            //until a number known to be divisible by 7 is obtained;
            //you can stop when this number has at most 2 digits
            //because you are supposed to know if a number of at
            //most 2 digits is divisible by 7 or not.
            //The original number is divisible by 7 if and only
            //if the last number obtained using this procedure
            //is divisible by 7.
            //Examples:
            //1 - m = 371-> 37 − (2×1) -> 37 − 2 = 35; thus,
            //since 35 is divisible by 7, 371 is divisible by 7.
            //The number of steps to get the result is 1.
            //2 - m = 1603-> 160 - (2 x 3) -> 154-> 15 - 8 = 7 and 7 is divisible by 7.
            //3 - m = 372-> 37 − (2×2) -> 37 − 4 = 33; thus,
            //since 33 is not divisible by 7, 372 is not divisible by 7.
            //4 - m = 477557101->47755708->4775554->477547->47740->4774->469->28
            //and 28 is divisible by 7, so is 477557101.The number of steps is 7.
            //Task:
            //Your task is to return to the function seven(m)(m integer >= 0)
            //an array(or a pair, depending on the language) of numbers, the
            //first being the last number m with at most 2 digits obtained by
            //your function(this last m will be divisible or not by 7), the
            //second one being the number of steps to get the result.
            //Forth Note:
            //Return on the stack number - of - steps, last - number - m - with - at - most - 2 - digits
            //Examples:
            //seven(371) should return [35, 1]
            //seven(1603) should return [7, 2]
            //seven(477557101) should return [28, 7]

            //var s = Seven(371);
            //Console.WriteLine("{0}-{1}", s[0], s[1]);

            //s = Seven(1021);
            //Console.WriteLine("{0}-{1}", s[0], s[1]);

            //s = Seven(1603);
            //Console.WriteLine("{0}-{1}", s[0], s[1]);

            //var s = Seven(477557101);
            //Console.WriteLine("{0}-{1}", s[0], s[1]);

            #endregion
        }

        public static long[] Seven(long m)
        {
            // your code
            long step = 0;
            while (m > 99)
            {
                m = m / 10 - m % 10 * 2;
                step++;
            }
            return new long[] { m, step };
        }

        public static int Running(int n)
        {
            // your code
            if (n % 2 == 0 || n % 5 == 0) return -1;

            var val = 1;
            var let = 0;
            while (true)
            {
                val = val * 10 % n;
                let++;
                if (val == 1)
                    return let;
            }
        }

        public static int DblLinear(int n)
        {
            SortedSet<int> u = new SortedSet<int> { 1 };

            while (n > 0)
            {
                u.Add(2 * u.Min + 1);
                u.Add(3 * u.Min + 1);
                u.Remove(u.Min);
                n--;
            }
            return u.Min;
        }

        public static string Disemvowel(string str)
        {
            //return Regex.Replace(str, "(?i)[aeiouy]", "",RegexOptions.IgnoreCase);
            return string.Concat(str.Where(i => !"aeiouAEIOU".Contains(i)));
        }

        public static string PrinterError(string s)
        {
            // your code
            return string.Concat(s.Count(i => i < 'a' || i > 'm'), "/", s.Length);
        }

        public static int Number(List<int[]> peopleListInOut)
        {
            // Happy Coding
            return peopleListInOut.Sum(i => i[0] - i[1]);
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
