using System;

public class 6kyuTasks
{
    // Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.
    
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        T current = default;

        foreach (var ch in iterable)
        {
            if (!ch.Equals(current))
            {
                yield return ch;
                current = ch;
            }
        }
    }

    // Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors. A tower block is represented with "*" character.

    public static string[] TowerBuilder(int nFloors)
    {
        string[] final = new string[nFloors];
        int pad;

        for (int i = 1; i < nFloors * 2; i += 2)
        {
            pad = (nFloors * 2 - i) / 2;
            final[i / 2] = new string(' ', pad) + new string('*', i) + new string(' ', pad);
        }
        return final;
    }

    // In this kata you are required to, given a string, replace every letter with its position in the alphabet.
    // If anything in the text isn't a letter, ignore it and don't return it.

    public static string AlphabetPosition(string text)
    {
        string res = "";

        foreach (char ch in text.ToLower())
        {
            if (char.IsLetter(ch))
            {
                res += ch - 'a' + 1 + " ";
            }
        }
        return res.TrimEnd();
    }

    // There is an array with some numbers. All numbers are equal except for one. Try to find it! 
    // The tests contain some very huge arrays, so think about performance.

    public static int GetUnique(IEnumerable<int> numbers)
    {
        return numbers
          .GroupBy(x => x)
          .Single(x => x.Count() == 1)
          .Key;
    }

    // The depth of an integer n is defined to be how many multiples of n it is necessary to compute before all 10 digits have appeared at least once in some multiple.
    // Looking at the above table under digits column you can find all the digits from 0 to 9, Hence it required 9 multiples of 42 to get all the digits. So the depth of 42 is 9.
    // Write a function named computeDepth which computes the depth of its integer argument.Only positive numbers greater than zero will be passed as an input.

    public static int ComputeDepth(int n)
    {
        bool[] num = new bool[10];
        bool finCheck;
        int final = 1;

        while (true)
        {
            int res = n * final;
            while (res > 0)
            {
                int ch = res % 10;
                res /= 10;
                if (!num[ch])
                {
                    num[ch] = true;
                }
            }
            finCheck = true;
            foreach (bool fl in num)
            {
                if (!fl)
                    finCheck = false;
            }
            if (finCheck) break;
            final++;
        }
        return final;
    }

    // There is a queue for the self-checkout tills at the supermarket. Your task is write a function to calculate the total time required for all the customers to check out!

    public static long QueueTime(int[] customers, int n)
    {
        int[] res = new int[n];

        for (int i = 0; i < customers.Length; i++)
        {
            res[0] += customers[i];
            Array.Sort(res);
        }
        //Array.Sort(res);
        return res[n - 1];
    }

    // The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string.
    // Ignore capitalization when determining if a character is a duplicate.

    public static string DuplicateEncode(string word)
    {
        string result = word.ToLower();
        string res = null;

        foreach (char ch in result)
        {
            res += result.Count(x => x == ch) > 1 ? ")" : "(";
        }
        return res;
    }

    // Could you make a program that 
    // - makes this string uppercase
    // - gives it sorted in alphabetical order by last name.
    // When the last names are the same, sort them by first name. Last name and first name of a guest come in the result between parentheses separated by a comma.
    // It can happen that in two distinct families with the same family name two people have the same first name too.

    public static string Meeting(string s)
    {
        return string.Concat(s.ToUpper()
                             .Split(";")
                             .Select(x => $"({string.Join(", ", x.Split(':').Reverse())})")
                             .OrderBy(f => f));
    }

    // Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.
    // Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).
    // If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.

    public static string Order(string words)
    {
        var d = new Dictionary<string, int>();
        string dig;

        foreach (var word in words.Split())
        {
            var num = 0;
            dig = null;
            foreach (var c in word)
            {
                // dig = null;
                if (char.IsDigit(c))
                {
                    dig = dig + c.ToString();
                }
            }
            if (dig != null)
            {
                num = int.Parse(dig);
            }
            d.Add(word, num);
        }
        return string.Join(" ", d.OrderBy(x => x.Value).Select(x => x.Key).ToList());
    }

    // The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.
    // What if the string is empty? Then the result should be empty object literal, {}.

    public static Dictionary<char, int> Count(string str)
    {
        Dictionary<char, int> count = new Dictionary<char, int>();

        foreach (char character in str)
        {
            int i = 0;
            count.TryGetValue(character, out i);
            count[character] = i + 1;
        }
        return count;
    }

    // Write a function that takes an array of numbers (integers for the tests) and a target number.
    // It should find two different items in the array that, when added together, give the target value.
    // The indices of these items should then be returned in a tuple / list (depending on your language) like so: (index1, index2).

    public static int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return null;
    }

    // Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.
    // Remember that there can't be more than 3 identical symbols in a row.

    public static string Solution(int n)
    {
        int[] num = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] let = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        string val = "";

        for (int i = 0; i < num.Length && n != 0; i++)
        {
            while (n >= num[i])
            {
                n = n - num[i];
                val = val + let[i];
            }
        }
        return val;
    }

    // Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

    public static string CreatePhoneNumber(int[] numbers)
    {
        return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
    }

    // Given a string of words, you need to find the highest scoring word.
    // Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
    // You need to return the highest scoring word as a string.
    // If two words score the same, return the word that appears earliest in the original string.

    public static string High(string s)
    {
        int score;
        var words = s.Split();
        var result = new List<int>();

        foreach (string x in words)
        {
            score = 0;
            foreach (char c in x)
            {
                score = score + (int)c - 'a' + 1;
            }
            result.Add(score);
        }
        return words[result.IndexOf(result.Max())];
    }

    // You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block,
    // so create a function that will return true if the walk the app gives you will take you exactly ten minutes(you don't want to be early or late!)
    // and will, of course, return you to your starting point. Return false otherwise.

    public static bool IsValidWalk(string[] walk)
    {
        int x = 0;
        int y = 0;
        if (walk.Length != 10) return false;

        for (int des = 0; des < walk.Length; des++)
        {
            switch (walk[des])
            {
                case "n": { y++; break; }
                case "s": { y--; break; }
                case "w": { x++; break; }
                case "e": { x--; break; }
            }
        }
        if (x == 0 && y == 0) return true;
        else return false;
    }

    // Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string.
    // The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

    public static int DuplicateCount(string str)
    {
        string f = "";
        int count = 0;

        str = str.ToLower();
        for (int i = 0; i < str.Length;)
        {
            if (str.IndexOf(str[i]) == str.LastIndexOf(str[i]))
            {
                i++;
            }
            else
            {
                count++;
                char[] gg = new char[1];
                gg[0] = str[i];
                f = new string(gg);
                Console.Write(f);
                str = str.Replace(f, string.Empty);
            }
        }
        return count;
    }

}
