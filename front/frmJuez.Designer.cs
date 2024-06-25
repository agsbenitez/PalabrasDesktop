namespace front
{
    partial class frmJuez
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
            this.components = new System.ComponentModel.Container();
            this.grpBPalabrasAlumno = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.btnSigJugador = new System.Windows.Forms.Button();
            this.btnFinJuego = new System.Windows.Forms.Button();
            this.txtIdParticipante = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblIdJuego = new System.Windows.Forms.Label();
            this.lblindexJugador = new System.Windows.Forms.Label();
            this.lblCantJugadores = new System.Windows.Forms.Label();
            this.grpBPalabrasAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBPalabrasAlumno
            // 
            this.grpBPalabrasAlumno.BackColor = System.Drawing.Color.Transparent;
            this.grpBPalabrasAlumno.Controls.Add(this.checkedListBox1);
            this.grpBPalabrasAlumno.Font = new System.Drawing.Font("Adabra", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBPalabrasAlumno.Location = new System.Drawing.Point(52, 134);
            this.grpBPalabrasAlumno.Name = "grpBPalabrasAlumno";
            this.grpBPalabrasAlumno.Size = new System.Drawing.Size(385, 328);
            this.grpBPalabrasAlumno.TabIndex = 0;
            this.grpBPalabrasAlumno.TabStop = false;
            this.grpBPalabrasAlumno.Text = "Palabras por Alumno";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(49, 41);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(290, 256);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox1_MouseClick);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Adabra", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(48, 27);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(160, 66);
            this.lblAlumno.TabIndex = 1;
            this.lblAlumno.Text = "Alumno";
            // 
            // btnSigJugador
            // 
            this.btnSigJugador.BackColor = System.Drawing.Color.Transparent;
            this.btnSigJugador.BackgroundImage = global::front.Properties.Resources.SigJugador;
            this.btnSigJugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSigJugador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSigJugador.Location = new System.Drawing.Point(729, 27);
            this.btnSigJugador.Name = "btnSigJugador";
            this.btnSigJugador.Size = new System.Drawing.Size(217, 58);
            this.btnSigJugador.TabIndex = 2;
            this.btnSigJugador.UseVisualStyleBackColor = false;
            this.btnSigJugador.Click += new System.EventHandler(this.btnSigJugador_Click);
            // 
            // btnFinJuego
            // 
            this.btnFinJuego.BackColor = System.Drawing.Color.Transparent;
            this.btnFinJuego.BackgroundImage = global::front.Properties.Resources.finJuego;
            this.btnFinJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinJuego.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinJuego.Location = new System.Drawing.Point(799, 463);
            this.btnFinJuego.Name = "btnFinJuego";
            this.btnFinJuego.Size = new System.Drawing.Size(147, 58);
            this.btnFinJuego.TabIndex = 3;
            this.btnFinJuego.UseVisualStyleBackColor = false;
            this.btnFinJuego.Click += new System.EventHandler(this.btnFinJuego_Click);
            // 
            // txtIdParticipante
            // 
            this.txtIdParticipante.Enabled = false;
            this.txtIdParticipante.Location = new System.Drawing.Point(255, 47);
            this.txtIdParticipante.Name = "txtIdParticipante";
            this.txtIdParticipante.Size = new System.Drawing.Size(100, 20);
            this.txtIdParticipante.TabIndex = 4;
            this.txtIdParticipante.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Adabra", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(788, 175);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 66);
            this.lblTime.TabIndex = 5;
            // 
            // lblIdJuego
            // 
            this.lblIdJuego.AutoSize = true;
            this.lblIdJuego.Font = new System.Drawing.Font("Adabra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJuego.Location = new System.Drawing.Point(476, 292);
            this.lblIdJuego.Name = "lblIdJuego";
            this.lblIdJuego.Size = new System.Drawing.Size(45, 15);
            this.lblIdJuego.TabIndex = 6;
            this.lblIdJuego.Text = "id_juego";
            this.lblIdJuego.Visible = false;
            // 
            // lblindexJugador
            // 
            this.lblindexJugador.AutoSize = true;
            this.lblindexJugador.Font = new System.Drawing.Font("Adabra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblindexJugador.Location = new System.Drawing.Point(476, 307);
            this.lblindexJugador.Name = "lblindexJugador";
            this.lblindexJugador.Size = new System.Drawing.Size(67, 15);
            this.lblindexJugador.TabIndex = 7;
            this.lblindexJugador.Text = "indexJugador";
            this.lblindexJugador.Visible = false;
            // 
            // lblCantJugadores
            // 
            this.lblCantJugadores.AutoSize = true;
            this.lblCantJugadores.Font = new System.Drawing.Font("Adabra", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantJugadores.Location = new System.Drawing.Point(476, 322);
            this.lblCantJugadores.Name = "lblCantJugadores";
            this.lblCantJugadores.Size = new System.Drawing.Size(71, 15);
            this.lblCantJugadores.TabIndex = 8;
            this.lblCantJugadores.Text = "cantJugadores";
            this.lblCantJugadores.Visible = false;
            // 
            // frmJuez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::front.Properties.Resources._d3df169f_a9f7_4aed_acbf_adc473dc2211;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 621);
            this.Controls.Add(this.lblCantJugadores);
            this.Controls.Add(this.lblindexJugador);
            this.Controls.Add(this.lblIdJuego);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtIdParticipante);
            this.Controls.Add(this.btnFinJuego);
            this.Controls.Add(this.btnSigJugador);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.grpBPalabrasAlumno);
            this.Name = "frmJuez";
            this.Text = "Juez";
            this.Load += new System.EventHandler(this.frmJuez_Load);
            this.grpBPalabrasAlumno.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBPalabrasAlumno;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Button btnSigJugador;
        private System.Windows.Forms.Button btnFinJuego;
        private System.Windows.Forms.TextBox txtIdParticipante;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblIdJuego;
        private System.Windows.Forms.Label lblindexJugador;
        private System.Windows.Forms.Label lblCantJugadores;
    }
}