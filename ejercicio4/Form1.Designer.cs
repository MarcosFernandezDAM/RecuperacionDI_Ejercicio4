namespace ejercicio4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.btnOperacion = new System.Windows.Forms.Button();
            this.labelIgual = new System.Windows.Forms.Label();
            this.labelOperacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDiv = new System.Windows.Forms.RadioButton();
            this.radioButtonMulti = new System.Windows.Forms.RadioButton();
            this.radioButtonResta = new System.Windows.Forms.RadioButton();
            this.radioButtonSuma = new System.Windows.Forms.RadioButton();
            this.labelResultado = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(116, 65);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum1.TabIndex = 0;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(317, 65);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum2.TabIndex = 1;
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Location = new System.Drawing.Point(116, 46);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(53, 13);
            this.labelNum1.TabIndex = 2;
            this.labelNum1.Text = "Número 1";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Location = new System.Drawing.Point(317, 45);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(53, 13);
            this.labelNum2.TabIndex = 3;
            this.labelNum2.Text = "Número 2";
            // 
            // btnOperacion
            // 
            this.btnOperacion.Location = new System.Drawing.Point(173, 239);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(75, 23);
            this.btnOperacion.TabIndex = 3;
            this.btnOperacion.Text = "Operar";
            this.btnOperacion.UseVisualStyleBackColor = true;
            this.btnOperacion.Click += new System.EventHandler(this.BtnOperacion_Click);
            // 
            // labelIgual
            // 
            this.labelIgual.AutoSize = true;
            this.labelIgual.Location = new System.Drawing.Point(438, 68);
            this.labelIgual.Name = "labelIgual";
            this.labelIgual.Size = new System.Drawing.Size(13, 13);
            this.labelIgual.TabIndex = 5;
            this.labelIgual.Text = "=";
            // 
            // labelOperacion
            // 
            this.labelOperacion.AutoSize = true;
            this.labelOperacion.Location = new System.Drawing.Point(252, 68);
            this.labelOperacion.Name = "labelOperacion";
            this.labelOperacion.Size = new System.Drawing.Size(13, 13);
            this.labelOperacion.TabIndex = 6;
            this.labelOperacion.Text = "+";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDiv);
            this.groupBox1.Controls.Add(this.radioButtonMulti);
            this.groupBox1.Controls.Add(this.radioButtonResta);
            this.groupBox1.Controls.Add(this.radioButtonSuma);
            this.groupBox1.Location = new System.Drawing.Point(30, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // radioButtonDiv
            // 
            this.radioButtonDiv.AutoSize = true;
            this.radioButtonDiv.Location = new System.Drawing.Point(364, 30);
            this.radioButtonDiv.Name = "radioButtonDiv";
            this.radioButtonDiv.Size = new System.Drawing.Size(62, 17);
            this.radioButtonDiv.TabIndex = 5;
            this.radioButtonDiv.TabStop = true;
            this.radioButtonDiv.Tag = "/";
            this.radioButtonDiv.Text = "División";
            this.radioButtonDiv.UseVisualStyleBackColor = true;
            this.radioButtonDiv.CheckedChanged += new System.EventHandler(this.cambiaChecked);
            // 
            // radioButtonMulti
            // 
            this.radioButtonMulti.AutoSize = true;
            this.radioButtonMulti.Location = new System.Drawing.Point(248, 30);
            this.radioButtonMulti.Name = "radioButtonMulti";
            this.radioButtonMulti.Size = new System.Drawing.Size(89, 17);
            this.radioButtonMulti.TabIndex = 4;
            this.radioButtonMulti.TabStop = true;
            this.radioButtonMulti.Tag = "x";
            this.radioButtonMulti.Text = "Multiplicación";
            this.radioButtonMulti.UseVisualStyleBackColor = true;
            this.radioButtonMulti.CheckedChanged += new System.EventHandler(this.cambiaChecked);
            // 
            // radioButtonResta
            // 
            this.radioButtonResta.AutoSize = true;
            this.radioButtonResta.Location = new System.Drawing.Point(138, 30);
            this.radioButtonResta.Name = "radioButtonResta";
            this.radioButtonResta.Size = new System.Drawing.Size(53, 17);
            this.radioButtonResta.TabIndex = 3;
            this.radioButtonResta.TabStop = true;
            this.radioButtonResta.Tag = "-";
            this.radioButtonResta.Text = "Resta";
            this.radioButtonResta.UseVisualStyleBackColor = true;
            this.radioButtonResta.CheckedChanged += new System.EventHandler(this.cambiaChecked);
            // 
            // radioButtonSuma
            // 
            this.radioButtonSuma.AutoSize = true;
            this.radioButtonSuma.Checked = true;
            this.radioButtonSuma.Location = new System.Drawing.Point(18, 30);
            this.radioButtonSuma.Name = "radioButtonSuma";
            this.radioButtonSuma.Size = new System.Drawing.Size(52, 17);
            this.radioButtonSuma.TabIndex = 2;
            this.radioButtonSuma.TabStop = true;
            this.radioButtonSuma.Tag = "+";
            this.radioButtonSuma.Text = "Suma";
            this.radioButtonSuma.UseVisualStyleBackColor = true;
            this.radioButtonSuma.CheckedChanged += new System.EventHandler(this.cambiaChecked);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(477, 68);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 13);
            this.labelResultado.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelOperacion);
            this.Controls.Add(this.labelIgual);
            this.Controls.Add(this.btnOperacion);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.Label labelIgual;
        private System.Windows.Forms.Label labelOperacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDiv;
        private System.Windows.Forms.RadioButton radioButtonMulti;
        private System.Windows.Forms.RadioButton radioButtonResta;
        private System.Windows.Forms.RadioButton radioButtonSuma;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Timer timer1;
    }
}

