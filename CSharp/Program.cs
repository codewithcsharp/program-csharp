using CSharp;
using CSharp.LinkedList;
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

        #region Star printing problem - C#

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

        #endregion

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

        #region Shift pair numbers in last - Array
        int[] pair = { 2, 2, 2, 4, 5, 6, 7, 1, 1, 1, 8, 9, 10, 1 };
        Console.WriteLine("Original Array:");
        StringProgram.PrintShiftPairNumbersInLast(pair);

        int[] shiftedArray = StringProgram.ShiftPairNumbersInLast(pair);
        Console.WriteLine("\nArray after shifting elements with multiple occurrences to end:");
        StringProgram.PrintShiftPairNumbersInLast(shiftedArray);
        #endregion

        #region Find the longest subarrays in the Array

        int[] longArrayInput = { 5, 3, 10, 2, 1, 20 };
        List<int[]> Output = StringProgram.LongestSubArray(longArrayInput);
        Console.WriteLine(Output);
        Console.WriteLine("Maximum Subarrays where the first element is greater than the second:");
        foreach (var subarray in Output)
        {
            Console.Write("{ " + string.Join(", ", subarray) + " }");
        }

        #endregion

        #region Print Combination on Array
        int[] arrayInput = { 1, 2, 3, 4, 5, 6, 8, 11, 10, 9, 7 };
        int arrayIndex = 12;
        var output = StringProgram.PrintCombination(arrayInput, arrayIndex);

        foreach (var i in output)
        {
            Console.WriteLine($"[{i[0]},,{i[1]}]");
        }
        #endregion

        #region Print Sum of string Itrate Integers - Total

        string strInput = "xayz20yt5ttu10";
        int intOutput = StringProgram.SumStringItrateInteger(strInput);
        Console.WriteLine(intOutput);

        #endregion

        #region Polymerphism Implementation - Interface

        IA Ab = new Base();
        int objA = Ab.IAPrint(1);
        Console.WriteLine(objA);
        int obj1 = Ab.IPrint(13);
        Console.WriteLine(obj1);

        Base bc = new();
        int objB = ((IA)bc).IAPrint(1);
        Console.WriteLine(objB);
        int obj2 = ((IA)bc).IPrint(13);
        Console.WriteLine(obj2);

        #endregion

        #region Merge Two Shorted Array - Array

        int[] first = { 1, 2, 3, 4, 5, 6, 7 };
        int[] second = { 8, 9, 10, 11, 12, 13, 14 };

        int[] finalOutput = StringProgram.MergeTwoShortedArray(first, second);

        foreach (int i in finalOutput)
        {
            Console.Write(i + " ");
        }

        #endregion

        #region Find second heighest integer - Integer

        int[] inputFindSecondHeighestInteger = { 1, 2, 3, 4, 5, 6, 7, 0, 17, 15, 23, 24 };
        int outputFindSecondHeighestInteger = StringProgram.FindSecondHeighestInteger(inputFindSecondHeighestInteger);
        Console.WriteLine(outputFindSecondHeighestInteger);

        #endregion

        #region Short an Array : Shorting Technique - Quick Short

        int[] inputQuickShort = { 1, 2, 3, 4, 5, 6, 7, 20, 17, 15, 23, 24 };

        int[] outputQuickShort = StringProgram.QuickShort(inputQuickShort);

        foreach (int i in outputQuickShort)
        {
            Console.Write(i + " ");
        }

        #endregion

        #region Output of Polymerphism - Polymerphism

        BaseClass baseClass = new BaseClass();
        baseClass.ShowInDerived();
        baseClass = new DerivedClass();
        baseClass.ShowInDerived();

        #endregion

        #region Find middle index element from node list - Linkedlist

        SingleLinkedList list = new SingleLinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(5);
        list.Add(7);
        list.Add(40);
        list.Add(60);
        list.Add(100);
        list.Add(4);

        int middleElement = SingleLinkedList.FindMiddleIndexFromNodeList(list.Head!);
        Console.WriteLine($"Middle Element from the Node List : { middleElement }");
        
        #endregion
    }
}

