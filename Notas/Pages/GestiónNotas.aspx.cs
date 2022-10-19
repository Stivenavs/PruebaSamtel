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
    public partial class GestiónNotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarNotasFinalesGridView();
                CargarAlumnos();
                CargarMaterias();
            }
        }

        protected void LinkBtn_AsignarNota_Click(object sender, EventArgs e)
        {
            NotaFinal notaFinal;
            int intAlumno;
            int codMateria;
            double nota;

            intAlumno = Convert.ToInt32(Ddl_Alumno.SelectedValue);
            codMateria = Convert.ToInt32(Ddl_Materia.SelectedValue);
            nota = Convert.ToInt32(Txt_Codigo.Text.Trim());

            try
            {
                notaFinal = new NotaFinal(intAlumno, codMateria, nota);
                notaFinal.CrearNuevo();
                CargarNotasFinalesGridView();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void CargarAlumnos()
        {
            DataTable dt = new DataTable("Alumnos");
            Alumno alumno = new Alumno();

            dt = alumno.CargarAlumnos();
            Ddl_Alumno.DataSource = dt;
            Ddl_Alumno.DataTextField = "NombreCompleto";
            Ddl_Alumno.DataValueField = "Documento";
            Ddl_Alumno.DataBind();
        }

        private void CargarMaterias()
        {
            DataTable dt = new DataTable("Materias");
            Materia materia = new Materia();

            dt = materia.CargarMaterias();
            Ddl_Materia.DataSource = dt;
            Ddl_Materia.DataTextField = "Materia";
            Ddl_Materia.DataValueField = "Codigo";
            Ddl_Materia.DataBind();
        }

        private void CargarNotasFinalesGridView()
        {
            DataTable dt = new DataTable("NotasFinales");
            NotaFinal notaFinal = new NotaFinal();

            dt = notaFinal.CargarNotasFinales();
            GV_NotasFinales.DataSource = dt;
            GV_NotasFinales.DataBind();
        }
    }
}