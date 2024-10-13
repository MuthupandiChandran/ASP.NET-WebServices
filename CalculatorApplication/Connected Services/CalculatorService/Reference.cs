﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorApplication.CalculatorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorService.CalculateWebServiceSoap")]
    public interface CalculateWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int FirstNumber, int SecondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int FirstNumber, int SecondNumber);
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        CalculatorApplication.CalculatorService.GetAllResponse GetAll(CalculatorApplication.CalculatorService.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculatorApplication.CalculatorService.GetAllResponse> GetAllAsync(CalculatorApplication.CalculatorService.GetAllRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public CalculatorApplication.CalculatorService.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(CalculatorApplication.CalculatorService.GetAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRequestBody {
        
        public GetAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public CalculatorApplication.CalculatorService.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(CalculatorApplication.CalculatorService.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CalculatorApplication.CalculatorService.ArrayOfString GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(CalculatorApplication.CalculatorService.ArrayOfString GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculateWebServiceSoapChannel : CalculatorApplication.CalculatorService.CalculateWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculateWebServiceSoapClient : System.ServiceModel.ClientBase<CalculatorApplication.CalculatorService.CalculateWebServiceSoap>, CalculatorApplication.CalculatorService.CalculateWebServiceSoap {
        
        public CalculateWebServiceSoapClient() {
        }
        
        public CalculateWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculateWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculateWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculateWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int FirstNumber, int SecondNumber) {
            return base.Channel.Add(FirstNumber, SecondNumber);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int FirstNumber, int SecondNumber) {
            return base.Channel.AddAsync(FirstNumber, SecondNumber);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CalculatorApplication.CalculatorService.GetAllResponse CalculatorApplication.CalculatorService.CalculateWebServiceSoap.GetAll(CalculatorApplication.CalculatorService.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public CalculatorApplication.CalculatorService.ArrayOfString GetAll() {
            CalculatorApplication.CalculatorService.GetAllRequest inValue = new CalculatorApplication.CalculatorService.GetAllRequest();
            inValue.Body = new CalculatorApplication.CalculatorService.GetAllRequestBody();
            CalculatorApplication.CalculatorService.GetAllResponse retVal = ((CalculatorApplication.CalculatorService.CalculateWebServiceSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CalculatorApplication.CalculatorService.GetAllResponse> CalculatorApplication.CalculatorService.CalculateWebServiceSoap.GetAllAsync(CalculatorApplication.CalculatorService.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalculatorApplication.CalculatorService.GetAllResponse> GetAllAsync() {
            CalculatorApplication.CalculatorService.GetAllRequest inValue = new CalculatorApplication.CalculatorService.GetAllRequest();
            inValue.Body = new CalculatorApplication.CalculatorService.GetAllRequestBody();
            return ((CalculatorApplication.CalculatorService.CalculateWebServiceSoap)(this)).GetAllAsync(inValue);
        }
    }
}
