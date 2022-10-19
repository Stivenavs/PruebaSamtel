using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WS_Notas_DB.Properties;

namespace WS_Notas_DB.Classes
{
    public class GestionPrograma
    {
        public DataTable CargarTodos()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable("Programas");
            Settings settings = new Settings();

            con.ConnectionString = settings.ConexionBD;
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TM_ProgramasSL";

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }
    }
}