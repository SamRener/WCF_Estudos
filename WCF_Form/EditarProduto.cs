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
    public partial class EditarProduto : Form
    {
        private ProdutoServiceClient client { get; set; }
        private string message = null;
        public EditarProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if(client.Edit(new Produto { Id = (int)cmbProduto.SelectedValue, Nome = txtNome.Text, Marca = txtMarca.Text, Preco = decimal.Parse(txtPreco.Text) }, ref message)){
                    MessageBox.Show(message);
                }
            }
            else MessageBox.Show("Preencha todos o itens corretamente");

        }
        bool Validar()
        {
            return !String.IsNullOrWhiteSpace(txtMarca.Text) && !String.IsNullOrWhiteSpace(txtNome.Text) && decimal.TryParse(txtPreco.Text, out decimal preco);
        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {
            client = new ProdutoServiceClient();

            cmbProduto.DataSource = client.Find(ref message);

            if (!String.IsNullOrEmpty(message))
            {
                MessageBox.Show("Não há Produtos para editar");
            }
            else{
                cmbProduto.DisplayMember = "Nome";
                cmbProduto.ValueMember = "Id";
            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Produto produto = client.Get((int)cmbProduto.SelectedValue, ref message);

                if (produto != null)
                {
                    txtNome.Text = produto.Nome;
                    txtMarca.Text = produto.Marca;
                    txtPreco.Text = produto.Preco.ToString();
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
            catch
            {

            }
        }

        private void cadastrarLink_Click(object sender, EventArgs e)
        {
            new CadastrarProduto().ShowDialog();
            this.Hide();
        }

        private void atualizarLink_Click(object sender, EventArgs e)
        {
            new AtualizarEstoque().ShowDialog();
            this.Hide();
        }

        private void listarLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListarProduto().ShowDialog();
        }
    }
}
