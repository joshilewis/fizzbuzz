using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell
{
    public class FizzBuzzResponse
    {
        public string[] Output { get; private set; }

        public FizzBuzzResponse(string[] output)
        {
            Output = output;
        }
    }
}
