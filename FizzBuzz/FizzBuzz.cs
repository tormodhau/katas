using System;

namespace FizzBuzz
{
    public class FizzBuzz : IFizzBuzzKata
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        public string Answer(int number)
        {
            var isDivisibleBy = new Func<int,int,bool>((n,m) => n%m == 0);

            if (isDivisibleBy(number, 3) && isDivisibleBy(number, 5)) return "FizzBuzz";
            if (isDivisibleBy(number, 3)) return "Fizz";
            if (isDivisibleBy(number, 5)) return "Buzz";
            return number.ToString();
        }
    }
}