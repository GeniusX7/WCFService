using Service;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                //host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(),
                //    "Http://127.0.0.1:1234/calculatorservice");
                //if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                //{
                //    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                //    behavior.HttpGetEnabled = true;
                //    behavior.HttpGetUrl = new Uri("Http://127.0.0.1:1234/calculatorservice/metadata");
                //    host.Description.Behaviors.Add(behavior);
                //}

                host.Opened += delegate
                {
                    Console.WriteLine("CalcultorService is opend, press any key to exit...");
                };

                host.Open();
                Console.Read();
            }
        }
    }
}
