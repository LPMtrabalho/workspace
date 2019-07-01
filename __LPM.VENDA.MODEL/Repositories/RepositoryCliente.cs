using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using __LPM.Clientes.MODEL.Helpers;

namespace __LPM.Clientes.MODEL.Repositories
{
    public class RepositoryCliente : IDisposable
    {
        /**
         * LPM_Cliente se refere a classe criada a partir do banco de dados
         * Para a classe: LPM_db.edmx > LPM_db.Context.tt > LPM_db.tt > LPM_Cliente.cs 
         */

        LPM_dbEntities oDb;
        public RepositoryCliente()
        {
            oDb = MyGlobal.GetDataContext();
        }

        public void Incluir(LPM_Cliente oCli)
        {
            oDb.LPM_Cliente.Add(oCli);
            oDb.SaveChanges();
        }
        public void Alterar(LPM_Cliente oCli)
        {
            oDb.Entry(oCli).State = System.Data.Entity.EntityState.Modified;
            oDb.SaveChanges();
        }
        public void Deletar(LPM_Cliente oCli, bool foraContexto = false)
        {
            if (foraContexto) {
                oDb.LPM_Cliente.Attach(oCli);
            }
            oDb.LPM_Cliente.Remove(oCli);
            oDb.SaveChanges();
        }
        public LPM_Cliente Selecionar(int id) {
            return (from compare in oDb.LPM_Cliente where compare.id == id select compare).FirstOrDefault();
        }
        public List<LPM_Cliente> SelecionarTodos()
        {
            return (from a in oDb.LPM_Cliente orderby a.nome select a).ToList();
        }

        public void Dispose() 
        {
            oDb.Dispose();
        }
    }
}
