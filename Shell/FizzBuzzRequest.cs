using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell
{
    public class FizzBuzzRequest
    {
        public int Number { get; private set; }

        public FizzBuzzRequest(int number)
        {
            Number = number;
        }
    }
}
