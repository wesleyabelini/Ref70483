using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Cap._4_List4_39
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModels", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(
        ConfigurationName ="ExternalService.MyService")]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    public interface MyService
    {
        //implementar o serviço na interface
        [System.ServiceModel.OperationContractAttribute(Action ="http://tempuri.org/MyService/DoWork", 
            ReplyAction ="http://tempuri.org/MyService/DoWorkResponse")]
        string DoWork(string right, string left);

        // TODO: Add your service operations here
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyServiceChannel: Cap._4_List4_39.MyService, System.ServiceModel.IClientChannel
    {

    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<Cap._4_List4_39.MyService>, Cap._4_List4_39.MyService
    {
        public MyServiceClient() { }
        public MyServiceClient(string endpointConfigurationName): base(endpointConfigurationName) { }
        public MyServiceClient(string endpointConfigurationName, string remoteAddress): base(endpointConfigurationName, remoteAddress) { }
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress): 
            base(endpointConfigurationName, remoteAddress)
        { }
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress):
            base(binding, remoteAddress)
        { }

        public string DoWork(string left, string right)
        {
            return base.Channel.DoWork(left, right);
        }

        public System.Threading.Tasks.Task<string> DoWorkAsync(string left, string right)
        {
            return base.Channel.DoWorkAsync(left, right);
        }
    }
}
