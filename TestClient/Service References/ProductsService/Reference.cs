﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestClient.ProductsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductData", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class ProductData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ListPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ListPrice {
            get {
                return this.ListPriceField;
            }
            set {
                if ((this.ListPriceField.Equals(value) != true)) {
                    this.ListPriceField = value;
                    this.RaisePropertyChanged("ListPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://eclinicalworks.com", ConfigurationName="ProductsService.ProductsService", CallbackContract=typeof(TestClient.ProductsService.ProductsServiceCallback))]
    public interface ProductsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://eclinicalworks.com/ProductsService/ListProducts", ReplyAction="http://eclinicalworks.com/ProductsService/ListProductsResponse")]
        TestClient.ProductsService.ProductData[] ListProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://eclinicalworks.com/ProductsService/ListProducts", ReplyAction="http://eclinicalworks.com/ProductsService/ListProductsResponse")]
        System.Threading.Tasks.Task<TestClient.ProductsService.ProductData[]> ListProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://eclinicalworks.com/ProductsService/ChangePrice", ReplyAction="http://eclinicalworks.com/ProductsService/ChangePriceResponse")]
        void ChangePrice(string productName, decimal price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://eclinicalworks.com/ProductsService/ChangePrice", ReplyAction="http://eclinicalworks.com/ProductsService/ChangePriceResponse")]
        System.Threading.Tasks.Task ChangePriceAsync(string productName, decimal price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://eclinicalworks.com/ProductsService/SubscribeToPriceChangedEvent", ReplyAction="http://eclinicalworks.com/ProductsService/SubscribeToPriceChangedEventResponse")]
        bool SubscribeToPriceChangedEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://eclinicalworks.com/ProductsService/SubscribeToPriceChangedEvent", ReplyAction="http://eclinicalworks.com/ProductsService/SubscribeToPriceChangedEventResponse")]
        System.Threading.Tasks.Task<bool> SubscribeToPriceChangedEventAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://eclinicalworks.com/ProductsService/UnsubscribeFromPriceChangedEvent", ReplyAction="http://eclinicalworks.com/ProductsService/UnsubscribeFromPriceChangedEventRespons" +
            "e")]
        bool UnsubscribeFromPriceChangedEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://eclinicalworks.com/ProductsService/UnsubscribeFromPriceChangedEvent", ReplyAction="http://eclinicalworks.com/ProductsService/UnsubscribeFromPriceChangedEventRespons" +
            "e")]
        System.Threading.Tasks.Task<bool> UnsubscribeFromPriceChangedEventAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProductsServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://eclinicalworks.com/ProductsService/OnPriceChanged")]
        void OnPriceChanged(TestClient.ProductsService.ProductData product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProductsServiceChannel : TestClient.ProductsService.ProductsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsServiceClient : System.ServiceModel.DuplexClientBase<TestClient.ProductsService.ProductsService>, TestClient.ProductsService.ProductsService {
        
        public ProductsServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ProductsServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ProductsServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public TestClient.ProductsService.ProductData[] ListProducts() {
            return base.Channel.ListProducts();
        }
        
        public System.Threading.Tasks.Task<TestClient.ProductsService.ProductData[]> ListProductsAsync() {
            return base.Channel.ListProductsAsync();
        }
        
        public void ChangePrice(string productName, decimal price) {
            base.Channel.ChangePrice(productName, price);
        }
        
        public System.Threading.Tasks.Task ChangePriceAsync(string productName, decimal price) {
            return base.Channel.ChangePriceAsync(productName, price);
        }
        
        public bool SubscribeToPriceChangedEvent() {
            return base.Channel.SubscribeToPriceChangedEvent();
        }
        
        public System.Threading.Tasks.Task<bool> SubscribeToPriceChangedEventAsync() {
            return base.Channel.SubscribeToPriceChangedEventAsync();
        }
        
        public bool UnsubscribeFromPriceChangedEvent() {
            return base.Channel.UnsubscribeFromPriceChangedEvent();
        }
        
        public System.Threading.Tasks.Task<bool> UnsubscribeFromPriceChangedEventAsync() {
            return base.Channel.UnsubscribeFromPriceChangedEventAsync();
        }
    }
}
