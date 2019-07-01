using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __LPM.Clientes.MODEL.Helpers
{
    public class MyGlobal
    {
        public static LPM_dbEntities GetDataContext()
        {
            LPM_dbEntities oDb = new LPM_dbEntities();
            oDb.Configuration.ProxyCreationEnabled = false;
            return oDb;
        }
    }
}
