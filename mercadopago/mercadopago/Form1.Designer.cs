namespace mercadopago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.qrCode = new System.Windows.Forms.PictureBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.btnCriarTerminal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQrCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(108, 100);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(150, 32);
            this.txtValor.TabIndex = 1;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(285, 92);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(140, 47);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "Requisição";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(441, 92);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(140, 47);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // qrCode
            // 
            this.qrCode.BackColor = System.Drawing.Color.Transparent;
            this.qrCode.Location = new System.Drawing.Point(650, 65);
            this.qrCode.Name = "qrCode";
            this.qrCode.Size = new System.Drawing.Size(150, 150);
            this.qrCode.TabIndex = 4;
            this.qrCode.TabStop = false;
            // 
            // txtPedido
            // 
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(108, 45);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(150, 32);
            this.txtPedido.TabIndex = 5;
            // 
            // btnCriarTerminal
            // 
            this.btnCriarTerminal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCriarTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarTerminal.Location = new System.Drawing.Point(21, 264);
            this.btnCriarTerminal.Name = "btnCriarTerminal";
            this.btnCriarTerminal.Size = new System.Drawing.Size(231, 47);
            this.btnCriarTerminal.TabIndex = 6;
            this.btnCriarTerminal.Text = "Criar Terminal";
            this.btnCriarTerminal.UseVisualStyleBackColor = false;
            this.btnCriarTerminal.Click += new System.EventHandler(this.btnCriarTerminal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pedido:";
            // 
            // btnQrCode
            // 
            this.btnQrCode.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQrCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQrCode.Location = new System.Drawing.Point(650, 12);
            this.btnQrCode.Name = "btnQrCode";
            this.btnQrCode.Size = new System.Drawing.Size(150, 47);
            this.btnQrCode.TabIndex = 9;
            this.btnQrCode.Text = "qrCode";
            this.btnQrCode.UseVisualStyleBackColor = false;
            this.btnQrCode.Click += new System.EventHandler(this.btnQrCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::mercadopago.Properties.Resources.mercadopago_integrado_pluga;
            this.ClientSize = new System.Drawing.Size(812, 323);
            this.Controls.Add(this.btnQrCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriarTerminal);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.qrCode);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtValor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercado Pago - Testes dos Métodos - Ambiente de Homologação - 2020.09.10";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.PictureBox qrCode;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Button btnCriarTerminal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQrCode;
    }
}

