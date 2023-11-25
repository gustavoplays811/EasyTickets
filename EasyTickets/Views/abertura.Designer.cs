namespace EasyTickets.Views
{
    partial class abertura
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
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.btnCentral = new System.Windows.Forms.Button();
            this.btnLateral = new System.Windows.Forms.Button();
            this.btnVip = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCentral = new System.Windows.Forms.Label();
            this.lblLateral = new System.Windows.Forms.Label();
            this.lblVip = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.BackColor = System.Drawing.Color.Transparent;
            this.lblSaudacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaudacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaudacao.Location = new System.Drawing.Point(156, 20);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(468, 25);
            this.lblSaudacao.TabIndex = 0;
            this.lblSaudacao.Text = "Bem vindo(a) a compra de ingressos online";
            // 
            // btnCentral
            // 
            this.btnCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCentral.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCentral.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCentral.Location = new System.Drawing.Point(12, 159);
            this.btnCentral.Name = "btnCentral";
            this.btnCentral.Size = new System.Drawing.Size(102, 46);
            this.btnCentral.TabIndex = 1;
            this.btnCentral.Text = "Compra de ingresso";
            this.btnCentral.UseVisualStyleBackColor = false;
            this.btnCentral.Click += new System.EventHandler(this.btnCentral_Click);
            // 
            // btnLateral
            // 
            this.btnLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLateral.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLateral.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLateral.Location = new System.Drawing.Point(12, 224);
            this.btnLateral.Name = "btnLateral";
            this.btnLateral.Size = new System.Drawing.Size(100, 55);
            this.btnLateral.TabIndex = 2;
            this.btnLateral.Text = "Eventos";
            this.btnLateral.UseVisualStyleBackColor = false;
            this.btnLateral.Click += new System.EventHandler(this.btnLateral_Click);
            // 
            // btnVip
            // 
            this.btnVip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVip.Location = new System.Drawing.Point(13, 298);
            this.btnVip.Name = "btnVip";
            this.btnVip.Size = new System.Drawing.Size(101, 48);
            this.btnVip.TabIndex = 3;
            this.btnVip.Text = "Visualizar Compras";
            this.btnVip.UseVisualStyleBackColor = false;
            this.btnVip.Click += new System.EventHandler(this.btnVip_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Black;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprar.ForeColor = System.Drawing.Color.Lime;
            this.btnComprar.Location = new System.Drawing.Point(616, 415);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(154, 23);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escolha uma das opções abaixo:";
            // 
            // lblCentral
            // 
            this.lblCentral.AutoSize = true;
            this.lblCentral.Location = new System.Drawing.Point(138, 176);
            this.lblCentral.Name = "lblCentral";
            this.lblCentral.Size = new System.Drawing.Size(40, 13);
            this.lblCentral.TabIndex = 6;
            this.lblCentral.Text = "220,00";
            // 
            // lblLateral
            // 
            this.lblLateral.AutoSize = true;
            this.lblLateral.Location = new System.Drawing.Point(138, 245);
            this.lblLateral.Name = "lblLateral";
            this.lblLateral.Size = new System.Drawing.Size(40, 13);
            this.lblLateral.TabIndex = 7;
            this.lblLateral.Text = "110,00";
            // 
            // lblVip
            // 
            this.lblVip.AutoSize = true;
            this.lblVip.Location = new System.Drawing.Point(138, 316);
            this.lblVip.Name = "lblVip";
            this.lblVip.Size = new System.Drawing.Size(40, 13);
            this.lblVip.TabIndex = 8;
            this.lblVip.Text = "500,00";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.ForeColor = System.Drawing.Color.Red;
            this.btnVoltar.Location = new System.Drawing.Point(13, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // abertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EasyTickets.Properties.Resources.coded;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblVip);
            this.Controls.Add(this.lblLateral);
            this.Controls.Add(this.lblCentral);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnVip);
            this.Controls.Add(this.btnLateral);
            this.Controls.Add(this.btnCentral);
            this.Controls.Add(this.lblSaudacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "abertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.Button btnCentral;
        private System.Windows.Forms.Button btnLateral;
        private System.Windows.Forms.Button btnVip;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCentral;
        private System.Windows.Forms.Label lblLateral;
        private System.Windows.Forms.Label lblVip;
        private System.Windows.Forms.Button btnVoltar;
    }
}