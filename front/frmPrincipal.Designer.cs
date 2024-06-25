namespace front
{
    partial class frmPrincipal
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
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnPalabras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Transparent;
            this.btnJugar.BackgroundImage = global::front.Properties.Resources.JugarPNG;
            this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJugar.Location = new System.Drawing.Point(201, 236);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(123, 63);
            this.btnJugar.TabIndex = 22;
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnPalabras
            // 
            this.btnPalabras.BackColor = System.Drawing.Color.Transparent;
            this.btnPalabras.BackgroundImage = global::front.Properties.Resources.Palabras1;
            this.btnPalabras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPalabras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPalabras.Location = new System.Drawing.Point(597, 237);
            this.btnPalabras.Name = "btnPalabras";
            this.btnPalabras.Size = new System.Drawing.Size(181, 63);
            this.btnPalabras.TabIndex = 24;
            this.btnPalabras.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::front.Properties.Resources._a6b0d98e_df4a_4c63_9710_63662760ec09;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 621);
            this.Controls.Add(this.btnPalabras);
            this.Controls.Add(this.btnJugar);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnPalabras;
    }
}