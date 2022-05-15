using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancesResource
{
    public partial class Lancamentos : Form
    {
        Thread t1;
        DataTable dt = new DataTable();
        DataTable dr = new DataTable();
        public Lancamentos()
        {
            InitializeComponent();
            ddlMes.SelectedIndex = 0;
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO TB_GASTOS (TXT_DESCRICAO, DIA_VENCIMENTO, VALOR_GASTO, MES, ID_USER) VALUES(" + "'" + txtDescription.Text + "'," + "'" + txtVencimento.Text + "'," + "'" + txtValue.Text + "'," + "'" + ddlMes.Text + "'" + "," + Global.ID.ToString() + ")";
            dt = DataBase.insert(sql);

            if (!string.IsNullOrEmpty(txtRenda.Text.ToString()))
            {
                string sqlRenda = "INSERT INTO TB_RENDA_LIQUIDA(VALOR_RENDA_LIQUIDA, MES_RENDA_LIQUIDA, ID_USER) VALUES(" + "'" + txtRenda.Text + "', " + "'" + ddlMes.Text + "'" + "," + Global.ID.ToString() + ")";
                dr = DataBase.insert(sqlRenda);
            }

            if (!dt.HasErrors && !dr.HasErrors)
            {
                MessageBox.Show("Inserido com sucesso!");
                txtDescription.Text = "";
                txtVencimento.Text = "";
                txtValue.Text = "";
                txtRenda.Text = "";
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openLancado);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public void openLancado()
        {
            Application.Run(new Lancados());
        }
    }
}
