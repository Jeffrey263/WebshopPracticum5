using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Webshop
{
    public class webshopService : IwebshopService
    {
        public void PostOrderTest(string name, int quantity)
        {
            Console.WriteLine($"order: {name} quantity: {quantity}");
        }
    }
}
