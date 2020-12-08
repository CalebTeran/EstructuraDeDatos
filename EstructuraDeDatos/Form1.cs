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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void triangularYDeterminanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //triangular anonima
            new triangular().ShowDialog();

            //Triangular con objeto
/*            triangular triangulo = new triangular();
            triangulo.Show();*/
        }

        private void estructuraAbstracta7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new iniciar().ShowDialog();
        }

        private void tiposDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EstructuraAbstracta().ShowDialog();
        }

        private void matrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new matices().ShowDialog();
        }

        private void matrizInversaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new matricesInversas().ShowDialog();
        }

        private void matrizTranspuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new matricesTranspuestas().ShowDialog();
        }

        private void memoramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Memorama().ShowDialog();
        }

        private void serieDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Recursiviad().ShowDialog();
        }

        private void pilaGenericaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PilaGenerica().ShowDialog();
        }

        private void unidad5ArbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void torresDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TorresDeHanoi().ShowDialog();
        }

        private void unidad4PilasYColasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notacionPostfijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new notacionPostfija().ShowDialog();
        }
    }
}
