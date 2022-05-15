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
    public partial class AlteraLancamentos : Form
    {
        Thread t1;
        Thread t2;
        Thread t3;
        DataTable dt = new DataTable();
        DataTable dr = new DataTable();
        public AlteraLancamentos()
        {
            InitializeComponent();
            ddlMesAltera.SelectedIndex = 0;
            ddlStatus.SelectedIndex = 0;
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(openLogin);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE TB_GASTOS SET TXT_DESCRICAO ='" + txtDescriptionAltera.Text + "' ," + "DIA_VENCIMENTO= '" + txtVencimentoAltera.Text + "' ," + "VALOR_GASTO= '" + txtValueAltera.Text + "', STATUS= '" + ddlStatus.SelectedIndex + "' WHERE TXT_DESCRICAO= '" + txtDescriptionAltera.Text + "' AND ID_USER = " + Global.ID.ToString();
            dt = DataBase.update(sql);

            if (!dt.HasErrors)
            {
                MessageBox.Show("Alterado com sucesso!");
                this.Close();

                t1 = new Thread(openLancado);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }

        public void openLancado()
        {
            Lancados lancados = new Lancados();
            lancados.ddlMes.SelectedIndex = ddlMesAltera.SelectedIndex;
            lancados.dataGridView1.Columns["ID"].Visible = false;
            lancados.ShowDialog();

        }
        public void openLogin()
        {
            Application.Run(new Login());
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(openHome);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }
        public void openHome()
        {
            Application.Run(new Home());
        }
    }
}
