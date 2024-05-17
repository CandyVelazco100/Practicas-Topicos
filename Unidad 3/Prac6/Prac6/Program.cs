using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac6
{
    public void numeros(KeyPressEventArgs e) {
        try
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            } else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            } else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else {
                e.Handled = true;
                MessageBox.Show("¡SOLO NÚMEROS!");
            }
        }
        catch (Exception ex)
        {}
    }

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VentanaCalcu());
        }
    }
}
