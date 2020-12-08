using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class matices : Form
    {
        Random random = new Random();
        public matices()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(txtColumnas.Text); i++)
            {
                dataGridView1.Columns.Add("Column", "Column");
                dataGridView2.Columns.Add("Column", "Column");
                dataGridView3.Columns.Add("Column", "Column");
            }
            for (int i = 0; i < int.Parse(txtRenglon.Text); i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = "Row" + i;
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;
                dataGridView3.Rows.Add();
                dataGridView3.Rows[i].HeaderCell.Value = "Row" + i;
            }
            for (int r = 0; r <int.Parse(txtRenglon.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                {
                    dataGridView1[c, r].Value = "1";
                    dataGridView2[c, r].Value = "1";
                }
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            for (int r = 0; r < int.Parse(txtRenglon.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                {
                    dataGridView3[c, r].Value = int.Parse(dataGridView1[c, r].Value.ToString()) + int.Parse(dataGridView2[c, r].Value.ToString());

                }
            }

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < int.Parse(txtRenglon.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                {
                    dataGridView1[c, r].Value = random.Next(int.Parse(txtLimInf.Text)- 1, int.Parse(txtLimSup.Text) + 1).ToString();
                    dataGridView2[c, r].Value = random.Next(int.Parse(txtLimInf.Text) - 1, int.Parse(txtLimSup.Text) + 1).ToString();
                }
            }
        }
    }
}
