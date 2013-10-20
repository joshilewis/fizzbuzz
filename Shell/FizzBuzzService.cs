using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using ServiceStack.ServiceHost;

namespace Shell
{
    public class FizzBuzzService : IService<FizzBuzzRequest>
    {
        public object Execute(FizzBuzzRequest request)
        {
            return new FizzBuzzResponse(
                new FizzBuzzer().FizzBuzzIt(request.Number)
                    .ToArray());
        }
    }
}
