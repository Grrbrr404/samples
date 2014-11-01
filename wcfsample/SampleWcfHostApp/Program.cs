using System;
using System.ServiceModel;

namespace SampleWcfHostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sample WCF Service";

            using (var host = new ServiceHost(typeof (SampleWcfServiceLibrary.SampleWcfService)))
            {
                // ABC Prinzip

                host.AddServiceEndpoint(
                    typeof (SampleWcfServiceLibrary.ISampleContract), // C - Contract
                    new NetTcpBinding(), // B - Binding
                    "net.tcp://localhost:8888/SampleEndpoint" // A - Address
                    );

                host.Open();

                Console.ReadLine();
            }

        }
    }
}
