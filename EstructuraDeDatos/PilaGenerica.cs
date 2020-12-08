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
    public partial class PilaGenerica : Form
    {
        Stack<int> pilita = new Stack<int>();
        Random random = new Random();

        public PilaGenerica()
        {
            InitializeComponent();
        }

        private void FrmPilaGenerica_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                pilita.Push(random.Next(int.Parse(txtInferior.Text) - 1, int.Parse(txtSuperior.Text) + 1));
            }
            imprimir();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            pilita.Clear();
            for (int i = 0; i < 10; i++)
            {
                pilita.Push(random.Next(int.Parse(txtInferior.Text) - 1, int.Parse(txtSuperior.Text) + 1));

            }
            imprimir();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pilita.Clear();
            imprimir();
        }

        private void txtCaptura_TextChanged(object sender, EventArgs e)
        {
            btnPilita.Text = "pilita.Push(" + txtCaptura.Text + ")";
            btnContains.Text = "pilita.Contains(" + txtCaptura.Text + ")";
        }

        private void btnPilita_Click(object sender, EventArgs e)
        {
            try
            {
                pilita.Push(int.Parse(txtCaptura.Text));
                imprimir();
                txtCaptura.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("No puedes capturar un elemento vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            try
            {
                pilita.Pop();
                imprimir();
            }
            catch (Exception)
            {

                MessageBox.Show("No puedes quitar el ultimo elemento de la pila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            try
            {
                if (pilita.Contains(int.Parse(txtCaptura.Text)))
                {
                    MessageBox.Show("Si está el contains", "Se encuentra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No está", "No se encuentra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No puedes utilizar metodo constains en una pila vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnGet_Click(object sender, EventArgs e) => MessageBox.Show(pilita.GetType().ToString());

        private void imprimir()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in pilita)
            {
                dataGridView1.Rows.Add(item.ToString());
            }
            lbl10Elementos.Text = "La pila contiene " + pilita.Count + " elementos";
            if (pilita.Count == 0)
            {
                lblPila.Text = "Pila Vacía";
            }
            else
            {
                lblPila.Text = "En el tope de la pila hay: " + pilita.Peek();
            }
        }

        private void btnReversa_Click(object sender, EventArgs e)
        {
            try
            {
                pilita = new Stack<int>(pilita);
                imprimir();
            }
            catch (Exception)
            {
                MessageBox.Show("", "");
            }
        }

        private void btnElementAt_Click(object sender, EventArgs e)
        {
            try
            {
                pilita.ElementAt(int.Parse(txtIndice.Text));
                MessageBox.Show("Si está el elemento " + txtIndice.Text + " Con el elemento " + pilita.ElementAt(int.Parse(txtIndice.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro el elemento ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbl10Elementos_Click(object sender, EventArgs e)
        {

        }

        private void lblPila_Click(object sender, EventArgs e)
        {

        }

        private void txtIndice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuperior_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInferior_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTope_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
