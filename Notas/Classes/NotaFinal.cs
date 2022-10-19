using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Notas.Classes
{
    public class NotaFinal
    {
        private int intAlumno;
        private int codMateria;
        private double notaFinal;

        public NotaFinal(int intAlumno, int codMatria, double notaFinal)
        {
            this.intAlumno = intAlumno;
            this.codMateria = codMatria;
            this.notaFinal = notaFinal;
        }

        public NotaFinal()
        {

        }

        public void CrearNuevo()
        {
            WS_NotasDB.WS_NotasSoapClient soapClient = new WS_NotasDB.WS_NotasSoapClient();
            soapClient.AgregarNotaFinal(intAlumno, codMateria, notaFinal);
        }


        public DataTable CargarNotasFinales()
        {
            WS_NotasDB.WS_NotasSoapClient soapClient = new WS_NotasDB.WS_NotasSoapClient();
            DataTable dt = new DataTable("NotasFinales");

            dt = soapClient.CargarNotasFinales();
            return dt;
        }
    }
}