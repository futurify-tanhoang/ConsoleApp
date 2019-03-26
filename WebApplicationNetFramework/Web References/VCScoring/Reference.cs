﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebApplicationNetFramework.VCScoring {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EventSoapBinding", Namespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1/wsdl/")]
    public partial class EventService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback EventOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public EventService() {
            this.Url = global::WebApplicationNetFramework.Properties.Settings.Default.WebApplicationNetFramework_VCScoring_EventService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event EventCompletedEventHandler EventCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1", ResponseNamespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Header")]
        public HeaderResponseType Event(HeaderType Header, [System.Xml.Serialization.XmlArrayItemAttribute("Data", IsNullable=false)] DataItemType[] Body, [System.Xml.Serialization.XmlAttributeAttribute()] ref string name, [System.Xml.Serialization.XmlArrayAttribute("Body")] [System.Xml.Serialization.XmlArrayItemAttribute("Data", IsNullable=false)] out DataItemResponseType[] Body1) {
            object[] results = this.Invoke("Event", new object[] {
                        Header,
                        Body,
                        name});
            name = ((string)(results[1]));
            Body1 = ((DataItemResponseType[])(results[2]));
            return ((HeaderResponseType)(results[0]));
        }
        
        /// <remarks/>
        public void EventAsync(HeaderType Header, DataItemType[] Body, string name) {
            this.EventAsync(Header, Body, name, null);
        }
        
        /// <remarks/>
        public void EventAsync(HeaderType Header, DataItemType[] Body, string name, object userState) {
            if ((this.EventOperationCompleted == null)) {
                this.EventOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEventOperationCompleted);
            }
            this.InvokeAsync("Event", new object[] {
                        Header,
                        Body,
                        name}, this.EventOperationCompleted, userState);
        }
        
        private void OnEventOperationCompleted(object arg) {
            if ((this.EventCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EventCompleted(this, new EventCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1")]
    public partial class HeaderType {
        
        private string identityField;
        
        private string clientTimeZoneIDField;
        
        /// <remarks/>
        public string Identity {
            get {
                return this.identityField;
            }
            set {
                this.identityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ClientTimeZoneID {
            get {
                return this.clientTimeZoneIDField;
            }
            set {
                this.clientTimeZoneIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1")]
    public partial class DataItemResponseType {
        
        private object itemField;
        
        private DataItemResponseTypeName nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Float", typeof(Float))]
        [System.Xml.Serialization.XmlElementAttribute("Int", typeof(Int))]
        [System.Xml.Serialization.XmlElementAttribute("String", typeof(String))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DataItemResponseTypeName name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1")]
    public partial class Float {
        
        private double valField;
        
        private bool valFieldSpecified;
        
        /// <remarks/>
        public double Val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValSpecified {
            get {
                return this.valFieldSpecified;
            }
            set {
                this.valFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1")]
    public partial class Int {
        
        private long valField;
        
        private bool valFieldSpecified;
        
        /// <remarks/>
        public long Val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValSpecified {
            get {
                return this.valFieldSpecified;
            }
            set {
                this.valFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1")]
    public partial class String {
        
        private string valField;
        
        /// <remarks/>
        public string Val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1")]
    public enum DataItemResponseTypeName {
        
        /// <remarks/>
        Application_Number,
        
        /// <remarks/>
        Score,
        
        /// <remarks/>
        Score_Category,
        
        /// <remarks/>
        Results,
        
        /// <remarks/>
        Scheme_Code,
        
        /// <remarks/>
        Score_Credit_Limit,
        
        /// <remarks/>
        STATUSCODE,
        
        /// <remarks/>
        STATUSDESC,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1")]
    public partial class HeaderResponseType {
        
        private string correlationIdField;
        
        private string startTimeField;
        
        private string completionTimeField;
        
        /// <remarks/>
        public string CorrelationId {
            get {
                return this.correlationIdField;
            }
            set {
                this.correlationIdField = value;
            }
        }
        
        /// <remarks/>
        public string StartTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }
        
        /// <remarks/>
        public string CompletionTime {
            get {
                return this.completionTimeField;
            }
            set {
                this.completionTimeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1")]
    public partial class DataItemType {
        
        private object itemField;
        
        private DataItemTypeName nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DateTime", typeof(DateTime))]
        [System.Xml.Serialization.XmlElementAttribute("Float", typeof(Float))]
        [System.Xml.Serialization.XmlElementAttribute("Int", typeof(Int))]
        [System.Xml.Serialization.XmlElementAttribute("String", typeof(String))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DataItemTypeName name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1")]
    public partial class DateTime {
        
        private System.DateTime valField;
        
        private bool valFieldSpecified;
        
        /// <remarks/>
        public System.DateTime Val {
            get {
                return this.valField;
            }
            set {
                this.valField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValSpecified {
            get {
                return this.valFieldSpecified;
            }
            set {
                this.valFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sas.com/xml/schema/sas-svcs/rtdm-1.1")]
    public enum DataItemTypeName {
        
        /// <remarks/>
        Application_Number,
        
        /// <remarks/>
        Request_Limit,
        
        /// <remarks/>
        Application_ID,
        
        /// <remarks/>
        Product,
        
        /// <remarks/>
        Credit_Card_Type,
        
        /// <remarks/>
        Promo_Code,
        
        /// <remarks/>
        Age,
        
        /// <remarks/>
        Resident_Type,
        
        /// <remarks/>
        Marital_Status,
        
        /// <remarks/>
        Address_Type,
        
        /// <remarks/>
        State,
        
        /// <remarks/>
        City,
        
        /// <remarks/>
        Number_of_Dependents,
        
        /// <remarks/>
        Number_of_Children,
        
        /// <remarks/>
        Occupation_Type,
        
        /// <remarks/>
        Industry,
        
        /// <remarks/>
        Nature_of_Business,
        
        /// <remarks/>
        SubIndustry,
        
        /// <remarks/>
        Company_Type,
        
        /// <remarks/>
        Employment_type,
        
        /// <remarks/>
        Employment_Status,
        
        /// <remarks/>
        Employment_From,
        
        /// <remarks/>
        Years_In_Job,
        
        /// <remarks/>
        Employment_Location,
        
        /// <remarks/>
        Gross_Monthly_Income,
        
        /// <remarks/>
        Missing_Information,
        
        /// <remarks/>
        Employer_Status,
        
        /// <remarks/>
        Employer_Establish_Day,
        
        /// <remarks/>
        Annual_Net_Income,
        
        /// <remarks/>
        Annual_Gross_Income,
        
        /// <remarks/>
        Income_From_Other_Sources,
        
        /// <remarks/>
        Card_Limit,
        
        /// <remarks/>
        Card_Expiry,
        
        /// <remarks/>
        PCB_Response_XML,
        
        /// <remarks/>
        Maximum_Worststatus,
        
        /// <remarks/>
        Result,
        
        /// <remarks/>
        No_of_Contract,
        
        /// <remarks/>
        Results_2,
        
        /// <remarks/>
        Amount_of_Unpaid_Due_Installments,
        
        /// <remarks/>
        Overdue_Not_Paid_Amount,
        
        /// <remarks/>
        Total_Current_Overdue_Amount,
        
        /// <remarks/>
        Results_3,
        
        /// <remarks/>
        Number_of_Bank_Relationship,
        
        /// <remarks/>
        No_of_Installment_Loans,
        
        /// <remarks/>
        Total_Outstanding_Balances,
        
        /// <remarks/>
        No_of_Credit_Cards,
        
        /// <remarks/>
        Total_Credit_Limit,
        
        /// <remarks/>
        Total_Oustanding_Balance_1,
        
        /// <remarks/>
        No_Overdraft,
        
        /// <remarks/>
        Total_Credit_Limit_1,
        
        /// <remarks/>
        Total_Monthly_Payment_Excluding_Overdraft,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void EventCompletedEventHandler(object sender, EventCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EventCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EventCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public HeaderResponseType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((HeaderResponseType)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public DataItemResponseType[] Body1 {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DataItemResponseType[])(this.results[2]));
            }
        }
    }
}

#pragma warning restore 1591