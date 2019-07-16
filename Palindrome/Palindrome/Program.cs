using System;

namespace Palindrome
{
    class Program
    {
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
        static void Main(string[] args)
        {
            string[] array =
            {
            "abut-1-tuba",
            "@allula"
        };

            foreach (string value in array)
            {
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
            }
        }
    }
}
