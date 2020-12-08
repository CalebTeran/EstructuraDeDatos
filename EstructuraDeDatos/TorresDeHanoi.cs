using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class TorresDeHanoi : Form
    {
        private int contador = 0;
        private string origen = "";
        private Stack<PictureBox> pb = new Stack<PictureBox>();
        private Stack<PictureBox> pb2 = new Stack<PictureBox>();
        private Stack<PictureBox> pb3 = new Stack<PictureBox>();

        public TorresDeHanoi()
        {
            InitializeComponent();
            foreach (Panel item in this.Controls.OfType<Panel>())
            {
                item.AllowDrop = true;
                item.DragEnter+= Panel_DragEnter;
                item.DragDrop += Panel_DragDrop;
            }
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox2.MouseDown += PictureBox2_MouseDown;
            pictureBox3.MouseDown += PictureBox3_MouseDown;
        }

        private bool setPosition( PictureBox pictureB, string origin)
        {
            switch (pictureB.Parent.Name.ToString())
            {
                case "panel2": 
                    if (origin == "panel6") return validar(pb2,pb, pictureB);

                    if (origin == "panel7") return validar(pb3, pb, pictureB);
                    break;
                    
                case "panel6":
                    if (origin == "panel2") return validar(pb, pb2, pictureB);

                    if (origin == "panel7") return validar(pb3, pb2, pictureB);
                    break;
                    
                case "panel7":
                    if (origin == "panel2") return validar(pb, pb3, pictureB);

                    if (origin == "panel6") return validar(pb2, pb3, pictureB);

                    break;

            }
            return true;
        }
        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mover(pictureBox1);
        }
        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            mover(pictureBox2);
        }
        private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            mover(pictureBox3);
        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            ((PictureBox)e.Data.GetData(typeof(PictureBox))).Parent = (Panel)sender;
        }


        private void TorresDeHanoi_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        private void mover(PictureBox pictureBox)
        {

            origen = pictureBox.Parent.Name.ToString();
            /*MessageBox.Show(origen);*/
            pictureBox.DoDragDrop(pictureBox, DragDropEffects.Move);

            if (setPosition(pictureBox, origen))
            {
                switch (origen)
                {
                    case "panel2":
                        pictureBox.Parent = panel2;
                        break;
                    case "panel6":
                        pictureBox.Parent = panel6;
                        break;
                    case "panel7":
                        pictureBox.Parent = panel7;
                        break;
                }
            }
            pictureBox.BringToFront();

        }

        private void limpiar()
        {
            pictureBox1.Parent = panel2;
            pictureBox2.Parent = panel2;
            pictureBox3.Parent = panel2;
            pictureBox1.BringToFront();
            pictureBox2.BringToFront();
            pictureBox3.BringToFront();
            pb.Clear() ;
            pb2.Clear();
            pb3.Clear();
            pb.Push(pictureBox1);
            pb2.Push(pictureBox2);
            pb3.Push(pictureBox3);
            contador = 0;
            label5.Text = "Movimientos : 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private bool validar(Stack<PictureBox>origen, Stack<PictureBox>destino, PictureBox picBox)
        {
            if ((destino.Count == 0 &&  picBox.Tag == origen.Peek().Tag) ||
                (destino.Count != 0 &&
                int.Parse(destino.Peek().Tag.ToString()) > int.Parse(picBox.Tag.ToString()) &&
                picBox.Tag.ToString() == origen.Peek().Tag.ToString())
                )
            {
                destino.Push(origen.Pop());
                picBox.Top = panel2.Height - picBox.Height - destino.Count * picBox.Height;
                label5.Text = "Movimientos :  " + (++contador);
                label5.Update();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Mover(Stack<PictureBox>pila1,Stack<PictureBox>pila2,PictureBox pictureBox, Panel pn)
        {
            validar(pila1, pila2, pictureBox);
            pictureBox.Parent = pn;
            panel2.Update();
            panel6.Update();
            panel7.Update();
            label5.Text = "Movimientos :  " + (++contador);
            label5.Update();
            pictureBox.BringToFront();
            pictureBox.Update();
            Thread.Sleep(500);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
            Mover(pb, pb2, pictureBox3, panel7);
            Mover(pb, pb3, pictureBox2, panel6);
            Mover(pb, pb3, pictureBox3, panel6);
            Mover(pb, pb2, pictureBox1, panel7);
            Mover(pb, pb2, pictureBox3, panel2);
            Mover(pb, pb2, pictureBox2, panel7);
            Mover(pb, pb2, pictureBox3, panel7);
        }
    }
}
