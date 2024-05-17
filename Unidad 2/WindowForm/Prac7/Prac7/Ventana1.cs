using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac7
{
    public partial class Ventana1 : Form
    {
        public Ventana1()
        {
            InitializeComponent();
        }

        private void Ventana1_Load(object sender, EventArgs e)
        {}

        private void pb1_Click(object sender, EventArgs e)
        {}

        private void b1_Click(object sender, EventArgs e)
        {
            pb1.Image = Prac7.Properties.Resources.dia;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            pb1.Image = Prac7.Properties.Resources.noche;
        }
    }
}
