namespace InterviewTaskPalindromeExtended
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(IsPalindrome(input));
        }

        static bool IsPalindrome(string input)
        {
            char[] tokens = input.ToCharArray();
            string reversedInput = string.Empty;

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                reversedInput += tokens[i];
            }

            bool asd = reversedInput.ToLower() == input.ToLower();

            if (reversedInput.ToLower() == input.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
