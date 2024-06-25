namespace front
{
    partial class frmPalabraCorrecta
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
            this.btnPalabraCorrecta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPalabraCorrecta = new System.Windows.Forms.Label();
            this.btnPalabraIncorrecta = new System.Windows.Forms.Button();
            this.btnMejorParticipante = new System.Windows.Forms.Button();
            this.btnCantidadJegos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPalabraCorrecta
            // 
            this.btnPalabraCorrecta.Location = new System.Drawing.Point(41, 232);
            this.btnPalabraCorrecta.Name = "btnPalabraCorrecta";
            this.btnPalabraCorrecta.Size = new System.Drawing.Size(134, 23);
            this.btnPalabraCorrecta.TabIndex = 0;
            this.btnPalabraCorrecta.Text = "Palabra Correcta";
            this.btnPalabraCorrecta.UseVisualStyleBackColor = true;
            this.btnPalabraCorrecta.Click += new System.EventHandler(this.btnPalabraCorrecta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(955, 168);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblPalabraCorrecta
            // 
            this.lblPalabraCorrecta.AutoSize = true;
            this.lblPalabraCorrecta.Location = new System.Drawing.Point(198, 9);
            this.lblPalabraCorrecta.Name = "lblPalabraCorrecta";
            this.lblPalabraCorrecta.Size = new System.Drawing.Size(0, 13);
            this.lblPalabraCorrecta.TabIndex = 2;
            this.lblPalabraCorrecta.Click += new System.EventHandler(this.lblPalabraCorrecta_Click);
            // 
            // btnPalabraIncorrecta
            // 
            this.btnPalabraIncorrecta.Location = new System.Drawing.Point(216, 232);
            this.btnPalabraIncorrecta.Name = "btnPalabraIncorrecta";
            this.btnPalabraIncorrecta.Size = new System.Drawing.Size(151, 23);
            this.btnPalabraIncorrecta.TabIndex = 3;
            this.btnPalabraIncorrecta.Text = "Palabras incorrectas";
            this.btnPalabraIncorrecta.UseVisualStyleBackColor = true;
            this.btnPalabraIncorrecta.Click += new System.EventHandler(this.btnPalabraIncorrecta_Click);
            // 
            // btnMejorParticipante
            // 
            this.btnMejorParticipante.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMejorParticipante.Location = new System.Drawing.Point(404, 232);
            this.btnMejorParticipante.Name = "btnMejorParticipante";
            this.btnMejorParticipante.Size = new System.Drawing.Size(135, 23);
            this.btnMejorParticipante.TabIndex = 4;
            this.btnMejorParticipante.Text = "Mejor Participante";
            this.btnMejorParticipante.UseVisualStyleBackColor = true;
            this.btnMejorParticipante.Click += new System.EventHandler(this.btnMejorParticipante_Click);
            // 
            // btnCantidadJegos
            // 
            this.btnCantidadJegos.Location = new System.Drawing.Point(575, 232);
            this.btnCantidadJegos.Name = "btnCantidadJegos";
            this.btnCantidadJegos.Size = new System.Drawing.Size(123, 23);
            this.btnCantidadJegos.TabIndex = 5;
            this.btnCantidadJegos.Text = "Cantidad De Juegos";
            this.btnCantidadJegos.UseVisualStyleBackColor = true;
            this.btnCantidadJegos.Click += new System.EventHandler(this.btnCantidadJegos_Click);
            // 
            // frmPalabraCorrecta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 279);
            this.Controls.Add(this.btnCantidadJegos);
            this.Controls.Add(this.btnMejorParticipante);
            this.Controls.Add(this.btnPalabraIncorrecta);
            this.Controls.Add(this.lblPalabraCorrecta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPalabraCorrecta);
            this.Name = "frmPalabraCorrecta";
            this.Text = "frmPalabraCorrecta";
            this.Load += new System.EventHandler(this.frmPalabraCorrecta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPalabraCorrecta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPalabraCorrecta;
        private System.Windows.Forms.Button btnPalabraIncorrecta;
        private System.Windows.Forms.Button btnMejorParticipante;
        private System.Windows.Forms.Button btnCantidadJegos;
    }
}