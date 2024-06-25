namespace front
{
    partial class frmPlay
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJugadores = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNJuego = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adabra", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleciones Jugador:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbJugadores
            // 
            this.cmbJugadores.FormattingEnabled = true;
            this.cmbJugadores.Location = new System.Drawing.Point(243, 213);
            this.cmbJugadores.Name = "cmbJugadores";
            this.cmbJugadores.Size = new System.Drawing.Size(128, 21);
            this.cmbJugadores.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::front.Properties.Resources.play1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(405, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 49);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNJuego
            // 
            this.lblNJuego.AutoSize = true;
            this.lblNJuego.Location = new System.Drawing.Point(104, 50);
            this.lblNJuego.Name = "lblNJuego";
            this.lblNJuego.Size = new System.Drawing.Size(63, 13);
            this.lblNJuego.TabIndex = 5;
            this.lblNJuego.Text = "nuevojuego";
            // 
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::front.Properties.Resources._a4224fd4_357c_44f2_a3c9_1fcd696d2ef3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 500);
            this.Controls.Add(this.lblNJuego);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbJugadores);
            this.Controls.Add(this.label1);
            this.Name = "frmPlay";
            this.Text = "Play";
            this.Load += new System.EventHandler(this.FrmPlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJugadores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNJuego;
    }
}