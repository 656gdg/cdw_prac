using System;

public class 5kyuTasks
{
    // In this kata you have to correctly return who is the "survivor", ie: the last element of a Josephus permutation.
    // Notes and tips: using the solution to the other kata to check your function may be helpful,
    // but as much larger numbers will be used, using an array/list to compute the number of the survivor may be too slow; you may assume that both n and k will always be >=1.

    public static int JosSurvivor(int n, int k)
    {
        int sur = 0;

        for (int i = 1; i <= n; i++)
        {
            sur = (sur + k) % i;
        }
        return sur + 1;
    }

    // Define a function that takes in two non-negative integers aaa and bbb and returns the last decimal digit of a^b

    public static int GetLastDigit(BigInteger n1, BigInteger n2)
    {
        return (int)BigInteger.ModPow(n1, n2, 10);
    }

    // Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

    public static int[] MoveZeroes(int[] arr)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0) continue;
            arr[count] = arr[i];
            count++;
        }
        for (int i = count; i < arr.Length; i++)
        {
            arr[i] = 0;
        }
        return arr;
    }

    // Create a function that takes a string and returns the string ciphered with Rot13.
    // If there are numbers or special characters included in the string, they should be returned as they are.
    // Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".

    public static string Rot13(string message)
    {
        char[] mes = message.ToCharArray();

        for (int i = 0; i < mes.Length; i++)
        {
            int ch = (int)mes[i];
            if ('a' <= ch && ch <= 'm' || 'A' <= ch && ch <= 'M')
            {
                ch += 13;
            }
            else if ('n' <= ch && ch <= 'z' || 'N' <= ch && ch <= 'Z')
            {
                ch -= 13;
            }
            mes[i] = (char)ch;
        }
        return new string(mes);
    }
}
