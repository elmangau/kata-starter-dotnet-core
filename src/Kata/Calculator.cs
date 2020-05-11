using System;
using System.Linq;

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

            var separator = new [] {",", "\n"};
            if (input.StartsWith("//"))
            {
                var parts = input.Split("\n");
                separator = new[]{parts[0].Replace("//", "")};
                input = parts[1];
            }
            var numbers = input.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            if (numbers.Any(n => n < 0))
            {
                var x = numbers.FirstOrDefault(n => n < 0);
                
                throw new Exception("negatives not allowed: " + x.ToString());
            }
            
            return numbers.Sum();
        }
    }
}