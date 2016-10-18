using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        public void ExecutePalindrome()
        {
            GetUserInput();
            DisplayPalindromeResults();
            
        }
        string userInput;
        public bool CheckIsPalindrome(string userInput)
        {
            int fromBeginning = 0;
            int fromEnding= userInput.Length - 1;
            while (true)
            {
                if (fromBeginning > fromEnding)
                {
                    return true;
                }
                char currentLetterA = userInput[fromBeginning];
                char currentLetterB = userInput[fromEnding];
                if (char.ToLower(currentLetterA) != char.ToLower(currentLetterB))
                {
                    return false;
                }
                fromBeginning++;
                fromEnding--;
            }
        }
        public void GetUserInput()
        {
            Console.WriteLine("Enter word to check for Palindrome");
            userInput = Console.ReadLine();
        }
        public void DisplayPalindromeResults()
        {
            bool IsPalindrome = CheckIsPalindrome(userInput);
            if (IsPalindrome)
            {
                Console.WriteLine("{0} is a Palindrome", userInput);
            } else if (!IsPalindrome)
            {
                Console.WriteLine("{0} is not a Palindrome", userInput);
            }
        }
    }
}

