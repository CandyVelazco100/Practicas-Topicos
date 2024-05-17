
namespace Practica4U3
{
    partial class Ventana
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRCHIVOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wFIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wFEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRCHIVOSToolStripMenuItem,
            this.wFIToolStripMenuItem,
            this.wFEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRCHIVOSToolStripMenuItem
            // 
            this.aRCHIVOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.aRCHIVOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRCHIVOSToolStripMenuItem.Name = "aRCHIVOSToolStripMenuItem";
            this.aRCHIVOSToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.aRCHIVOSToolStripMenuItem.Text = "ARCHIVOS";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // wFIToolStripMenuItem
            // 
            this.wFIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wF1ToolStripMenuItem,
            this.wF2ToolStripMenuItem});
            this.wFIToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Italic);
            this.wFIToolStripMenuItem.Name = "wFIToolStripMenuItem";
            this.wFIToolStripMenuItem.Size = new System.Drawing.Size(41, 21);
            this.wFIToolStripMenuItem.Text = "WFI";
            // 
            // wF1ToolStripMenuItem
            // 
            this.wF1ToolStripMenuItem.Name = "wF1ToolStripMenuItem";
            this.wF1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wF1ToolStripMenuItem.Text = "WF1";
            this.wF1ToolStripMenuItem.Click += new System.EventHandler(this.wF1ToolStripMenuItem_Click);
            // 
            // wF2ToolStripMenuItem
            // 
            this.wF2ToolStripMenuItem.Name = "wF2ToolStripMenuItem";
            this.wF2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wF2ToolStripMenuItem.Text = "WF2";
            this.wF2ToolStripMenuItem.Click += new System.EventHandler(this.wF2ToolStripMenuItem_Click);
            // 
            // wFEToolStripMenuItem
            // 
            this.wFEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaToolStripMenuItem,
            this.datosToolStripMenuItem,
            this.gráficaToolStripMenuItem,
            this.proyectoToolStripMenuItem});
            this.wFEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Italic);
            this.wFEToolStripMenuItem.Name = "wFEToolStripMenuItem";
            this.wFEToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.wFEToolStripMenuItem.Text = "WFE";
            // 
            // tablaToolStripMenuItem
            // 
            this.tablaToolStripMenuItem.Name = "tablaToolStripMenuItem";
            this.tablaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tablaToolStripMenuItem.Text = "Tabla";
            this.tablaToolStripMenuItem.Click += new System.EventHandler(this.tablaToolStripMenuItem_Click);
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosToolStripMenuItem.Text = "Datos";
            this.datosToolStripMenuItem.Click += new System.EventHandler(this.datosToolStripMenuItem_Click);
            // 
            // gráficaToolStripMenuItem
            // 
            this.gráficaToolStripMenuItem.Name = "gráficaToolStripMenuItem";
            this.gráficaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gráficaToolStripMenuItem.Text = "Gráfica";
            this.gráficaToolStripMenuItem.Click += new System.EventHandler(this.gráficaToolStripMenuItem_Click);
            // 
            // proyectoToolStripMenuItem
            // 
            this.proyectoToolStripMenuItem.Name = "proyectoToolStripMenuItem";
            this.proyectoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proyectoToolStripMenuItem.Text = "Proyecto";
            this.proyectoToolStripMenuItem.Click += new System.EventHandler(this.proyectoToolStripMenuItem_Click);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ventana";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ventana_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wFIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wF1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wFEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectoToolStripMenuItem;
    }
}

