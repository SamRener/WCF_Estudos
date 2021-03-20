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
    public partial class ListarProduto : Form
    {
        private ProdutoServiceClient client { get; set; }
        private string message = null;
        public ListarProduto()
        {
            InitializeComponent();
        }

        private void ListarProduto_Load(object sender, EventArgs e)
        {
            client = new ProdutoServiceClient();
            dgv_Produtos.DataSource = client.Find(ref message);
        }

        private void cadastrarLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CadastrarProduto().ShowDialog();
        }

        private void editarLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditarProduto().ShowDialog();
        }

        private void atualizarLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AtualizarEstoque().ShowDialog();
        }
    }
}
