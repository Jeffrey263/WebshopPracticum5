using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopClientConsole.webshopService;

namespace WebshopClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            using(IwebshopServiceClient shopProxy = new IwebshopServiceClient()) 
            {
                shopProxy.PostOrderTest("yeet", 69);
            }
        }
    }
}
