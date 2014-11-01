using System;
using System.ServiceModel;

namespace SampleWcfClientApp {


    /// <summary>
    /// Sample Contract ..
    /// 
    /// <remarks>
    /// This is a copy of the ISampleContract.cs from SampleWcfServiceLibrary Project.
    /// I did this for the context of this stupid simple sample project. In real world these two projects
    /// would not share the same solution
    /// </remarks>
    /// </summary>
    [ServiceContract(Namespace = "http://blog.grrbrr.de/samples/c/2014/11/wcf")]
    public interface ISampleContract {
        [OperationContract]
        string Say(string msg);
    }
    
    class Program {
        static void Main(string[] args)
        {
            Console.Title = "Sample Client App";


            // ABC Prinzip
                                                   // C- Contract
            ISampleContract proxy = ChannelFactory<ISampleContract>.CreateChannel(
                new NetTcpBinding(), // B - Binding
                new EndpointAddress("net.tcp://localhost:8888/SampleEndpoint") // A - Address
            );

            var input = string.Empty;

            while (input != "q") {
                Console.WriteLine("Enter text: ");
                input = Console.ReadLine();
                var serviceResponse = proxy.Say(input);
                Console.WriteLine("Service response:" + serviceResponse);
            }
            
        }
    }
}
