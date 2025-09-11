using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakerCommerce
{
    public partial class FormProdutos : Form
    {
        Model.Produto produto = new Model.Produto();
        Model.Usuario usuario;

        int idSelecionado = 0;

        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            ListarCategoriasCmb();
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
            // Mostrar as informações do bd no datagrividview:
            dgvProdutos.DataSource = produto.Listar();

        }
        public void ResetarCampos()
        {
            //AtualizarDgv o dgv:
            AtualizarDgv();

            // Limpar campos de edição
            txbNomeEditar.Clear();
            txbPrecoEditar.Clear();
            cmbCategoriaEditar.SelectedIndex = - 1;

            // retornar o idSelecionado para 0
            idSelecionado = 0;

            // retornar o texto padrão do "apagar":
            lblNomeCadastro.Text = "Selecione o produto que deseja apagar.";

            // Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;

        }
        public void ListarCategoriasCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            // Tabela para receber o resultado do select
            DataTable tabela = categoria.Listar();

            foreach (DataRow dr in tabela.Rows)
            {
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");

            }
             
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNomeCadastro.Text.Length < 2)
            {
                MessageBox.Show("O produto deve ter no mínimo 2 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbPrecoCadastro.Text.Length < 1) // a@a.com
            {
                MessageBox.Show("O preço deve ter no mínimo 1 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cmbCategoriaCadastro.SelectedIndex == - 1)
            {
                MessageBox.Show("A Categoria deve .", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // Fazer o cadastro
                Model.Produto produtoCadastro = new Model.Produto();

                produtoCadastro.Nome = txbNomeCadastro.Text;
                produtoCadastro.Preco = Convert.ToDouble(txbPrecoCadastro.Text);
                produtoCadastro.IdCategoria = Convert.ToInt32(cmbCategoriaCadastro.Text.Split('-')[0].Trim());
                produtoCadastro.IdRespCadastro = usuario.Id;
                // executar o INSERT:
                if (produtoCadastro.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // atualizar o dgv:
                    AtualizarDgv();

                    // apagar os campos de cadastro:
                    txbNomeCadastro.Clear();
                    txbPrecoCadastro.Clear();
                    cmbCategoriaCadastro.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o produto.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

            // Extrair o id da categoria
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNomeEditar.Text.Length < 2)
            {
                MessageBox.Show("O nome deve ter no mínimo 2 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!double.TryParse(txbPrecoEditar.Text, out double preco)) 
            {
                MessageBox.Show("O preço deve ter no mínimo 1 caractere.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cmbCategoriaEditar.SelectedIndex == - 1)
            {
                MessageBox.Show("A categoria deve estar selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // Proseguir com a edição:
                Model.Produto produtoEditar = new Model.Produto();
                produtoEditar.Id = idSelecionado;
                produtoEditar.Nome = txbNomeEditar.Text;
                produtoEditar.Preco = preco;
                produtoEditar.IdCategoria = Convert.ToInt32(cmbCategoriaEditar.Text.Split('-')[0].Trim());

                if (produtoEditar.Modificar())
                {
                    MessageBox.Show("Produto modificado com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao modificar o produto.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }
        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar a linha selecionada:
            int ls = dgvProdutos.SelectedCells[0].RowIndex;

            // Colocar os valores das celulas no txb de edição:
            txbNomeEditar.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o ID de quem foi selelcionado:
            idSelecionado = (int)dgvProdutos.Rows[ls].Cells[0].Value;


            // ativar o grbEditar:
            grbEditar.Enabled = true;

            lblApagar.Text = $"Apagar: {dgvProdutos.Rows[ls].Cells[1].Value}";

            grbApagar.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este produto?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão...
                Model.Produto produtoApagar = new Model.Produto();
                produtoApagar.Id = idSelecionado;
                if (produtoApagar.Apagar())
                {
                    MessageBox.Show("Produto apagado com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o produto.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }
    }
}
