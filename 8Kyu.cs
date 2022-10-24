using System;

public class 8KyuTasks
{

    // Create a function which translates a given DNA string into RNA. For example: "GCAT"  =>  "GCAU"
    // The input string can be of arbitrary length - in particular, it may be empty.
    // All input is guaranteed to be valid, i.e. each input string will only ever consist of 'G', 'C', 'A' and/or 'T'.

    public string dnaToRna(string dna)
    {
        return dna.Replace('T', 'U');
    }

    // Create a function which answers the question "Are you playing banjo?".
    // If your name starts with the letter "R" or lower case "r", you are playing banjo!
    // The function takes a name as its only argument, and returns one of the following strings:
    // name + " plays banjo" 
    // name + " does not play banjo"
    // Names given are always valid strings.

    public static string AreYouPlayingBanjo(string name)
    {
        if (name.ToLower().StartsWith("r"))
        {
            return name + " plays banjo";
        }
        else
        {
            return name + " does not play banjo";
        }
    }

    // Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.

    public static string RepeatStr(int n, string s)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            sb.Append(s);
        }
        return sb.ToString();
    }

    // Given an array of integers your solution should find the smallest integer.
    // You can assume, for the purpose of this kata, that the supplied array will not be empty.

    public static int FindSmallestInt(int[] args)
    {
        return args.Min();
    }

    // Write a function which calculates the average of the numbers in a given list.
    // Note: Empty arrays should return 0.

    public static double FindAverage(double[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }
        else return array.Average();
    }

    // Given a non - empty array of integers, return the result of multiplying the values together in order.

    public static int Grow(int[] x)
    {
        int result = 1;
        for (int i = 0; i < x.Length; i++)
        {
            result *= x[i];
        }
        return result;
    }

    // Create a method to see whether the string is ALL CAPS.
    // In this Kata, a string is said to be in ALL CAPS whenever it does not contain any lowercase letter so any string containing no letters at all is trivially considered to be in ALL CAPS.

    public static bool IsUpperCase(this string text)
    {
        if (text == text.ToUpper()) return true;
        else return false;
    }

    // Consider an array/list of sheep where some sheep may be missing from their place. We need a function that counts the number of sheep present in the array (true means present).
    // Hint: Don't forget to check for bad values like null/undefined

    public static int CountSheeps(bool[] sheeps)
    {
        int res = 0;
        foreach (bool b in sheeps)
        {
            if (b.ToString() != null && b != false)
            {
                res++;
            }
        }
        return res;
    }

    // Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.

    public static int[] InvertValues(int[] input)
    {
        return input.Select(n => -n).ToArray();
    }

    // Make a function that will return a greeting statement that uses an input; your program should return, "Hello, <name> how are you doing today?".

    public static string Greet(string name)
    {
        return "Hello, " + name + " how are you doing today?";
    }

    // Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.

    public static string EvenOrOdd(int number)
    {
        if (number % 2 == 0 || number == 0)
        {
            return "Even";
        }
        else return "Odd";
    }

    // Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

    public static long[] Digitize(long n)
    {
        return n.ToString()
          .ToCharArray()
          .Select(c => long.Parse(c.ToString()))
          .Reverse()
          .ToArray();
    }

    // In this simple assignment you are given a number and have to make it negative. But maybe the number is already negative?
    // The number can be negative already, in which case no change is required.
    // Zero (0) is not checked for any specific sign. Negative zeros make no mathematical sense.

    public static int MakeNegative(int number)
    {
        if (number <= 0)
        {
            return number;
        }
        else
        {
            return 0 - number;
        }
    }

    // There was a test in your class and you passed it. Congratulations!
    // But you're an ambitious person. You want to know if you're better than the average student in your class.
    // You receive an array with your peers' test scores. Now calculate the average and compare your score!
    // Return True if you're better, else False!

    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        int avg;
        int sum = 0;

        for (int i = 0; i < ClassPoints.Length; i++)
        {
            sum += ClassPoints[i];
        }
        avg = sum / ClassPoints.Length;

        if (avg > YourPoints) return false;
        else return true;
    }

    // This code does not execute properly. Try to figure out why.

    public static int Multiply(int a, int b)
    {
        return a * b;
    }



}
