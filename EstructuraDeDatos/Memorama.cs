using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace EstructuraDeDatos
{
    public partial class Memorama : Form
    {
        string[] posicionesLv1 = {"carta1n1.png","carta1n1.png", "carta2n1.png","carta2n1.png", "carta3n1.png","carta3n1.png",
            "carta4n1.png","carta4n1.png", "carta5n1.png","carta5n1.png", "carta6n1.png", "carta6n1.png",
            "carta7n1.png","carta7n1.png", "carta8n1.png", "carta8n1.png", "carta9n1.png", "carta9n1.png"
        };
        /*        string[] posicionesLv2 = {"carta1n1.png", "carta2n1.png", "carta3n1.png",
                    "carta4n1.png", "carta5n1.png", "carta6n1.png",
                    "carta7n1.png", "carta8n1.png", "carta9n1.png"
                    };
                string[] posicionesLv3 = {"carta1n1.png", "carta2n1.png", "carta3n1.png",
                    "carta4n1.png", "carta5n1.png", "carta6n1.png",
                    "carta7n1.png", "carta8n1.png", "carta9n1.png"
                    };
                string[] posicionesLv4 = {"carta1n1.png", "carta2n1.png", "carta3n1.png",
                    "carta4n1.png", "carta5n1.png", "carta6n1.png",
                    "carta7n1.png", "carta8n1.png", "carta9n1.png"
                    };*/
        int nivel;
        int score;
        Random random = new Random();
        string carta1 = "";
        string carta2 = "";
        PictureBox imgTemp;
        int pares;
        int restantes = 9;
        int posTemp;
        bool time = true;
        int intentosRest = 50;

        int intentos = 0;
        string ruta = @"C:\Users\USER\source\repos\Practica1\EstructuraDeDatos\EstructuraDeDatos\img\";
        Stopwatch Swatch = new Stopwatch();
        public Memorama()
        {
            InitializeComponent();
            
        }
        public void voltearCarta(PictureBox img, int position )
        {
            score = 8000;
            lblScoreNum.Text = score.ToString();
            img.BackgroundImage = Image.FromFile(ruta + posicionesLv1[position]);
            img.Update();
            if (time)
            {
                imgTemp = img;
                posTemp = position;
                img.Enabled = false;
            }
            else
            {
                if (posicionesLv1[posTemp] == posicionesLv1[position] )
                {
                    imgTemp.BackgroundImage = null;
                    img.BackgroundImage = null;
                    imgTemp.Enabled = false;
                    img.Enabled = false;
                    ++pares;
                    lblPares.Text = pares.ToString();
                    --restantes;
                    lblParesRest.Text = restantes.ToString();
                    lblIntentos.Text = (intentos/2).ToString();
                    --intentosRest;
                    if (intentos > 25)
                        score = score-150;
                    
                        
                }
                else
                {
                    Thread.Sleep(1000);
                    img.BackgroundImage = Image.FromFile(ruta + "dorso.png");
                    imgTemp.BackgroundImage = Image.FromFile(ruta + "dorso.png");
                    imgTemp.Enabled = true;
                    img.Enabled = true;
                    --intentosRest;
                }
            }
            //Asgnacion y visualizar estrellas
            time = !time;
            if ((intentos/2) <=30)
            {
                pbStar1.Visible = true;
                pbStar2.Visible = true;
                pbStar3.Visible = true;
                lblMsgFinal.Text = "¡¡¡¡PERFECTOOO, TRES ESTRELLAS!!!!";
                pbStarwin3.Visible = true;
                pbStarwin1.Visible = true;
                pbStarwin2.Visible = true;
            }
            else if ((intentos / 2) <= 40)
            {
                pbStar1.Visible = false;
                pbStar2.Visible = true;
                pbStar3.Visible = true;
                lblMsgFinal.Text = "¡¡¡¡BIEN, DOS ESTRELLAS!!!!";
                pbStarwin3.Visible = true;
                pbStarwin2.Visible = true;
            }
            else
            {
                pbStar1.Visible = false;
                pbStar2.Visible = false;
                pbStar3.Visible = true;
                lblMsgFinal.Text = "¡¡¡¡SOLO UNA ESTRELLA!!!";
                pbStarwin3.Visible = true;
            }
            if (restantes == 0)
            {
                panel1.Visible = true;
            }
            if (intentosRest==0)
            {
                panel1.BackgroundImage = Image.FromFile(@"C:\Users\USER\source\repos\Practica1\EstructuraDeDatos\EstructuraDeDatos\img\Derrota.jpg");
                panel1.Visible = true;
                lblMsgFinal.Text = "¿¿¿¿Y LAS ESTRELLAS????";
            }
        }

        private void Memorama_Load(object sender, EventArgs e)
        {
            int backg = random.Next(1, 11);
            string dorsoimg = @"C:\Users\USER\source\repos\Practica1\EstructuraDeDatos\EstructuraDeDatos\img\wallpaper" + backg + ".jpg";
            this.BackgroundImage = Image.FromFile(dorsoimg);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            int deck = random.Next(1,4);
            ruta = @"C:\Users\USER\source\repos\Practica1\EstructuraDeDatos\EstructuraDeDatos\img\deck"+deck+ @"\";
            lblScoreNum.Text = "00";
            lblIntentos.Text = "00";
/*            MessageBox.Show(string.Join("", posicionesLv1));*/
            posicionesLv1 = posicionesLv1.OrderBy(s => Guid.NewGuid()).ToArray();
            Swatch.Start();
            timer1.Enabled = true;
            foreach (PictureBox item in this.Controls.OfType<PictureBox>())
            {
                pb1.BackgroundImage = Image.FromFile(ruta + "dorso.png");
                pb1.BackgroundImageLayout = ImageLayout.Stretch;
                pb2.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb2.BackgroundImageLayout = ImageLayout.Stretch;
                pb3.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb3.BackgroundImageLayout = ImageLayout.Stretch;
                pb4.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb4.BackgroundImageLayout = ImageLayout.Stretch;
                pb5.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb5.BackgroundImageLayout = ImageLayout.Stretch;
                pb6.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb6.BackgroundImageLayout = ImageLayout.Stretch;
                pb7.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb7.BackgroundImageLayout = ImageLayout.Stretch;
                pb8.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb8.BackgroundImageLayout = ImageLayout.Stretch;
                pb9.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb9.BackgroundImageLayout = ImageLayout.Stretch;
                pb10.BackgroundImage = Image.FromFile(ruta + "dorso.png");
                pb10.BackgroundImageLayout = ImageLayout.Stretch;
                pb11.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb11.BackgroundImageLayout = ImageLayout.Stretch;
                pb12.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb12.BackgroundImageLayout = ImageLayout.Stretch;
                pb13.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb13.BackgroundImageLayout = ImageLayout.Stretch;
                pb14.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb14.BackgroundImageLayout = ImageLayout.Stretch;
                pb15.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb15.BackgroundImageLayout = ImageLayout.Stretch;
                pb16.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb16.BackgroundImageLayout = ImageLayout.Stretch;
                pb17.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb17.BackgroundImageLayout = ImageLayout.Stretch;
                pb18.BackgroundImage = Image.FromFile(ruta + "dorso.png" );
                pb18.BackgroundImageLayout = ImageLayout.Stretch;
                item.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)Swatch.ElapsedMilliseconds);
            lblMin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            lblSeg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            lblMili.Text = ts.Milliseconds.ToString();
        }
        public void reset()
        {
            Swatch.Restart();
            intentos = 0;
            restantes = 8;
            pares = 0;
            lblMili.Text = "00";
            lblSeg.Text = "00";
            lblMin.Text = "00";
            timer1.Enabled = false;
            nivel++;
            panel1.Visible = false;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            reset();
            panel1.Hide();
            Memorama_Load(sender, e);
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb1, 0);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb2, 1);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb5, 4);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb4, 3);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb3, 2);
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb6, 5);
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb11, 10);
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb8, 7);
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb9, 8);
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb10, 9);
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb7, 6);
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb12, 11);
        }

        private void pb13_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb13, 12);
        }

        private void pb14_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb14, 13);
        }

        private void pb15_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb15, 14);
        }

        private void pb16_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb16, 15);
        }

        private void pb17_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb17, 16);
        }

        private void pb18_Click(object sender, EventArgs e)
        {
            intentos++;
            voltearCarta(pb18, 17);
        }

        private void lblReiniciar_Click(object sender, EventArgs e)
        {
            reset();
            Memorama_Load(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
