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
    public partial class FormUsuarios : Form
    {
        // objetos globais
        Model.Usuario usuario;

        int idSelecionado = 0; // armazenar o id do usuário selecionado p/ apagar ou editar

        public FormUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            AtualizarDgv();

        }
        public void AtualizarDgv()
        {
            // Mostrar as informações do bd no datagrividview:
            dgvUsuarios.DataSource = usuario.Listar();

        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNomeCadastro.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else if(txbEmailCadastro.Text.Length < 7) // a@a.com
            {
                MessageBox.Show("O Email deve ter no mínimo 7 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else if(txbSenhaCadastro.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
                // Fazer o cadastro
                Model.Usuario usuarioCadastro = new Model.Usuario();

                usuarioCadastro.NomeCompleto = txbNomeCadastro.Text;
                usuarioCadastro.Email = txbEmailCadastro.Text;
                usuarioCadastro.Senha = txbSenhaCadastro.Text;

                // executar o INSERT:
                if(usuarioCadastro.Cadastrar()) 
                {
                   MessageBox.Show("Usuário cadastrado com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // atualizar o dgv:
                    AtualizarDgv();

                    // apagar os campos de cadastro:
                    txbNomeCadastro.Clear();
                    txbEmailCadastro.Clear();
                    txbSenhaCadastro.Clear();

                }
                else 
                {
                    MessageBox.Show("Falha ao cadastrar o usuário.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                   

            }

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar a linha selecionada:
            int ls = dgvUsuarios.SelectedCells[0].RowIndex;

            // Colocar os valores das celulas no txb de edição:
            txbNomeEditar.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();
            txbEmailEditar.Text = dgvUsuarios.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o ID de quem foi selelcionado:
            idSelecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value;


            // ativar o grbEditar:
            grbEditar.Enabled = true;

            lblApagar.Text = $"Apagar: {dgvUsuarios.Rows[ls].Cells[1].Value}";

            grbApagar.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este usuário?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão...
                Model.Usuario usuarioApagar = new Model.Usuario();
                usuarioApagar.Id = idSelecionado;
                if(usuarioApagar.Apagar())
                {

                    MessageBox.Show("Usuário apagado com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   ResetarCampos();


                }
                else
                {
                    MessageBox.Show("Falha ao apagar o usuário.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
            
            }
        }

        public void ResetarCampos()
        {
            //AtualizarDgv o dgv:
            AtualizarDgv();

            // Limpar campos de edição
            txbEmailEditar.Clear();
            txbSenhaEditar.Clear();
            txbNomeEditar.Clear();

            // retornar o idSelecionado para 0
            idSelecionado = 0;

            // retornar o texto padrão do "apagar":
            lblNomeCadastro.Text = "Selecione o usuário que deseja apagar.";

            // Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNomeEditar.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbEmailEditar.Text.Length < 7) // a@a.com
            {
                MessageBox.Show("O Email deve ter no mínimo 7 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbSenhaEditar.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            { 
                // Proseguir com a edição:
                Model.Usuario usuarioEditar = new Model.Usuario();  
                usuarioEditar.Id = idSelecionado;
                usuarioEditar.NomeCompleto = txbNomeCadastro.Text;
                usuarioEditar.Email = txbEmailEditar.Text;
                usuarioEditar.Senha = txbSenhaEditar.Text;

                if (usuarioEditar.Modificar())
                {
                    MessageBox.Show("Usuário modificado com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao modificar o usuário.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
            }
           
        }
    }
}
