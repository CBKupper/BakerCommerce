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
    public partial class FormComandas : Form
    {
        Model.Usuario usuario;
        public FormComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvComandas.DataSource = produto.Listar();
        }

        private void dgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvComandas.SelectedCells[0].RowIndex;

            txbCodProduto.Text = dgvComandas.Rows[ls].Cells[0].Value.ToString();
            txbProdutos.Text = dgvComandas.Rows[ls].Cells[0].Value.ToString();


        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // verificar se os campos estão vazios:
            if (txbComanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o numero da comanda!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }else if(txbCodProduto.Text.Length == 0)
            {
                MessageBox.Show("Informe o código do produto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                grbInformacoes.Enabled = false;
                grbLancamento.Enabled = true;
                
            }


        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            // verificar se a quantidade foi preenchida:
            if(txbQuantidade.Text.Length == 0)
            {
                MessageBox.Show("Informe a quantidade!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComanda.Text);
                ordemComanda.IdProduto = int.Parse(txbCodProduto.Text);
                ordemComanda.Quantidade = int.Parse(txbQuantidade.Text);
                ordemComanda.IdResp = usuario.Id;

                if(ordemComanda.Cadastrar())
                {
                    MessageBox.Show("Lançamento efetuado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {

                    MessageBox.Show("Falha ao efetuar o lançamento!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ResetarCampos()
        {
            txbCodProduto.Clear();
            txbQuantidade.Clear();
            txbProdutos.Clear();
            txbComanda.Clear();
            // resetar os groupbox:
            grbLancamento.Enabled = false;
            grbInformacoes.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}
