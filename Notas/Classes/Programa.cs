using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Notas.Classes
{
    public class Programa
    {
        public DataTable CargarProgramas()
        {
            WS_NotasDB.WS_NotasSoapClient soapClient = new WS_NotasDB.WS_NotasSoapClient();
            DataTable dt = new DataTable("Programas");

            dt = soapClient.CargarProgramas();
            return dt;
        }

    }
}