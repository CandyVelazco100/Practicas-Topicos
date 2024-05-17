
namespace Prac6
{
    partial class VentanaCalcu
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
            this.label1 = new System.Windows.Forms.Label();
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.op1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.op2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Aritmetica";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sumar
            // 
            this.sumar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sumar.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold);
            this.sumar.Location = new System.Drawing.Point(196, 65);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(51, 44);
            this.sumar.TabIndex = 1;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = false;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // restar
            // 
            this.restar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.restar.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold);
            this.restar.Location = new System.Drawing.Point(265, 65);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(51, 44);
            this.restar.TabIndex = 2;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = false;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // multi
            // 
            this.multi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multi.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold);
            this.multi.Location = new System.Drawing.Point(196, 131);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(51, 44);
            this.multi.TabIndex = 3;
            this.multi.Text = "X";
            this.multi.UseVisualStyleBackColor = false;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // dividir
            // 
            this.dividir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dividir.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold);
            this.dividir.Location = new System.Drawing.Point(265, 131);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(51, 44);
            this.dividir.TabIndex = 4;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = false;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrar.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.Location = new System.Drawing.Point(218, 197);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(82, 32);
            this.borrar.TabIndex = 5;
            this.borrar.Text = "BORRAR";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Operando 1";
            // 
            // op1
            // 
            this.op1.Location = new System.Drawing.Point(16, 89);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(100, 20);
            this.op1.TabIndex = 7;
            this.op1.TextChanged += new System.EventHandler(this.op1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Operando 2";
            // 
            // op2
            // 
            this.op2.Location = new System.Drawing.Point(16, 155);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(100, 20);
            this.op2.TabIndex = 9;
            this.op2.TextChanged += new System.EventHandler(this.op2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resultado";
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(16, 241);
            this.res.Name = "res";
            this.res.ReadOnly = true;
            this.res.Size = new System.Drawing.Size(100, 20);
            this.res.TabIndex = 11;
            this.res.TextChanged += new System.EventHandler(this.res_TextChanged);
            // 
            // VentanaCalcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(346, 322);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.op1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VentanaCalcu";
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.VentanaCalcu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox op1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox op2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox res;
    }
}

