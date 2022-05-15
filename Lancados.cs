using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinancesResource.Enum;

namespace FinancesResource
{
    public partial class Lancados : Form
    {
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;
        DataTable dt = new DataTable();
        DataTable dv = new DataTable();
        DataTable di = new DataTable();
        DataTable de = new DataTable();

        AlteraLancamentos alteraLancamentos = new AlteraLancamentos();

        public Lancados()
        {
            InitializeComponent();
            ddlMes.SelectedIndex = 0;
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 6;

                DataGridViewImageColumn dtimg = new DataGridViewImageColumn();
                dtimg.Image = Properties.Resources.alterar;
                dtimg.Name = "EDITAR";

                DataGridViewImageColumn dtimg2 = new DataGridViewImageColumn();
                dtimg2.Image = Properties.Resources.excluir;
                dtimg2.Name = "EXCLUIR";

                if (ddlMes.Text.Contains("Selecione"))
                {
                    var sql1 = "SELECT ID_GASTO AS ID, TXT_DESCRICAO AS DESCRICAO, DIA_VENCIMENTO AS VENCIMENTO, VALOR_GASTO AS VALOR, STATUS AS STATUS FROM TB_GASTOS";
                    dt = DataBase.request(sql1);

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        dataGridView1.Columns[i].Name = dt.Columns[i].ToString();
                    }

                    //dataGridView1.Columns[4].Name = "STATUS";
                    dataGridView1.Columns.Add(dtimg);
                    dataGridView1.Columns.Add(dtimg2);
                    dataGridView1.Columns["ID"].Visible = false;                    
                }
                else
                {
                    var sql = "SELECT ID_GASTO AS ID, TXT_DESCRICAO AS DESCRICAO, DIA_VENCIMENTO AS VENCIMENTO, VALOR_GASTO AS VALOR, STATUS AS STATUS, ID_USER AS USER FROM TB_GASTOS WHERE MES = '" + ddlMes.Text + "' AND ID_USER = " + Global.ID.ToString();
                    dt = DataBase.request(sql);

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        dataGridView1.Columns[i].Name = dt.Columns[i].ToString();
                    }

                    //dataGridView1.Columns[4].Name = "STATUS";
                    dataGridView1.Columns.Add(dtimg);
                    dataGridView1.Columns.Add(dtimg2);
                    dataGridView1.Columns["ID"].Visible = false;
                    dataGridView1.Columns["USER"].Visible = false;

                    string strStatus = string.Empty;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DateTime DiaVencimento = Convert.ToDateTime(dt.Rows[i].ItemArray[2].ToString());
                        DateTime DiaAtual = DateTime.Today;

                        if (!dt.Rows[i].ItemArray[4].ToString().Contains("4") && !dt.Rows[i].ItemArray[4].ToString().Contains("5"))
                        {

                            if (DiaVencimento == DiaAtual)
                            {
                                strStatus = StatusPagamento.Vencendo.ToString();
                            }
                            else if (DiaVencimento < DiaAtual)
                            {
                                strStatus = StatusPagamento.Vencido.ToString();
                            }
                            else if (DiaVencimento >= DiaAtual)
                            {
                                strStatus = StatusPagamento.AVencer.ToString();
                            }

                            dataGridView1.Rows.Add(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), dt.Rows[i].ItemArray[2].ToString(), dt.Rows[i].ItemArray[3].ToString(), strStatus);
                        }
                        else if (dt.Rows[i].ItemArray[4].ToString().Contains("4"))
                        {
                            strStatus = StatusPagamento.Pago.ToString();
                            dataGridView1.Rows.Add(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), dt.Rows[i].ItemArray[2].ToString(), dt.Rows[i].ItemArray[3].ToString(), strStatus);
                        }
                        else
                        {
                            strStatus = StatusPagamento.Lancado.ToString();
                            dataGridView1.Rows.Add(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), dt.Rows[i].ItemArray[2].ToString(), dt.Rows[i].ItemArray[3].ToString(), strStatus);
                        }
                    }

                    var sqlTotal = "SELECT SUM(VALOR_GASTO) FROM TB_GASTOS WHERE MES = '" + ddlMes.Text + "' AND ID_USER = " + Global.ID.ToString();
                    dv = DataBase.request(sqlTotal);

                    lblValorTotal.Text = dv.Rows[0].ItemArray[0].ToString();

                    var sqlRenda = "SELECT VALOR_RENDA_LIQUIDA FROM TB_RENDA_LIQUIDA WHERE MES_RENDA_LIQUIDA = '" + ddlMes.Text + "' AND ID_USER = " + Global.ID.ToString();
                    di = DataBase.request(sqlRenda);

                    lblValorTotal.Text = "R$ ";
                    lblValorTotal.Text += dv.Rows[0].ItemArray[0].ToString();
                    lblRendaLiquida.Text = "R$ ";
                    string strRendaLiquida = di.Rows[0].ItemArray[0].ToString();

                    lblRendaLiquida.Text += (Convert.ToDouble(strRendaLiquida) - Convert.ToDouble(lblValorTotal.Text.ToString().Replace("R$", "")));
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void openLogin()
        {
            Application.Run(new Login());
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["EDITAR"].ToolTipText = "Clique aqui para Editar";
            dataGridView1.Rows[e.RowIndex].Cells["EXCLUIR"].ToolTipText = "Clique aqui para Excluir";

            dataGridView1.Columns["VENCIMENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["VALOR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["STATUS"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dataGridView1.Columns)
            {
                switch (coluna.Name)
                {
                    case "DESCRICAO":
                        coluna.Width = 180;
                        break;
                    case "VENCIMENTO":
                        coluna.Width = 100;
                        break;
                    case "VALOR":
                        coluna.Width = 100;
                        break;
                    case "STATUS":
                        coluna.Width = 100;
                        break;
                }
            }
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idGasto;

            idGasto = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());

            try
            {
                if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["EDITAR"])
                {
                    alteraLancamentos.txtDescriptionAltera.Text = dataGridView1.Rows[e.RowIndex].Cells["DESCRICAO"].Value.ToString();
                    alteraLancamentos.txtVencimentoAltera.Text = dataGridView1.Rows[e.RowIndex].Cells["VENCIMENTO"].Value.ToString();
                    alteraLancamentos.txtValueAltera.Text = dataGridView1.Rows[e.RowIndex].Cells["VALOR"].Value.ToString();
                    alteraLancamentos.ddlMesAltera.Text = ddlMes.Text;
                    this.Close();
                    t2 = new Thread(openAlteraLancamentos);
                    t2.SetApartmentState(ApartmentState.STA);
                    t2.Start();

                }
                else if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["EXCLUIR"])
                {
                    var sqlExclui = "DELETE FROM TB_GASTOS WHERE ID_GASTO=" + idGasto;
                    de = DataBase.exclui(sqlExclui);

                    if(!de.HasErrors)
                    {
                        MessageBox.Show("Excluido com sucesso!");

                        this.Close();
                        t4 = new Thread(atualizaLancados);
                        t4.SetApartmentState(ApartmentState.STA);
                        t4.Start();
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        public void openAlteraLancamentos()
        {
            alteraLancamentos.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
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

        public void atualizaLancados()
        {
            Lancados lancados = new Lancados();
            lancados.ddlMes.SelectedIndex = ddlMes.SelectedIndex;
            lancados.dataGridView1.Columns["ID"].Visible = false;
            lancados.ShowDialog();
        }
    }
}
