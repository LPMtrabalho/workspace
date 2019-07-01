using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using __LPM.Clientes.MODEL;
using __LPM.Clientes.MODEL.Repositories;

namespace __LPM.Clientes.VIEW.Controllers
{
    public class CCadastroCliente : IDisposable
    {
        RepositoryCliente _Repository;

        public void CadastroCliente()
        {
            _Repository = new RepositoryCliente();
        }
        public void Incluir(LPM_Cliente oCli)
        {
            _Repository.Incluir(oCli);
        }
        public void Alterar(LPM_Cliente oCli)
        {
            _Repository.Alterar(oCli);
        }
        public void Deletar(LPM_Cliente oCli)
        {
            _Repository.Deletar(oCli);
        }
        public LPM_Cliente Selecionar(int id)
        {
            return _Repository.Selecionar(id);
        }
        public List<LPM_Cliente> SelecionarTodos()
        {
            return _Repository?.SelecionarTodos();
        }
        public void Dispose()
        {
            _Repository.Dispose();

        }
    }
}
