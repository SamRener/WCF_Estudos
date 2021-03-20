using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF_Form.ItemService;
using WCF_Form.ProdutoService;
using Produto = WCF_Form.ProdutoService.Produto;

namespace WCF_Form
{
    public partial class AtualizarEstoque : Form
    {
        private ProdutoServiceClient client { get; set; }
        private ItemServiceClient itemClient { get; set; }
        private string message = null;
        public AtualizarEstoque()
        {
            InitializeComponent();
        }

        private void AtualizarEstoque_Load(object sender, EventArgs e)
        {
            client = new ProdutoServiceClient();
            itemClient = new ItemServiceClient();

            cmbProduto.DataSource = client.Find(ref message);

            if (String.IsNullOrEmpty(message))
            {
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
                    dgv_Produtos.DataSource = itemClient.Find((int)cmbProduto.SelectedValue,ref message);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    int.TryParse(txtCodigo.Text, out int codigoBarra);
                    string message = "";
                    if (itemClient.Add(codigoBarra, (int)cmbProduto.SelectedValue, ref message))
                    {
                        MessageBox.Show(message);
                    }
                }
                else MessageBox.Show("Preencha todos o itens corretamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        bool Validar()
        {
            return !String.IsNullOrWhiteSpace(txtCodigo.Text) && int.TryParse(txtCodigo.Text, out int result) && !String.IsNullOrWhiteSpace(cmbProduto.SelectedValue.ToString());
        }

        private void listarLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListarProduto().ShowDialog();
        }

        private void editarLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditarProduto().ShowDialog();
        }

        private void cadastrarLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CadastrarProduto().ShowDialog();
        }
    }
}
