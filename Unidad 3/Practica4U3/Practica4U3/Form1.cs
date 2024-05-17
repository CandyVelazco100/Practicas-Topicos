using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practica3U3
{
    public partial class Form1 : Form
    {
        List<int> valores = new List<int>();
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void timer1_Tick(object sender, EventArgs e)
        {
            valores.Add(trackBar1.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void bGraficar_Click(object sender, EventArgs e)
        {
            this.chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.Titles.Add("Temperatura");
            for (int i = 0; i < valores.Count; i++)
            {
                chart1.Series["SensorTemperatura"].Points.Add(valores[i]);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {}
    }
}
