﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlackJackClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Card", Namespace="http://schemas.datacontract.org/2004/07/BlackJackService")]
    [System.SerializableAttribute()]
    public partial class Card : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BlackJackClient.ServiceReference1.Suit SuitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ValueField;
        
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
        public BlackJackClient.ServiceReference1.Suit Suit {
            get {
                return this.SuitField;
            }
            set {
                if ((this.SuitField.Equals(value) != true)) {
                    this.SuitField = value;
                    this.RaisePropertyChanged("Suit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Suit", Namespace="http://schemas.datacontract.org/2004/07/BlackJackService")]
    public enum Suit : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SPADES = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CLUBS = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DIAMONDS = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HEARTS = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMyGame", CallbackContract=typeof(BlackJackClient.ServiceReference1.IMyGameCallback))]
    public interface IMyGame {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyGame/EnterGame", ReplyAction="http://tempuri.org/IMyGame/EnterGameResponse")]
        void EnterGame(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyGame/EnterGame", ReplyAction="http://tempuri.org/IMyGame/EnterGameResponse")]
        System.Threading.Tasks.Task EnterGameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyGame/ExitGame", ReplyAction="http://tempuri.org/IMyGame/ExitGameResponse")]
        void ExitGame(int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyGame/ExitGame", ReplyAction="http://tempuri.org/IMyGame/ExitGameResponse")]
        System.Threading.Tasks.Task ExitGameAsync(int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyGame/Ready", ReplyAction="http://tempuri.org/IMyGame/ReadyResponse")]
        void Ready(int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyGame/Ready", ReplyAction="http://tempuri.org/IMyGame/ReadyResponse")]
        System.Threading.Tasks.Task ReadyAsync(int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyGame/Pass", ReplyAction="http://tempuri.org/IMyGame/PassResponse")]
        void Pass(int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyGame/Pass", ReplyAction="http://tempuri.org/IMyGame/PassResponse")]
        System.Threading.Tasks.Task PassAsync(int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyGame/GiveCard", ReplyAction="http://tempuri.org/IMyGame/GiveCardResponse")]
        BlackJackClient.ServiceReference1.Card GiveCard(int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyGame/GiveCard", ReplyAction="http://tempuri.org/IMyGame/GiveCardResponse")]
        System.Threading.Tasks.Task<BlackJackClient.ServiceReference1.Card> GiveCardAsync(int playerId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyGameCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyGame/ShowCard", ReplyAction="http://tempuri.org/IMyGame/ShowCardResponse")]
        void ShowCard(BlackJackClient.ServiceReference1.Card card);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyGameChannel : BlackJackClient.ServiceReference1.IMyGame, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyGameClient : System.ServiceModel.DuplexClientBase<BlackJackClient.ServiceReference1.IMyGame>, BlackJackClient.ServiceReference1.IMyGame {
        
        public MyGameClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MyGameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MyGameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MyGameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MyGameClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void EnterGame(string name) {
            base.Channel.EnterGame(name);
        }
        
        public System.Threading.Tasks.Task EnterGameAsync(string name) {
            return base.Channel.EnterGameAsync(name);
        }
        
        public void ExitGame(int playerId) {
            base.Channel.ExitGame(playerId);
        }
        
        public System.Threading.Tasks.Task ExitGameAsync(int playerId) {
            return base.Channel.ExitGameAsync(playerId);
        }
        
        public void Ready(int playerId) {
            base.Channel.Ready(playerId);
        }
        
        public System.Threading.Tasks.Task ReadyAsync(int playerId) {
            return base.Channel.ReadyAsync(playerId);
        }
        
        public void Pass(int playerId) {
            base.Channel.Pass(playerId);
        }
        
        public System.Threading.Tasks.Task PassAsync(int playerId) {
            return base.Channel.PassAsync(playerId);
        }
        
        public BlackJackClient.ServiceReference1.Card GiveCard(int playerId) {
            return base.Channel.GiveCard(playerId);
        }
        
        public System.Threading.Tasks.Task<BlackJackClient.ServiceReference1.Card> GiveCardAsync(int playerId) {
            return base.Channel.GiveCardAsync(playerId);
        }
    }
}
