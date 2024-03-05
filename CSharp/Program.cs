using System;
using System.Text;

public class Solution
{
    #region Reverse array of an Integer
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

    #region Reverse a String
    static string ReverseString(string str)
    {
        string revStr = "";
        char[] chars = str.ToCharArray();
        for (int i = chars.Length - 1; i >= 0; i--)
        {
            revStr += chars[i];
        }
        return revStr;
    }
    #endregion

    #region Combine two String Array into Single Array.
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

    #region Reverse a Sentance of Strings.
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

    #region Find the fixed Charector from given String.
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

    #region Is Number is Even Number
    static string IsEven(int num)
    {
        string res = num % 2 == 0 ? "Even" : "ODD";
        return res;
    }
    #endregion

    #region Is Number is Prime Number
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

    #region Is Number Armstrong Number
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

    #region Find the Common Prefix from an String Array
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

    #region Find Duplicate Frequency in the given String
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

    #region Find the Common item from the given two Integer Array

    public static int[] SecondMaxElement()
    {
        int[] l1 = { 1, 7, 50, 100 };
        Array.Sort(l1);
        int[] l2 = { 200, 250, 50, 7, 90 };
        Array.Sort(l2);

        int[] lst = new int[Math.Min(l1.Length, l2.Length)];
        int temp = 0, i = 0, j = 0;

        while (i < l1.Length && j < l2.Length) 
        {
            if (l1[i] == l2[j])
            {
                lst[temp] = l1[i];
                temp++;
                i++;
                j++;
            }
            else if (l1[i] < l2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }
        Array.Resize(ref lst, temp);
        return lst;
    }

    #endregion
    public static void Main(string[] args)
    {
        #region Reverse array of an Integer
        int parseIntegerInput = Int32.Parse(Console.ReadLine()!);
        int[] array = new int[parseIntegerInput];
        for (int i = 0; i < parseIntegerInput; i++)
        {
            array[i] = Int32.Parse(Console.ReadLine()!);
        }
        var arrays = ReverseArray(array);
        Console.WriteLine(String.Join(' ', arrays));
        #endregion

        #region Reverse a String

        string stringReverseInput = Console.ReadLine()!;
        string rev = ReverseString(stringReverseInput);

        Console.WriteLine(rev);

        #endregion

        #region Combine two String Array into Single Array.

        string firstStringArrayInput = Console.ReadLine()!;
        string[] firstArray = new string[firstStringArrayInput.Length];
        string secondStringArrayInput = Console.ReadLine()!;
        string[] secondArray = new string[secondStringArrayInput.Length];
        string[] finalArray = CombineTwoArray(firstArray!, secondArray!);

        for (int i = 0; i < finalArray.Length; i++)
        {
            Console.WriteLine(finalArray[i] + " ");
        }

        #endregion

        #region Reverse a Sentance of Strings.

        string stringWordInput = Console.ReadLine()!;
        string[] reverseStringWordArray = ReverseStringWord(stringWordInput);

        for (int i = 0; i <= reverseStringWordArray.Length - 1; i++)
        {
            Console.Write(reverseStringWordArray[i] + " ");
        }

        #endregion

        #region Find the fixed Charector from given String.

        string stringWord = Console.ReadLine()!;
        char fixedcharector = Char.Parse(Console.ReadLine()!);
        int index = FindIndexOfCharector(stringWord, fixedcharector);

        Console.WriteLine(index);

        #endregion

        #region Is Number is Even Number

        int findEvenNumber = Int32.Parse(Console.ReadLine()!);
        string result = IsEven(findEvenNumber);

        Console.WriteLine(result);

        #endregion

        #region Is Number is Prime Number

        int findPrimeNumber = Int32.Parse(Console.ReadLine()!);
        string response = IsPrime(findPrimeNumber);
        Console.WriteLine(response);

        #endregion

        #region Is Number Armstrong Number

        int findArmstrongNumber = Int32.Parse(Console.ReadLine()!);
        string ArmstrongNumber = IsArmStrong(findArmstrongNumber);
        Console.WriteLine(ArmstrongNumber);

        #endregion

        #region Is String is Pelindrom or Not

        string pelindromeInputstring = Console.ReadLine()!;
        string OutputPelindrome = IsPelindrome(pelindromeInputstring);
        Console.WriteLine(OutputPelindrome);

        #endregion

        #region Find the Common Prefix from an String Array

        string commonInputString = Console.ReadLine()!;
        string[] commonInputStringArray = commonInputString.Split(',');

        string commonOutputResult = CommonString(commonInputStringArray);
        Console.WriteLine(commonOutputResult);

        #endregion

        #region Find Duplicate Frequency in the given String

        string duplicateInputString = Console.ReadLine()!;
        char[] duplicateOutputArray = DuplicateFrequency(duplicateInputString);

        for (int i = 0; i <= duplicateOutputArray.Length - 1; i++)
        {
            Console.Write(duplicateOutputArray[i] + " ");
        }

        #endregion

        #region Find the Common item from the given two Integer Array

        int[] lstUser = SecondMaxElement();
        for (int i = 0; i < lstUser.Length; i++)
        {
            Console.WriteLine(lstUser[i]);
        }

        #endregion
    }
}

