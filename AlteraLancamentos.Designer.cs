
namespace FinancesResource
{
    partial class AlteraLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlteraLancamentos));
            this.lblSelecione = new System.Windows.Forms.Label();
            this.ddlMesAltera = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescriptionAltera = new System.Windows.Forms.TextBox();
            this.btnInsertAltera = new System.Windows.Forms.Button();
            this.txtVencimentoAltera = new System.Windows.Forms.MaskedTextBox();
            this.txtValueAltera = new System.Windows.Forms.MaskedTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(12, 65);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(159, 23);
            this.lblSelecione.TabIndex = 0;
            this.lblSelecione.Text = "Selecione o mes";
            // 
            // ddlMesAltera
            // 
            this.ddlMesAltera.AllowDrop = true;
            this.ddlMesAltera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMesAltera.FormattingEnabled = true;
            this.ddlMesAltera.Items.AddRange(new object[] {
            "Selecione",
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.ddlMesAltera.Location = new System.Drawing.Point(363, 64);
            this.ddlMesAltera.Name = "ddlMesAltera";
            this.ddlMesAltera.Size = new System.Drawing.Size(182, 24);
            this.ddlMesAltera.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOffToolStripMenuItem});
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.logOffToolStripMenuItem.Text = "Log Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vencimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor";
            // 
            // txtDescriptionAltera
            // 
            this.txtDescriptionAltera.Location = new System.Drawing.Point(363, 127);
            this.txtDescriptionAltera.Name = "txtDescriptionAltera";
            this.txtDescriptionAltera.Size = new System.Drawing.Size(182, 22);
            this.txtDescriptionAltera.TabIndex = 6;
            // 
            // btnInsertAltera
            // 
            this.btnInsertAltera.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertAltera.Location = new System.Drawing.Point(574, 354);
            this.btnInsertAltera.Name = "btnInsertAltera";
            this.btnInsertAltera.Size = new System.Drawing.Size(192, 47);
            this.btnInsertAltera.TabIndex = 9;
            this.btnInsertAltera.Text = "Alterar";
            this.btnInsertAltera.UseVisualStyleBackColor = true;
            this.btnInsertAltera.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtVencimentoAltera
            // 
            this.txtVencimentoAltera.Location = new System.Drawing.Point(363, 185);
            this.txtVencimentoAltera.Mask = "00/00/0000";
            this.txtVencimentoAltera.Name = "txtVencimentoAltera";
            this.txtVencimentoAltera.Size = new System.Drawing.Size(182, 22);
            this.txtVencimentoAltera.TabIndex = 10;
            this.txtVencimentoAltera.ValidatingType = typeof(System.DateTime);
            // 
            // txtValueAltera
            // 
            this.txtValueAltera.Location = new System.Drawing.Point(363, 245);
            this.txtValueAltera.Name = "txtValueAltera";
            this.txtValueAltera.Size = new System.Drawing.Size(182, 22);
            this.txtValueAltera.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(15, 301);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 24);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // ddlStatus
            // 
            this.ddlStatus.AllowDrop = true;
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "Selecione",
            "A Vencer",
            "Vencendo",
            "Vencido",
            "Pago",
            "Lancado"});
            this.ddlStatus.Location = new System.Drawing.Point(363, 301);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(182, 24);
            this.ddlStatus.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(19, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(192, 47);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AlteraLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 451);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtValueAltera);
            this.Controls.Add(this.txtVencimentoAltera);
            this.Controls.Add(this.btnInsertAltera);
            this.Controls.Add(this.txtDescriptionAltera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlMesAltera);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlteraLancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altera Lancamentos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox ddlMesAltera;
        public System.Windows.Forms.TextBox txtDescriptionAltera;
        public System.Windows.Forms.Button btnInsertAltera;
        public System.Windows.Forms.MaskedTextBox txtVencimentoAltera;
        public System.Windows.Forms.MaskedTextBox txtValueAltera;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.ComboBox ddlStatus;
        public System.Windows.Forms.Button btnBack;
    }
}