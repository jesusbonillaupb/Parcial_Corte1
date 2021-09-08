
namespace Parcial_Corte1
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.lblTituloadmin = new System.Windows.Forms.Label();
            this.lblTextoAdmin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloadmin
            // 
            this.lblTituloadmin.AutoSize = true;
            this.lblTituloadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloadmin.Location = new System.Drawing.Point(226, 27);
            this.lblTituloadmin.Name = "lblTituloadmin";
            this.lblTituloadmin.Size = new System.Drawing.Size(279, 25);
            this.lblTituloadmin.TabIndex = 0;
            this.lblTituloadmin.Text = "Bienvenido administrador";
            // 
            // lblTextoAdmin
            // 
            this.lblTextoAdmin.AutoSize = true;
            this.lblTextoAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoAdmin.Location = new System.Drawing.Point(92, 116);
            this.lblTextoAdmin.Name = "lblTextoAdmin";
            this.lblTextoAdmin.Size = new System.Drawing.Size(565, 25);
            this.lblTextoAdmin.TabIndex = 1;
            this.lblTextoAdmin.Text = " en esta parte puedes acceder a funciones de admin";
            this.lblTextoAdmin.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "regresar a inicio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ademas puedes gestionar ventas y entre otros..";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(761, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTextoAdmin);
            this.Controls.Add(this.lblTituloadmin);
            this.Name = "admin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloadmin;
        private System.Windows.Forms.Label lblTextoAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}