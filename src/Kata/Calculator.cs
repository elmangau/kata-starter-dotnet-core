using System;

namespace Kata
{
    public class Calculator
    {
        public int Add(string input = "")
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;                
            }

            var numbers = input.Split(",", StringSplitOptions.RemoveEmptyEntries);

            if (numbers.Length >= 2)
            {
                return int.Parse(numbers[0]) + int.Parse(numbers[1]);
            }

            return int.Parse(input);
        }
    }
}