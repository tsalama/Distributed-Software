﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/password", ReplyAction="http://tempuri.org/IService1/passwordResponse")]
        string password(string firstName, string lastName, int age);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/password", ReplyAction="http://tempuri.org/IService1/passwordResponse")]
        System.Threading.Tasks.Task<string> passwordAsync(string firstName, string lastName, int age);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/loginId", ReplyAction="http://tempuri.org/IService1/loginIdResponse")]
        int loginId(int age);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/loginId", ReplyAction="http://tempuri.org/IService1/loginIdResponse")]
        System.Threading.Tasks.Task<int> loginIdAsync(int age);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication1.ServiceReference1.IService1>, WebApplication1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string password(string firstName, string lastName, int age) {
            return base.Channel.password(firstName, lastName, age);
        }
        
        public System.Threading.Tasks.Task<string> passwordAsync(string firstName, string lastName, int age) {
            return base.Channel.passwordAsync(firstName, lastName, age);
        }
        
        public int loginId(int age) {
            return base.Channel.loginId(age);
        }
        
        public System.Threading.Tasks.Task<int> loginIdAsync(int age) {
            return base.Channel.loginIdAsync(age);
        }
    }
}