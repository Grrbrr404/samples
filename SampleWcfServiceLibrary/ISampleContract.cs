using System.ServiceModel;

namespace SampleWcfServiceLibrary
{
    
    [ServiceContract(Namespace = "http://blog.grrbrr.de/samples/c/2014/11/wcf")]
    public interface ISampleContract
    {
        [OperationContract]
        string Say(string msg);
    }
}
