﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteConsoleApp.Clientes {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/DemoAzureWCF.Models")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Clientes.IClientes")]
    public interface IClientes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/Todos", ReplyAction="http://tempuri.org/IClientes/TodosResponse")]
        ClienteConsoleApp.Clientes.Cliente[] Todos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/Todos", ReplyAction="http://tempuri.org/IClientes/TodosResponse")]
        System.Threading.Tasks.Task<ClienteConsoleApp.Clientes.Cliente[]> TodosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ObterPorId", ReplyAction="http://tempuri.org/IClientes/ObterPorIdResponse")]
        ClienteConsoleApp.Clientes.Cliente ObterPorId(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ObterPorId", ReplyAction="http://tempuri.org/IClientes/ObterPorIdResponse")]
        System.Threading.Tasks.Task<ClienteConsoleApp.Clientes.Cliente> ObterPorIdAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientesChannel : ClienteConsoleApp.Clientes.IClientes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientesClient : System.ServiceModel.ClientBase<ClienteConsoleApp.Clientes.IClientes>, ClienteConsoleApp.Clientes.IClientes {
        
        public ClientesClient() {
        }
        
        public ClientesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteConsoleApp.Clientes.Cliente[] Todos() {
            return base.Channel.Todos();
        }
        
        public System.Threading.Tasks.Task<ClienteConsoleApp.Clientes.Cliente[]> TodosAsync() {
            return base.Channel.TodosAsync();
        }
        
        public ClienteConsoleApp.Clientes.Cliente ObterPorId(string id) {
            return base.Channel.ObterPorId(id);
        }
        
        public System.Threading.Tasks.Task<ClienteConsoleApp.Clientes.Cliente> ObterPorIdAsync(string id) {
            return base.Channel.ObterPorIdAsync(id);
        }
    }
}
