using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Notas.Classes
{
    public class Alumno
    {
        private string strdDocumento;
        private string primerNombre;
        private string segundoNombre;
        private string primerApellido;
        private string SegundoApellido;
        private int idPrograma;

        public Alumno(string strdDocumento, string primerNombre, string segundoNombre,
                                    string primerApellido, string SegundoApellido, int idPrograma)
        {
            this.strdDocumento = strdDocumento;
            this.primerNombre = primerNombre;
            this.segundoNombre = segundoNombre;
            this.primerApellido = primerApellido;
            this.SegundoApellido = SegundoApellido;
            this.idPrograma = idPrograma;
        }

        public Alumno()
        {

        }

        public void CrearNuevo()
        {
            WS_NotasDB.WS_NotasSoapClient soapClient = new WS_NotasDB.WS_NotasSoapClient();
            soapClient.AgregarAlumno(strdDocumento, primerNombre, segundoNombre, primerApellido, SegundoApellido, idPrograma);
        }

        public DataTable CargarAlumnos()
        {
            WS_NotasDB.WS_NotasSoapClient soapClient = new WS_NotasDB.WS_NotasSoapClient();
            DataTable dt = new DataTable("Alumnos");

            dt = soapClient.CargarAlumnos();
            return dt;
        }
    }
}