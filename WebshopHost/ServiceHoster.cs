using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Webshop;

namespace WebshopHost
{
    class ServiceHoster
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(webshopService))) 
            { 
                host.Open(); 
                Console.WriteLine("Service ready");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
