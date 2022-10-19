using Notas.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Notas.Pages
{
    public partial class GestionAlumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaListaProgramas();
                CargarAlumnosGridView();
            }
        }

        protected void LinkBtn_CrearAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno; 
            string strdDocumento;
            string primerNombre;
            string segundoNombre;
            string primerApellido;
            string SegundoApellido;
            int idPrograma;

            strdDocumento = Txt_Documento.Text.Trim();
            primerNombre = Txt_PrimerNombre.Text.Trim();
            segundoNombre = Txt_SegundoNombre.Text.Trim();
            primerApellido = Txt_PrimerApellido.Text.Trim();
            SegundoApellido = Txt_SegundoApellido.Text.Trim();
            idPrograma = Convert.ToInt32(Ddl_Programa.SelectedValue);

            try
            {
                alumno = new Alumno(strdDocumento, primerNombre, segundoNombre, primerApellido, SegundoApellido, idPrograma);
                alumno.CrearNuevo();
                CargarAlumnosGridView();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void CargarAlumnosGridView()
        {
            DataTable dt = new DataTable("Alumnos");
            Alumno alumno = new Alumno();

            dt = alumno.CargarAlumnos();
            GV_Alumnos.DataSource = dt;
            GV_Alumnos.DataBind();
        }

        private void CargaListaProgramas()
        {            
            DataTable dt = new DataTable("Programas");
            Programa programa = new Programa();

            dt = programa.CargarProgramas();

            Ddl_Programa.DataSource = dt;
            Ddl_Programa.DataTextField = "Descripcion";
            Ddl_Programa.DataValueField = "ID";
            Ddl_Programa.DataBind();
        }

    }
}