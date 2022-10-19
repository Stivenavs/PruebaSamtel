using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WS_Notas_DB.Properties;

namespace WS_Notas_DB.Classes
{
    public class GestionMateria
    {
        public void AgregarMateria(string descripcion, int codigoMateria,  int idPrograma)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            Settings settings = new Settings();

            con.ConnectionString = settings.ConexionBD;
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TM_MateriasAD";
            cmd.Parameters.Add(new SqlParameter("@parDescripcion", descripcion));
            cmd.Parameters.Add(new SqlParameter("@parCodigo", codigoMateria));
            cmd.Parameters.Add(new SqlParameter("@parIdPrograma", idPrograma));

            cmd.ExecuteNonQuery();
        }

        public DataTable CargarTodas()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable("Materias");
            Settings settings = new Settings();

            con.ConnectionString = settings.ConexionBD;
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TM_MateriasSL";

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }
    }
}