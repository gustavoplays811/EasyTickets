namespace EasyTickets.Views
{
    partial class ControleDeVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleDeVendas));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCompIngre = new System.Windows.Forms.Label();
            this.grbAddCompra = new System.Windows.Forms.GroupBox();
            this.txbIdShow = new System.Windows.Forms.TextBox();
            this.lblidshow = new System.Windows.Forms.Label();
            this.cmbQtdIngressos = new System.Windows.Forms.ComboBox();
            this.lblPag = new System.Windows.Forms.Label();
            this.lblQTDingr = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNomeShow = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.DgvEventos = new System.Windows.Forms.DataGridView();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbUsuarios = new System.Windows.Forms.GroupBox();
            this.txbIdCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbNomeUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbAddCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.ForeColor = System.Drawing.Color.Red;
            this.btnVoltar.Location = new System.Drawing.Point(12, 577);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCompIngre
            // 
            this.lblCompIngre.AutoSize = true;
            this.lblCompIngre.BackColor = System.Drawing.Color.Transparent;
            this.lblCompIngre.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompIngre.ForeColor = System.Drawing.Color.LightGray;
            this.lblCompIngre.Location = new System.Drawing.Point(225, 45);
            this.lblCompIngre.Name = "lblCompIngre";
            this.lblCompIngre.Size = new System.Drawing.Size(342, 42);
            this.lblCompIngre.TabIndex = 3;
            this.lblCompIngre.Text = "Compra de ingresso";
            // 
            // grbAddCompra
            // 
            this.grbAddCompra.BackColor = System.Drawing.Color.Transparent;
            this.grbAddCompra.Controls.Add(this.txbIdShow);
            this.grbAddCompra.Controls.Add(this.lblidshow);
            this.grbAddCompra.Controls.Add(this.cmbQtdIngressos);
            this.grbAddCompra.Controls.Add(this.lblPag);
            this.grbAddCompra.Controls.Add(this.lblQTDingr);
            this.grbAddCompra.Controls.Add(this.txbData);
            this.grbAddCompra.Controls.Add(this.txbNome);
            this.grbAddCompra.Controls.Add(this.lblPreco);
            this.grbAddCompra.Controls.Add(this.lblNomeShow);
            this.grbAddCompra.ForeColor = System.Drawing.Color.White;
            this.grbAddCompra.Location = new System.Drawing.Point(418, 362);
            this.grbAddCompra.Name = "grbAddCompra";
            this.grbAddCompra.Size = new System.Drawing.Size(377, 180);
            this.grbAddCompra.TabIndex = 4;
            this.grbAddCompra.TabStop = false;
            this.grbAddCompra.Text = "Escolha sua compra";
            this.grbAddCompra.Enter += new System.EventHandler(this.grbAddCompra_Enter);
            // 
            // txbIdShow
            // 
            this.txbIdShow.Location = new System.Drawing.Point(209, 96);
            this.txbIdShow.Name = "txbIdShow";
            this.txbIdShow.Size = new System.Drawing.Size(100, 20);
            this.txbIdShow.TabIndex = 9;
            // 
            // lblidshow
            // 
            this.lblidshow.AutoSize = true;
            this.lblidshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidshow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblidshow.Location = new System.Drawing.Point(7, 97);
            this.lblidshow.Name = "lblidshow";
            this.lblidshow.Size = new System.Drawing.Size(81, 16);
            this.lblidshow.TabIndex = 8;
            this.lblidshow.Text = "Id do show";
            // 
            // cmbQtdIngressos
            // 
            this.cmbQtdIngressos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbQtdIngressos.FormattingEnabled = true;
            this.cmbQtdIngressos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQtdIngressos.Location = new System.Drawing.Point(209, 68);
            this.cmbQtdIngressos.Name = "cmbQtdIngressos";
            this.cmbQtdIngressos.Size = new System.Drawing.Size(100, 21);
            this.cmbQtdIngressos.TabIndex = 6;
            this.cmbQtdIngressos.SelectedIndexChanged += new System.EventHandler(this.cmbQtdIngressos_SelectedIndexChanged);
            // 
            // lblPag
            // 
            this.lblPag.AutoSize = true;
            this.lblPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPag.Location = new System.Drawing.Point(222, 139);
            this.lblPag.Name = "lblPag";
            this.lblPag.Size = new System.Drawing.Size(70, 20);
            this.lblPag.TabIndex = 6;
            this.lblPag.Text = "R$00,00";
            // 
            // lblQTDingr
            // 
            this.lblQTDingr.AutoSize = true;
            this.lblQTDingr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQTDingr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQTDingr.Location = new System.Drawing.Point(7, 68);
            this.lblQTDingr.Name = "lblQTDingr";
            this.lblQTDingr.Size = new System.Drawing.Size(181, 16);
            this.lblQTDingr.TabIndex = 7;
            this.lblQTDingr.Text = "Quantidade de ingressos";
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(209, 42);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(100, 20);
            this.txbData.TabIndex = 4;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(209, 16);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 3;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPreco.Location = new System.Drawing.Point(7, 38);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(171, 16);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Data do show desejado";
            // 
            // lblNomeShow
            // 
            this.lblNomeShow.AutoSize = true;
            this.lblNomeShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomeShow.Location = new System.Drawing.Point(7, 16);
            this.lblNomeShow.Name = "lblNomeShow";
            this.lblNomeShow.Size = new System.Drawing.Size(181, 16);
            this.lblNomeShow.TabIndex = 0;
            this.lblNomeShow.Text = "Nome do Show desejado";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Black;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Lime;
            this.btnConfirmar.Location = new System.Drawing.Point(679, 574);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 26);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confimar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // DgvEventos
            // 
            this.DgvEventos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEventos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvEventos.Location = new System.Drawing.Point(418, 119);
            this.DgvEventos.Name = "DgvEventos";
            this.DgvEventos.Size = new System.Drawing.Size(377, 200);
            this.DgvEventos.TabIndex = 5;
            this.DgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEventos_CellClick);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 119);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(380, 200);
            this.dgvUsuarios.TabIndex = 7;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // grbUsuarios
            // 
            this.grbUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.grbUsuarios.Controls.Add(this.txbIdCliente);
            this.grbUsuarios.Controls.Add(this.lblCliente);
            this.grbUsuarios.Controls.Add(this.txbEmail);
            this.grbUsuarios.Controls.Add(this.txbNomeUsuario);
            this.grbUsuarios.Controls.Add(this.label2);
            this.grbUsuarios.Controls.Add(this.label3);
            this.grbUsuarios.ForeColor = System.Drawing.Color.White;
            this.grbUsuarios.Location = new System.Drawing.Point(12, 362);
            this.grbUsuarios.Name = "grbUsuarios";
            this.grbUsuarios.Size = new System.Drawing.Size(380, 180);
            this.grbUsuarios.TabIndex = 8;
            this.grbUsuarios.TabStop = false;
            this.grbUsuarios.Text = "Qual usuario?";
            // 
            // txbIdCliente
            // 
            this.txbIdCliente.Location = new System.Drawing.Point(209, 34);
            this.txbIdCliente.Name = "txbIdCliente";
            this.txbIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txbIdCliente.TabIndex = 6;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCliente.Location = new System.Drawing.Point(6, 34);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(97, 16);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Id do usuário";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(209, 96);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEmail.TabIndex = 4;
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
            // 
            // txbNomeUsuario
            // 
            this.txbNomeUsuario.Location = new System.Drawing.Point(209, 63);
            this.txbNomeUsuario.Name = "txbNomeUsuario";
            this.txbNomeUsuario.Size = new System.Drawing.Size(100, 20);
            this.txbNomeUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome do Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ControleDeVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 612);
            this.Controls.Add(this.grbUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.DgvEventos);
            this.Controls.Add(this.grbAddCompra);
            this.Controls.Add(this.lblCompIngre);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControleDeVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleDeVendas";
            this.Load += new System.EventHandler(this.ControleDeVendas_Load);
            this.grbAddCompra.ResumeLayout(false);
            this.grbAddCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbUsuarios.ResumeLayout(false);
            this.grbUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCompIngre;
        private System.Windows.Forms.GroupBox grbAddCompra;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNomeShow;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblQTDingr;
        private System.Windows.Forms.DataGridView DgvEventos;
        private System.Windows.Forms.ComboBox cmbQtdIngressos;
        private System.Windows.Forms.Label lblPag;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbUsuarios;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbNomeUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIdCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txbIdShow;
        private System.Windows.Forms.Label lblidshow;
    }
}