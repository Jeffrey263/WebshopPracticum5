﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webshopFormsApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/WebshopDomain")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int stockField;
        
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
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int stock {
            get {
                return this.stockField;
            }
            set {
                if ((this.stockField.Equals(value) != true)) {
                    this.stockField = value;
                    this.RaisePropertyChanged("stock");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WebshopDomain")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double balanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
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
        public double balance {
            get {
                return this.balanceField;
            }
            set {
                if ((this.balanceField.Equals(value) != true)) {
                    this.balanceField = value;
                    this.RaisePropertyChanged("balance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/WebshopDomain")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private webshopFormsApp.ServiceReference1.User UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private webshopFormsApp.ServiceReference1.Order_Product[] productenField;
        
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
        public webshopFormsApp.ServiceReference1.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public webshopFormsApp.ServiceReference1.Order_Product[] producten {
            get {
                return this.productenField;
            }
            set {
                if ((object.ReferenceEquals(this.productenField, value) != true)) {
                    this.productenField = value;
                    this.RaisePropertyChanged("producten");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Order_Product", Namespace="http://schemas.datacontract.org/2004/07/WebshopDomain")]
    [System.SerializableAttribute()]
    public partial class Order_Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private webshopFormsApp.ServiceReference1.Product ProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int quantityField;
        
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
        public webshopFormsApp.ServiceReference1.Product Product {
            get {
                return this.ProductField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductField, value) != true)) {
                    this.ProductField = value;
                    this.RaisePropertyChanged("Product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int quantity {
            get {
                return this.quantityField;
            }
            set {
                if ((this.quantityField.Equals(value) != true)) {
                    this.quantityField = value;
                    this.RaisePropertyChanged("quantity");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderProductDTO", Namespace="http://schemas.datacontract.org/2004/07/WebshopDomain")]
    [System.SerializableAttribute()]
    public partial class OrderProductDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int productField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int quantityField;
        
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
        public int product {
            get {
                return this.productField;
            }
            set {
                if ((this.productField.Equals(value) != true)) {
                    this.productField = value;
                    this.RaisePropertyChanged("product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int quantity {
            get {
                return this.quantityField;
            }
            set {
                if ((this.quantityField.Equals(value) != true)) {
                    this.quantityField = value;
                    this.RaisePropertyChanged("quantity");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IwebshopService")]
    public interface IwebshopService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetAllProducts", ReplyAction="http://tempuri.org/IwebshopService/GetAllProductsResponse")]
        webshopFormsApp.ServiceReference1.Product[] GetAllProducts(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetAllProducts", ReplyAction="http://tempuri.org/IwebshopService/GetAllProductsResponse")]
        System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.Product[]> GetAllProductsAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetProductById", ReplyAction="http://tempuri.org/IwebshopService/GetProductByIdResponse")]
        webshopFormsApp.ServiceReference1.Product GetProductById(int id, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetProductById", ReplyAction="http://tempuri.org/IwebshopService/GetProductByIdResponse")]
        System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.Product> GetProductByIdAsync(int id, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/SaveProduct", ReplyAction="http://tempuri.org/IwebshopService/SaveProductResponse")]
        void SaveProduct(string name, string desc, int stock, double price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/SaveProduct", ReplyAction="http://tempuri.org/IwebshopService/SaveProductResponse")]
        System.Threading.Tasks.Task SaveProductAsync(string name, string desc, int stock, double price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetAllUsers", ReplyAction="http://tempuri.org/IwebshopService/GetAllUsersResponse")]
        webshopFormsApp.ServiceReference1.User[] GetAllUsers(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetAllUsers", ReplyAction="http://tempuri.org/IwebshopService/GetAllUsersResponse")]
        System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.User[]> GetAllUsersAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetUserByID", ReplyAction="http://tempuri.org/IwebshopService/GetUserByIDResponse")]
        webshopFormsApp.ServiceReference1.User GetUserByID(int id, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetUserByID", ReplyAction="http://tempuri.org/IwebshopService/GetUserByIDResponse")]
        System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.User> GetUserByIDAsync(int id, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetUserByName", ReplyAction="http://tempuri.org/IwebshopService/GetUserByNameResponse")]
        webshopFormsApp.ServiceReference1.User GetUserByName(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetUserByName", ReplyAction="http://tempuri.org/IwebshopService/GetUserByNameResponse")]
        System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.User> GetUserByNameAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/SaveNewUser", ReplyAction="http://tempuri.org/IwebshopService/SaveNewUserResponse")]
        string SaveNewUser(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/SaveNewUser", ReplyAction="http://tempuri.org/IwebshopService/SaveNewUserResponse")]
        System.Threading.Tasks.Task<string> SaveNewUserAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/CheckUserAuthentication", ReplyAction="http://tempuri.org/IwebshopService/CheckUserAuthenticationResponse")]
        bool CheckUserAuthentication(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/CheckUserAuthentication", ReplyAction="http://tempuri.org/IwebshopService/CheckUserAuthenticationResponse")]
        System.Threading.Tasks.Task<bool> CheckUserAuthenticationAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetAllOrdersByCustomerID", ReplyAction="http://tempuri.org/IwebshopService/GetAllOrdersByCustomerIDResponse")]
        int[] GetAllOrdersByCustomerID(int cId, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetAllOrdersByCustomerID", ReplyAction="http://tempuri.org/IwebshopService/GetAllOrdersByCustomerIDResponse")]
        System.Threading.Tasks.Task<int[]> GetAllOrdersByCustomerIDAsync(int cId, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetOrderByID", ReplyAction="http://tempuri.org/IwebshopService/GetOrderByIDResponse")]
        webshopFormsApp.ServiceReference1.Order GetOrderByID(int id, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetOrderByID", ReplyAction="http://tempuri.org/IwebshopService/GetOrderByIDResponse")]
        System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.Order> GetOrderByIDAsync(int id, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/SaveNewOrder", ReplyAction="http://tempuri.org/IwebshopService/SaveNewOrderResponse")]
        void SaveNewOrder(webshopFormsApp.ServiceReference1.User u, webshopFormsApp.ServiceReference1.Order_Product[] producten, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/SaveNewOrder", ReplyAction="http://tempuri.org/IwebshopService/SaveNewOrderResponse")]
        System.Threading.Tasks.Task SaveNewOrderAsync(webshopFormsApp.ServiceReference1.User u, webshopFormsApp.ServiceReference1.Order_Product[] producten, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetProductsFromOrder", ReplyAction="http://tempuri.org/IwebshopService/GetProductsFromOrderResponse")]
        webshopFormsApp.ServiceReference1.OrderProductDTO[] GetProductsFromOrder(int orderID, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwebshopService/GetProductsFromOrder", ReplyAction="http://tempuri.org/IwebshopService/GetProductsFromOrderResponse")]
        System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.OrderProductDTO[]> GetProductsFromOrderAsync(int orderID, string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IwebshopServiceChannel : webshopFormsApp.ServiceReference1.IwebshopService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IwebshopServiceClient : System.ServiceModel.ClientBase<webshopFormsApp.ServiceReference1.IwebshopService>, webshopFormsApp.ServiceReference1.IwebshopService {
        
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
        
        public webshopFormsApp.ServiceReference1.Product[] GetAllProducts(string username, string password) {
            return base.Channel.GetAllProducts(username, password);
        }
        
        public System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.Product[]> GetAllProductsAsync(string username, string password) {
            return base.Channel.GetAllProductsAsync(username, password);
        }
        
        public webshopFormsApp.ServiceReference1.Product GetProductById(int id, string username, string password) {
            return base.Channel.GetProductById(id, username, password);
        }
        
        public System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.Product> GetProductByIdAsync(int id, string username, string password) {
            return base.Channel.GetProductByIdAsync(id, username, password);
        }
        
        public void SaveProduct(string name, string desc, int stock, double price) {
            base.Channel.SaveProduct(name, desc, stock, price);
        }
        
        public System.Threading.Tasks.Task SaveProductAsync(string name, string desc, int stock, double price) {
            return base.Channel.SaveProductAsync(name, desc, stock, price);
        }
        
        public webshopFormsApp.ServiceReference1.User[] GetAllUsers(string username, string password) {
            return base.Channel.GetAllUsers(username, password);
        }
        
        public System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.User[]> GetAllUsersAsync(string username, string password) {
            return base.Channel.GetAllUsersAsync(username, password);
        }
        
        public webshopFormsApp.ServiceReference1.User GetUserByID(int id, string username, string password) {
            return base.Channel.GetUserByID(id, username, password);
        }
        
        public System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.User> GetUserByIDAsync(int id, string username, string password) {
            return base.Channel.GetUserByIDAsync(id, username, password);
        }
        
        public webshopFormsApp.ServiceReference1.User GetUserByName(string username, string password) {
            return base.Channel.GetUserByName(username, password);
        }
        
        public System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.User> GetUserByNameAsync(string username, string password) {
            return base.Channel.GetUserByNameAsync(username, password);
        }
        
        public string SaveNewUser(string name) {
            return base.Channel.SaveNewUser(name);
        }
        
        public System.Threading.Tasks.Task<string> SaveNewUserAsync(string name) {
            return base.Channel.SaveNewUserAsync(name);
        }
        
        public bool CheckUserAuthentication(string username, string password) {
            return base.Channel.CheckUserAuthentication(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUserAuthenticationAsync(string username, string password) {
            return base.Channel.CheckUserAuthenticationAsync(username, password);
        }
        
        public int[] GetAllOrdersByCustomerID(int cId, string username, string password) {
            return base.Channel.GetAllOrdersByCustomerID(cId, username, password);
        }
        
        public System.Threading.Tasks.Task<int[]> GetAllOrdersByCustomerIDAsync(int cId, string username, string password) {
            return base.Channel.GetAllOrdersByCustomerIDAsync(cId, username, password);
        }
        
        public webshopFormsApp.ServiceReference1.Order GetOrderByID(int id, string username, string password) {
            return base.Channel.GetOrderByID(id, username, password);
        }
        
        public System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.Order> GetOrderByIDAsync(int id, string username, string password) {
            return base.Channel.GetOrderByIDAsync(id, username, password);
        }
        
        public void SaveNewOrder(webshopFormsApp.ServiceReference1.User u, webshopFormsApp.ServiceReference1.Order_Product[] producten, string username, string password) {
            base.Channel.SaveNewOrder(u, producten, username, password);
        }
        
        public System.Threading.Tasks.Task SaveNewOrderAsync(webshopFormsApp.ServiceReference1.User u, webshopFormsApp.ServiceReference1.Order_Product[] producten, string username, string password) {
            return base.Channel.SaveNewOrderAsync(u, producten, username, password);
        }
        
        public webshopFormsApp.ServiceReference1.OrderProductDTO[] GetProductsFromOrder(int orderID, string username, string password) {
            return base.Channel.GetProductsFromOrder(orderID, username, password);
        }
        
        public System.Threading.Tasks.Task<webshopFormsApp.ServiceReference1.OrderProductDTO[]> GetProductsFromOrderAsync(int orderID, string username, string password) {
            return base.Channel.GetProductsFromOrderAsync(orderID, username, password);
        }
    }
}
