using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac6
{
    public partial class VentanaCalcu : Form
    {
        Validacion v = new Validacion();
        int s;
        public VentanaCalcu()
        {
            InitializeComponent();
        }

        double a, b, op;

        private void VentanaCalcu_Load(object sender, EventArgs e)
        {}

        private void label1_Click(object sender, EventArgs e)
        {}

        private void sumar_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(op1.Text);
                b = double.Parse(op2.Text);
                op = a + b;
                res.Text = op.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Solo números enteros");
            }
        }

        private void restar_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(op1.Text);
                b = double.Parse(op2.Text);
                op = b - a;
                res.Text = op.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Solo números enteros");
            }
        }

        private void multi_Click(object sender, EventArgs e)
        {
           try
            {
                a = double.Parse(op1.Text);
                b = double.Parse(op2.Text);
                op = a * b;
                res.Text = op.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Solo números enteros");
            }
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(op1.Text);
                b = double.Parse(op2.Text);
                int n1 = (int)a;
                int n2 = (int)b;
                int div = n1 / n2;
                op = Convert.ToDouble(div);
                res.Text = op.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Solo números enteros");
            }
            catch (DivideByZeroException ex) 
            {
                MessageBox.Show("No se puede dividir entre cero");
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            op1.Text = "";
            op2.Text = "";
            res.Text = "";
        }

        private void op1_TextChanged(object sender, EventArgs e)
        {}

        private void op2_TextChanged(object sender, EventArgs e)
        {}

        private void res_TextChanged(object sender, EventArgs e)
        {}
    }
}
