namespace AlgoritmoLzw
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtComprimir = new System.Windows.Forms.TextBox();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.LbDiccionario = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbSalida = new System.Windows.Forms.ListBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnComprimir = new System.Windows.Forms.Button();
            this.BtnDescomprimir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LbCodigo = new System.Windows.Forms.ListBox();
            this.BtnCodigo = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBorrar2 = new System.Windows.Forms.Button();
            this.BtnBorrar1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALGORITMO LZW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese una frase:";
            // 
            // TxtComprimir
            // 
            this.TxtComprimir.Location = new System.Drawing.Point(114, 105);
            this.TxtComprimir.Name = "TxtComprimir";
            this.TxtComprimir.Size = new System.Drawing.Size(137, 20);
            this.TxtComprimir.TabIndex = 3;
            this.TxtComprimir.TextChanged += new System.EventHandler(this.TxtComprimir_TextChanged);
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Location = new System.Drawing.Point(275, 52);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(90, 26);
            this.BtnEjecutar.TabIndex = 6;
            this.BtnEjecutar.Text = "&Ejecutar";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(15, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 43);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(111, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Descomprimir";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Comprimir";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // LbDiccionario
            // 
            this.LbDiccionario.FormattingEnabled = true;
            this.LbDiccionario.Location = new System.Drawing.Point(51, 195);
            this.LbDiccionario.Name = "LbDiccionario";
            this.LbDiccionario.Size = new System.Drawing.Size(73, 147);
            this.LbDiccionario.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Diccionario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Salida";
            // 
            // LbSalida
            // 
            this.LbSalida.FormattingEnabled = true;
            this.LbSalida.Location = new System.Drawing.Point(222, 195);
            this.LbSalida.Name = "LbSalida";
            this.LbSalida.Size = new System.Drawing.Size(76, 147);
            this.LbSalida.TabIndex = 11;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(257, 103);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(68, 23);
            this.BtnAgregar.TabIndex = 12;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnComprimir
            // 
            this.BtnComprimir.Location = new System.Drawing.Point(275, 53);
            this.BtnComprimir.Name = "BtnComprimir";
            this.BtnComprimir.Size = new System.Drawing.Size(90, 25);
            this.BtnComprimir.TabIndex = 13;
            this.BtnComprimir.Text = "Comprimir";
            this.BtnComprimir.UseVisualStyleBackColor = true;
            this.BtnComprimir.Click += new System.EventHandler(this.BtnComprimir_Click);
            // 
            // BtnDescomprimir
            // 
            this.BtnDescomprimir.Location = new System.Drawing.Point(275, 52);
            this.BtnDescomprimir.Name = "BtnDescomprimir";
            this.BtnDescomprimir.Size = new System.Drawing.Size(90, 25);
            this.BtnDescomprimir.TabIndex = 14;
            this.BtnDescomprimir.Text = "Descomprimir";
            this.BtnDescomprimir.UseVisualStyleBackColor = true;
            this.BtnDescomprimir.Click += new System.EventHandler(this.BtnDescomprimir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(319, 319);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 15;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Código Anterior";
            // 
            // LbCodigo
            // 
            this.LbCodigo.FormattingEnabled = true;
            this.LbCodigo.Location = new System.Drawing.Point(137, 195);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(73, 147);
            this.LbCodigo.TabIndex = 17;
            // 
            // BtnCodigo
            // 
            this.BtnCodigo.Location = new System.Drawing.Point(257, 141);
            this.BtnCodigo.Name = "BtnCodigo";
            this.BtnCodigo.Size = new System.Drawing.Size(68, 23);
            this.BtnCodigo.TabIndex = 20;
            this.BtnCodigo.Text = "Agregar";
            this.BtnCodigo.UseVisualStyleBackColor = true;
            this.BtnCodigo.Click += new System.EventHandler(this.BtnCodigo_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(114, 141);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(137, 20);
            this.TxtCodigo.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ingrese codigo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 21;
            // 
            // BtnBorrar2
            // 
            this.BtnBorrar2.Location = new System.Drawing.Point(331, 140);
            this.BtnBorrar2.Name = "BtnBorrar2";
            this.BtnBorrar2.Size = new System.Drawing.Size(68, 25);
            this.BtnBorrar2.TabIndex = 22;
            this.BtnBorrar2.Text = "Borrar";
            this.BtnBorrar2.UseVisualStyleBackColor = true;
            this.BtnBorrar2.Click += new System.EventHandler(this.BtnBorrar2_Click);
            // 
            // BtnBorrar1
            // 
            this.BtnBorrar1.Location = new System.Drawing.Point(331, 103);
            this.BtnBorrar1.Name = "BtnBorrar1";
            this.BtnBorrar1.Size = new System.Drawing.Size(68, 23);
            this.BtnBorrar1.TabIndex = 23;
            this.BtnBorrar1.Text = "Borrar";
            this.BtnBorrar1.UseVisualStyleBackColor = true;
            this.BtnBorrar1.Click += new System.EventHandler(this.BtnBorrar1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Utilice un guión bajo  (_)  para identifcar un espacio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlgoritmoLzw.Properties.Resources.cod;
            this.ClientSize = new System.Drawing.Size(413, 377);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnBorrar1);
            this.Controls.Add(this.BtnBorrar2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCodigo);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LbSalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbDiccionario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtComprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnComprimir);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.BtnDescomprimir);
            this.Name = "Form1";
            this.Text = "LZW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtComprimir;
        private System.Windows.Forms.Button BtnEjecutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox LbDiccionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LbSalida;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnComprimir;
        private System.Windows.Forms.Button BtnDescomprimir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LbCodigo;
        private System.Windows.Forms.Button BtnCodigo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnBorrar2;
        private System.Windows.Forms.Button BtnBorrar1;
        private System.Windows.Forms.Label label8;
    }
}

