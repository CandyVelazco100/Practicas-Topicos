
namespace Prac3U3
{
    partial class Grafica
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bIniciar = new System.Windows.Forms.Button();
            this.bDetener = new System.Windows.Forms.Button();
            this.bGraficar = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(60, 283);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(517, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // chart1
            // 
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(236, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsXValueIndexed = true;
            series1.Name = "SensorTemperatura";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(375, 257);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Name = "Temperatura";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // bIniciar
            // 
            this.bIniciar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bIniciar.Location = new System.Drawing.Point(30, 60);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(98, 37);
            this.bIniciar.TabIndex = 2;
            this.bIniciar.Text = "INICIAR";
            this.bIniciar.UseVisualStyleBackColor = false;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // bDetener
            // 
            this.bDetener.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bDetener.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bDetener.Location = new System.Drawing.Point(30, 108);
            this.bDetener.Name = "bDetener";
            this.bDetener.Size = new System.Drawing.Size(98, 37);
            this.bDetener.TabIndex = 3;
            this.bDetener.Text = "DETENER";
            this.bDetener.UseVisualStyleBackColor = false;
            this.bDetener.Click += new System.EventHandler(this.bDetener_Click);
            // 
            // bGraficar
            // 
            this.bGraficar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bGraficar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bGraficar.Location = new System.Drawing.Point(30, 159);
            this.bGraficar.Name = "bGraficar";
            this.bGraficar.Size = new System.Drawing.Size(98, 37);
            this.bGraficar.TabIndex = 4;
            this.bGraficar.Text = "GRAFICAR";
            this.bGraficar.UseVisualStyleBackColor = false;
            this.bGraficar.Click += new System.EventHandler(this.bGraficar_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(30, 25);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(159, 25);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "Adquirir datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(638, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.bGraficar);
            this.Controls.Add(this.bDetener);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Grafica";
            this.Text = "Grafica";
            this.Load += new System.EventHandler(this.Grafica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Button bDetener;
        private System.Windows.Forms.Button bGraficar;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label2;
    }
}

