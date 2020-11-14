using RH.DataAccessLayer;
using RH.Entities;
using System.Collections.Generic;

namespace RH.BusinessLogic
{
    public class TipoDocumentoBL
    {

        public List<TipoDocumentoIdentificacion> GetAllTipoDocumentos()
        {
            TipoDocumentoDAL tipoDocDal = new TipoDocumentoDAL();
            return tipoDocDal.GetAllTiposDocumento();
        }
    }
}
