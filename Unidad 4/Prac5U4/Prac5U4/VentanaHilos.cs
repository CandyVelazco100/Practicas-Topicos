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

namespace Prac5U4
{
    public partial class VentanaHilos : Form
    {
        public VentanaHilos()
        {
            InitializeComponent();
        }

        private void VentanaHilos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soy un botón prueba");
        }

        public void procesoHilo()
        {
            Thread.Sleep(8000);
            MessageBox.Show("TERMINA PROCESO");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart t = new ThreadStart(procesoHilo);
            Thread h1 = new Thread(t);
            h1.Start();
        }
    }
}
