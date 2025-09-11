namespace BakerCommerce
{
    partial class FormComandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComandas));
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblComandaInformacoes = new System.Windows.Forms.Label();
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbProdutos = new System.Windows.Forms.TextBox();
            this.lblQuantidadeLancamento = new System.Windows.Forms.Label();
            this.lblProdutoLancamento = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.lblLancamento = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.grbLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.btnContinuar);
            this.grbInformacoes.Controls.Add(this.txbCodProduto);
            this.grbInformacoes.Controls.Add(this.txbComanda);
            this.grbInformacoes.Controls.Add(this.lblCodProduto);
            this.grbInformacoes.Controls.Add(this.lblComandaInformacoes);
            this.grbInformacoes.Location = new System.Drawing.Point(40, 79);
            this.grbInformacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbInformacoes.Size = new System.Drawing.Size(263, 215);
            this.grbInformacoes.TabIndex = 0;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(21, 119);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(216, 57);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Location = new System.Drawing.Point(109, 80);
            this.txbCodProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(128, 22);
            this.txbCodProduto.TabIndex = 3;
            // 
            // txbComanda
            // 
            this.txbComanda.Location = new System.Drawing.Point(109, 43);
            this.txbComanda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(128, 22);
            this.txbComanda.TabIndex = 2;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.Location = new System.Drawing.Point(30, 78);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(73, 21);
            this.lblCodProduto.TabIndex = 1;
            this.lblCodProduto.Text = "Produto:";
            // 
            // lblComandaInformacoes
            // 
            this.lblComandaInformacoes.AutoSize = true;
            this.lblComandaInformacoes.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandaInformacoes.Location = new System.Drawing.Point(17, 43);
            this.lblComandaInformacoes.Name = "lblComandaInformacoes";
            this.lblComandaInformacoes.Size = new System.Drawing.Size(86, 21);
            this.lblComandaInformacoes.TabIndex = 0;
            this.lblComandaInformacoes.Text = "Comanda:";
            // 
            // dgvComandas
            // 
            this.dgvComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComandas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(350, 70);
            this.dgvComandas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(388, 436);
            this.dgvComandas.TabIndex = 1;
            this.dgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellClick);
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.btnCancelar);
            this.grbLancamento.Controls.Add(this.txbQuantidade);
            this.grbLancamento.Controls.Add(this.txbProdutos);
            this.grbLancamento.Controls.Add(this.lblQuantidadeLancamento);
            this.grbLancamento.Controls.Add(this.lblProdutoLancamento);
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Location = new System.Drawing.Point(40, 318);
            this.grbLancamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbLancamento.Size = new System.Drawing.Size(263, 207);
            this.grbLancamento.TabIndex = 2;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamento";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(109, 82);
            this.txbQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(128, 22);
            this.txbQuantidade.TabIndex = 4;
            // 
            // txbProdutos
            // 
            this.txbProdutos.Location = new System.Drawing.Point(109, 44);
            this.txbProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbProdutos.Name = "txbProdutos";
            this.txbProdutos.ReadOnly = true;
            this.txbProdutos.Size = new System.Drawing.Size(128, 22);
            this.txbProdutos.TabIndex = 3;
            // 
            // lblQuantidadeLancamento
            // 
            this.lblQuantidadeLancamento.AutoSize = true;
            this.lblQuantidadeLancamento.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeLancamento.Location = new System.Drawing.Point(13, 83);
            this.lblQuantidadeLancamento.Name = "lblQuantidadeLancamento";
            this.lblQuantidadeLancamento.Size = new System.Drawing.Size(101, 21);
            this.lblQuantidadeLancamento.TabIndex = 2;
            this.lblQuantidadeLancamento.Text = "Quantidade:";
            // 
            // lblProdutoLancamento
            // 
            this.lblProdutoLancamento.AutoSize = true;
            this.lblProdutoLancamento.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoLancamento.Location = new System.Drawing.Point(35, 42);
            this.lblProdutoLancamento.Name = "lblProdutoLancamento";
            this.lblProdutoLancamento.Size = new System.Drawing.Size(73, 21);
            this.lblProdutoLancamento.TabIndex = 1;
            this.lblProdutoLancamento.Text = "Produto:";
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(21, 112);
            this.btnLancar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(220, 36);
            this.btnLancar.TabIndex = 0;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // lblLancamento
            // 
            this.lblLancamento.AutoSize = true;
            this.lblLancamento.BackColor = System.Drawing.SystemColors.Info;
            this.lblLancamento.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancamento.Location = new System.Drawing.Point(35, 22);
            this.lblLancamento.Name = "lblLancamento";
            this.lblLancamento.Size = new System.Drawing.Size(262, 28);
            this.lblLancamento.TabIndex = 3;
            this.lblLancamento.Text = "Lançamento de comandas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(21, 156);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(220, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(766, 565);
            this.Controls.Add(this.lblLancamento);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.dgvComandas);
            this.Controls.Add(this.grbInformacoes);
            this.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComandas";
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Label lblComandaInformacoes;
        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbProdutos;
        private System.Windows.Forms.Label lblQuantidadeLancamento;
        private System.Windows.Forms.Label lblProdutoLancamento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Label lblLancamento;
        private System.Windows.Forms.Button btnCancelar;
    }
}