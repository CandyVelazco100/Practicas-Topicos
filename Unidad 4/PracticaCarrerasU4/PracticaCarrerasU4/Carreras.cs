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

namespace PracticaCarrerasU4
{
    public partial class Carreras : Form
    {
        delegate void delega(PictureBox pic, int y, int veloz);

        public Carreras()
        {
            InitializeComponent();
        }

        private void form(object sender, EventArgs e)
        {
            
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Carreras_Paint(object sender, PaintEventArgs e)
        {
            Pen p1 = new Pen(Color.CornflowerBlue, 8);
            Graphics p = CreateGraphics();

            p.DrawLine(p1, new Point(50, 100), new Point(700, 100));
            p.DrawLine(p1, new Point(50, 230), new Point(700, 230));
            p.DrawLine(p1, new Point(50, 350), new Point(700, 350));
        }

        public void metodo()
        {
            delega d = new delega(mover);

            if (Thread.CurrentThread.Name.Equals("H0"))
            {
                d.Invoke(AutoAmarillo, AutoAmarillo.Location.Y, 10);
                MessageBox.Show("LUGAR #1. AUTO AMARILLO");
            }
            else if (Thread.CurrentThread.Name.Equals("H1"))
            {
                d.Invoke(AutoRojo, AutoRojo.Location.Y, 100);
                MessageBox.Show("LUGAR #3. AUTO ROJO");
            }
            else if (Thread.CurrentThread.Name.Equals("H2"))
            {
                d.Invoke(AutoAzul, AutoAzul.Location.Y, 20);
                MessageBox.Show("LUGAR #2. AUTO AZUL");
            }
        }

        public void mover(PictureBox pic, int y, int veloz)
        {
            for (int i = 0; i < 600; i++)
            {
                pic.Location = new Point(i, y);

                if (Thread.CurrentThread.Name.Equals("H0"))
                {
                    Thread.Sleep(veloz);
                }
                else if (Thread.CurrentThread.Name.Equals("H1"))
                {
                    Thread.Sleep(veloz);
                }
                else if (Thread.CurrentThread.Name.Equals("H2"))
                {
                    Thread.Sleep(veloz);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Thread[] hilos = new Thread[3];

            for(int i = 0; i< hilos.Length; i++)
            {
                hilos[i] = new Thread(metodo);
                hilos[i].Name = "H"+i;
                hilos[i].Start();
            }
            button1.Enabled = true;
        }
    }
}
