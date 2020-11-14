using RH.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.DataAccessLayer
{
    public class TipoDocumentoDAL
    {
        SQLDbManager db = new SQLDbManager();

        public List<TipoDocumentoIdentificacion> GetAllTiposDocumento()
        {
            StringBuilder SbQuery = new StringBuilder();
            SbQuery.Append("SELECT ");
            SbQuery.Append(" [TipoDocumentoId], [TipoDocumento] ");
            SbQuery.Append("FROM TipoDocumentoIdentificacion ");

            SqlDataReader reader = db.ReadData(SbQuery.ToString());
            List<TipoDocumentoIdentificacion> lista = new List<TipoDocumentoIdentificacion>();

            while (reader.Read())
            {
                TipoDocumentoIdentificacion tipodoc = new TipoDocumentoIdentificacion()
                {
                    TipoDocumentoId = Convert.ToInt32(reader["TipoDocumentoId"]),
                    TipoDocumento = reader["TipoDocumento"].ToString()
                };
                lista.Add(tipodoc);
            }
            reader.Close();

            return lista;
        }
    }
}
