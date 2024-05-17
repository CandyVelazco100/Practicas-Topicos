using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac2U3
{
    public partial class VRegistro : Form
    {
        Validar v = new Validar();
        String gen = "";

        public VRegistro()
        {
            InitializeComponent();
        }

        private void VRegistro_Load(object sender, EventArgs e)
        {}

        private void txb1_TextChanged(object sender, EventArgs e)
        {}

        private void txb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txb2_TextChanged(object sender, EventArgs e)
        {}

        private void txb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txb3_TextChanged(object sender, EventArgs e)
        {}

        private void txb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txb4_TextChanged(object sender, EventArgs e)
        {}

        private void txb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            registros.Enabled = true;
            

            if (rb1.Checked == true)
            {
                gen = "Hombre";
            }else if (rb2.Checked == true)
            {
                gen = "Mujer";
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            txb1.Text = "";
            txb2.Text = "";
            txb3.Text = "";
            txb4.Text = "";
            txb5.Text = "";
            txb6.Text = "";
            ResetAll(genero);
            registros.Enabled = false;
        }

        private void bAlta_Click(object sender, EventArgs e)
        {
            Salida.Items.Add("MATRICULA: " + txb1.Text);
            Salida.Items.Add("NOMBRE: " + txb2.Text);
            Salida.Items.Add("A. PATERNO: " + txb3.Text);
            Salida.Items.Add("A. MATERNO: " + txb4.Text);
            Salida.Items.Add("CORREO: " + txb5.Text);
            Salida.Items.Add("ESCUELA: " + txb6.Text);
            Salida.Items.Add("GENERO: " + gen);
        }

        private void bBaja_Click(object sender, EventArgs e)
        {
            Salida.Items.Clear();
        }

        private void genero_Enter(object sender, EventArgs e)
        {}

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {}

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {}

        void ResetAll(GroupBox gbox)
        {
            foreach (Control ctrl in gbox.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctrl;
                    radioButton.Checked = false;
                }
            }
            gen = "";
        }
    }
}
