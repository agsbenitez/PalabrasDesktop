﻿namespace front
{
    partial class VentanaCrud
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
            this.lblVentana = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVentana
            // 
            this.lblVentana.AutoSize = true;
            this.lblVentana.Location = new System.Drawing.Point(145, 67);
            this.lblVentana.Name = "lblVentana";
            this.lblVentana.Size = new System.Drawing.Size(46, 13);
            this.lblVentana.TabIndex = 0;
            this.lblVentana.Text = "ventana";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // VentanaCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblVentana);
            this.Name = "VentanaCrud";
            this.Text = "VentanaCrud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentana;
        private System.Windows.Forms.TextBox textBox1;
    }
}