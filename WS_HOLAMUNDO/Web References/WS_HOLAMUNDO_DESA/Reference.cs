﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.42.
// 
#pragma warning disable 1591

namespace WS_HOLAMUNDO.WS_HOLAMUNDO_DESA {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_HOLAMUNDOBinding", Namespace="http://xmlns.oracle.com/orawsv/WS_RO/WS_HOLAMUNDO")]
    public partial class WS_HOLAMUNDOService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback WS_HOLAMUNDOOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS_HOLAMUNDOService() {
            this.Url = global::WS_HOLAMUNDO.Properties.Settings.Default.WS_HOLAMUNDO_WS_HOLAMUNDO_WS_HOLAMUNDOService;
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
        public event WS_HOLAMUNDOCompletedEventHandler WS_HOLAMUNDOCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("WS_HOLAMUNDO", RequestElementName="SVARCHAR2-WS_HOLAMUNDOInput", RequestNamespace="http://xmlns.oracle.com/orawsv/WS_RO/WS_HOLAMUNDO", ResponseElementName="WS_HOLAMUNDOOutput", ResponseNamespace="http://xmlns.oracle.com/orawsv/WS_RO/WS_HOLAMUNDO", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("RETURN")]
        public string WS_HOLAMUNDO([System.Xml.Serialization.XmlElementAttribute("INPUT-VARCHAR2-IN")] string INPUTVARCHAR2IN) {
            object[] results = this.Invoke("WS_HOLAMUNDO", new object[] {
                        INPUTVARCHAR2IN});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WS_HOLAMUNDOAsync(string INPUTVARCHAR2IN) {
            this.WS_HOLAMUNDOAsync(INPUTVARCHAR2IN, null);
        }
        
        /// <remarks/>
        public void WS_HOLAMUNDOAsync(string INPUTVARCHAR2IN, object userState) {
            if ((this.WS_HOLAMUNDOOperationCompleted == null)) {
                this.WS_HOLAMUNDOOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWS_HOLAMUNDOOperationCompleted);
            }
            this.InvokeAsync("WS_HOLAMUNDO", new object[] {
                        INPUTVARCHAR2IN}, this.WS_HOLAMUNDOOperationCompleted, userState);
        }
        
        private void OnWS_HOLAMUNDOOperationCompleted(object arg) {
            if ((this.WS_HOLAMUNDOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WS_HOLAMUNDOCompleted(this, new WS_HOLAMUNDOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void WS_HOLAMUNDOCompletedEventHandler(object sender, WS_HOLAMUNDOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WS_HOLAMUNDOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WS_HOLAMUNDOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591