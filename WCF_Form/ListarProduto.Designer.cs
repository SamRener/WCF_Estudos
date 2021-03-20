
namespace WCF_Form
{
    partial class ListarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLink = new System.Windows.Forms.ToolStripMenuItem();
            this.editarLink = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarLink = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Produtos = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLink,
            this.editarLink,
            this.atualizarLink});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarLink
            // 
            this.cadastrarLink.Name = "cadastrarLink";
            this.cadastrarLink.Size = new System.Drawing.Size(227, 28);
            this.cadastrarLink.Text = "Cadastrar";
            this.cadastrarLink.Click += new System.EventHandler(this.cadastrarLink_Click);
            // 
            // editarLink
            // 
            this.editarLink.Name = "editarLink";
            this.editarLink.Size = new System.Drawing.Size(227, 28);
            this.editarLink.Text = "Editar";
            this.editarLink.Click += new System.EventHandler(this.editarLink_Click);
            // 
            // atualizarLink
            // 
            this.atualizarLink.Name = "atualizarLink";
            this.atualizarLink.Size = new System.Drawing.Size(227, 28);
            this.atualizarLink.Text = "Atualizar Estoque";
            this.atualizarLink.Click += new System.EventHandler(this.atualizarLink_Click);
            // 
            // dgv_Produtos
            // 
            this.dgv_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produtos.Location = new System.Drawing.Point(12, 31);
            this.dgv_Produtos.Name = "dgv_Produtos";
            this.dgv_Produtos.RowHeadersWidth = 51;
            this.dgv_Produtos.RowTemplate.Height = 24;
            this.dgv_Produtos.Size = new System.Drawing.Size(776, 407);
            this.dgv_Produtos.TabIndex = 9;
            // 
            // ListarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Produtos);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ListarProduto";
            this.Text = "ListarProduto";
            this.Load += new System.EventHandler(this.ListarProduto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarLink;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLink;
        private System.Windows.Forms.ToolStripMenuItem atualizarLink;
        private System.Windows.Forms.DataGridView dgv_Produtos;
    }
}