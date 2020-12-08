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
    public partial class matricesTranspuestas : Form
    {
        Random random = new Random();
        public matricesTranspuestas()
        {
            InitializeComponent();
        }
        public void generarMatriz()
        {
            for (int i = 0; i < int.Parse(txtColumnas.Text); i++)
            {
                dataGridView1.Columns.Add("Column", "Column");
            }
            for (int i = 0; i < int.Parse(txtRenglon.Text); i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = "Row" + i;

            }
            for (int r = 0; r < int.Parse(txtRenglon.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                {
                    dataGridView1[c, r].Value = "1";
                }
            }
        }
        public void generarMatrizTranspuesta()
        {
            for (int i = 0; i < int.Parse(txtRenglon.Text); i++)
            {
                dataGridView2.Columns.Add("Column", "Column");
            }
            for (int i = 0; i < int.Parse(txtColumnas.Text); i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;

            }
            for (int r = 0; r < int.Parse(txtRenglon.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                {
                    dataGridView1[c, r].Value = "1";
                    dataGridView2[r, c].Value = "1";
                }
            }
        }
        private void matricesTranspuestas_Load(object sender, EventArgs e)
        {
            generarMatriz();
        }

        private void btnDimensioanr_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            generarMatriz();
            generarMatrizTranspuesta();


        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < int.Parse(txtRenglon.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtColumnas.Text); c++)
                {
                    dataGridView1[c, r].Value = random.Next(int.Parse(txtLimInf.Text) - 1, int.Parse(txtLimSup.Text) + 1).ToString();
                }
            }
        }

        private void btnTransp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(txtRenglon.Text); i++)
            {
                dataGridView2.Columns.Add("Column", "Column");
            }
            for (int i = 0; i < int.Parse(txtColumnas.Text); i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].HeaderCell.Value = "Row" + i;

            }
            for (int r = 0; r < int.Parse(txtColumnas.Text); r++)
            {
                for (int c = 0; c < int.Parse(txtRenglon.Text); c++)
                {
                    dataGridView2[c, r].Value = int.Parse(dataGridView1[r, c].Value.ToString());

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLimSup_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLimInf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtColumnas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
