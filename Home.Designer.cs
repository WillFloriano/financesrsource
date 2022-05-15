
namespace FinancesResource
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlAcesso = new System.Windows.Forms.Panel();
            this.lblSuporte = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnInside = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAcesso.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAcesso
            // 
            this.pnlAcesso.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlAcesso.Controls.Add(this.lblSuporte);
            this.pnlAcesso.Controls.Add(this.lblUserName);
            this.pnlAcesso.Controls.Add(this.lblNivel);
            this.pnlAcesso.Controls.Add(this.pictureBox1);
            this.pnlAcesso.Controls.Add(this.lblUser);
            this.pnlAcesso.Controls.Add(this.lblAcesso);
            this.pnlAcesso.Location = new System.Drawing.Point(5, 376);
            this.pnlAcesso.Name = "pnlAcesso";
            this.pnlAcesso.Size = new System.Drawing.Size(773, 54);
            this.pnlAcesso.TabIndex = 0;
            // 
            // lblSuporte
            // 
            this.lblSuporte.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSuporte.Enabled = false;
            this.lblSuporte.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSuporte.Location = new System.Drawing.Point(478, 21);
            this.lblSuporte.Name = "lblSuporte";
            this.lblSuporte.Size = new System.Drawing.Size(292, 30);
            this.lblSuporte.TabIndex = 5;
            this.lblSuporte.Text = "Suporte@wftecnology.com.br";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(246, 22);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(31, 23);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "---";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(126, 22);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(22, 23);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "0";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(154, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(86, 23);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario:";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Location = new System.Drawing.Point(40, 21);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(80, 23);
            this.lblAcesso.TabIndex = 1;
            this.lblAcesso.Text = "Acesso:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOfToolStripMenuItem});
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // logOfToolStripMenuItem
            // 
            this.logOfToolStripMenuItem.Name = "logOfToolStripMenuItem";
            this.logOfToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.logOfToolStripMenuItem.Text = "Logoff";
            this.logOfToolStripMenuItem.Click += new System.EventHandler(this.logOfToolStripMenuItem_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(26, 55);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(731, 224);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Inclua e gerencie seus gastos mensais";
            // 
            // btnInside
            // 
            this.btnInside.Location = new System.Drawing.Point(30, 293);
            this.btnInside.Name = "btnInside";
            this.btnInside.Size = new System.Drawing.Size(234, 56);
            this.btnInside.TabIndex = 3;
            this.btnInside.Text = "Incluir";
            this.btnInside.UseVisualStyleBackColor = true;
            this.btnInside.Click += new System.EventHandler(this.btnInside_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(487, 293);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(234, 56);
            this.btnConsult.TabIndex = 4;
            this.btnConsult.Text = "Consultar";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinancesResource.Properties.Resources.ledverde;
            this.pictureBox1.Location = new System.Drawing.Point(11, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(790, 442);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.btnInside);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pnlAcesso);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("NanumGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finances Resource - vs 1.0";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlAcesso.ResumeLayout(false);
            this.pnlAcesso.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlAcesso;
        public System.Windows.Forms.Label lblUserName;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblNivel;
        public System.Windows.Forms.Label lblAcesso;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOfToolStripMenuItem;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnInside;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Label lblSuporte;
    }
}