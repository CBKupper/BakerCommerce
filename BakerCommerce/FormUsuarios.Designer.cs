namespace BakerCommerce
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.txbNomeCadastro = new System.Windows.Forms.TextBox();
            this.txbEmailCadastro = new System.Windows.Forms.TextBox();
            this.txbSenhaCadastro = new System.Windows.Forms.TextBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.lblEmailCadastro = new System.Windows.Forms.Label();
            this.lblSenhaCadastro = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.txbSenhaEditar = new System.Windows.Forms.TextBox();
            this.txbEmailEditar = new System.Windows.Forms.TextBox();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbApagar = new System.Windows.Forms.GroupBox();
            this.lblApagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbCadastro.SuspendLayout();
            this.gbEditar.SuspendLayout();
            this.gbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(41, 91);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(693, 265);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.btnCadastrar);
            this.gbCadastro.Controls.Add(this.lblSenhaCadastro);
            this.gbCadastro.Controls.Add(this.lblEmailCadastro);
            this.gbCadastro.Controls.Add(this.lblNomeCadastro);
            this.gbCadastro.Controls.Add(this.txbSenhaCadastro);
            this.gbCadastro.Controls.Add(this.txbEmailCadastro);
            this.gbCadastro.Controls.Add(this.txbNomeCadastro);
            this.gbCadastro.Enabled = false;
            this.gbCadastro.Location = new System.Drawing.Point(67, 362);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(325, 257);
            this.gbCadastro.TabIndex = 1;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastro";
            // 
            // txbNomeCadastro
            // 
            this.txbNomeCadastro.Location = new System.Drawing.Point(97, 48);
            this.txbNomeCadastro.Name = "txbNomeCadastro";
            this.txbNomeCadastro.Size = new System.Drawing.Size(199, 21);
            this.txbNomeCadastro.TabIndex = 0;
            // 
            // txbEmailCadastro
            // 
            this.txbEmailCadastro.Location = new System.Drawing.Point(97, 87);
            this.txbEmailCadastro.Name = "txbEmailCadastro";
            this.txbEmailCadastro.Size = new System.Drawing.Size(199, 21);
            this.txbEmailCadastro.TabIndex = 1;
            // 
            // txbSenhaCadastro
            // 
            this.txbSenhaCadastro.Location = new System.Drawing.Point(97, 128);
            this.txbSenhaCadastro.Name = "txbSenhaCadastro";
            this.txbSenhaCadastro.Size = new System.Drawing.Size(199, 21);
            this.txbSenhaCadastro.TabIndex = 2;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(6, 48);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(93, 14);
            this.lblNomeCadastro.TabIndex = 3;
            this.lblNomeCadastro.Text = "Nome Completo:";
            // 
            // lblEmailCadastro
            // 
            this.lblEmailCadastro.AutoSize = true;
            this.lblEmailCadastro.Location = new System.Drawing.Point(56, 95);
            this.lblEmailCadastro.Name = "lblEmailCadastro";
            this.lblEmailCadastro.Size = new System.Drawing.Size(37, 14);
            this.lblEmailCadastro.TabIndex = 4;
            this.lblEmailCadastro.Text = "Email:";
            // 
            // lblSenhaCadastro
            // 
            this.lblSenhaCadastro.AutoSize = true;
            this.lblSenhaCadastro.Location = new System.Drawing.Point(50, 136);
            this.lblSenhaCadastro.Name = "lblSenhaCadastro";
            this.lblSenhaCadastro.Size = new System.Drawing.Size(42, 14);
            this.lblSenhaCadastro.TabIndex = 5;
            this.lblSenhaCadastro.Text = "Senha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(33, 171);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(263, 45);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.btnEditar);
            this.gbEditar.Controls.Add(this.lblSenhaEditar);
            this.gbEditar.Controls.Add(this.lblEmailEditar);
            this.gbEditar.Controls.Add(this.lblNomeEditar);
            this.gbEditar.Controls.Add(this.txbSenhaEditar);
            this.gbEditar.Controls.Add(this.txbEmailEditar);
            this.gbEditar.Controls.Add(this.txbNomeEditar);
            this.gbEditar.Enabled = false;
            this.gbEditar.Location = new System.Drawing.Point(398, 362);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(324, 257);
            this.gbEditar.TabIndex = 2;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(33, 171);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(264, 45);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Location = new System.Drawing.Point(50, 136);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(42, 14);
            this.lblSenhaEditar.TabIndex = 5;
            this.lblSenhaEditar.Text = "Senha:";
            // 
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Location = new System.Drawing.Point(56, 95);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(37, 14);
            this.lblEmailEditar.TabIndex = 4;
            this.lblEmailEditar.Text = "Email:";
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(6, 48);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(93, 14);
            this.lblNomeEditar.TabIndex = 3;
            this.lblNomeEditar.Text = "Nome Completo:";
            // 
            // txbSenhaEditar
            // 
            this.txbSenhaEditar.Location = new System.Drawing.Point(97, 128);
            this.txbSenhaEditar.Name = "txbSenhaEditar";
            this.txbSenhaEditar.Size = new System.Drawing.Size(200, 21);
            this.txbSenhaEditar.TabIndex = 2;
            // 
            // txbEmailEditar
            // 
            this.txbEmailEditar.Location = new System.Drawing.Point(97, 87);
            this.txbEmailEditar.Name = "txbEmailEditar";
            this.txbEmailEditar.Size = new System.Drawing.Size(200, 21);
            this.txbEmailEditar.TabIndex = 1;
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(97, 48);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(200, 21);
            this.txbNomeEditar.TabIndex = 0;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(482, 13);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(114, 48);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // gbApagar
            // 
            this.gbApagar.Controls.Add(this.lblApagar);
            this.gbApagar.Controls.Add(this.btnApagar);
            this.gbApagar.Enabled = false;
            this.gbApagar.Location = new System.Drawing.Point(120, 635);
            this.gbApagar.Name = "gbApagar";
            this.gbApagar.Size = new System.Drawing.Size(602, 71);
            this.gbApagar.TabIndex = 4;
            this.gbApagar.TabStop = false;
            this.gbApagar.Text = "Apagar";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Location = new System.Drawing.Point(6, 30);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(185, 14);
            this.lblApagar.TabIndex = 4;
            this.lblApagar.Text = "Selecione um usuário para apagar.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gerenciamento de Usuários";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 756);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbApagar);
            this.Controls.Add(this.gbEditar);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuarios";
            this.Text = ":: Gerenciamento de Usuários ::";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            this.gbApagar.ResumeLayout(false);
            this.gbApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblSenhaCadastro;
        private System.Windows.Forms.Label lblEmailCadastro;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.TextBox txbSenhaCadastro;
        private System.Windows.Forms.TextBox txbEmailCadastro;
        private System.Windows.Forms.TextBox txbNomeCadastro;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblSenhaEditar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.TextBox txbSenhaEditar;
        private System.Windows.Forms.TextBox txbEmailEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Label label1;
    }
}