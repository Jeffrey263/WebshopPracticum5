﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebshopClientConsole.webshopService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="webshopService.IwebshopService")]
    public interface IwebshopService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/PostOrderTest", ReplyAction="http://tempuri.org/IwebshopService/PostOrderTestResponse")]
        void PostOrderTest(string name, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/PostOrderTest", ReplyAction="http://tempuri.org/IwebshopService/PostOrderTestResponse")]
        System.Threading.Tasks.Task PostOrderTestAsync(string name, int quantity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IwebshopServiceChannel : WebshopClientConsole.webshopService.IwebshopService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IwebshopServiceClient : System.ServiceModel.ClientBase<WebshopClientConsole.webshopService.IwebshopService>, WebshopClientConsole.webshopService.IwebshopService {
        
        public IwebshopServiceClient() {
        }
        
        public IwebshopServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IwebshopServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwebshopServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwebshopServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void PostOrderTest(string name, int quantity) {
            base.Channel.PostOrderTest(name, quantity);
        }
        
        public System.Threading.Tasks.Task PostOrderTestAsync(string name, int quantity) {
            return base.Channel.PostOrderTestAsync(name, quantity);
        }
    }
}
