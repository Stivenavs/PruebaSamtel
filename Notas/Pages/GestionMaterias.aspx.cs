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
    public partial class GestionMaterias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaListaProgramas();
                CargarMateriasGridView();
            }
        }

        protected void LinkBtn_CrearMateria_Click(object sender, EventArgs e)
        {
            Materia materia; 
            string descripcion;
            int codigoMateria;
            int idPrograma;

            descripcion = Txt_Descripcion.Text.Trim();
            codigoMateria = Convert.ToInt32(Txt_Codigo.Text.Trim());
            idPrograma = Convert.ToInt32(Ddl_Programa.SelectedValue);

            try
            {
                materia = new Materia(descripcion, codigoMateria, idPrograma);
                materia.CrearNuevo();
                CargarMateriasGridView();
            }
            catch (Exception)
            {
                throw;
            }            
        }

        private void CargarMateriasGridView()
        {
            DataTable dt = new DataTable("Materias");
            Materia materia = new Materia();

            dt = materia.CargarMaterias();
            GV_Materias.DataSource = dt;
            GV_Materias.DataBind();
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