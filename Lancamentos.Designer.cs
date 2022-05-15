
namespace FinancesResource
{
    partial class Lancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lancamentos));
            this.lblSelecione = new System.Windows.Forms.Label();
            this.ddlMes = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtVencimento = new System.Windows.Forms.MaskedTextBox();
            this.txtValue = new System.Windows.Forms.MaskedTextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblRenda = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
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
            // ddlMes
            // 
            this.ddlMes.AllowDrop = true;
            this.ddlMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMes.FormattingEnabled = true;
            this.ddlMes.Items.AddRange(new object[] {
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
            this.ddlMes.Location = new System.Drawing.Point(363, 64);
            this.ddlMes.Name = "ddlMes";
            this.ddlMes.Size = new System.Drawing.Size(182, 24);
            this.ddlMes.TabIndex = 1;
            this.ddlMes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 28);
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
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(363, 127);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(182, 22);
            this.txtDescription.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(363, 370);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(192, 47);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Incluir";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtVencimento
            // 
            this.txtVencimento.Location = new System.Drawing.Point(363, 185);
            this.txtVencimento.Mask = "00/00/0000";
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(182, 22);
            this.txtVencimento.TabIndex = 10;
            this.txtVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(363, 245);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(182, 22);
            this.txtValue.TabIndex = 11;
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(586, 370);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(192, 47);
            this.btnFinish.TabIndex = 12;
            this.btnFinish.Text = "Consultar";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblRenda
            // 
            this.lblRenda.AutoSize = true;
            this.lblRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenda.Location = new System.Drawing.Point(15, 299);
            this.lblRenda.Name = "lblRenda";
            this.lblRenda.Size = new System.Drawing.Size(129, 20);
            this.lblRenda.TabIndex = 13;
            this.lblRenda.Text = "Renda Liquida";
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(363, 299);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(182, 22);
            this.txtRenda.TabIndex = 14;
            // 
            // Lancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(790, 442);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.lblRenda);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlMes);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lancamentos";
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
        private System.Windows.Forms.Label lblRenda;
        public System.Windows.Forms.ComboBox ddlMes;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.MaskedTextBox txtVencimento;
        public System.Windows.Forms.MaskedTextBox txtValue;
        public System.Windows.Forms.Button btnFinish;
        public System.Windows.Forms.TextBox txtRenda;
    }
}