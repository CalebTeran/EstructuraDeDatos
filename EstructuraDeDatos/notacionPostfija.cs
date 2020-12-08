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
    public partial class notacionPostfija : Form
    {
        Stack<float> pila = new Stack<float>();
        string[] elementos;
        int indice = 0;

        public notacionPostfija()
        {
            InitializeComponent();
        }

        private void imprimir()
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = "";
        }
        public void imprimirExpresion()
        {
            string salida = "";
            foreach (var item in pila.Reverse())
            {
                salida += item + " ";

            }

            for (int i = indice + 1; i < elementos.Length; i++)
            {
                salida += elementos[i] + " ";

            }
            richTextBox1.AppendText(salida + "\n");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            elementos = txtExpresion.Text.Split();
            indice = 0;
            pila.Clear();
            {
                richTextBox1.Clear();
                richTextBox1.AppendText(txtExpresion.Text + "\n");
                foreach (var item in elementos)
                {
                    switch (item)
                    {
                        case "*": MessageBox.Show("Multiplicacion"); break;
                        case "-": MessageBox.Show("Resta"); break;
                        case "+": MessageBox.Show("Suma"); break;
                        case "/": MessageBox.Show("División"); break;
                        case "%": MessageBox.Show("modulo"); break;
                        default: MessageBox.Show("Es un operando"); break;
                    }
                    if (item == "*" || item == "/" || item == "+" || item == "-" || item == "%")
                    {
                        MessageBox.Show("Es operador" + item);
                    }
                    else
                    {
                        MessageBox.Show("Es operando" + item);
                        pila.Push(float.Parse(item));
                    }
                    indice++;
                }
            }
        }
    }
}
