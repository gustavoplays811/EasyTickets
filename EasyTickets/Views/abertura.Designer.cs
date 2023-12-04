namespace EasyTickets.Views
{
    partial class Abertura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abertura));
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.btnCentral = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGVEventosViews = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEventosViews)).BeginInit();
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
            this.btnCentral.BackColor = System.Drawing.Color.Black;
            this.btnCentral.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCentral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCentral.Location = new System.Drawing.Point(671, 415);
            this.btnCentral.Name = "btnCentral";
            this.btnCentral.Size = new System.Drawing.Size(117, 23);
            this.btnCentral.TabIndex = 1;
            this.btnCentral.Text = "Compra de ingresso";
            this.btnCentral.UseVisualStyleBackColor = false;
            this.btnCentral.Click += new System.EventHandler(this.btnCentral_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eventos disponíveis:";
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(732, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DGVEventosViews
            // 
            this.DGVEventosViews.AllowUserToAddRows = false;
            this.DGVEventosViews.AllowUserToDeleteRows = false;
            this.DGVEventosViews.AllowUserToResizeColumns = false;
            this.DGVEventosViews.AllowUserToResizeRows = false;
            this.DGVEventosViews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVEventosViews.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVEventosViews.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGVEventosViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEventosViews.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGVEventosViews.Location = new System.Drawing.Point(171, 114);
            this.DGVEventosViews.Name = "DGVEventosViews";
            this.DGVEventosViews.Size = new System.Drawing.Size(463, 274);
            this.DGVEventosViews.TabIndex = 11;
            this.DGVEventosViews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEventosViews_CellContentClick);
            // 
            // Abertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVEventosViews);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCentral);
            this.Controls.Add(this.lblSaudacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Abertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura";
            this.Activated += new System.EventHandler(this.Abertura_Activated);
            this.Load += new System.EventHandler(this.Abertura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEventosViews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.Button btnCentral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGVEventosViews;
    }
}