﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Notas.WS_NotasDB {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WS_NotasDB.WS_NotasSoap")]
    public interface WS_NotasSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void AgregarAlumno(string strDocumento, string primerNombre, string segundoNombre, string primerApellido, string SegundoApellido, int idPrograma);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task AgregarAlumnoAsync(string strDocumento, string primerNombre, string segundoNombre, string primerApellido, string SegundoApellido, int idPrograma);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CargarAlumnos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable CargarAlumnos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CargarAlumnos", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> CargarAlumnosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CargarProgramas", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable CargarProgramas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CargarProgramas", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> CargarProgramasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarMateria", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void AgregarMateria(string descripcion, int codigoMateria, int idPrograma);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarMateria", ReplyAction="*")]
        System.Threading.Tasks.Task AgregarMateriaAsync(string descripcion, int codigoMateria, int idPrograma);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CargarMaterias", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable CargarMaterias();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CargarMaterias", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> CargarMateriasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarNotaFinal", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void AgregarNotaFinal(int intAlumno, int codMateria, double notaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarNotaFinal", ReplyAction="*")]
        System.Threading.Tasks.Task AgregarNotaFinalAsync(int intAlumno, int codMateria, double notaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CargarNotasFinales", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable CargarNotasFinales();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CargarNotasFinales", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> CargarNotasFinalesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WS_NotasSoapChannel : Notas.WS_NotasDB.WS_NotasSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WS_NotasSoapClient : System.ServiceModel.ClientBase<Notas.WS_NotasDB.WS_NotasSoap>, Notas.WS_NotasDB.WS_NotasSoap {
        
        public WS_NotasSoapClient() {
        }
        
        public WS_NotasSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WS_NotasSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_NotasSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_NotasSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AgregarAlumno(string strDocumento, string primerNombre, string segundoNombre, string primerApellido, string SegundoApellido, int idPrograma) {
            base.Channel.AgregarAlumno(strDocumento, primerNombre, segundoNombre, primerApellido, SegundoApellido, idPrograma);
        }
        
        public System.Threading.Tasks.Task AgregarAlumnoAsync(string strDocumento, string primerNombre, string segundoNombre, string primerApellido, string SegundoApellido, int idPrograma) {
            return base.Channel.AgregarAlumnoAsync(strDocumento, primerNombre, segundoNombre, primerApellido, SegundoApellido, idPrograma);
        }
        
        public System.Data.DataTable CargarAlumnos() {
            return base.Channel.CargarAlumnos();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> CargarAlumnosAsync() {
            return base.Channel.CargarAlumnosAsync();
        }
        
        public System.Data.DataTable CargarProgramas() {
            return base.Channel.CargarProgramas();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> CargarProgramasAsync() {
            return base.Channel.CargarProgramasAsync();
        }
        
        public void AgregarMateria(string descripcion, int codigoMateria, int idPrograma) {
            base.Channel.AgregarMateria(descripcion, codigoMateria, idPrograma);
        }
        
        public System.Threading.Tasks.Task AgregarMateriaAsync(string descripcion, int codigoMateria, int idPrograma) {
            return base.Channel.AgregarMateriaAsync(descripcion, codigoMateria, idPrograma);
        }
        
        public System.Data.DataTable CargarMaterias() {
            return base.Channel.CargarMaterias();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> CargarMateriasAsync() {
            return base.Channel.CargarMateriasAsync();
        }
        
        public void AgregarNotaFinal(int intAlumno, int codMateria, double notaFinal) {
            base.Channel.AgregarNotaFinal(intAlumno, codMateria, notaFinal);
        }
        
        public System.Threading.Tasks.Task AgregarNotaFinalAsync(int intAlumno, int codMateria, double notaFinal) {
            return base.Channel.AgregarNotaFinalAsync(intAlumno, codMateria, notaFinal);
        }
        
        public System.Data.DataTable CargarNotasFinales() {
            return base.Channel.CargarNotasFinales();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> CargarNotasFinalesAsync() {
            return base.Channel.CargarNotasFinalesAsync();
        }
    }
}