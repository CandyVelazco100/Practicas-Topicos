using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTablaU3
{
    public partial class Tablita : Form
    {
        public Tablita()
        {
            InitializeComponent();
        }

        private void Tablita_Load(object sender, EventArgs e)
        {}

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void boton1_Click(object sender, EventArgs e)
        {
            try{
                dgv1.Rows.Remove(dgv1.CurrentRow); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puede eliminar un registro vacio");
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow renglon = new DataGridViewRow();
            renglon.CreateCells(dgv1);

            renglon.Cells[0].Value = tb1.Text;
            renglon.Cells[1].Value = tb2.Text;
            renglon.Cells[2].Value = tb3.Text;
            renglon.Cells[3].Value = tb4.Text;
            renglon.Cells[4].Value = tb5.Text;
            renglon.Cells[5].Value = tb6.Text;
            renglon.Cells[6].Value = tb7.Text;

            dgv1.Rows.Add(renglon);

            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb5.Text = "";
            tb6.Text = "";
            tb7.Text = "";
        }  
    }
}
