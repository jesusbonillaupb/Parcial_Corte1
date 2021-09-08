
namespace Parcial_Corte1
{
    partial class empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empleados));
            this.lblTituloempleados = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numPanesAL = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numPanesNA = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numPanesE = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.radPm = new System.Windows.Forms.RadioButton();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.radAm = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numPanesAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanesNA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanesE)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloempleados
            // 
            this.lblTituloempleados.AutoSize = true;
            this.lblTituloempleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloempleados.Location = new System.Drawing.Point(282, 9);
            this.lblTituloempleados.Name = "lblTituloempleados";
            this.lblTituloempleados.Size = new System.Drawing.Size(190, 25);
            this.lblTituloempleados.TabIndex = 1;
            this.lblTituloempleados.Text = "menu empleados";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(88, 405);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 40);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "regresar a inicio";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "panes a vender";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numPanesAL
            // 
            this.numPanesAL.Location = new System.Drawing.Point(39, 135);
            this.numPanesAL.Name = "numPanesAL";
            this.numPanesAL.Size = new System.Drawing.Size(120, 20);
            this.numPanesAL.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "-panes aliñeados(1000c/u)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "-panes no aliñeados(500c/u)";
            // 
            // numPanesNA
            // 
            this.numPanesNA.Location = new System.Drawing.Point(39, 193);
            this.numPanesNA.Name = "numPanesNA";
            this.numPanesNA.Size = new System.Drawing.Size(120, 20);
            this.numPanesNA.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "-panes especiales(2000c/u)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numPanesE
            // 
            this.numPanesE.Location = new System.Drawing.Point(39, 239);
            this.numPanesE.Name = "numPanesE";
            this.numPanesE.Size = new System.Drawing.Size(120, 20);
            this.numPanesE.TabIndex = 10;
            this.numPanesE.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(488, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 40);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "vender producto";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "datos cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(542, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(436, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(542, 152);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "hora";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(61, 286);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(581, 113);
            this.rtbDatos.TabIndex = 21;
            this.rtbDatos.Text = "";
            this.rtbDatos.TextChanged += new System.EventHandler(this.rtbDatos_TextChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(310, 414);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(115, 31);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "borrar datos";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // radPm
            // 
            this.radPm.AutoSize = true;
            this.radPm.Location = new System.Drawing.Point(600, 239);
            this.radPm.Name = "radPm";
            this.radPm.Size = new System.Drawing.Size(41, 17);
            this.radPm.TabIndex = 23;
            this.radPm.TabStop = true;
            this.radPm.Text = "PM";
            this.radPm.UseVisualStyleBackColor = true;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(542, 206);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 20;
            this.txtHora.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // radAm
            // 
            this.radAm.AutoSize = true;
            this.radAm.Location = new System.Drawing.Point(488, 239);
            this.radAm.Name = "radAm";
            this.radAm.Size = new System.Drawing.Size(41, 17);
            this.radAm.TabIndex = 24;
            this.radAm.TabStop = true;
            this.radAm.Text = "AM";
            this.radAm.UseVisualStyleBackColor = true;
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(761, 457);
            this.Controls.Add(this.radAm);
            this.Controls.Add(this.radPm);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.numPanesE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPanesNA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numPanesAL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTituloempleados);
            this.Name = "empleados";
            this.Text = "empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPanesAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanesNA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanesE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloempleados;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numPanesAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPanesNA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPanesE;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.RadioButton radPm;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.RadioButton radAm;
    }
}