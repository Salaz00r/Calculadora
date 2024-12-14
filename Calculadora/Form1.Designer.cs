namespace Calculadora
{
    partial class FrmCalcular
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
            this.LblPeso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.TxtEstatura = new System.Windows.Forms.TextBox();
            this.TxtSumarCalorias = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtActividad = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeso.Location = new System.Drawing.Point(92, 140);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(213, 24);
            this.LblPeso.TabIndex = 0;
            this.LblPeso.Text = "Ingresa tu peso corporal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa tu estatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa tu actividad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calorias de aumento (300-500)";
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(372, 140);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(145, 20);
            this.TxtPeso.TabIndex = 4;
            this.TxtPeso.TextChanged += new System.EventHandler(this.TxtPeso_TextChanged);
            // 
            // TxtEstatura
            // 
            this.TxtEstatura.Location = new System.Drawing.Point(372, 202);
            this.TxtEstatura.Name = "TxtEstatura";
            this.TxtEstatura.Size = new System.Drawing.Size(145, 20);
            this.TxtEstatura.TabIndex = 5;
            this.TxtEstatura.TextChanged += new System.EventHandler(this.TxtEstatura_TextChanged);
            // 
            // TxtSumarCalorias
            // 
            this.TxtSumarCalorias.Location = new System.Drawing.Point(372, 316);
            this.TxtSumarCalorias.Name = "TxtSumarCalorias";
            this.TxtSumarCalorias.Size = new System.Drawing.Size(145, 20);
            this.TxtSumarCalorias.TabIndex = 7;
            this.TxtSumarCalorias.TextChanged += new System.EventHandler(this.TxtAumento_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(565, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 248);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1,25 si se es sedentario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = " 1,5 si se es activo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "1,75 si se es muy activo";
            // 
            // TxtActividad
            // 
            this.TxtActividad.Location = new System.Drawing.Point(372, 262);
            this.TxtActividad.Name = "TxtActividad";
            this.TxtActividad.Size = new System.Drawing.Size(145, 20);
            this.TxtActividad.TabIndex = 15;
            this.TxtActividad.TextChanged += new System.EventHandler(this.TxtActividad_TextChanged);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCalcular.ForeColor = System.Drawing.Color.White;
            this.BtnCalcular.Location = new System.Drawing.Point(372, 358);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(145, 30);
            this.BtnCalcular.TabIndex = 16;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 97);
            this.panel2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(270, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Calculadora de Calorias";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.gimnasio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel3.Location = new System.Drawing.Point(-1, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 32);
            this.panel3.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(92, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ingresa tu peso corporal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(92, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ingresa tu estatura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(92, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ingresa tu actividad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(92, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(266, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "Calorias de aumento (300-500)";
            // 
            // FrmCalcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(874, 510);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtActividad);
            this.Controls.Add(this.TxtSumarCalorias);
            this.Controls.Add(this.TxtEstatura);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblPeso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCalcular";
            this.Text = "Calculadora de calorias";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.TextBox TxtEstatura;
        private System.Windows.Forms.TextBox TxtSumarCalorias;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtActividad;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

