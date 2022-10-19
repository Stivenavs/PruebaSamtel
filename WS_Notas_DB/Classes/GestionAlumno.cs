using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WS_Notas_DB.Properties;

namespace WS_Notas_DB.Classes
{
    public class GestionAlumno
    {
        public void AgregarAlumno(string parDocumento, string primerNombre, string segundoNombre, 
                                    string primerApellido, string SegundoApellido, int idPrograma)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            Settings settings = new Settings();

            con.ConnectionString = settings.ConexionBD; 
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TM_AlumnosAD";
            cmd.Parameters.Add(new SqlParameter("@parDocumento", parDocumento));
            cmd.Parameters.Add(new SqlParameter("@parPrimerNombre", primerNombre));
            cmd.Parameters.Add(new SqlParameter("@parSegundoNombre", segundoNombre));
            cmd.Parameters.Add(new SqlParameter("@parPrimerApellido", primerApellido));
            cmd.Parameters.Add(new SqlParameter("@parSegundoApellido", SegundoApellido));
            cmd.Parameters.Add(new SqlParameter("@parNombreCompleto", string.Format("{0} {1} {2} {3}", primerNombre, segundoNombre, primerApellido, SegundoApellido)));
            cmd.Parameters.Add(new SqlParameter("@parIdPrograma", idPrograma));

            cmd.ExecuteNonQuery();

        }

        public DataTable CargarTodos()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable("Alumnos");
            Settings settings = new Settings();

            con.ConnectionString = settings.ConexionBD;
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TM_AlumnosSL";

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt; 

        }
    }
}