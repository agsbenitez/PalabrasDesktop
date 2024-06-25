namespace front
{
    partial class frmPalabras
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtIdDificultad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblIdDificultad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNuevaPalabra = new System.Windows.Forms.Label();
            this.gripDatos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gripDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(126, 233);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtIdDificultad
            // 
            this.txtIdDificultad.Location = new System.Drawing.Point(127, 129);
            this.txtIdDificultad.Name = "txtIdDificultad";
            this.txtIdDificultad.Size = new System.Drawing.Size(100, 20);
            this.txtIdDificultad.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(127, 174);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lblIdDificultad
            // 
            this.lblIdDificultad.AutoSize = true;
            this.lblIdDificultad.Location = new System.Drawing.Point(25, 129);
            this.lblIdDificultad.Name = "lblIdDificultad";
            this.lblIdDificultad.Size = new System.Drawing.Size(76, 13);
            this.lblIdDificultad.TabIndex = 6;
            this.lblIdDificultad.Text = "Id de dificultad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(38, 181);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // lblNuevaPalabra
            // 
            this.lblNuevaPalabra.AutoSize = true;
            this.lblNuevaPalabra.Location = new System.Drawing.Point(140, 100);
            this.lblNuevaPalabra.Name = "lblNuevaPalabra";
            this.lblNuevaPalabra.Size = new System.Drawing.Size(72, 13);
            this.lblNuevaPalabra.TabIndex = 8;
            this.lblNuevaPalabra.Text = "Nueva Plabra";
            // 
            // gripDatos
            // 
            this.gripDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gripDatos.Location = new System.Drawing.Point(379, 26);
            this.gripDatos.Name = "gripDatos";
            this.gripDatos.Size = new System.Drawing.Size(444, 230);
            this.gripDatos.TabIndex = 9;
            this.gripDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gripDatos_CellContentClick);
            this.gripDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gripDatos_CellDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(24, 233);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmPalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 295);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gripDatos);
            this.Controls.Add(this.lblNuevaPalabra);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblIdDificultad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdDificultad);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmPalabras";
            this.Text = "Palabras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gripDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtIdDificultad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblIdDificultad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNuevaPalabra;
        private System.Windows.Forms.DataGridView gripDatos;
        private System.Windows.Forms.Button btnNuevo;
    }
}