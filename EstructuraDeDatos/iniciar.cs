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

    public partial class iniciar : Form
    {
        datoAbstracto dAbstracto;
        datoAbstractoPerro dPerro;
        int r = 0;
        int c = 0;
        public iniciar()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (validarCampo())
            {
                if (EstructuraAbstracta.opcion == "ADT 1")
                {
                    dataGridView1[c,r].Value = new datoAbstracto(textBox1.Text).Nombre;
                }
                else if (EstructuraAbstracta.opcion == "ADT 2")
                {
                    dataGridView1[c, r].Value = new datoAbstractoPerro(textBox1.Text).Nombre;
                }
                else dataGridView1[c, r].Value = textBox1.Text;

                r++;
                if (r == 3) { c++; r = 0; }
                textBox1.Clear();
                textBox1.Focus();
                if (c == 3)
                {
                    btnCapturar.Enabled = false;
                    textBox1.Enabled = false;
                }
                else
                {
                    label1.Text = "Elemento [" + c + "," + r + "]= ";
                }
            }
            else
            {
                MessageBox.Show("NO PUEDES PONER LETRAS");
                textBox1.Focus();
                textBox1.Clear();
            }

        }
        public bool validarCampo()
        {

            switch (EstructuraAbstracta.opcion)
            {
                case "INT": return int.TryParse(textBox1.Text, out int x);
                case "DOUBLE": return double.TryParse(textBox1.Text, out double y);
                case "DECIMAL": return decimal.TryParse(textBox1.Text, out decimal z);
                case "CHAR": return char.TryParse(textBox1.Text, out char t);
                case "STRING": return true;
                case "ADT 1": return true;
                case "ADT 2": return true;
                default: return false;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            r = 0;
            c = 0;
            btnCapturar.Enabled = true;
            label1.Text = "Elemento [0,0]";
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void iniciar_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Height = 55;
            dataGridView1.Rows[1].Height = 55;
            dataGridView1.Rows[2].Height = 55;

            dataGridView1.Rows[0].HeaderCell.Value = "Renglon1";
            dataGridView1.Rows[1].HeaderCell.Value = "Renglon2";
            dataGridView1.Rows[2].HeaderCell.Value = "Renglon3";

            lbldato.Text = EstructuraAbstracta.opcion;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class datoAbstracto{

        private string nombre ;
        
        public datoAbstracto()
        {

        }
        public datoAbstracto(string nomb)
        {
            Nombre = nomb;

        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
    public class datoAbstractoPerro
    {
        private string raza ;
        
        public datoAbstractoPerro()
        {

        }
        public datoAbstractoPerro(string raza)
        {
            this.raza = raza;

        }

        public string Nombre { get => raza; set => raza= value; }
    }

}

