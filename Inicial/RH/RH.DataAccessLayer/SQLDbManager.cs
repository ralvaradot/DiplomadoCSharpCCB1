using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.DataAccessLayer
{
    /// <summary>
    /// Esta clase se conecta al motor de base de datos SQL Server 
    /// y ejecuta las diferentes operaciones contra la Base de datos
    /// </summary>
    public class SQLDbManager
    {
        /// <summary>
        /// Cadena de conexion a la base de datos
        /// </summary>
        public string ConnectionString { get; set; }

        public SqlConnection Connection { get; set; }

        public SQLDbManager()
        {
            ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=RH;Trusted_Connection=True;";

            Connection = new SqlConnection(ConnectionString);
            try
            {
                if (Connection.State != System.Data.ConnectionState.Open)
                {
                    Connection.Open();
                }
            }
            catch (SqlException ex)
            {
                // TODO:Crear el Log de errores
                
            }
        }

        /// <summary>
        /// Este metodo ejecuta sentencias o instrucciones SQL hacia la Base de datos
        /// </summary>
        /// <param name="query">Es la sentencia SQL SELECT a ejecutar</param>
        /// <returns>Un conjunto de datos</returns>
        public SqlDataReader ReadData(string query)
        {
            SqlDataReader reader;

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Connection;

                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                reader = cmd.ExecuteReader();
            }
            return reader;
        }

        public int AddOrUpdate(string query)
        {
            int retorno = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Connection;

                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                retorno = cmd.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
