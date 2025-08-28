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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Verificar se a pessoa digitou o email e a senha:
            
            if(txbEmail.Text.Length < 6 )
            {
                MessageBox.Show("Digite um e-mail valido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );


            }else if (txbSenha.Text.Length < 4)
            {

                MessageBox.Show("Digite uma senha valida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }else
            {
                // Prosseguir
                Model.Usuario usuario = new Model.Usuario();

                // Colocar os valores dos campos nos atributos do usuario:
                usuario.Email =txbEmail.Text;
                usuario.Senha =txbSenha.Text;

                // tabela que vai receber o resultado do SELECT (Logar)
                DataTable resultado = usuario.Logar();

                // verificar se acertou o e-mail e senha:
                if(resultado.Rows.Count == 0 )
                {

                    MessageBox.Show("E-mail e/ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                  // armazenar as infos vindas do db no objeto "usuario"
                    usuario.Id = int.Parse(resultado.Rows[0]["id"].ToString());
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();

                    // Mudar para o MenuPrincipal:
                    MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                    Hide(); 
                    menuPrincipal.ShowDialog();

                    Show();


                }


            }

        }
    }
}
