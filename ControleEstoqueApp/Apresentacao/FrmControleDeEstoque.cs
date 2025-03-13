using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Infraestrutura.Database;
using System.Text;

namespace ControleEstoqueApp
{
    public partial class FrmControleDeEstoque : Form
    {
        public FrmControleDeEstoque()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var produto = new Produto
            {
                Nome = txtNome.Text,
                Quantidade = int.Parse(txtQuantidade.Text),
                Preco = decimal.Parse(txtPreco.Text)
            };

            using var context = new AppDbContext();
            context.Produtos.Add(produto);
            context.SaveChanges();

            MessageBox.Show("Produto cadastrado com sucesso!");

            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            using var context = new AppDbContext();
            var produtos = context.Produtos.ToList();
            dtgEstoque.DataSource = produtos;
        }

        private void FrmControleDeEstoque_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void dtgEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgEstoque.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtQuantidade.Text = row.Cells["Quantidade"].Value.ToString();
                txtPreco.Text = row.Cells["Preco"].Value.ToString();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Selecione um produto válido para excluir.");
                return;
            }

            using var context = new AppDbContext();
            var produto = context.Produtos.Find(id);
            if (produto != null)
            {
                context.Produtos.Remove(produto);
                context.SaveChanges();
                MessageBox.Show("Produto excluído com sucesso!");
                CarregarProdutos();
            }
            else
            {
                MessageBox.Show("Produto não encontrado.");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Selecione um produto válido para atualizar.");
                return;
            }

            using var context = new AppDbContext();
            var produto = context.Produtos.Find(id);
            if (produto != null)
            {
                produto.Nome = txtNome.Text;
                produto.Quantidade = int.Parse(txtQuantidade.Text);
                produto.Preco = decimal.Parse(txtPreco.Text);

                context.SaveChanges();
                MessageBox.Show("Produto atualizado com sucesso!");
                CarregarProdutos();
            }
            else
            {
                MessageBox.Show("Produto não encontrado.");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var produtos = context.Produtos
                .Where(p => p.Nome.Contains(txtPesquisar.Text))
                .ToList();

            dtgEstoque.DataSource = produtos;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var produtos = context.Produtos.OrderBy(p => p.Preco).ToList();

            dtgEstoque.DataSource = produtos;
        }

        private void btnFiltrarBaixoEstoque_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var produtos = context.Produtos.Where(p => p.Quantidade < 5).ToList();

            dtgEstoque.DataSource = produtos;

            MessageBox.Show("Exibindo produtos com quantidade baixa.");
        }

        private void btnModoEscuro_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            foreach (Control c in this.Controls)
            {
                if (c is Label || c is Button || c is TextBox || c is DataGridView)
                {
                    c.ForeColor = Color.White;
                    c.BackColor = Color.DarkGray;
                }
            }
        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var produtos = context.Produtos.ToList();

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Salvar arquivo CSV",
                FileName = "estoque.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    writer.WriteLine("Id,Nome,Quantidade,Preco");
                    foreach (var produto in produtos)
                    {
                        writer.WriteLine($"{produto.Id},{produto.Nome},{produto.Quantidade},{produto.Preco}");
                    }
                }
                MessageBox.Show("Exportação concluída com sucesso!");
            }
        }
    }
}
