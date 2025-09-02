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

            }else if(txbEmailCadastro.Text.Length > 7) // a@a.com
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
    }
}
