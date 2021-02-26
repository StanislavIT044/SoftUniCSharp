namespace InterviewTaskPalindrome
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
            string newStringFromInput = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(input[i].ToString()))
                {
                    newStringFromInput += input[i];
                }
            }

            char[] tokens = input.ToCharArray();
            string reversedInput = string.Empty;

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(input[i].ToString()))
                {
                    reversedInput += tokens[i];
                }
            }

            if (reversedInput == newStringFromInput)
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
