using System;
using System.ServiceModel;

namespace PoC.Akka.WebServices
{
    class Program
    {
        static void Main(string[] args)
        {
            string serviceUrl = "http://www.dneonline.com/calculator.asmx?wsdl";

            //HTTPS with TLS 2.1 ?
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri(serviceUrl));
            var channelFactory = new CalculatorSoapClient(binding, endpoint);
            var serviceClient = channelFactory.ChannelFactory.CreateChannel();
            var result = serviceClient.AddAsync(31336,1).Result; //Leet
            Console.WriteLine(result);
            
        }
    }
}