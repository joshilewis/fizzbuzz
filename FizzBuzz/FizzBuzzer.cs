using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public virtual IEnumerable<string> FizzBuzzIt(int count)
        {
            return Enumerable
                .Range(1, count)
                .Select(Classifier)
                ;
        }

        public virtual string Classifier(int number)
        {
            var stringToReturn = string.Empty;

            if (number%3 == 0)
                stringToReturn = "Fizz";

            if (number % 5 == 0)
                stringToReturn += "Buzz";

            if (!string.IsNullOrEmpty(stringToReturn))
                return stringToReturn;

            return number.ToString();
        }
    }
}