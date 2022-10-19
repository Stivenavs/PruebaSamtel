using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WS_Notas_DB.Properties;

namespace WS_Notas_DB.Classes
{
    public class GestionNotaFinal
    {

        public void AgregarNotaFinal(int intAlumno, int codMateria, double notaFinal)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            Settings settings = new Settings();

            con.ConnectionString = settings.ConexionBD;
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TM_NotasFinalesAD";
            cmd.Parameters.Add(new SqlParameter("@parIdAlumno",intAlumno ));
            cmd.Parameters.Add(new SqlParameter("@parCodMateria", codMateria));
            cmd.Parameters.Add(new SqlParameter("@parNotaFinal", notaFinal));

            cmd.ExecuteNonQuery();

        }

        internal DataTable CargarTodas()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable("NotasFinales");
            Settings settings = new Settings();

            con.ConnectionString = settings.ConexionBD;
            con.Open();

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TM_NotasFinalesSL";

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }
    }
}