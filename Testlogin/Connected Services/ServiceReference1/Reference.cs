﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Testlogin.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RegisterViewModel", Namespace="http://schemas.datacontract.org/2004/07/Testlogin.Models")]
    [System.SerializableAttribute()]
    public partial class RegisterViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ConfirmPWField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PWField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
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
        public System.Nullable<int> Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ConfirmPW {
            get {
                return this.ConfirmPWField;
            }
            set {
                if ((object.ReferenceEquals(this.ConfirmPWField, value) != true)) {
                    this.ConfirmPWField = value;
                    this.RaisePropertyChanged("ConfirmPW");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lastname {
            get {
                return this.LastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastnameField, value) != true)) {
                    this.LastnameField = value;
                    this.RaisePropertyChanged("Lastname");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PW {
            get {
                return this.PWField;
            }
            set {
                if ((object.ReferenceEquals(this.PWField, value) != true)) {
                    this.PWField = value;
                    this.RaisePropertyChanged("PW");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RepasswordViewModel", Namespace="http://schemas.datacontract.org/2004/07/Testlogin.Models")]
    [System.SerializableAttribute()]
    public partial class RepasswordViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ConfirmPasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NewPasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
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
        public string ConfirmPassword {
            get {
                return this.ConfirmPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.ConfirmPasswordField, value) != true)) {
                    this.ConfirmPasswordField = value;
                    this.RaisePropertyChanged("ConfirmPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NewPassword {
            get {
                return this.NewPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.NewPasswordField, value) != true)) {
                    this.NewPasswordField = value;
                    this.RaisePropertyChanged("NewPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginViewModel", Namespace="http://schemas.datacontract.org/2004/07/Testlogin.Models")]
    [System.SerializableAttribute()]
    public partial class LoginViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Testlogin.ServiceReference1.CompositeType GetDataUsingDataContract(Testlogin.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Testlogin.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Testlogin.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registerid", ReplyAction="http://tempuri.org/IService1/RegisteridResponse")]
        int Registerid(Testlogin.ServiceReference1.RegisterViewModel r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registerid", ReplyAction="http://tempuri.org/IService1/RegisteridResponse")]
        System.Threading.Tasks.Task<int> RegisteridAsync(Testlogin.ServiceReference1.RegisterViewModel r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Updateid", ReplyAction="http://tempuri.org/IService1/UpdateidResponse")]
        int Updateid(Testlogin.ServiceReference1.RegisterViewModel r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Updateid", ReplyAction="http://tempuri.org/IService1/UpdateidResponse")]
        System.Threading.Tasks.Task<int> UpdateidAsync(Testlogin.ServiceReference1.RegisterViewModel r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Repass", ReplyAction="http://tempuri.org/IService1/RepassResponse")]
        int Repass(Testlogin.ServiceReference1.RepasswordViewModel re);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Repass", ReplyAction="http://tempuri.org/IService1/RepassResponse")]
        System.Threading.Tasks.Task<int> RepassAsync(Testlogin.ServiceReference1.RepasswordViewModel re);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Deleteid", ReplyAction="http://tempuri.org/IService1/DeleteidResponse")]
        int Deleteid(Testlogin.ServiceReference1.LoginViewModel l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Deleteid", ReplyAction="http://tempuri.org/IService1/DeleteidResponse")]
        System.Threading.Tasks.Task<int> DeleteidAsync(Testlogin.ServiceReference1.LoginViewModel l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Getlogin", ReplyAction="http://tempuri.org/IService1/GetloginResponse")]
        Testlogin.ServiceReference1.RegisterViewModel[] Getlogin(Testlogin.ServiceReference1.LoginViewModel l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Getlogin", ReplyAction="http://tempuri.org/IService1/GetloginResponse")]
        System.Threading.Tasks.Task<Testlogin.ServiceReference1.RegisterViewModel[]> GetloginAsync(Testlogin.ServiceReference1.LoginViewModel l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Checkid", ReplyAction="http://tempuri.org/IService1/CheckidResponse")]
        System.Nullable<int> Checkid(Testlogin.ServiceReference1.RegisterViewModel r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Checkid", ReplyAction="http://tempuri.org/IService1/CheckidResponse")]
        System.Threading.Tasks.Task<System.Nullable<int>> CheckidAsync(Testlogin.ServiceReference1.RegisterViewModel r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Checkemail", ReplyAction="http://tempuri.org/IService1/CheckemailResponse")]
        System.Nullable<int> Checkemail(Testlogin.ServiceReference1.RegisterViewModel r);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Checkemail", ReplyAction="http://tempuri.org/IService1/CheckemailResponse")]
        System.Threading.Tasks.Task<System.Nullable<int>> CheckemailAsync(Testlogin.ServiceReference1.RegisterViewModel r);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Testlogin.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Testlogin.ServiceReference1.IService1>, Testlogin.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Testlogin.ServiceReference1.CompositeType GetDataUsingDataContract(Testlogin.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Testlogin.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Testlogin.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int Registerid(Testlogin.ServiceReference1.RegisterViewModel r) {
            return base.Channel.Registerid(r);
        }
        
        public System.Threading.Tasks.Task<int> RegisteridAsync(Testlogin.ServiceReference1.RegisterViewModel r) {
            return base.Channel.RegisteridAsync(r);
        }
        
        public int Updateid(Testlogin.ServiceReference1.RegisterViewModel r) {
            return base.Channel.Updateid(r);
        }
        
        public System.Threading.Tasks.Task<int> UpdateidAsync(Testlogin.ServiceReference1.RegisterViewModel r) {
            return base.Channel.UpdateidAsync(r);
        }
        
        public int Repass(Testlogin.ServiceReference1.RepasswordViewModel re) {
            return base.Channel.Repass(re);
        }
        
        public System.Threading.Tasks.Task<int> RepassAsync(Testlogin.ServiceReference1.RepasswordViewModel re) {
            return base.Channel.RepassAsync(re);
        }
        
        public int Deleteid(Testlogin.ServiceReference1.LoginViewModel l) {
            return base.Channel.Deleteid(l);
        }
        
        public System.Threading.Tasks.Task<int> DeleteidAsync(Testlogin.ServiceReference1.LoginViewModel l) {
            return base.Channel.DeleteidAsync(l);
        }
        
        public Testlogin.ServiceReference1.RegisterViewModel[] Getlogin(Testlogin.ServiceReference1.LoginViewModel l) {
            return base.Channel.Getlogin(l);
        }
        
        public System.Threading.Tasks.Task<Testlogin.ServiceReference1.RegisterViewModel[]> GetloginAsync(Testlogin.ServiceReference1.LoginViewModel l) {
            return base.Channel.GetloginAsync(l);
        }
        
        public System.Nullable<int> Checkid(Testlogin.ServiceReference1.RegisterViewModel r) {
            return base.Channel.Checkid(r);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<int>> CheckidAsync(Testlogin.ServiceReference1.RegisterViewModel r) {
            return base.Channel.CheckidAsync(r);
        }
        
        public System.Nullable<int> Checkemail(Testlogin.ServiceReference1.RegisterViewModel r) {
            return base.Channel.Checkemail(r);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<int>> CheckemailAsync(Testlogin.ServiceReference1.RegisterViewModel r) {
            return base.Channel.CheckemailAsync(r);
        }
    }
}
