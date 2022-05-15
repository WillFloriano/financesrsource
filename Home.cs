using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FinancesResource
{
    public partial class Home : Form
    {
        Thread t1;
        Thread t2;
        public Home()
        {
            InitializeComponent();
            
            if(Global.loged == true)
            {
                lblNivel.Text = Global.acesso.ToString();
                lblUserName.Text = Global.username;
            }
        }

        private void logOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(openLogin);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnInside_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openLancamento);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public void openLancamento()
        {
            Application.Run(new Lancamentos());
        }

        public void openLancado()
        {
            Application.Run(new Lancados());
        }
        private void btnConsult_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openLancado);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        public void openLogin()
        {
            Application.Run(new Login());
        }
    }
}
