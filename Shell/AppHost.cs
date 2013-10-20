using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funq;
using ServiceStack.WebHost.Endpoints;

namespace Shell
{
    public class AppHost : AppHostHttpListenerBase 
    {
        public AppHost()
            : base("FizzBuzz Service Host", typeof(FizzBuzzService).Assembly)
        { }


        public override void Configure(Container container)
        {
            Routes
                .Add<FizzBuzzRequest>("/fizzbuzz/{Number}")
                ;
        }
    }
}
