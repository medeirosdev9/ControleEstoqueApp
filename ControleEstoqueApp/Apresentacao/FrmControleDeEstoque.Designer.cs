namespace ControleEstoqueApp
{
    partial class FrmControleDeEstoque
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            lblId = new Label();
            txtQuantidade = new TextBox();
            lblPreco = new Label();
            txtPreco = new TextBox();
            txtNome = new TextBox();
            lblNome = new Label();
            lblQuantidade = new Label();
            btnSalvar = new Button();
            btnExcluir = new Button();
            dtgEstoque = new DataGridView();
            btnAtualizar = new Button();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            btnPesquisar = new Button();
            btnFiltrarBaixoEstoque = new Button();
            label1 = new Label();
            btnExportarCSV = new Button();
            label2 = new Label();
            btnModoEscuro = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(61, 66);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(61, 48);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(379, 66);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 6;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(273, 48);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 9;
            lblPreco.Text = "Preco";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(273, 66);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(167, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 6;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(167, 48);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(379, 48);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 10;
            lblQuantidade.Text = "Quantidade";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(497, 66);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(497, 99);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dtgEstoque
            // 
            dtgEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstoque.Location = new Point(662, 48);
            dtgEstoque.Name = "dtgEstoque";
            dtgEstoque.Size = new Size(592, 355);
            dtgEstoque.TabIndex = 13;
            dtgEstoque.CellDoubleClick += dtgEstoque_CellDoubleClick;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(578, 66);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(61, 117);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(100, 23);
            txtPesquisar.TabIndex = 15;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(61, 99);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(102, 15);
            lblPesquisar.TabIndex = 16;
            lblPesquisar.Text = "Nome a pesquisar";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(167, 116);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 17;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnFiltrarBaixoEstoque
            // 
            btnFiltrarBaixoEstoque.Location = new Point(61, 191);
            btnFiltrarBaixoEstoque.Name = "btnFiltrarBaixoEstoque";
            btnFiltrarBaixoEstoque.Size = new Size(75, 23);
            btnFiltrarBaixoEstoque.TabIndex = 19;
            btnFiltrarBaixoEstoque.Text = "Filtrar";
            btnFiltrarBaixoEstoque.UseVisualStyleBackColor = true;
            btnFiltrarBaixoEstoque.Click += btnFiltrarBaixoEstoque_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 173);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 20;
            label1.Text = "Mostrar estoque baixo";
            // 
            // btnExportarCSV
            // 
            btnExportarCSV.Location = new Point(61, 246);
            btnExportarCSV.Name = "btnExportarCSV";
            btnExportarCSV.Size = new Size(75, 23);
            btnExportarCSV.TabIndex = 21;
            btnExportarCSV.Text = "Exportar";
            btnExportarCSV.UseVisualStyleBackColor = true;
            btnExportarCSV.Click += btnExportarCSV_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 228);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 22;
            label2.Text = "Exportar para CSV";
            // 
            // btnModoEscuro
            // 
            btnModoEscuro.Location = new Point(1179, 12);
            btnModoEscuro.Name = "btnModoEscuro";
            btnModoEscuro.Size = new Size(75, 23);
            btnModoEscuro.TabIndex = 23;
            btnModoEscuro.Text = "M. Escuro";
            btnModoEscuro.UseVisualStyleBackColor = true;
            btnModoEscuro.Click += btnModoEscuro_Click;
            // 
            // FrmControleDeEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 450);
            Controls.Add(btnModoEscuro);
            Controls.Add(label2);
            Controls.Add(btnExportarCSV);
            Controls.Add(label1);
            Controls.Add(btnFiltrarBaixoEstoque);
            Controls.Add(btnPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnAtualizar);
            Controls.Add(dtgEstoque);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(txtPreco);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(txtQuantidade);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Name = "FrmControleDeEstoque";
            Text = "Form1";
            Load += FrmControleDeEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtId;
        private Label lblId;
        private TextBox txtQuantidade;
        private Label lblPreco;
        private TextBox txtPreco;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblQuantidade;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView dtgEstoque;
        private Button btnAtualizar;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private Button btnPesquisar;
        private Button btnFiltrarBaixoEstoque;
        private Label label1;
        private Button btnExportarCSV;
        private Label label2;
        private Button btnModoEscuro;
    }
}
