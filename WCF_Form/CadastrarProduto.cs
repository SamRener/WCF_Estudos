using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF_Form.ProdutoService;

namespace WCF_Form
{
    public partial class CadastrarProduto : Form
    {
        private ProdutoServiceClient client { get; set; }
        private string message = null;
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string message = "";
                if(new ProdutoServiceClient().Create(txtNome.Text, txtMarca.Text, decimal.Parse(txtPreco.Text), ref message)){
                    MessageBox.Show(message);
                }
            }
            else MessageBox.Show("Preencha todos o itens corretamente");

        }
        bool Validar()
        {
            return !String.IsNullOrWhiteSpace(txtMarca.Text) && !String.IsNullOrWhiteSpace(txtNome.Text) && decimal.TryParse(txtPreco.Text, out decimal preco);
        }

        private void editarLink_Click(object sender, EventArgs e)
        {
            new EditarProduto().ShowDialog();
            this.Hide();
        }

        private void listarLink_Click(object sender, EventArgs e)
        {
            new ListarProduto().ShowDialog();
            this.Hide();
        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {
            client = new ProdutoServiceClient();
        }

        private void atualizarLink_Click(object sender, EventArgs e)
        {
            new AtualizarEstoque().ShowDialog();
            this.Hide();
        }
    }
}
