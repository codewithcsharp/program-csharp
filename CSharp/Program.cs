using StringProgram = CSharp.StringProgram;
public class Solution
{
    public static void Main(string[] args)
    {
        #region Reverse array of an Integer
        int parseIntegerInput = Int32.Parse(Console.ReadLine()!);
        int[] array = new int[parseIntegerInput];
        for (int i = 0; i < parseIntegerInput; i++)
        {
            array[i] = Int32.Parse(Console.ReadLine()!);
        }
        var arrays = StringProgram.ReverseArray(array);
        Console.WriteLine(String.Join(' ', arrays));
        #endregion

        #region Reverse a String

        string stringReverseInput = Console.ReadLine()!;
        string rev = StringProgram.ReverseString(stringReverseInput);

        Console.WriteLine(rev);

        #endregion

        #region Combine two String Array into Single Array.

        string firstStringArrayInput = Console.ReadLine()!;
        string[] firstArray = new string[firstStringArrayInput.Length];
        string secondStringArrayInput = Console.ReadLine()!;
        string[] secondArray = new string[secondStringArrayInput.Length];
        string[] finalArray = StringProgram.CombineTwoArray(firstArray!, secondArray!);

        for (int i = 0; i < finalArray.Length; i++)
        {
            Console.WriteLine(finalArray[i] + " ");
        }

        #endregion

        #region Reverse a Sentance of Strings.

        string stringWordInput = Console.ReadLine()!;
        string[] reverseStringWordArray = StringProgram.ReverseStringWord(stringWordInput);

        for (int i = 0; i <= reverseStringWordArray.Length - 1; i++)
        {
            Console.Write(reverseStringWordArray[i] + " ");
        }

        #endregion

        #region Find the fixed Charector from given String.

        string stringWord = Console.ReadLine()!;
        char fixedcharector = Char.Parse(Console.ReadLine()!);
        int index = StringProgram.FindIndexOfCharector(stringWord, fixedcharector);

        Console.WriteLine(index);

        #endregion

        #region Is Number is Even Number

        int findEvenNumber = Int32.Parse(Console.ReadLine()!);
        string result = StringProgram.IsEven(findEvenNumber);

        Console.WriteLine(result);

        #endregion

        #region Is Number is Prime Number

        int findPrimeNumber = Int32.Parse(Console.ReadLine()!);
        string response = StringProgram.IsPrime(findPrimeNumber);
        Console.WriteLine(response);

        #endregion

        #region Is Number Armstrong Number

        int findArmstrongNumber = Int32.Parse(Console.ReadLine()!);
        string ArmstrongNumber = StringProgram.IsArmStrong(findArmstrongNumber);
        Console.WriteLine(ArmstrongNumber);

        #endregion

        #region Is String is Pelindrom or Not

        string pelindromeInputstring = Console.ReadLine()!;
        string OutputPelindrome = StringProgram.IsPelindrome(pelindromeInputstring);
        Console.WriteLine(OutputPelindrome);

        #endregion

        #region Find the Common Prefix from an String Array

        string commonInputString = Console.ReadLine()!;
        string[] commonInputStringArray = commonInputString.Split(',');

        string commonOutputResult = StringProgram.CommonString(commonInputStringArray);
        Console.WriteLine(commonOutputResult);

        #endregion

        #region Find Duplicate Frequency in the given String

        string duplicateInputString = Console.ReadLine()!;
        char[] duplicateOutputArray = StringProgram.DuplicateFrequency(duplicateInputString);

        for (int i = 0; i <= duplicateOutputArray.Length - 1; i++)
        {
            Console.Write(duplicateOutputArray[i] + " ");
        }

        #endregion

        #region Find the Common item from the given two Integer Array

        int[] lstUser = StringProgram.SecondMaxElement();
        for (int i = 0; i < lstUser.Length; i++)
        {
            Console.WriteLine(lstUser[i]);
        }

        #endregion

        #region Reverse a string without using inbuilt method

        string StringInput = Console.ReadLine()!;
        string ReverseStringOutput = StringProgram.ReverseWithoutInbuiltString(StringInput);
        Console.WriteLine(ReverseStringOutput);

        #endregion

        int Even = int.Parse(Console.ReadLine()!);
        StringProgram.PrintEvenPeramid(Even);

        int Odd = int.Parse(Console.ReadLine()!);
        StringProgram.PrintOddPeramid(Odd);

        int Left = int.Parse(Console.ReadLine()!);
        StringProgram.PrintLeftStarPeramid(Left);

        int Right = int.Parse(Console.ReadLine()!);
        StringProgram.PrintRightStarPeramid(Right);

        int Parllel = int.Parse(Console.ReadLine()!);
        StringProgram.PrintStarParllel(Parllel);

        int Down = int.Parse(Console.ReadLine()!);
        StringProgram.PrintDownStar(Down);

        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine(a + " " + b);
        StringProgram.SwapNumberUsingThirdVariable(a, b);
        Console.WriteLine(a + " " + b);

        int x = int.Parse(Console.ReadLine()!);
        int y = int.Parse(Console.ReadLine()!);
        Console.WriteLine(x + " " + y);
        StringProgram.SwapNumberWithoutUsingThirdVariable(x, y);
        Console.WriteLine(x + " " + y);

        int X = int.Parse(Console.ReadLine()!);
        int Y = int.Parse(Console.ReadLine()!);
        Console.WriteLine(X + " " + Y);
        StringProgram.SwapNumberUsingThirdVariableInGenric(ref X, ref Y);
        Console.WriteLine(X + " " + Y);

        string userInput = Console.ReadLine()!;
        string[] inputArray = userInput.Split(' ');
        int[] integerArray = new int[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (int.TryParse(inputArray[i], out int number))
            {
                integerArray[i] = number;
            }
            else
            {
                Console.WriteLine($"Invalid input: '{inputArray[i]}' is not a valid integer.");
                return;
            }
        }

        string OutputString = StringProgram.IsMonotalic(integerArray);
        Console.WriteLine(OutputString);

        string str = Console.ReadLine()!;
        StringProgram.OccrenceChar(str);

        int target = 6;
        int[] numbers = { 3, 2, 4 };
        StringProgram.TwoSums(numbers, target);

        #region Tuple Practice problem in C#
        // 1. Technique of accessing tuple
        var person1 = Tuple.Create("Abhitosh Kumar", 1);
        Console.WriteLine($"Name : {person1.Item1} and Age : {person1.Item2}");

        // 2. Technique of accessing tuple using named elements
        var person2 = (Name: "Rohit Sharma", Age: 28);
        Console.WriteLine($"Name : {person2.Name} and Age : {person2.Age}");

        // 3. Technique of accessing tuple using function
        var (Name, Age) = StringProgram.CheckTypeOfData();

        // Display the retrieved data
        Console.WriteLine($"Name: {Name}, Age: {Age}");
        #endregion

        #region Tuple - Find max and min value in C#
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        var FindOutput = StringProgram.FindMinMax(arr);

        Console.WriteLine($"Minimum value : {FindOutput.Item1}");

        Console.WriteLine($"Maximum value : {FindOutput.Item2}");

        #endregion

        #region Remove Duplicates from an Array
        int[] sortedArray = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };

        // Call the function to remove duplicates
        int[] uniqueArray = StringProgram.RemoveDuplicates(sortedArray);

        Console.WriteLine("Array with duplicates removed:");
        foreach (int num in uniqueArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        #endregion

        #region Find Second Largest element in Array in C#
        int[] arrOut = { 2, 4, 3, 8, 6, 9, 13 };
        int outputSecondLargest = StringProgram.FindSecondLargest(arrOut);
        Console.WriteLine("Second largest number is: " + outputSecondLargest);  // Output: 9
        #endregion
    }
}

