﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.20702.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        // CODEGEN: Generating message contract since the operation NextStep is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/NextStep", ReplyAction="http://tempuri.org/IService/NextStepResponse")]
        Client.ServiceReference1.NextStepResponse NextStep(Client.ServiceReference1.NextStepRequest request);
        
        // CODEGEN: Generating message contract since the operation DiagnoseStart is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DiagnoseStart", ReplyAction="http://tempuri.org/IService/DiagnoseStartResponse")]
        Client.ServiceReference1.DiagnoseStartResponse DiagnoseStart(Client.ServiceReference1.DiagnoseStartRequest request);
        
        // CODEGEN: Generating message contract since the operation DiagnoseAC is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DiagnoseAC", ReplyAction="http://tempuri.org/IService/DiagnoseACResponse")]
        Client.ServiceReference1.DiagnoseACResponse DiagnoseAC(Client.ServiceReference1.DiagnoseACRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NextStepRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
        public System.Nullable<bool> boolean;
        
        public NextStepRequest() {
        }
        
        public NextStepRequest(System.Nullable<bool> boolean) {
            this.boolean = boolean;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NextStepResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
        public string @string;
        
        public NextStepResponse() {
        }
        
        public NextStepResponse(string @string) {
            this.@string = @string;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DiagnoseStartRequest {
        
        public DiagnoseStartRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DiagnoseStartResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
        public string @string;
        
        public DiagnoseStartResponse() {
        }
        
        public DiagnoseStartResponse(string @string) {
            this.@string = @string;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DiagnoseACRequest {
        
        public DiagnoseACRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DiagnoseACResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
        public string @string;
        
        public DiagnoseACResponse() {
        }
        
        public DiagnoseACResponse(string @string) {
            this.@string = @string;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Client.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IService>, Client.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.ServiceReference1.NextStepResponse Client.ServiceReference1.IService.NextStep(Client.ServiceReference1.NextStepRequest request) {
            return base.Channel.NextStep(request);
        }
        
        public string NextStep(System.Nullable<bool> boolean) {
            Client.ServiceReference1.NextStepRequest inValue = new Client.ServiceReference1.NextStepRequest();
            inValue.boolean = boolean;
            Client.ServiceReference1.NextStepResponse retVal = ((Client.ServiceReference1.IService)(this)).NextStep(inValue);
            return retVal.@string;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.ServiceReference1.DiagnoseStartResponse Client.ServiceReference1.IService.DiagnoseStart(Client.ServiceReference1.DiagnoseStartRequest request) {
            return base.Channel.DiagnoseStart(request);
        }
        
        public string DiagnoseStart() {
            Client.ServiceReference1.DiagnoseStartRequest inValue = new Client.ServiceReference1.DiagnoseStartRequest();
            Client.ServiceReference1.DiagnoseStartResponse retVal = ((Client.ServiceReference1.IService)(this)).DiagnoseStart(inValue);
            return retVal.@string;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.ServiceReference1.DiagnoseACResponse Client.ServiceReference1.IService.DiagnoseAC(Client.ServiceReference1.DiagnoseACRequest request) {
            return base.Channel.DiagnoseAC(request);
        }
        
        public string DiagnoseAC() {
            Client.ServiceReference1.DiagnoseACRequest inValue = new Client.ServiceReference1.DiagnoseACRequest();
            Client.ServiceReference1.DiagnoseACResponse retVal = ((Client.ServiceReference1.IService)(this)).DiagnoseAC(inValue);
            return retVal.@string;
        }
    }
}
