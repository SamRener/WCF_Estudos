﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Form.ItemService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Produto", Namespace="http://schemas.datacontract.org/2004/07/WCF_Exemplo.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Produto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MarcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrecoField;
        
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
        public string Marca {
            get {
                return this.MarcaField;
            }
            set {
                if ((object.ReferenceEquals(this.MarcaField, value) != true)) {
                    this.MarcaField = value;
                    this.RaisePropertyChanged("Marca");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Preco {
            get {
                return this.PrecoField;
            }
            set {
                if ((this.PrecoField.Equals(value) != true)) {
                    this.PrecoField = value;
                    this.RaisePropertyChanged("Preco");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/WCF_Exemplo.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoBarraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCF_Form.ItemService.Produto ProdutoField;
        
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
        public int CodigoBarra {
            get {
                return this.CodigoBarraField;
            }
            set {
                if ((this.CodigoBarraField.Equals(value) != true)) {
                    this.CodigoBarraField = value;
                    this.RaisePropertyChanged("CodigoBarra");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCF_Form.ItemService.Produto Produto {
            get {
                return this.ProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdutoField, value) != true)) {
                    this.ProdutoField = value;
                    this.RaisePropertyChanged("Produto");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ItemService.IItemService")]
    public interface IItemService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/Pass", ReplyAction="http://tempuri.org/IItemService/PassResponse")]
        WCF_Form.ItemService.PassResponse Pass(WCF_Form.ItemService.PassRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque a operação tem vários valores de retorno.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/Pass", ReplyAction="http://tempuri.org/IItemService/PassResponse")]
        System.Threading.Tasks.Task<WCF_Form.ItemService.PassResponse> PassAsync(WCF_Form.ItemService.PassRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/Add", ReplyAction="http://tempuri.org/IItemService/AddResponse")]
        WCF_Form.ItemService.AddResponse Add(WCF_Form.ItemService.AddRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque a operação tem vários valores de retorno.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/Add", ReplyAction="http://tempuri.org/IItemService/AddResponse")]
        System.Threading.Tasks.Task<WCF_Form.ItemService.AddResponse> AddAsync(WCF_Form.ItemService.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/Get", ReplyAction="http://tempuri.org/IItemService/GetResponse")]
        WCF_Form.ItemService.GetResponse Get(WCF_Form.ItemService.GetRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque a operação tem vários valores de retorno.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/Get", ReplyAction="http://tempuri.org/IItemService/GetResponse")]
        System.Threading.Tasks.Task<WCF_Form.ItemService.GetResponse> GetAsync(WCF_Form.ItemService.GetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/Find", ReplyAction="http://tempuri.org/IItemService/FindResponse")]
        WCF_Form.ItemService.FindResponse Find(WCF_Form.ItemService.FindRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque a operação tem vários valores de retorno.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/Find", ReplyAction="http://tempuri.org/IItemService/FindResponse")]
        System.Threading.Tasks.Task<WCF_Form.ItemService.FindResponse> FindAsync(WCF_Form.ItemService.FindRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Pass", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PassRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int codigoBarras;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public PassRequest() {
        }
        
        public PassRequest(int codigoBarras, string mensagem) {
            this.codigoBarras = codigoBarras;
            this.mensagem = mensagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PassResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PassResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool PassResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public PassResponse() {
        }
        
        public PassResponse(bool PassResult, string mensagem) {
            this.PassResult = PassResult;
            this.mensagem = mensagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Add", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int codigoBarras;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int IdProduto;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string mensagem;
        
        public AddRequest() {
        }
        
        public AddRequest(int codigoBarras, int IdProduto, string mensagem) {
            this.codigoBarras = codigoBarras;
            this.IdProduto = IdProduto;
            this.mensagem = mensagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool AddResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public AddResponse() {
        }
        
        public AddResponse(bool AddResult, string mensagem) {
            this.AddResult = AddResult;
            this.mensagem = mensagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Get", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int codigoBarras;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public GetRequest() {
        }
        
        public GetRequest(int codigoBarras, string mensagem) {
            this.codigoBarras = codigoBarras;
            this.mensagem = mensagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WCF_Form.ItemService.Produto GetResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public GetResponse() {
        }
        
        public GetResponse(WCF_Form.ItemService.Produto GetResult, string mensagem) {
            this.GetResult = GetResult;
            this.mensagem = mensagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Find", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FindRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int IdProduto;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public FindRequest() {
        }
        
        public FindRequest(int IdProduto, string mensagem) {
            this.IdProduto = IdProduto;
            this.mensagem = mensagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FindResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FindResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WCF_Form.ItemService.Item[] FindResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public FindResponse() {
        }
        
        public FindResponse(WCF_Form.ItemService.Item[] FindResult, string mensagem) {
            this.FindResult = FindResult;
            this.mensagem = mensagem;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IItemServiceChannel : WCF_Form.ItemService.IItemService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ItemServiceClient : System.ServiceModel.ClientBase<WCF_Form.ItemService.IItemService>, WCF_Form.ItemService.IItemService {
        
        public ItemServiceClient() {
        }
        
        public ItemServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ItemServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItemServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItemServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCF_Form.ItemService.PassResponse WCF_Form.ItemService.IItemService.Pass(WCF_Form.ItemService.PassRequest request) {
            return base.Channel.Pass(request);
        }
        
        public bool Pass(int codigoBarras, ref string mensagem) {
            WCF_Form.ItemService.PassRequest inValue = new WCF_Form.ItemService.PassRequest();
            inValue.codigoBarras = codigoBarras;
            inValue.mensagem = mensagem;
            WCF_Form.ItemService.PassResponse retVal = ((WCF_Form.ItemService.IItemService)(this)).Pass(inValue);
            mensagem = retVal.mensagem;
            return retVal.PassResult;
        }
        
        public System.Threading.Tasks.Task<WCF_Form.ItemService.PassResponse> PassAsync(WCF_Form.ItemService.PassRequest request) {
            return base.Channel.PassAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCF_Form.ItemService.AddResponse WCF_Form.ItemService.IItemService.Add(WCF_Form.ItemService.AddRequest request) {
            return base.Channel.Add(request);
        }
        
        public bool Add(int codigoBarras, int IdProduto, ref string mensagem) {
            WCF_Form.ItemService.AddRequest inValue = new WCF_Form.ItemService.AddRequest();
            inValue.codigoBarras = codigoBarras;
            inValue.IdProduto = IdProduto;
            inValue.mensagem = mensagem;
            WCF_Form.ItemService.AddResponse retVal = ((WCF_Form.ItemService.IItemService)(this)).Add(inValue);
            mensagem = retVal.mensagem;
            return retVal.AddResult;
        }
        
        public System.Threading.Tasks.Task<WCF_Form.ItemService.AddResponse> AddAsync(WCF_Form.ItemService.AddRequest request) {
            return base.Channel.AddAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCF_Form.ItemService.GetResponse WCF_Form.ItemService.IItemService.Get(WCF_Form.ItemService.GetRequest request) {
            return base.Channel.Get(request);
        }
        
        public WCF_Form.ItemService.Produto Get(int codigoBarras, ref string mensagem) {
            WCF_Form.ItemService.GetRequest inValue = new WCF_Form.ItemService.GetRequest();
            inValue.codigoBarras = codigoBarras;
            inValue.mensagem = mensagem;
            WCF_Form.ItemService.GetResponse retVal = ((WCF_Form.ItemService.IItemService)(this)).Get(inValue);
            mensagem = retVal.mensagem;
            return retVal.GetResult;
        }
        
        public System.Threading.Tasks.Task<WCF_Form.ItemService.GetResponse> GetAsync(WCF_Form.ItemService.GetRequest request) {
            return base.Channel.GetAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCF_Form.ItemService.FindResponse WCF_Form.ItemService.IItemService.Find(WCF_Form.ItemService.FindRequest request) {
            return base.Channel.Find(request);
        }
        
        public WCF_Form.ItemService.Item[] Find(int IdProduto, ref string mensagem) {
            WCF_Form.ItemService.FindRequest inValue = new WCF_Form.ItemService.FindRequest();
            inValue.IdProduto = IdProduto;
            inValue.mensagem = mensagem;
            WCF_Form.ItemService.FindResponse retVal = ((WCF_Form.ItemService.IItemService)(this)).Find(inValue);
            mensagem = retVal.mensagem;
            return retVal.FindResult;
        }
        
        public System.Threading.Tasks.Task<WCF_Form.ItemService.FindResponse> FindAsync(WCF_Form.ItemService.FindRequest request) {
            return base.Channel.FindAsync(request);
        }
    }
}
