using System;

class Palindrome
{
    public static void Main()
    {
        Console.WriteLine("Palindrome Checker");
        Console.WriteLine("Enter the word you wish to check:");
        string inputString = Console.ReadLine();
        char[] inputArray = inputString.ToCharArray();

        Array.Reverse(inputArray);

        string reversedString = new string(inputArray);
        PalindromeCheck(inputString, reversedString);
    }

    static void PalindromeCheck(string inputText, string reversedText)
    {
        if (reversedText == inputText)
        {
            Console.WriteLine("True, The word is a Palindrome");
        }
        else
        {
            Console.WriteLine("False, The word is not a Palindrome");
            Main();
        }
    } 


}