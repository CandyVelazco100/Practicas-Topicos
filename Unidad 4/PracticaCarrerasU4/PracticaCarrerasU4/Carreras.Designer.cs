
namespace PracticaCarrerasU4
{
    partial class Carreras
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
            this.button1 = new System.Windows.Forms.Button();
            this.AutoAzul = new System.Windows.Forms.PictureBox();
            this.AutoRojo = new System.Windows.Forms.PictureBox();
            this.AutoAmarillo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AutoAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoAmarillo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "INCIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AutoAzul
            // 
            this.AutoAzul.Image = global::PracticaCarrerasU4.Properties.Resources.aUTOaZUL;
            this.AutoAzul.Location = new System.Drawing.Point(50, 270);
            this.AutoAzul.Name = "AutoAzul";
            this.AutoAzul.Size = new System.Drawing.Size(127, 74);
            this.AutoAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AutoAzul.TabIndex = 2;
            this.AutoAzul.TabStop = false;
            // 
            // AutoRojo
            // 
            this.AutoRojo.Image = global::PracticaCarrerasU4.Properties.Resources.AutitoRojo;
            this.AutoRojo.Location = new System.Drawing.Point(50, 150);
            this.AutoRojo.Name = "AutoRojo";
            this.AutoRojo.Size = new System.Drawing.Size(127, 74);
            this.AutoRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AutoRojo.TabIndex = 1;
            this.AutoRojo.TabStop = false;
            // 
            // AutoAmarillo
            // 
            this.AutoAmarillo.Image = global::PracticaCarrerasU4.Properties.Resources.AAmarillo;
            this.AutoAmarillo.Location = new System.Drawing.Point(50, 20);
            this.AutoAmarillo.Name = "AutoAmarillo";
            this.AutoAmarillo.Size = new System.Drawing.Size(127, 74);
            this.AutoAmarillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AutoAmarillo.TabIndex = 0;
            this.AutoAmarillo.TabStop = false;
            // 
            // Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AutoAzul);
            this.Controls.Add(this.AutoRojo);
            this.Controls.Add(this.AutoAmarillo);
            this.Name = "Carreras";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Carreras_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Carreras_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.AutoAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoAmarillo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AutoAmarillo;
        private System.Windows.Forms.PictureBox AutoRojo;
        private System.Windows.Forms.PictureBox AutoAzul;
        private System.Windows.Forms.Button button1;
    }
}

