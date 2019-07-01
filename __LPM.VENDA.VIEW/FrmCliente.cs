using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using __LPM.Clientes.MODEL;
using __LPM.Clientes.VIEW.Controllers;

namespace __LPM.Clientes.VIEW
{
    public partial class FrmCliente : Form
    {
        CCadastroCliente _Control; 
        public FrmCliente()
        {
            InitializeComponent();
            _Control = new CCadastroCliente();

        }

        public void CarregaGrid() {
            GrdClientes.AutoGenerateColumns = false;
            GrdClientes.DataSource = _Control.SelecionarTodos();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private bool ValidaControles() {
            return true;
        }

        private String VerificaTipo(string doc)
        {
            return "Física";
        }
        private void BtnInclude_Click(object sender, EventArgs e)
        {
            if (ValidaControles()) {
                LPM_Cliente oCli = new LPM_Cliente();
                string doc = TxtDocumento.Text;
                oCli.documento = doc;
                oCli.nome = TxtNome.Text;
                oCli.sobrenome = TxtSobrenome.Text;
                oCli.cidade = TxtCidade.Text;
                oCli.bairro = TxtBairro.Text;
                oCli.logradouro = TxtLogradouro.Text;
                oCli.numero = TxtNumero.Text;
                oCli.complemento = TxtComplemento.Text;
                oCli.ponto_referencia = TxtPonto_referencia.Text;
                oCli.contato = MskContato.Text;
                oCli.tipo_pessoa = VerificaTipo(doc);
                _Control.Incluir(oCli);
                CarregaGrid();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
