using System;

public class 4kyu
{

    // The task is simply stated. Given an integer n (3 < n < 109), find the length of the smallest list of perfect squares which add up to n.
    // Come up with the best algorithm you can; you'll need it!

    public static int NSquaresFor(int n)
    {
        if (Math.Pow((int)Math.Sqrt(n), 2) != n)
        {
            for (int i = 0; i < (int)Math.Sqrt(n) + 1; i++)
            {
                int sq = (int)Math.Sqrt(n - Math.Pow(i, 2));
                if (sq * sq == n - Math.Pow(i, 2))
                {
                    return 2;
                }
            }
            while (n % 4 == 0)
            {
                n /= 4;
            }
            if (n % 8 != 7)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        return 1;
    }

    // We need to sum big numbers and we require your help.
    // Write a function that returns the sum of two numbers. The input numbers are strings and the function must return a string.
    public static string Add(string a, string b)
    {
        BigInteger a1 = BigInteger.Parse(a);
        BigInteger b1 = BigInteger.Parse(b);
        return (a1 + b1).ToString();
    }

    // Given the string representations of two integers, return the string representation of the sum of those integers.
    // A string representation of an integer will contain no characters besides the ten numerals "0" to "9".

    public static string sumStrings(string a, string b)
    {
        //long zxc;
        string final;

        if (a == string.Empty) a = "0";
        if (b == string.Empty) b = "0";
        //zxc = (long)(int.Parse(a) + int.Parse(b));
        BigInteger res = BigInteger.Parse(a) + BigInteger.Parse(b);
        final = Convert.ToString(res);
        return final;
    }

    // In this kata you have to create all permutations of a non empty input string and remove duplicates, if present.
    // This means, you have to shuffle all letters from the input in all possible orders.

    public static List<string> SinglePermutations(string s)
    {
        //var final = new List<string>();
        if (s.Length < 1)
        {
            return new List<string> { s };
        }
        else
        {
            return SinglePermutations(s.Substring(1))
                .SelectMany(x => Enumerable.Range(0, x.Length + 1)
                .Select((_, i) => x.Substring(0, i) + s[0] + x.Substring(i))).Distinct()
                .ToList();
        }
        //return new List<string> { s };  
    }

}

  // Here's a seemingly simple challenge. We're giving you a class called bagel, exactly as it appears below. All it really does is return an int, specifically 3.
  // The catch? For the solution, we're testing that the result is equal to 4. But as a little hint, the solution to this Kata is (almost) exactly the same as the example test cases.
public class BagelSolver
{
    public static Bagel Bagel
    {
        get
        {
            Bagel solution = new Bagel();
            solution.GetType()
              .GetProperty("Value")
              .SetValue(solution, 4);
            return solution;
        }
    }
}



