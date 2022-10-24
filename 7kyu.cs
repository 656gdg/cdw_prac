using System;

public class 7KyuTasks
{
    // Simple, given a string of words, return the length of the shortest word(s).
    // String will never be empty and you do not need to account for different data types.
    
    public static int FindShort(string s)
    {
        return s
          .Split(' ')
          .Min(w => w.Length);
    }

    // Given the triangle of consecutive odd numbers:
    //              1
    //           3     5
    //        7     9    11
    //    13    15    17    19
    // 21    23    25    27    29
    // Calculate the sum of the numbers in the nth row of this triangle (starting at index 1) e.g.: (Input --> Output)

    public static long rowSumOddNumbers(long n)
    {
        return n * n * n;
    }

    // Welcome. In this kata, you are asked to square every digit of a number and concatenate them.
    // For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
    // Note: The function accepts an integer and returns an integer

    public static int SquareDigits(int n)
    {
        string res = "";

        foreach (char ch in n.ToString())
        {
            double str = int.Parse(ch.ToString());
            res += Math.Pow(str, 2);
        }
        return Convert.ToInt32(res);
    }

    // You are going to be given a word. Your job is to return the middle character of the word.
    // If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.

    public static string GetMiddle(string s)
    {
        if (s.Length % 2 == 0)
        {
            return s.Substring((s.Length / 2) - 1, 2);
        }
        else
        {
            return s.Substring(s.Length / 2, 1);
        }
    }

    // Make a program that filters a list of strings and returns a list with only your friends name in it.
    // If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...
    // Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"] i.e.
    // friend["Ryan", "Kieran", "Mark"] `shouldBe` ["Ryan", "Mark"]
    // Note: keep the original order of the names in the output.

    public static IEnumerable<string> FriendOrFoe(string[] names)
    {
        return names.Where(arr => arr.Length == 4);
    }

    // Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

    public static bool XO(string input)
    {
        return input.ToLower().Count(x => x == 'x') == input.ToLower().Count(o => o == 'o');
    }

    // Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. No floats or non-positive integers will be passed.

    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        return numbers.OrderBy(i => i)
                    .Take(2)
                    .Sum();
    }

    // Return the number (count) of vowels in the given string. We will consider a, e, i, o, u as vowels for this Kata (but not y).
    // The input string will only consist of lower case letters and/or spaces.

    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        foreach (char ch in str.ToLower())
        {
            if ("aeiou".Contains(ch))
            {
                vowelCount++;
            }
        }
        return vowelCount;
    }

    // Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

    public static bool Solution(string str, string ending)
    {
        return str.EndsWith(ending);
    }

    // Take 2 strings s1 and s2 including only letters from a to z.
    // Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.

    public static string Longest(string s1, string s2)
    {
        string l1 = new string(s1.Distinct().ToArray());
        string l2 = new string(s2.Distinct().ToArray());
        string final = string.Concat(l1, l2);

        return string.Join("", final.Distinct().OrderBy(l => l));
    }

    // You are given two arrays a1 and a2 of strings. Each string is composed with letters from a to z. Let x be any string in the first array and y be any string in the second array.
    // Find max(abs(length(x) − length(y)))
    // If a1 and/or a2 are empty return -1 in each language except in Haskell (F#) where you will return Nothing (None).
    // input : 2 strings with substrings separated by ',' output: number as a string

    public static int Mxdiflg(string[] a1, string[] a2)
    {
        if ((a1.Length == 0 || a2.Length == 0)) return -1;
        else
        {
            int arr1 = Math.Abs(a1.Max(x => x.Length) - a2.Min(x => x.Length));
            int arr2 = Math.Abs(a2.Max(x => x.Length) - a1.Min(x => x.Length));

            return Math.Max(arr1, arr2);
        }
    }

    // Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.
    // The binary number returned should be a string.

    public static string AddBinary(int a, int b)
    {
        int c;
        string res = null;

        c = a + b;
        for (int i = 0; c > 0; i++)
        {
            res = c % 2 + res;
            c = c / 2;
        }
        return res;
    }
}
