using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;

namespace DEMO4
{
    public class Personas
    {
        string cadena;
        string sql;
        SqlConnection conector;
        SqlCommand comando;

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string barrio;

        public string Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }

        public Personas()
        {
            cadena = "Data Source=.;Initial Catalog=Ies21;Integrated Security=True";
            sql = "";
            conector = new SqlConnection(cadena);
            comando = new SqlCommand();

        }

        public void grabar()
        {
            conector.Open();
            sql = "INSERT INTO Personas VALUES(@id, @nombre, @barrio)";

            comando.Connection = conector;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@barrio", barrio);

            comando.ExecuteNonQuery();

            conector.Close();

        }
    }
}