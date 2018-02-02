﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NEXCORE.Service.ServiceManager.ProgramService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProgramService.IProgramService")]
    public interface IProgramService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgramService/DoWork", ReplyAction="http://tempuri.org/IProgramService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IProgramService/DoWork", ReplyAction="http://tempuri.org/IProgramService/DoWorkResponse")]
        System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState);
        
        void EndDoWork(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgramService/GetProgramList", ReplyAction="http://tempuri.org/IProgramService/GetProgramListResponse")]
        System.Collections.Generic.List<NEXCORE.Common.Data.Program> GetProgramList();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IProgramService/GetProgramList", ReplyAction="http://tempuri.org/IProgramService/GetProgramListResponse")]
        System.IAsyncResult BeginGetProgramList(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<NEXCORE.Common.Data.Program> EndGetProgramList(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgramService/GetProgramSelect", ReplyAction="http://tempuri.org/IProgramService/GetProgramSelectResponse")]
        System.Collections.Generic.List<NEXCORE.Common.Data.Program> GetProgramSelect(string pgmId);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IProgramService/GetProgramSelect", ReplyAction="http://tempuri.org/IProgramService/GetProgramSelectResponse")]
        System.IAsyncResult BeginGetProgramSelect(string pgmId, System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<NEXCORE.Common.Data.Program> EndGetProgramSelect(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgramService/GetProgram", ReplyAction="http://tempuri.org/IProgramService/GetProgramResponse")]
        NEXCORE.Common.Data.Program GetProgram(string pgmId);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IProgramService/GetProgram", ReplyAction="http://tempuri.org/IProgramService/GetProgramResponse")]
        System.IAsyncResult BeginGetProgram(string pgmId, System.AsyncCallback callback, object asyncState);
        
        NEXCORE.Common.Data.Program EndGetProgram(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgramService/GetProgramListWhereQuery", ReplyAction="http://tempuri.org/IProgramService/GetProgramListWhereQueryResponse")]
        System.Collections.Generic.List<NEXCORE.Common.Data.Program> GetProgramListWhereQuery(string pgmType, string pgmId, string pgmPath);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IProgramService/GetProgramListWhereQuery", ReplyAction="http://tempuri.org/IProgramService/GetProgramListWhereQueryResponse")]
        System.IAsyncResult BeginGetProgramListWhereQuery(string pgmType, string pgmId, string pgmPath, System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<NEXCORE.Common.Data.Program> EndGetProgramListWhereQuery(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgramService/Reload", ReplyAction="http://tempuri.org/IProgramService/ReloadResponse")]
        void Reload();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IProgramService/Reload", ReplyAction="http://tempuri.org/IProgramService/ReloadResponse")]
        System.IAsyncResult BeginReload(System.AsyncCallback callback, object asyncState);
        
        void EndReload(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgramService/AddProgram", ReplyAction="http://tempuri.org/IProgramService/AddProgramResponse")]
        void AddProgram(NEXCORE.Common.Data.Program menu);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IProgramService/AddProgram", ReplyAction="http://tempuri.org/IProgramService/AddProgramResponse")]
        System.IAsyncResult BeginAddProgram(NEXCORE.Common.Data.Program menu, System.AsyncCallback callback, object asyncState);
        
        void EndAddProgram(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgramService/DeleteProgram", ReplyAction="http://tempuri.org/IProgramService/DeleteProgramResponse")]
        void DeleteProgram(NEXCORE.Common.Data.Program menu);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IProgramService/DeleteProgram", ReplyAction="http://tempuri.org/IProgramService/DeleteProgramResponse")]
        System.IAsyncResult BeginDeleteProgram(NEXCORE.Common.Data.Program menu, System.AsyncCallback callback, object asyncState);
        
        void EndDeleteProgram(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgramService/UpdateProgram", ReplyAction="http://tempuri.org/IProgramService/UpdateProgramResponse")]
        void UpdateProgram(NEXCORE.Common.Data.Program menu);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IProgramService/UpdateProgram", ReplyAction="http://tempuri.org/IProgramService/UpdateProgramResponse")]
        System.IAsyncResult BeginUpdateProgram(NEXCORE.Common.Data.Program menu, System.AsyncCallback callback, object asyncState);
        
        void EndUpdateProgram(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProgramServiceChannel : NEXCORE.Service.ServiceManager.ProgramService.IProgramService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetProgramListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetProgramListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<NEXCORE.Common.Data.Program> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<NEXCORE.Common.Data.Program>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetProgramSelectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetProgramSelectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<NEXCORE.Common.Data.Program> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<NEXCORE.Common.Data.Program>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetProgramCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetProgramCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public NEXCORE.Common.Data.Program Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((NEXCORE.Common.Data.Program)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetProgramListWhereQueryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetProgramListWhereQueryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<NEXCORE.Common.Data.Program> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<NEXCORE.Common.Data.Program>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProgramServiceClient : System.ServiceModel.ClientBase<NEXCORE.Service.ServiceManager.ProgramService.IProgramService>, NEXCORE.Service.ServiceManager.ProgramService.IProgramService {
        
        private BeginOperationDelegate onBeginDoWorkDelegate;
        
        private EndOperationDelegate onEndDoWorkDelegate;
        
        private System.Threading.SendOrPostCallback onDoWorkCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetProgramListDelegate;
        
        private EndOperationDelegate onEndGetProgramListDelegate;
        
        private System.Threading.SendOrPostCallback onGetProgramListCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetProgramSelectDelegate;
        
        private EndOperationDelegate onEndGetProgramSelectDelegate;
        
        private System.Threading.SendOrPostCallback onGetProgramSelectCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetProgramDelegate;
        
        private EndOperationDelegate onEndGetProgramDelegate;
        
        private System.Threading.SendOrPostCallback onGetProgramCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetProgramListWhereQueryDelegate;
        
        private EndOperationDelegate onEndGetProgramListWhereQueryDelegate;
        
        private System.Threading.SendOrPostCallback onGetProgramListWhereQueryCompletedDelegate;
        
        private BeginOperationDelegate onBeginReloadDelegate;
        
        private EndOperationDelegate onEndReloadDelegate;
        
        private System.Threading.SendOrPostCallback onReloadCompletedDelegate;
        
        private BeginOperationDelegate onBeginAddProgramDelegate;
        
        private EndOperationDelegate onEndAddProgramDelegate;
        
        private System.Threading.SendOrPostCallback onAddProgramCompletedDelegate;
        
        private BeginOperationDelegate onBeginDeleteProgramDelegate;
        
        private EndOperationDelegate onEndDeleteProgramDelegate;
        
        private System.Threading.SendOrPostCallback onDeleteProgramCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdateProgramDelegate;
        
        private EndOperationDelegate onEndUpdateProgramDelegate;
        
        private System.Threading.SendOrPostCallback onUpdateProgramCompletedDelegate;
        
        public ProgramServiceClient() {
        }
        
        public ProgramServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProgramServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProgramServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProgramServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> DoWorkCompleted;
        
        public event System.EventHandler<GetProgramListCompletedEventArgs> GetProgramListCompleted;
        
        public event System.EventHandler<GetProgramSelectCompletedEventArgs> GetProgramSelectCompleted;
        
        public event System.EventHandler<GetProgramCompletedEventArgs> GetProgramCompleted;
        
        public event System.EventHandler<GetProgramListWhereQueryCompletedEventArgs> GetProgramListWhereQueryCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> ReloadCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> AddProgramCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> DeleteProgramCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> UpdateProgramCompleted;
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDoWork(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndDoWork(System.IAsyncResult result) {
            base.Channel.EndDoWork(result);
        }
        
        private System.IAsyncResult OnBeginDoWork(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginDoWork(callback, asyncState);
        }
        
        private object[] OnEndDoWork(System.IAsyncResult result) {
            this.EndDoWork(result);
            return null;
        }
        
        private void OnDoWorkCompleted(object state) {
            if ((this.DoWorkCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DoWorkCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DoWorkAsync() {
            this.DoWorkAsync(null);
        }
        
        public void DoWorkAsync(object userState) {
            if ((this.onBeginDoWorkDelegate == null)) {
                this.onBeginDoWorkDelegate = new BeginOperationDelegate(this.OnBeginDoWork);
            }
            if ((this.onEndDoWorkDelegate == null)) {
                this.onEndDoWorkDelegate = new EndOperationDelegate(this.OnEndDoWork);
            }
            if ((this.onDoWorkCompletedDelegate == null)) {
                this.onDoWorkCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDoWorkCompleted);
            }
            base.InvokeAsync(this.onBeginDoWorkDelegate, null, this.onEndDoWorkDelegate, this.onDoWorkCompletedDelegate, userState);
        }
        
        public System.Collections.Generic.List<NEXCORE.Common.Data.Program> GetProgramList() {
            return base.Channel.GetProgramList();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetProgramList(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetProgramList(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.Generic.List<NEXCORE.Common.Data.Program> EndGetProgramList(System.IAsyncResult result) {
            return base.Channel.EndGetProgramList(result);
        }
        
        private System.IAsyncResult OnBeginGetProgramList(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetProgramList(callback, asyncState);
        }
        
        private object[] OnEndGetProgramList(System.IAsyncResult result) {
            System.Collections.Generic.List<NEXCORE.Common.Data.Program> retVal = this.EndGetProgramList(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetProgramListCompleted(object state) {
            if ((this.GetProgramListCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetProgramListCompleted(this, new GetProgramListCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetProgramListAsync() {
            this.GetProgramListAsync(null);
        }
        
        public void GetProgramListAsync(object userState) {
            if ((this.onBeginGetProgramListDelegate == null)) {
                this.onBeginGetProgramListDelegate = new BeginOperationDelegate(this.OnBeginGetProgramList);
            }
            if ((this.onEndGetProgramListDelegate == null)) {
                this.onEndGetProgramListDelegate = new EndOperationDelegate(this.OnEndGetProgramList);
            }
            if ((this.onGetProgramListCompletedDelegate == null)) {
                this.onGetProgramListCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetProgramListCompleted);
            }
            base.InvokeAsync(this.onBeginGetProgramListDelegate, null, this.onEndGetProgramListDelegate, this.onGetProgramListCompletedDelegate, userState);
        }
        
        public System.Collections.Generic.List<NEXCORE.Common.Data.Program> GetProgramSelect(string pgmId) {
            return base.Channel.GetProgramSelect(pgmId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetProgramSelect(string pgmId, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetProgramSelect(pgmId, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.Generic.List<NEXCORE.Common.Data.Program> EndGetProgramSelect(System.IAsyncResult result) {
            return base.Channel.EndGetProgramSelect(result);
        }
        
        private System.IAsyncResult OnBeginGetProgramSelect(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string pgmId = ((string)(inValues[0]));
            return this.BeginGetProgramSelect(pgmId, callback, asyncState);
        }
        
        private object[] OnEndGetProgramSelect(System.IAsyncResult result) {
            System.Collections.Generic.List<NEXCORE.Common.Data.Program> retVal = this.EndGetProgramSelect(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetProgramSelectCompleted(object state) {
            if ((this.GetProgramSelectCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetProgramSelectCompleted(this, new GetProgramSelectCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetProgramSelectAsync(string pgmId) {
            this.GetProgramSelectAsync(pgmId, null);
        }
        
        public void GetProgramSelectAsync(string pgmId, object userState) {
            if ((this.onBeginGetProgramSelectDelegate == null)) {
                this.onBeginGetProgramSelectDelegate = new BeginOperationDelegate(this.OnBeginGetProgramSelect);
            }
            if ((this.onEndGetProgramSelectDelegate == null)) {
                this.onEndGetProgramSelectDelegate = new EndOperationDelegate(this.OnEndGetProgramSelect);
            }
            if ((this.onGetProgramSelectCompletedDelegate == null)) {
                this.onGetProgramSelectCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetProgramSelectCompleted);
            }
            base.InvokeAsync(this.onBeginGetProgramSelectDelegate, new object[] {
                        pgmId}, this.onEndGetProgramSelectDelegate, this.onGetProgramSelectCompletedDelegate, userState);
        }
        
        public NEXCORE.Common.Data.Program GetProgram(string pgmId) {
            return base.Channel.GetProgram(pgmId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetProgram(string pgmId, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetProgram(pgmId, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public NEXCORE.Common.Data.Program EndGetProgram(System.IAsyncResult result) {
            return base.Channel.EndGetProgram(result);
        }
        
        private System.IAsyncResult OnBeginGetProgram(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string pgmId = ((string)(inValues[0]));
            return this.BeginGetProgram(pgmId, callback, asyncState);
        }
        
        private object[] OnEndGetProgram(System.IAsyncResult result) {
            NEXCORE.Common.Data.Program retVal = this.EndGetProgram(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetProgramCompleted(object state) {
            if ((this.GetProgramCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetProgramCompleted(this, new GetProgramCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetProgramAsync(string pgmId) {
            this.GetProgramAsync(pgmId, null);
        }
        
        public void GetProgramAsync(string pgmId, object userState) {
            if ((this.onBeginGetProgramDelegate == null)) {
                this.onBeginGetProgramDelegate = new BeginOperationDelegate(this.OnBeginGetProgram);
            }
            if ((this.onEndGetProgramDelegate == null)) {
                this.onEndGetProgramDelegate = new EndOperationDelegate(this.OnEndGetProgram);
            }
            if ((this.onGetProgramCompletedDelegate == null)) {
                this.onGetProgramCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetProgramCompleted);
            }
            base.InvokeAsync(this.onBeginGetProgramDelegate, new object[] {
                        pgmId}, this.onEndGetProgramDelegate, this.onGetProgramCompletedDelegate, userState);
        }
        
        public System.Collections.Generic.List<NEXCORE.Common.Data.Program> GetProgramListWhereQuery(string pgmType, string pgmId, string pgmPath) {
            return base.Channel.GetProgramListWhereQuery(pgmType, pgmId, pgmPath);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetProgramListWhereQuery(string pgmType, string pgmId, string pgmPath, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetProgramListWhereQuery(pgmType, pgmId, pgmPath, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.Generic.List<NEXCORE.Common.Data.Program> EndGetProgramListWhereQuery(System.IAsyncResult result) {
            return base.Channel.EndGetProgramListWhereQuery(result);
        }
        
        private System.IAsyncResult OnBeginGetProgramListWhereQuery(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string pgmType = ((string)(inValues[0]));
            string pgmId = ((string)(inValues[1]));
            string pgmPath = ((string)(inValues[2]));
            return this.BeginGetProgramListWhereQuery(pgmType, pgmId, pgmPath, callback, asyncState);
        }
        
        private object[] OnEndGetProgramListWhereQuery(System.IAsyncResult result) {
            System.Collections.Generic.List<NEXCORE.Common.Data.Program> retVal = this.EndGetProgramListWhereQuery(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetProgramListWhereQueryCompleted(object state) {
            if ((this.GetProgramListWhereQueryCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetProgramListWhereQueryCompleted(this, new GetProgramListWhereQueryCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetProgramListWhereQueryAsync(string pgmType, string pgmId, string pgmPath) {
            this.GetProgramListWhereQueryAsync(pgmType, pgmId, pgmPath, null);
        }
        
        public void GetProgramListWhereQueryAsync(string pgmType, string pgmId, string pgmPath, object userState) {
            if ((this.onBeginGetProgramListWhereQueryDelegate == null)) {
                this.onBeginGetProgramListWhereQueryDelegate = new BeginOperationDelegate(this.OnBeginGetProgramListWhereQuery);
            }
            if ((this.onEndGetProgramListWhereQueryDelegate == null)) {
                this.onEndGetProgramListWhereQueryDelegate = new EndOperationDelegate(this.OnEndGetProgramListWhereQuery);
            }
            if ((this.onGetProgramListWhereQueryCompletedDelegate == null)) {
                this.onGetProgramListWhereQueryCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetProgramListWhereQueryCompleted);
            }
            base.InvokeAsync(this.onBeginGetProgramListWhereQueryDelegate, new object[] {
                        pgmType,
                        pgmId,
                        pgmPath}, this.onEndGetProgramListWhereQueryDelegate, this.onGetProgramListWhereQueryCompletedDelegate, userState);
        }
        
        public void Reload() {
            base.Channel.Reload();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginReload(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginReload(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndReload(System.IAsyncResult result) {
            base.Channel.EndReload(result);
        }
        
        private System.IAsyncResult OnBeginReload(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginReload(callback, asyncState);
        }
        
        private object[] OnEndReload(System.IAsyncResult result) {
            this.EndReload(result);
            return null;
        }
        
        private void OnReloadCompleted(object state) {
            if ((this.ReloadCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ReloadCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ReloadAsync() {
            this.ReloadAsync(null);
        }
        
        public void ReloadAsync(object userState) {
            if ((this.onBeginReloadDelegate == null)) {
                this.onBeginReloadDelegate = new BeginOperationDelegate(this.OnBeginReload);
            }
            if ((this.onEndReloadDelegate == null)) {
                this.onEndReloadDelegate = new EndOperationDelegate(this.OnEndReload);
            }
            if ((this.onReloadCompletedDelegate == null)) {
                this.onReloadCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnReloadCompleted);
            }
            base.InvokeAsync(this.onBeginReloadDelegate, null, this.onEndReloadDelegate, this.onReloadCompletedDelegate, userState);
        }
        
        public void AddProgram(NEXCORE.Common.Data.Program menu) {
            base.Channel.AddProgram(menu);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginAddProgram(NEXCORE.Common.Data.Program menu, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAddProgram(menu, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndAddProgram(System.IAsyncResult result) {
            base.Channel.EndAddProgram(result);
        }
        
        private System.IAsyncResult OnBeginAddProgram(object[] inValues, System.AsyncCallback callback, object asyncState) {
            NEXCORE.Common.Data.Program menu = ((NEXCORE.Common.Data.Program)(inValues[0]));
            return this.BeginAddProgram(menu, callback, asyncState);
        }
        
        private object[] OnEndAddProgram(System.IAsyncResult result) {
            this.EndAddProgram(result);
            return null;
        }
        
        private void OnAddProgramCompleted(object state) {
            if ((this.AddProgramCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AddProgramCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AddProgramAsync(NEXCORE.Common.Data.Program menu) {
            this.AddProgramAsync(menu, null);
        }
        
        public void AddProgramAsync(NEXCORE.Common.Data.Program menu, object userState) {
            if ((this.onBeginAddProgramDelegate == null)) {
                this.onBeginAddProgramDelegate = new BeginOperationDelegate(this.OnBeginAddProgram);
            }
            if ((this.onEndAddProgramDelegate == null)) {
                this.onEndAddProgramDelegate = new EndOperationDelegate(this.OnEndAddProgram);
            }
            if ((this.onAddProgramCompletedDelegate == null)) {
                this.onAddProgramCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAddProgramCompleted);
            }
            base.InvokeAsync(this.onBeginAddProgramDelegate, new object[] {
                        menu}, this.onEndAddProgramDelegate, this.onAddProgramCompletedDelegate, userState);
        }
        
        public void DeleteProgram(NEXCORE.Common.Data.Program menu) {
            base.Channel.DeleteProgram(menu);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDeleteProgram(NEXCORE.Common.Data.Program menu, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDeleteProgram(menu, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndDeleteProgram(System.IAsyncResult result) {
            base.Channel.EndDeleteProgram(result);
        }
        
        private System.IAsyncResult OnBeginDeleteProgram(object[] inValues, System.AsyncCallback callback, object asyncState) {
            NEXCORE.Common.Data.Program menu = ((NEXCORE.Common.Data.Program)(inValues[0]));
            return this.BeginDeleteProgram(menu, callback, asyncState);
        }
        
        private object[] OnEndDeleteProgram(System.IAsyncResult result) {
            this.EndDeleteProgram(result);
            return null;
        }
        
        private void OnDeleteProgramCompleted(object state) {
            if ((this.DeleteProgramCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DeleteProgramCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DeleteProgramAsync(NEXCORE.Common.Data.Program menu) {
            this.DeleteProgramAsync(menu, null);
        }
        
        public void DeleteProgramAsync(NEXCORE.Common.Data.Program menu, object userState) {
            if ((this.onBeginDeleteProgramDelegate == null)) {
                this.onBeginDeleteProgramDelegate = new BeginOperationDelegate(this.OnBeginDeleteProgram);
            }
            if ((this.onEndDeleteProgramDelegate == null)) {
                this.onEndDeleteProgramDelegate = new EndOperationDelegate(this.OnEndDeleteProgram);
            }
            if ((this.onDeleteProgramCompletedDelegate == null)) {
                this.onDeleteProgramCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDeleteProgramCompleted);
            }
            base.InvokeAsync(this.onBeginDeleteProgramDelegate, new object[] {
                        menu}, this.onEndDeleteProgramDelegate, this.onDeleteProgramCompletedDelegate, userState);
        }
        
        public void UpdateProgram(NEXCORE.Common.Data.Program menu) {
            base.Channel.UpdateProgram(menu);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginUpdateProgram(NEXCORE.Common.Data.Program menu, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdateProgram(menu, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndUpdateProgram(System.IAsyncResult result) {
            base.Channel.EndUpdateProgram(result);
        }
        
        private System.IAsyncResult OnBeginUpdateProgram(object[] inValues, System.AsyncCallback callback, object asyncState) {
            NEXCORE.Common.Data.Program menu = ((NEXCORE.Common.Data.Program)(inValues[0]));
            return this.BeginUpdateProgram(menu, callback, asyncState);
        }
        
        private object[] OnEndUpdateProgram(System.IAsyncResult result) {
            this.EndUpdateProgram(result);
            return null;
        }
        
        private void OnUpdateProgramCompleted(object state) {
            if ((this.UpdateProgramCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdateProgramCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdateProgramAsync(NEXCORE.Common.Data.Program menu) {
            this.UpdateProgramAsync(menu, null);
        }
        
        public void UpdateProgramAsync(NEXCORE.Common.Data.Program menu, object userState) {
            if ((this.onBeginUpdateProgramDelegate == null)) {
                this.onBeginUpdateProgramDelegate = new BeginOperationDelegate(this.OnBeginUpdateProgram);
            }
            if ((this.onEndUpdateProgramDelegate == null)) {
                this.onEndUpdateProgramDelegate = new EndOperationDelegate(this.OnEndUpdateProgram);
            }
            if ((this.onUpdateProgramCompletedDelegate == null)) {
                this.onUpdateProgramCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateProgramCompleted);
            }
            base.InvokeAsync(this.onBeginUpdateProgramDelegate, new object[] {
                        menu}, this.onEndUpdateProgramDelegate, this.onUpdateProgramCompletedDelegate, userState);
        }
    }
}
