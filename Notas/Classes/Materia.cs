using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Notas.Classes
{
    public class Materia
    {
        private string descripcion;
        private int codigoMateria;
        private int idPrograma;

        public Materia(string descripcion, int codigoMateria, int idPrograma)
        {
            this.descripcion = descripcion;
            this.codigoMateria = codigoMateria;
            this.idPrograma = idPrograma;
        }

        public Materia()
        {

        }

        public void CrearNuevo()
        {
            WS_NotasDB.WS_NotasSoapClient soapClient = new WS_NotasDB.WS_NotasSoapClient();
            soapClient.AgregarMateria(descripcion, codigoMateria, idPrograma);
        }


        public DataTable CargarMaterias()
        {
            WS_NotasDB.WS_NotasSoapClient soapClient = new WS_NotasDB.WS_NotasSoapClient();
            DataTable dt = new DataTable("Materias");

            dt = soapClient.CargarMaterias();
            return dt;
        }
    }
}