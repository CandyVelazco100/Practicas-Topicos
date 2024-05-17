using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4U3
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void Ventana_Load(object sender, EventArgs e)
        {}

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplo1_WF_ w1 = new Ejemplo1_WF_();
            w1.Show();
        }

        private void wF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplo2_WF_ w2 = new Ejemplo2_WF_();
            w2.Show();
        }

        private void gráficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Practica3U3.Form1 grafica = new Practica3U3.Form1();
            grafica.Show();
        }

        private void tablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PracticaTablaU3.Tablita tabla = new PracticaTablaU3.Tablita();
            tabla.Show();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App1.VentanaEjemplo datos = new App1.VentanaEjemplo();
            datos.Show();
        }

        private void proyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoDCS.DCS1 dcs = new ProyectoDCS.DCS1();
            dcs.Show();
        }
    }
}
