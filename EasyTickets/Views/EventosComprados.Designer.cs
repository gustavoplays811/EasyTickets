namespace EasyTickets.Views
{
    partial class EventosComprados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventosComprados));
            this.dgvAdicionarShow = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.txbPrecoShow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbLocalShow = new System.Windows.Forms.TextBox();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.txbDataShow = new System.Windows.Forms.TextBox();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.txbNomeShow = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.txbEditPrecoShow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbEditLocalShow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEditDataShow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEditNomeShow = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionarShow)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdicionarShow
            // 
            this.dgvAdicionarShow.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAdicionarShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdicionarShow.Location = new System.Drawing.Point(106, 12);
            this.dgvAdicionarShow.Name = "dgvAdicionarShow";
            this.dgvAdicionarShow.Size = new System.Drawing.Size(577, 195);
            this.dgvAdicionarShow.TabIndex = 7;
            this.dgvAdicionarShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdicionarShow_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.BackColor = System.Drawing.Color.Transparent;
            this.grbCadastro.Controls.Add(this.txbPrecoShow);
            this.grbCadastro.Controls.Add(this.label1);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbLocalShow);
            this.grbCadastro.Controls.Add(this.lblSenhaCad);
            this.grbCadastro.Controls.Add(this.txbDataShow);
            this.grbCadastro.Controls.Add(this.lblEmailCad);
            this.grbCadastro.Controls.Add(this.txbNomeShow);
            this.grbCadastro.Controls.Add(this.lblNome);
            this.grbCadastro.Location = new System.Drawing.Point(106, 239);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(252, 201);
            this.grbCadastro.TabIndex = 8;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // txbPrecoShow
            // 
            this.txbPrecoShow.Location = new System.Drawing.Point(110, 98);
            this.txbPrecoShow.Name = "txbPrecoShow";
            this.txbPrecoShow.Size = new System.Drawing.Size(79, 20);
            this.txbPrecoShow.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Preço do Show";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Location = new System.Drawing.Point(110, 128);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(79, 39);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbLocalShow
            // 
            this.txbLocalShow.Location = new System.Drawing.Point(110, 69);
            this.txbLocalShow.Name = "txbLocalShow";
            this.txbLocalShow.Size = new System.Drawing.Size(79, 20);
            this.txbLocalShow.TabIndex = 5;
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSenhaCad.Location = new System.Drawing.Point(19, 72);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(78, 13);
            this.lblSenhaCad.TabIndex = 4;
            this.lblSenhaCad.Text = "Local do Show";
            // 
            // txbDataShow
            // 
            this.txbDataShow.Location = new System.Drawing.Point(110, 45);
            this.txbDataShow.Name = "txbDataShow";
            this.txbDataShow.Size = new System.Drawing.Size(79, 20);
            this.txbDataShow.TabIndex = 3;
            this.txbDataShow.TextChanged += new System.EventHandler(this.txbEmailCad_TextChanged);
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmailCad.Location = new System.Drawing.Point(19, 48);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(75, 13);
            this.lblEmailCad.TabIndex = 2;
            this.lblEmailCad.Text = "Data do Show";
            // 
            // txbNomeShow
            // 
            this.txbNomeShow.Location = new System.Drawing.Point(110, 19);
            this.txbNomeShow.Name = "txbNomeShow";
            this.txbNomeShow.Size = new System.Drawing.Size(79, 20);
            this.txbNomeShow.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Location = new System.Drawing.Point(19, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(80, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Show";
            // 
            // grbApagar
            // 
            this.grbApagar.BackColor = System.Drawing.Color.Transparent;
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grbApagar.Location = new System.Drawing.Point(201, 457);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(464, 58);
            this.grbApagar.TabIndex = 9;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Black;
            this.btnApagar.Location = new System.Drawing.Point(364, 17);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 35);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApagar.Location = new System.Drawing.Point(16, 29);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(217, 16);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione um usuário para apagar.";
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.Color.Transparent;
            this.grbEditar.Controls.Add(this.txbEditPrecoShow);
            this.grbEditar.Controls.Add(this.label2);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbEditLocalShow);
            this.grbEditar.Controls.Add(this.label3);
            this.grbEditar.Controls.Add(this.txbEditDataShow);
            this.grbEditar.Controls.Add(this.label4);
            this.grbEditar.Controls.Add(this.txbEditNomeShow);
            this.grbEditar.Controls.Add(this.label5);
            this.grbEditar.Location = new System.Drawing.Point(431, 239);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(252, 201);
            this.grbEditar.TabIndex = 9;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // txbEditPrecoShow
            // 
            this.txbEditPrecoShow.Location = new System.Drawing.Point(110, 98);
            this.txbEditPrecoShow.Name = "txbEditPrecoShow";
            this.txbEditPrecoShow.Size = new System.Drawing.Size(79, 20);
            this.txbEditPrecoShow.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preço do Show";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(110, 128);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(79, 39);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbEditLocalShow
            // 
            this.txbEditLocalShow.Location = new System.Drawing.Point(110, 69);
            this.txbEditLocalShow.Name = "txbEditLocalShow";
            this.txbEditLocalShow.Size = new System.Drawing.Size(79, 20);
            this.txbEditLocalShow.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(19, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local do Show";
            // 
            // txbEditDataShow
            // 
            this.txbEditDataShow.Location = new System.Drawing.Point(110, 45);
            this.txbEditDataShow.Name = "txbEditDataShow";
            this.txbEditDataShow.Size = new System.Drawing.Size(79, 20);
            this.txbEditDataShow.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(19, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data do Show";
            // 
            // txbEditNomeShow
            // 
            this.txbEditNomeShow.Location = new System.Drawing.Point(110, 19);
            this.txbEditNomeShow.Name = "txbEditNomeShow";
            this.txbEditNomeShow.Size = new System.Drawing.Size(79, 20);
            this.txbEditNomeShow.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome do Show";
            // 
            // EventosComprados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 537);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvAdicionarShow);
            this.Name = "EventosComprados";
            this.Text = "EventosComprados";
            this.Load += new System.EventHandler(this.EventosComprados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionarShow)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdicionarShow;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbLocalShow;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.TextBox txbDataShow;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.TextBox txbNomeShow;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.TextBox txbPrecoShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.TextBox txbEditPrecoShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbEditLocalShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEditDataShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEditNomeShow;
        private System.Windows.Forms.Label label5;
    }
}