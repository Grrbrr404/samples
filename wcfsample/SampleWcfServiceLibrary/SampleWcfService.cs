using System;

namespace SampleWcfServiceLibrary
{
    public class SampleWcfService : ISampleContract
    {
        public string Say(string msg)
        {
            Console.WriteLine("Received from client: " + msg);
            return string.Format("{0}: '{1}' has been entered.", DateTime.Now.ToLocalTime(), msg);
        }
    }
}
