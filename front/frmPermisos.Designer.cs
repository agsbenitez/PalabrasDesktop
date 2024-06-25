namespace front
{
    partial class frmPermisos
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
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBoxOtros = new System.Windows.Forms.GroupBox();
            this.chkBoxListPalabras = new System.Windows.Forms.CheckBox();
            this.chkBkp = new System.Windows.Forms.CheckBox();
            this.choReportes = new System.Windows.Forms.CheckBox();
            this.chkNJuego = new System.Windows.Forms.CheckBox();
            this.grpBoxPalabras = new System.Windows.Forms.GroupBox();
            this.chkBajaP = new System.Windows.Forms.CheckBox();
            this.chkModP = new System.Windows.Forms.CheckBox();
            this.chkAltaP = new System.Windows.Forms.CheckBox();
            this.grpBoxUsuarios = new System.Windows.Forms.GroupBox();
            this.chkPermisos = new System.Windows.Forms.CheckBox();
            this.chkAltaAdmin = new System.Windows.Forms.CheckBox();
            this.chkBaja = new System.Windows.Forms.CheckBox();
            this.chkMod = new System.Windows.Forms.CheckBox();
            this.chkAlta = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpBoxOtros.SuspendLayout();
            this.grpBoxPalabras.SuspendLayout();
            this.grpBoxUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(385, 37);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(30, 13);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Perfil";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(421, 34);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(121, 21);
            this.cmbPerfil.TabIndex = 1;
            this.cmbPerfil.SelectedIndexChanged += new System.EventHandler(this.cmbPerfil_SelectedIndexChanged);
            this.cmbPerfil.Leave += new System.EventHandler(this.cmbPerfil_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpBoxOtros);
            this.groupBox1.Controls.Add(this.grpBoxPalabras);
            this.groupBox1.Controls.Add(this.grpBoxUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(46, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // grpBoxOtros
            // 
            this.grpBoxOtros.Controls.Add(this.chkBoxListPalabras);
            this.grpBoxOtros.Controls.Add(this.chkBkp);
            this.grpBoxOtros.Controls.Add(this.choReportes);
            this.grpBoxOtros.Controls.Add(this.chkNJuego);
            this.grpBoxOtros.Location = new System.Drawing.Point(566, 37);
            this.grpBoxOtros.Name = "grpBoxOtros";
            this.grpBoxOtros.Size = new System.Drawing.Size(294, 129);
            this.grpBoxOtros.TabIndex = 2;
            this.grpBoxOtros.TabStop = false;
            this.grpBoxOtros.Text = "Otros";
            // 
            // chkBoxListPalabras
            // 
            this.chkBoxListPalabras.AutoSize = true;
            this.chkBoxListPalabras.Location = new System.Drawing.Point(20, 81);
            this.chkBoxListPalabras.Name = "chkBoxListPalabras";
            this.chkBoxListPalabras.Size = new System.Drawing.Size(119, 17);
            this.chkBoxListPalabras.TabIndex = 17;
            this.chkBoxListPalabras.Tag = "11";
            this.chkBoxListPalabras.Text = "Listado de Palabras";
            this.chkBoxListPalabras.UseVisualStyleBackColor = true;
            // 
            // chkBkp
            // 
            this.chkBkp.AutoSize = true;
            this.chkBkp.Location = new System.Drawing.Point(227, 36);
            this.chkBkp.Name = "chkBkp";
            this.chkBkp.Size = new System.Drawing.Size(63, 17);
            this.chkBkp.TabIndex = 16;
            this.chkBkp.Tag = "10";
            this.chkBkp.Text = "Backup";
            this.chkBkp.UseVisualStyleBackColor = true;
            // 
            // choReportes
            // 
            this.choReportes.AutoSize = true;
            this.choReportes.Location = new System.Drawing.Point(126, 36);
            this.choReportes.Name = "choReportes";
            this.choReportes.Size = new System.Drawing.Size(69, 17);
            this.choReportes.TabIndex = 15;
            this.choReportes.Tag = "9";
            this.choReportes.Text = "Reportes";
            this.choReportes.UseVisualStyleBackColor = true;
            // 
            // chkNJuego
            // 
            this.chkNJuego.AutoSize = true;
            this.chkNJuego.Location = new System.Drawing.Point(20, 36);
            this.chkNJuego.Name = "chkNJuego";
            this.chkNJuego.Size = new System.Drawing.Size(90, 17);
            this.chkNJuego.TabIndex = 14;
            this.chkNJuego.Tag = "8";
            this.chkNJuego.Text = "Nuevo Juego";
            this.chkNJuego.UseVisualStyleBackColor = true;
            // 
            // grpBoxPalabras
            // 
            this.grpBoxPalabras.Controls.Add(this.chkBajaP);
            this.grpBoxPalabras.Controls.Add(this.chkModP);
            this.grpBoxPalabras.Controls.Add(this.chkAltaP);
            this.grpBoxPalabras.Location = new System.Drawing.Point(287, 37);
            this.grpBoxPalabras.Name = "grpBoxPalabras";
            this.grpBoxPalabras.Size = new System.Drawing.Size(260, 129);
            this.grpBoxPalabras.TabIndex = 1;
            this.grpBoxPalabras.TabStop = false;
            this.grpBoxPalabras.Text = "Palabras";
            // 
            // chkBajaP
            // 
            this.chkBajaP.AutoSize = true;
            this.chkBajaP.Location = new System.Drawing.Point(193, 36);
            this.chkBajaP.Name = "chkBajaP";
            this.chkBajaP.Size = new System.Drawing.Size(47, 17);
            this.chkBajaP.TabIndex = 13;
            this.chkBajaP.Tag = "7";
            this.chkBajaP.Text = "Baja";
            this.chkBajaP.UseVisualStyleBackColor = true;
            // 
            // chkModP
            // 
            this.chkModP.AutoSize = true;
            this.chkModP.Location = new System.Drawing.Point(88, 36);
            this.chkModP.Name = "chkModP";
            this.chkModP.Size = new System.Drawing.Size(86, 17);
            this.chkModP.TabIndex = 12;
            this.chkModP.Tag = "6";
            this.chkModP.Text = "Modificación";
            this.chkModP.UseVisualStyleBackColor = true;
            // 
            // chkAltaP
            // 
            this.chkAltaP.AutoSize = true;
            this.chkAltaP.Location = new System.Drawing.Point(6, 36);
            this.chkAltaP.Name = "chkAltaP";
            this.chkAltaP.Size = new System.Drawing.Size(44, 17);
            this.chkAltaP.TabIndex = 11;
            this.chkAltaP.Tag = "5";
            this.chkAltaP.Text = "Alta";
            this.chkAltaP.UseVisualStyleBackColor = true;
            // 
            // grpBoxUsuarios
            // 
            this.grpBoxUsuarios.Controls.Add(this.chkPermisos);
            this.grpBoxUsuarios.Controls.Add(this.chkAltaAdmin);
            this.grpBoxUsuarios.Controls.Add(this.chkBaja);
            this.grpBoxUsuarios.Controls.Add(this.chkMod);
            this.grpBoxUsuarios.Controls.Add(this.chkAlta);
            this.grpBoxUsuarios.Location = new System.Drawing.Point(6, 37);
            this.grpBoxUsuarios.Name = "grpBoxUsuarios";
            this.grpBoxUsuarios.Size = new System.Drawing.Size(275, 129);
            this.grpBoxUsuarios.TabIndex = 0;
            this.grpBoxUsuarios.TabStop = false;
            this.grpBoxUsuarios.Text = "Usuarios";
            // 
            // chkPermisos
            // 
            this.chkPermisos.AutoSize = true;
            this.chkPermisos.Location = new System.Drawing.Point(138, 81);
            this.chkPermisos.Name = "chkPermisos";
            this.chkPermisos.Size = new System.Drawing.Size(68, 17);
            this.chkPermisos.TabIndex = 11;
            this.chkPermisos.Tag = "12";
            this.chkPermisos.Text = "Permisos";
            this.chkPermisos.UseVisualStyleBackColor = true;
            // 
            // chkAltaAdmin
            // 
            this.chkAltaAdmin.AutoSize = true;
            this.chkAltaAdmin.Location = new System.Drawing.Point(6, 81);
            this.chkAltaAdmin.Name = "chkAltaAdmin";
            this.chkAltaAdmin.Size = new System.Drawing.Size(115, 17);
            this.chkAltaAdmin.TabIndex = 10;
            this.chkAltaAdmin.Tag = "1";
            this.chkAltaAdmin.Text = "Alta Usuario Admin";
            this.chkAltaAdmin.UseVisualStyleBackColor = true;
            // 
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.chkBaja.Location = new System.Drawing.Point(193, 36);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(47, 17);
            this.chkBaja.TabIndex = 9;
            this.chkBaja.Tag = "3";
            this.chkBaja.Text = "Baja";
            this.chkBaja.UseVisualStyleBackColor = true;
            // 
            // chkMod
            // 
            this.chkMod.AutoSize = true;
            this.chkMod.Location = new System.Drawing.Point(78, 36);
            this.chkMod.Name = "chkMod";
            this.chkMod.Size = new System.Drawing.Size(86, 17);
            this.chkMod.TabIndex = 8;
            this.chkMod.Tag = "2";
            this.chkMod.Text = "Modificación";
            this.chkMod.UseVisualStyleBackColor = true;
            // 
            // chkAlta
            // 
            this.chkAlta.AutoSize = true;
            this.chkAlta.Location = new System.Drawing.Point(6, 36);
            this.chkAlta.Name = "chkAlta";
            this.chkAlta.Size = new System.Drawing.Size(44, 17);
            this.chkAlta.TabIndex = 7;
            this.chkAlta.Tag = "4";
            this.chkAlta.Text = "Alta";
            this.chkAlta.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(868, 363);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(717, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(578, 363);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 421);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.lblRol);
            this.Name = "frmPermisos";
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpBoxOtros.ResumeLayout(false);
            this.grpBoxOtros.PerformLayout();
            this.grpBoxPalabras.ResumeLayout(false);
            this.grpBoxPalabras.PerformLayout();
            this.grpBoxUsuarios.ResumeLayout(false);
            this.grpBoxUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxPalabras;
        private System.Windows.Forms.GroupBox grpBoxUsuarios;
        private System.Windows.Forms.GroupBox grpBoxOtros;
        private System.Windows.Forms.CheckBox chkAltaAdmin;
        private System.Windows.Forms.CheckBox chkBaja;
        private System.Windows.Forms.CheckBox chkMod;
        private System.Windows.Forms.CheckBox chkAlta;
        private System.Windows.Forms.CheckBox chkBkp;
        private System.Windows.Forms.CheckBox choReportes;
        private System.Windows.Forms.CheckBox chkNJuego;
        private System.Windows.Forms.CheckBox chkBajaP;
        private System.Windows.Forms.CheckBox chkModP;
        private System.Windows.Forms.CheckBox chkAltaP;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkBoxListPalabras;
        private System.Windows.Forms.CheckBox chkPermisos;
    }
}