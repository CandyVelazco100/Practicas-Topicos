﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class VentanaEjemplo : Form
    {
        public VentanaEjemplo()
        {
            InitializeComponent();
        }

        private void Ventana_Load(object sender, EventArgs e)
        {}

        private void label1_Click(object sender, EventArgs e)
        {}

        private void label4_Click(object sender, EventArgs e)
        {}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        private void txb2_TextChanged(object sender, EventArgs e)
        {}

        private void txb3_TextChanged(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: " +textBox1.Text + "\nCarrera: " + txb2.Text+ "\nSemestre: " + txb3.Text + 
                "\nCorreo: " + txb4.Text + "\nTelefóno: " + txb5.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {}

        private void label5_Click(object sender, EventArgs e)
        {}

        private void label6_Click(object sender, EventArgs e)
        {}

        private void txb4_TextChanged(object sender, EventArgs e)
        {}

        private void txb5_TextChanged(object sender, EventArgs e)
        {}
    }
}
