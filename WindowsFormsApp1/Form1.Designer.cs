
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbViradouro = new System.Windows.Forms.RadioButton();
            this.rdbTerraRoxa = new System.Windows.Forms.RadioButton();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.rdbDinheiro = new System.Windows.Forms.RadioButton();
            this.rdbCartao = new System.Windows.Forms.RadioButton();
            this.rdbPix = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbOutro = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(46, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(46, 160);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(110, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cidade";
            // 
            // rdbViradouro
            // 
            this.rdbViradouro.AutoSize = true;
            this.rdbViradouro.Location = new System.Drawing.Point(34, 40);
            this.rdbViradouro.Name = "rdbViradouro";
            this.rdbViradouro.Size = new System.Drawing.Size(70, 17);
            this.rdbViradouro.TabIndex = 5;
            this.rdbViradouro.TabStop = true;
            this.rdbViradouro.Text = "Viradouro";
            this.rdbViradouro.UseVisualStyleBackColor = true;
            this.rdbViradouro.CheckedChanged += new System.EventHandler(this.rdbViradouro_CheckedChanged);
            // 
            // rdbTerraRoxa
            // 
            this.rdbTerraRoxa.AutoSize = true;
            this.rdbTerraRoxa.Location = new System.Drawing.Point(142, 40);
            this.rdbTerraRoxa.Name = "rdbTerraRoxa";
            this.rdbTerraRoxa.Size = new System.Drawing.Size(78, 17);
            this.rdbTerraRoxa.TabIndex = 6;
            this.rdbTerraRoxa.TabStop = true;
            this.rdbTerraRoxa.Text = "Terra Roxa";
            this.rdbTerraRoxa.UseVisualStyleBackColor = true;
            this.rdbTerraRoxa.CheckedChanged += new System.EventHandler(this.rdbTerraRoxa_CheckedChanged);
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(44, 382);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(126, 20);
            this.dtpDataVenda.TabIndex = 7;
            this.dtpDataVenda.Value = new System.DateTime(2022, 4, 24, 21, 18, 21, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data da Venda";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(421, 302);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(98, 34);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(547, 302);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 34);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(666, 302);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 34);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(69, 77);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.ReadOnly = true;
            this.txtUnidade.Size = new System.Drawing.Size(100, 20);
            this.txtUnidade.TabIndex = 15;
            this.txtUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdbDinheiro
            // 
            this.rdbDinheiro.AutoSize = true;
            this.rdbDinheiro.Location = new System.Drawing.Point(28, 67);
            this.rdbDinheiro.Name = "rdbDinheiro";
            this.rdbDinheiro.Size = new System.Drawing.Size(64, 17);
            this.rdbDinheiro.TabIndex = 16;
            this.rdbDinheiro.TabStop = true;
            this.rdbDinheiro.Text = "Dinheiro";
            this.rdbDinheiro.UseVisualStyleBackColor = true;
            // 
            // rdbCartao
            // 
            this.rdbCartao.AutoSize = true;
            this.rdbCartao.Location = new System.Drawing.Point(104, 67);
            this.rdbCartao.Name = "rdbCartao";
            this.rdbCartao.Size = new System.Drawing.Size(56, 17);
            this.rdbCartao.TabIndex = 17;
            this.rdbCartao.TabStop = true;
            this.rdbCartao.Text = "Cartão";
            this.rdbCartao.UseVisualStyleBackColor = true;
            // 
            // rdbPix
            // 
            this.rdbPix.AutoSize = true;
            this.rdbPix.Location = new System.Drawing.Point(172, 67);
            this.rdbPix.Name = "rdbPix";
            this.rdbPix.Size = new System.Drawing.Size(42, 17);
            this.rdbPix.TabIndex = 18;
            this.rdbPix.TabStop = true;
            this.rdbPix.Text = "PIX";
            this.rdbPix.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Metodo de Pagamento";
            // 
            // rdbOutro
            // 
            this.rdbOutro.AutoSize = true;
            this.rdbOutro.Location = new System.Drawing.Point(233, 67);
            this.rdbOutro.Name = "rdbOutro";
            this.rdbOutro.Size = new System.Drawing.Size(51, 17);
            this.rdbOutro.TabIndex = 20;
            this.rdbOutro.TabStop = true;
            this.rdbOutro.Text = "Outro";
            this.rdbOutro.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Valor Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(523, 222);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(104, 20);
            this.txtTotal.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbDinheiro);
            this.panel1.Controls.Add(this.rdbOutro);
            this.panel1.Controls.Add(this.rdbCartao);
            this.panel1.Controls.Add(this.rdbPix);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(421, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 100);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUnidade);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rdbViradouro);
            this.panel2.Controls.Add(this.rdbTerraRoxa);
            this.panel2.Location = new System.Drawing.Point(12, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 103);
            this.panel2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbViradouro;
        private System.Windows.Forms.RadioButton rdbTerraRoxa;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.RadioButton rdbDinheiro;
        private System.Windows.Forms.RadioButton rdbCartao;
        private System.Windows.Forms.RadioButton rdbPix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbOutro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

