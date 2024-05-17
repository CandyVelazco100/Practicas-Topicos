namespace Practica3U3
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lb1 = new System.Windows.Forms.Label();
            this.bGraficar = new System.Windows.Forms.Button();
            this.bDetener = new System.Windows.Forms.Button();
            this.bIniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("3ds", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(44, 28);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(167, 29);
            this.lb1.TabIndex = 9;
            this.lb1.Text = "Adquirir datos";
            // 
            // bGraficar
            // 
            this.bGraficar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bGraficar.Font = new System.Drawing.Font("3ds", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGraficar.Location = new System.Drawing.Point(49, 174);
            this.bGraficar.Name = "bGraficar";
            this.bGraficar.Size = new System.Drawing.Size(98, 37);
            this.bGraficar.TabIndex = 8;
            this.bGraficar.Text = "GRAFICAR";
            this.bGraficar.UseVisualStyleBackColor = false;
            this.bGraficar.Click += new System.EventHandler(this.bGraficar_Click);
            // 
            // bDetener
            // 
            this.bDetener.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bDetener.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDetener.Font = new System.Drawing.Font("3ds", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDetener.Location = new System.Drawing.Point(49, 123);
            this.bDetener.Name = "bDetener";
            this.bDetener.Size = new System.Drawing.Size(98, 37);
            this.bDetener.TabIndex = 7;
            this.bDetener.Text = "DETENER";
            this.bDetener.UseVisualStyleBackColor = false;
            this.bDetener.Click += new System.EventHandler(this.bDetener_Click);
            // 
            // bIniciar
            // 
            this.bIniciar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bIniciar.Font = new System.Drawing.Font("3ds", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bIniciar.Location = new System.Drawing.Point(49, 75);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(98, 37);
            this.bIniciar.TabIndex = 6;
            this.bIniciar.Text = "INICIAR";
            this.bIniciar.UseVisualStyleBackColor = false;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(107, 345);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(569, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(258, 28);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "SensorTemperatura";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(523, 300);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            title2.Name = "Temperatura";
            this.chart1.Titles.Add(title2);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(808, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.bGraficar);
            this.Controls.Add(this.bDetener);
            this.Controls.Add(this.bIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button bGraficar;
        private System.Windows.Forms.Button bDetener;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
    }
}

