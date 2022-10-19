using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using WS_Notas_DB.Classes;

namespace WS_Notas_DB
{
    /// <summary>
    /// Descripción breve de WS_Notas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_Notas : System.Web.Services.WebService
    {
        [WebMethod]
        public void AgregarAlumno(string strDocumento, string primerNombre, string segundoNombre,
                                    string primerApellido, string SegundoApellido, int idPrograma)
        {
            GestionAlumno ga = new GestionAlumno();
            ga.AgregarAlumno(strDocumento, primerNombre, segundoNombre, primerApellido, SegundoApellido, idPrograma);
        }


        [WebMethod]
        public DataTable CargarAlumnos()
        {
            GestionAlumno ga = new GestionAlumno();
            return ga.CargarTodos();
        }

        [WebMethod]
        public DataTable CargarProgramas()
        {
            GestionPrograma gp = new GestionPrograma();
            return gp.CargarTodos();
        }


        [WebMethod]
        public void AgregarMateria(string descripcion, int codigoMateria, int idPrograma)
        {
            GestionMateria gm = new GestionMateria();
             gm.AgregarMateria(descripcion, codigoMateria, idPrograma);
        }


        [WebMethod]
        public DataTable CargarMaterias()
        {
            GestionMateria gm = new GestionMateria();
            return gm.CargarTodas();
        }


        [WebMethod]
        public void AgregarNotaFinal(int intAlumno, int codMateria, double notaFinal)
        {
            GestionNotaFinal gnf = new GestionNotaFinal();
            gnf.AgregarNotaFinal(intAlumno, codMateria, notaFinal);
        }

        [WebMethod]
        public DataTable CargarNotasFinales()
        {
            GestionNotaFinal gnf = new GestionNotaFinal();
            return gnf.CargarTodas();
        }
    }
}
