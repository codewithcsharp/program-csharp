using System;
using System.Text;

public class Solution
{
    #region Reverse array of an string
    static int[] ReverseArray(int[] array)
    {
        int reverse = array.Length - 1;
        int[] revArr = new int[array.Length];
        for (int i = reverse; i >= 0; i--)
        {
            revArr[i] = array[reverse - i];
        }
        return revArr;
    }

    #endregion

    #region Reverse a string
    static string ReverseString(string str)
    {
        string revStr = "";
        char[] chars = str.ToCharArray();
        for (int i = chars.Length - 1; i >= 0; i--)
        {
            var c = chars[i];
            revStr += c;
        }
        return revStr;
    }
    #endregion

    #region Combine two array into single array
    static string[] CombineTwoArray(string[] a, string[] b)
    {
        string[] c = new string[a.Length + b.Length];

        string[] maxLength = a.Length > b.Length ? a : b;
        string[] minLength = a.Length > b.Length ? b : a;

        int temp = 0;
        int temp1 = minLength.Length;
        for (int i = 0; i < maxLength.Length; i++)
        {
            if (i < minLength.Length)
            {
                c[temp] = minLength[i];
                temp++;
            }
            if (i < maxLength.Length)
            {
                c[temp1++] = maxLength[i];
                temp1++;
            }
        }
        return c;
    }
    #endregion

    #region Reverse an sentance of string.
    static string[] ReverseStringWord(string word)
    {
        string[] rev = new string[word.Trim().Split().Length];
        int temp = 0;
        string[] arr = word.Trim().Split();
        for (int i = arr.Length-1; i >= 0; i--)
        {
            rev[temp] = arr[i];
            temp++;
        }
        return rev;
    }
    #endregion

    #region Find the fixed char from given array.
    static int FindIndexOfCharector(string word, char index)
    {
        char[] arr = word.ToCharArray();
        int temp = 0;
        for(int i = 0; i <= arr.Length-1; i++)
        {
            temp = arr[i] == index ? i : 0;
        }
        return temp;
    }
    #endregion

    #region Is number even number
    static string IsEven(int num)
    {
        string res = num % 2 == 0 ? "Even" : "ODD";
        return res;
    }
    #endregion

    #region Is number is prime number
    static string IsPrime(int num)
    {
        string res = "";
        if (num == 1 || num == 2)
        {
            res = "PRIME";
        }
        int n = num%2==0 ? num/2 : num/2+1;
        for (int i = 2; i <= n; i++)
        {
            int rem = num % i;
            res = rem == 0 ? "NOT PRIME" : "PRIME";
        }
        return res;
    }
    #endregion

    #region Is number Armstrong Number
    static bool CheckArmstrong(int num)
    {
        int result = 0;
        int temp = num;
        int count = CountDigit(num);
        while (num > 0)
        {

            int digit = num % 10;
            num /= 10;
            result += (int)Math.Pow(digit, count);
        }
        return temp == result;
    }
    static int CountDigit(int num)
    {
        int count = 0;
        while (num > 0)
        {
            num /= 10;
            count++;
        }
        return count;
    }
    static string IsArmStrong(int num)
    {
        var res = CheckArmstrong(num);
        var result = res ? "Armstrong" : "Non-Armstrong";
        return result;
    }
    #endregion

    #region Is String is Pelindrom or Not
    static string CheckPelindrome(string str)
    {
        string revStr = "";
        char[] arr = str.ToCharArray();
        for (int i = arr.Length-1; i>=0; i--)
        {
            revStr += arr[i];
        }
        return revStr;
    }

    static string IsPelindrome(string str)
    {
        string temp = str;
        string rev = CheckPelindrome (str);
        return temp == rev ? "Pelindrome" : "Not-Pelindrome";
    }
    #endregion

    #region Find the common prefix from an array
    static string CommonString(string[] str)
    {
        Array.Sort(str);
        char[] start = str[0].ToArray();
        char[] end = str[^1].ToArray();
        StringBuilder prefix = new StringBuilder();
        for (int i = 0; i <= start.Length-1; i++)
        {
            if (start[i] != end[i])
            {
                break;
            }
            prefix.Append(start[i]);
        }
        return prefix.ToString();
    }
    #endregion

    #region Find duplicate frequency in the given string
    static char[] DuplicateFrequency(string str)
    {
        char[] arr = str.ToLower().ToArray();
        List<char> duplicates = new();

        for (int i = 0; i <= arr.Length - 1; i++)
        {
            char currentChar = arr[i];
            bool isDuplicate = false;
            if (duplicates.Contains(currentChar))
            {
                continue;
            }

            for (int j = i + 1; j <= arr.Length-1; j++)
            {
                if (currentChar == arr[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (isDuplicate)
            {
                duplicates.Add(currentChar);
            }
        }
        return duplicates.ToArray();
    }

    #endregion
    public static void Main(string[] args)
    {
        #region 1
        int n = Int32.Parse(Console.ReadLine()!);
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Int32.Parse(Console.ReadLine()!);
        }
        var arrays = ReverseArray(array);
        Console.WriteLine(String.Join(' ', arrays));
        #endregion

        #region 2
        string str = Console.ReadLine()!;
        string rev = ReverseString(str);
        Console.WriteLine(rev);
        #endregion

        #region 3
        string arr = Console.ReadLine()!;
        string[] arr1 = new string[arr.Length];
        string brr = Console.ReadLine()!;
        string[] brr1 = new string[brr.Length];
        string[] crr = CombineTwoArray(arr1!, brr1!);
        for (int i = 0; i < crr.Length; i++)
        {
            Console.WriteLine(crr[i] + " ");
        }
        #endregion

        #region 4
        string srd = Console.ReadLine()!;
        string[] strarr = ReverseStringWord(srd);
        for (int i = 0; i <= strarr.Length - 1; i++)
        {
            Console.Write(strarr[i] + " ");
        }
        #endregion

        int num = Int32.Parse(Console.ReadLine()!);

        string res = IsEven(num);
        Console.WriteLine(res);

        string response = IsPrime(num);
        Console.WriteLine(response);

        int Inputnum = Int32.Parse(Console.ReadLine()!);
        string result = IsArmStrong(Inputnum);
        Console.WriteLine(result);

        string Inputstr = Console.ReadLine()!;
        string Outputrev = IsPelindrome(Inputstr);
        Console.WriteLine(Outputrev);

        char ch = Char.Parse(Console.ReadLine()!);
        int index = FindIndexOfCharector(str, ch);
        Console.WriteLine(index);

        string InputString = Console.ReadLine()!;

        char[] Outputarr = DuplicateFrequency(InputString);

        for (int i = 0; i <= Outputarr.Length - 1; i++)
        {
            Console.Write(Outputarr[i] + " ");
        }

        string[] InputStrArr = InputString.Split(',');

        string Outputresult = CommonString(InputStrArr);
        Console.WriteLine(Outputresult);
    }
}

