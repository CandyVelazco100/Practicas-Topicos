
namespace Prac4U3
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Pat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ap_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Género = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instituto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boton1 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nombre,
            this.Apellido_Pat,
            this.Ap_Mat,
            this.Correo,
            this.Género,
            this.Instituto});
            this.dgv1.Location = new System.Drawing.Point(50, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(743, 387);
            this.dgv1.TabIndex = 0;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido_Pat
            // 
            this.Apellido_Pat.HeaderText = "Apellido Paterno";
            this.Apellido_Pat.Name = "Apellido_Pat";
            // 
            // Ap_Mat
            // 
            this.Ap_Mat.HeaderText = "Apellido Materno";
            this.Ap_Mat.Name = "Ap_Mat";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Género
            // 
            this.Género.HeaderText = "Género";
            this.Género.Name = "Género";
            // 
            // Instituto
            // 
            this.Instituto.HeaderText = "Instituto";
            this.Instituto.Name = "Instituto";
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.PeachPuff;
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton1.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.ForeColor = System.Drawing.Color.Black;
            this.boton1.Location = new System.Drawing.Point(765, 468);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(100, 37);
            this.boton1.TabIndex = 1;
            this.boton1.Text = "Eliminar";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.PeachPuff;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn.ForeColor = System.Drawing.Color.Black;
            this.btn.Location = new System.Drawing.Point(659, 468);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(91, 37);
            this.btn.TabIndex = 2;
            this.btn.Text = "Agregar";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(24, 418);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(115, 20);
            this.tb1.TabIndex = 3;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(145, 419);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(111, 20);
            this.tb2.TabIndex = 4;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(267, 419);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(109, 20);
            this.tb3.TabIndex = 5;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(389, 419);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(110, 20);
            this.tb4.TabIndex = 6;
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(516, 419);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(113, 20);
            this.tb5.TabIndex = 7;
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(635, 419);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(115, 20);
            this.tb6.TabIndex = 8;
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(756, 419);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(109, 20);
            this.tb7.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(895, 517);
            this.Controls.Add(this.tb7);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.dgv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Pat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ap_Mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Género;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instituto;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.TextBox tb7;
    }
}

