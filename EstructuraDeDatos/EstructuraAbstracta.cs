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
    public partial class EstructuraAbstracta : Form
    {
        public static string opcion="int";
        public EstructuraAbstracta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                opcion = "INT";
            }else if (radioButton2.Checked)
            {
                opcion = "DOUBLE";
            }else if (radioButton3.Checked)
            {
                opcion = "DECIMAL";
            }else if (radioButton4.Checked)
            {
                opcion = "CHAR";
            }
            else if (radioButton5.Checked)
            {
                opcion = "STRING";
            }
            else if (radioButton6.Checked)
            {
                opcion = "ADT 1";
            }
            else if(radioButton7.Checked)
            {
                opcion = "ADT 2";
            }
            new iniciar().ShowDialog();
        }
    }
}
