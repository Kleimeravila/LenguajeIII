namespace LenguajeIII
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Edad = new System.Windows.Forms.TextBox();
            this.comboBox_Registro = new System.Windows.Forms.ComboBox();
            this.button_Agrerar = new System.Windows.Forms.Button();
            this.button_Desc = new System.Windows.Forms.Button();
            this.button_Asc = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MicroSquare", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rigistro de Nombres segun su Edad";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.comboBox_Registro);
            this.groupBox1.Controls.Add(this.textBox_Edad);
            this.groupBox1.Controls.Add(this.textBox_Nombre);
            this.groupBox1.Controls.Add(this.button_Agrerar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("MicroSquare", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(145, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Edad";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(92, 24);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(100, 25);
            this.textBox_Nombre.TabIndex = 2;
            // 
            // textBox_Edad
            // 
            this.textBox_Edad.Location = new System.Drawing.Point(92, 58);
            this.textBox_Edad.Name = "textBox_Edad";
            this.textBox_Edad.Size = new System.Drawing.Size(100, 25);
            this.textBox_Edad.TabIndex = 3;
            // 
            // comboBox_Registro
            // 
            this.comboBox_Registro.FormattingEnabled = true;
            this.comboBox_Registro.Location = new System.Drawing.Point(309, 30);
            this.comboBox_Registro.Name = "comboBox_Registro";
            this.comboBox_Registro.Size = new System.Drawing.Size(121, 26);
            this.comboBox_Registro.TabIndex = 4;
            this.comboBox_Registro.Text = "Registros";
            // 
            // button_Agrerar
            // 
            this.button_Agrerar.Location = new System.Drawing.Point(319, 98);
            this.button_Agrerar.Name = "button_Agrerar";
            this.button_Agrerar.Size = new System.Drawing.Size(87, 33);
            this.button_Agrerar.TabIndex = 2;
            this.button_Agrerar.Text = "Agregar";
            this.button_Agrerar.UseVisualStyleBackColor = true;
            this.button_Agrerar.Click += new System.EventHandler(this.button_Agrerar_Click);
            // 
            // button_Desc
            // 
            this.button_Desc.Font = new System.Drawing.Font("MicroSquare", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Desc.Location = new System.Drawing.Point(120, 274);
            this.button_Desc.Name = "button_Desc";
            this.button_Desc.Size = new System.Drawing.Size(111, 23);
            this.button_Desc.TabIndex = 3;
            this.button_Desc.Text = "Descendente";
            this.button_Desc.UseVisualStyleBackColor = true;
            this.button_Desc.Click += new System.EventHandler(this.button_Desc_Click);
            // 
            // button_Asc
            // 
            this.button_Asc.Font = new System.Drawing.Font("MicroSquare", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Asc.Location = new System.Drawing.Point(237, 274);
            this.button_Asc.Name = "button_Asc";
            this.button_Asc.Size = new System.Drawing.Size(109, 23);
            this.button_Asc.TabIndex = 4;
            this.button_Asc.Text = "Ascendente";
            this.button_Asc.UseVisualStyleBackColor = true;
            this.button_Asc.Click += new System.EventHandler(this.button_Asc_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Font = new System.Drawing.Font("MicroSquare", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Limpiar.Location = new System.Drawing.Point(454, 274);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(97, 23);
            this.button_Limpiar.TabIndex = 5;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Font = new System.Drawing.Font("MicroSquare", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salir.Location = new System.Drawing.Point(585, 274);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(96, 23);
            this.button_Salir.TabIndex = 6;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Asc);
            this.Controls.Add(this.button_Desc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Registro;
        private System.Windows.Forms.TextBox textBox_Edad;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Button button_Agrerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Desc;
        private System.Windows.Forms.Button button_Asc;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Salir;
    }
}

