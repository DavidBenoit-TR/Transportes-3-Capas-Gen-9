﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente_Transportes_Gen_9.WS_Camiones {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Camiones_VO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Camiones_VO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdcamionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MatriculaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoCamionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MarcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModeloField;
        
        private int CapacidadField;
        
        private double KilometrajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UrlFotoField;
        
        private bool DisponibilidadField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Idcamion {
            get {
                return this.IdcamionField;
            }
            set {
                if ((this.IdcamionField.Equals(value) != true)) {
                    this.IdcamionField = value;
                    this.RaisePropertyChanged("Idcamion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Matricula {
            get {
                return this.MatriculaField;
            }
            set {
                if ((object.ReferenceEquals(this.MatriculaField, value) != true)) {
                    this.MatriculaField = value;
                    this.RaisePropertyChanged("Matricula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string TipoCamion {
            get {
                return this.TipoCamionField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoCamionField, value) != true)) {
                    this.TipoCamionField = value;
                    this.RaisePropertyChanged("TipoCamion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Modelo {
            get {
                return this.ModeloField;
            }
            set {
                if ((object.ReferenceEquals(this.ModeloField, value) != true)) {
                    this.ModeloField = value;
                    this.RaisePropertyChanged("Modelo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int Capacidad {
            get {
                return this.CapacidadField;
            }
            set {
                if ((this.CapacidadField.Equals(value) != true)) {
                    this.CapacidadField = value;
                    this.RaisePropertyChanged("Capacidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public double Kilometraje {
            get {
                return this.KilometrajeField;
            }
            set {
                if ((this.KilometrajeField.Equals(value) != true)) {
                    this.KilometrajeField = value;
                    this.RaisePropertyChanged("Kilometraje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string UrlFoto {
            get {
                return this.UrlFotoField;
            }
            set {
                if ((object.ReferenceEquals(this.UrlFotoField, value) != true)) {
                    this.UrlFotoField = value;
                    this.RaisePropertyChanged("UrlFoto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public bool Disponibilidad {
            get {
                return this.DisponibilidadField;
            }
            set {
                if ((this.DisponibilidadField.Equals(value) != true)) {
                    this.DisponibilidadField = value;
                    this.RaisePropertyChanged("Disponibilidad");
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
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfAnyType", Namespace="http://tempuri.org/", ItemName="anyType")]
    [System.SerializableAttribute()]
    public class ArrayOfAnyType : System.Collections.Generic.List<object> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WS_Camiones.WS_CamionesSoap")]
    public interface WS_CamionesSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento camion del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_Camion", ReplyAction="*")]
        Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionResponse insertar_Camion(Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar_Camion", ReplyAction="*")]
        System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionResponse> insertar_CamionAsync(Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento parametros del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/get_Camiones", ReplyAction="*")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Cliente_Transportes_Gen_9.WS_Camiones.ArrayOfAnyType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO[]))]
        Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesResponse get_Camiones(Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/get_Camiones", ReplyAction="*")]
        System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesResponse> get_CamionesAsync(Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento camion del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_Camion", ReplyAction="*")]
        Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionResponse actualizar_Camion(Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar_Camion", ReplyAction="*")]
        System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionResponse> actualizar_CamionAsync(Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento eliminar_CamionResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_Camion", ReplyAction="*")]
        Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionResponse eliminar_Camion(Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar_Camion", ReplyAction="*")]
        System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionResponse> eliminar_CamionAsync(Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento get_Camion_by_IDResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/get_Camion_by_ID", ReplyAction="*")]
        Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDResponse get_Camion_by_ID(Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/get_Camion_by_ID", ReplyAction="*")]
        System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDResponse> get_Camion_by_IDAsync(Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertar_CamionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertar_Camion", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionRequestBody Body;
        
        public insertar_CamionRequest() {
        }
        
        public insertar_CamionRequest(Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insertar_CamionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO camion;
        
        public insertar_CamionRequestBody() {
        }
        
        public insertar_CamionRequestBody(Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO camion) {
            this.camion = camion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insertar_CamionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insertar_CamionResponse", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionResponseBody Body;
        
        public insertar_CamionResponse() {
        }
        
        public insertar_CamionResponse(Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insertar_CamionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string insertar_CamionResult;
        
        public insertar_CamionResponseBody() {
        }
        
        public insertar_CamionResponseBody(string insertar_CamionResult) {
            this.insertar_CamionResult = insertar_CamionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class get_CamionesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="get_Camiones", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesRequestBody Body;
        
        public get_CamionesRequest() {
        }
        
        public get_CamionesRequest(Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class get_CamionesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.ArrayOfAnyType parametros;
        
        public get_CamionesRequestBody() {
        }
        
        public get_CamionesRequestBody(Cliente_Transportes_Gen_9.WS_Camiones.ArrayOfAnyType parametros) {
            this.parametros = parametros;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class get_CamionesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="get_CamionesResponse", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesResponseBody Body;
        
        public get_CamionesResponse() {
        }
        
        public get_CamionesResponse(Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class get_CamionesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO[] get_CamionesResult;
        
        public get_CamionesResponseBody() {
        }
        
        public get_CamionesResponseBody(Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO[] get_CamionesResult) {
            this.get_CamionesResult = get_CamionesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class actualizar_CamionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="actualizar_Camion", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionRequestBody Body;
        
        public actualizar_CamionRequest() {
        }
        
        public actualizar_CamionRequest(Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class actualizar_CamionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO camion;
        
        public actualizar_CamionRequestBody() {
        }
        
        public actualizar_CamionRequestBody(Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO camion) {
            this.camion = camion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class actualizar_CamionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="actualizar_CamionResponse", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionResponseBody Body;
        
        public actualizar_CamionResponse() {
        }
        
        public actualizar_CamionResponse(Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class actualizar_CamionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string actualizar_CamionResult;
        
        public actualizar_CamionResponseBody() {
        }
        
        public actualizar_CamionResponseBody(string actualizar_CamionResult) {
            this.actualizar_CamionResult = actualizar_CamionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class eliminar_CamionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="eliminar_Camion", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionRequestBody Body;
        
        public eliminar_CamionRequest() {
        }
        
        public eliminar_CamionRequest(Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class eliminar_CamionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public eliminar_CamionRequestBody() {
        }
        
        public eliminar_CamionRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class eliminar_CamionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="eliminar_CamionResponse", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionResponseBody Body;
        
        public eliminar_CamionResponse() {
        }
        
        public eliminar_CamionResponse(Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class eliminar_CamionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string eliminar_CamionResult;
        
        public eliminar_CamionResponseBody() {
        }
        
        public eliminar_CamionResponseBody(string eliminar_CamionResult) {
            this.eliminar_CamionResult = eliminar_CamionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class get_Camion_by_IDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="get_Camion_by_ID", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDRequestBody Body;
        
        public get_Camion_by_IDRequest() {
        }
        
        public get_Camion_by_IDRequest(Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class get_Camion_by_IDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public get_Camion_by_IDRequestBody() {
        }
        
        public get_Camion_by_IDRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class get_Camion_by_IDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="get_Camion_by_IDResponse", Namespace="http://tempuri.org/", Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDResponseBody Body;
        
        public get_Camion_by_IDResponse() {
        }
        
        public get_Camion_by_IDResponse(Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class get_Camion_by_IDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO get_Camion_by_IDResult;
        
        public get_Camion_by_IDResponseBody() {
        }
        
        public get_Camion_by_IDResponseBody(Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO get_Camion_by_IDResult) {
            this.get_Camion_by_IDResult = get_Camion_by_IDResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WS_CamionesSoapChannel : Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WS_CamionesSoapClient : System.ServiceModel.ClientBase<Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap>, Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap {
        
        public WS_CamionesSoapClient() {
        }
        
        public WS_CamionesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WS_CamionesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_CamionesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_CamionesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionResponse Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap.insertar_Camion(Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionRequest request) {
            return base.Channel.insertar_Camion(request);
        }
        
        public string insertar_Camion(Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO camion) {
            Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionRequest inValue = new Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionRequest();
            inValue.Body = new Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionRequestBody();
            inValue.Body.camion = camion;
            Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionResponse retVal = ((Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap)(this)).insertar_Camion(inValue);
            return retVal.Body.insertar_CamionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionResponse> Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap.insertar_CamionAsync(Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionRequest request) {
            return base.Channel.insertar_CamionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionResponse> insertar_CamionAsync(Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO camion) {
            Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionRequest inValue = new Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionRequest();
            inValue.Body = new Cliente_Transportes_Gen_9.WS_Camiones.insertar_CamionRequestBody();
            inValue.Body.camion = camion;
            return ((Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap)(this)).insertar_CamionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesResponse Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap.get_Camiones(Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesRequest request) {
            return base.Channel.get_Camiones(request);
        }
        
        public Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO[] get_Camiones(Cliente_Transportes_Gen_9.WS_Camiones.ArrayOfAnyType parametros) {
            Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesRequest inValue = new Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesRequest();
            inValue.Body = new Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesRequestBody();
            inValue.Body.parametros = parametros;
            Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesResponse retVal = ((Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap)(this)).get_Camiones(inValue);
            return retVal.Body.get_CamionesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesResponse> Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap.get_CamionesAsync(Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesRequest request) {
            return base.Channel.get_CamionesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesResponse> get_CamionesAsync(Cliente_Transportes_Gen_9.WS_Camiones.ArrayOfAnyType parametros) {
            Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesRequest inValue = new Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesRequest();
            inValue.Body = new Cliente_Transportes_Gen_9.WS_Camiones.get_CamionesRequestBody();
            inValue.Body.parametros = parametros;
            return ((Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap)(this)).get_CamionesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionResponse Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap.actualizar_Camion(Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionRequest request) {
            return base.Channel.actualizar_Camion(request);
        }
        
        public string actualizar_Camion(Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO camion) {
            Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionRequest inValue = new Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionRequest();
            inValue.Body = new Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionRequestBody();
            inValue.Body.camion = camion;
            Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionResponse retVal = ((Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap)(this)).actualizar_Camion(inValue);
            return retVal.Body.actualizar_CamionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionResponse> Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap.actualizar_CamionAsync(Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionRequest request) {
            return base.Channel.actualizar_CamionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionResponse> actualizar_CamionAsync(Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO camion) {
            Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionRequest inValue = new Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionRequest();
            inValue.Body = new Cliente_Transportes_Gen_9.WS_Camiones.actualizar_CamionRequestBody();
            inValue.Body.camion = camion;
            return ((Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap)(this)).actualizar_CamionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionResponse Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap.eliminar_Camion(Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionRequest request) {
            return base.Channel.eliminar_Camion(request);
        }
        
        public string eliminar_Camion(int id) {
            Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionRequest inValue = new Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionRequest();
            inValue.Body = new Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionRequestBody();
            inValue.Body.id = id;
            Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionResponse retVal = ((Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap)(this)).eliminar_Camion(inValue);
            return retVal.Body.eliminar_CamionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionResponse> Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap.eliminar_CamionAsync(Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionRequest request) {
            return base.Channel.eliminar_CamionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionResponse> eliminar_CamionAsync(int id) {
            Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionRequest inValue = new Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionRequest();
            inValue.Body = new Cliente_Transportes_Gen_9.WS_Camiones.eliminar_CamionRequestBody();
            inValue.Body.id = id;
            return ((Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap)(this)).eliminar_CamionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDResponse Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap.get_Camion_by_ID(Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDRequest request) {
            return base.Channel.get_Camion_by_ID(request);
        }
        
        public Cliente_Transportes_Gen_9.WS_Camiones.Camiones_VO get_Camion_by_ID(int id) {
            Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDRequest inValue = new Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDRequest();
            inValue.Body = new Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDRequestBody();
            inValue.Body.id = id;
            Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDResponse retVal = ((Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap)(this)).get_Camion_by_ID(inValue);
            return retVal.Body.get_Camion_by_IDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDResponse> Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap.get_Camion_by_IDAsync(Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDRequest request) {
            return base.Channel.get_Camion_by_IDAsync(request);
        }
        
        public System.Threading.Tasks.Task<Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDResponse> get_Camion_by_IDAsync(int id) {
            Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDRequest inValue = new Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDRequest();
            inValue.Body = new Cliente_Transportes_Gen_9.WS_Camiones.get_Camion_by_IDRequestBody();
            inValue.Body.id = id;
            return ((Cliente_Transportes_Gen_9.WS_Camiones.WS_CamionesSoap)(this)).get_Camion_by_IDAsync(inValue);
        }
    }
}
