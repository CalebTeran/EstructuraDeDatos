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
    public partial class Recursiviad : Form
    {
        ulong a = 0;
        ulong b = 1;
        ulong c = 0;

        public Recursiviad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 1;
            c = 1;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("0");
            dataGridView1.Rows[0].Height = 45;
            dataGridView1.Rows[0].HeaderCell.Value = "1";
            for (int i = 1; c <= ulong.Parse(textBox1.Text); i++)
            {
                dataGridView1.Rows.Add(c.ToString());
                dataGridView1.Rows[i].HeaderCell.Value = (i+1).ToString();
                dataGridView1.Rows[i].Height = 45;
                c = a + b;
                a = b;
                b = c;
            }

        }
    }
}
