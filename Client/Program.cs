
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChannelFactory<ICalculator> channelFactory =
                /*new ChannelFactory<ICalculator>(new WSHttpBinding(), "Http://127.0.0.1:1234/calculatorservice")*/
                new ChannelFactory<ICalculator>("calculatorserviceok")
                )
            {
                ICalculator proxy = channelFactory.CreateChannel();
                Console.WriteLine("x+y={0}", proxy.Add(1, 2));
                Console.WriteLine("x-y={0}", proxy.Subtract(1, 2));
                Console.WriteLine("x*y={0}", proxy.Multiply(4, 2));
                Console.WriteLine("x/y={0}", proxy.Divide(1, 2));
            }
            Console.Read();
        }
    }
}
