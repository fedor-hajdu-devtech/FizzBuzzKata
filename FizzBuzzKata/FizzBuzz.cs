using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string Run(int input)
        {
            if (input % 3 == 0) return "Fizz";
            return input.ToString();
        }
    }
}
