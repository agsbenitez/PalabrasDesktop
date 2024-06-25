namespace front
{
    partial class frmJuego
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
            this.lblDificultad = new System.Windows.Forms.Label();
            this.cbDificultad = new System.Windows.Forms.ComboBox();
            this.gboxParticipantes = new System.Windows.Forms.GroupBox();
            this.dtGParticipantesS = new System.Windows.Forms.DataGridView();
            this.id_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.establecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtGParticipantesNS = new System.Windows.Forms.DataGridView();
            this.btnRemove_1 = new System.Windows.Forms.Button();
            this.btnAdd_1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.gboxParticipantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGParticipantesS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGParticipantesNS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.BackColor = System.Drawing.Color.Transparent;
            this.lblDificultad.Font = new System.Drawing.Font("Adabra", 22F);
            this.lblDificultad.Location = new System.Drawing.Point(464, 62);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(110, 31);
            this.lblDificultad.TabIndex = 1;
            this.lblDificultad.Text = "Dificultad:";
            // 
            // cbDificultad
            // 
            this.cbDificultad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDificultad.Font = new System.Drawing.Font("Adabra", 18F);
            this.cbDificultad.FormattingEnabled = true;
            this.cbDificultad.Items.AddRange(new object[] {
            "Primario",
            "Secundario"});
            this.cbDificultad.Location = new System.Drawing.Point(580, 60);
            this.cbDificultad.Name = "cbDificultad";
            this.cbDificultad.Size = new System.Drawing.Size(207, 33);
            this.cbDificultad.TabIndex = 2;
            this.cbDificultad.SelectedIndexChanged += new System.EventHandler(this.cbDificultad_SelectedIndexChanged);
            // 
            // gboxParticipantes
            // 
            this.gboxParticipantes.BackColor = System.Drawing.Color.Transparent;
            this.gboxParticipantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gboxParticipantes.Controls.Add(this.dtGParticipantesS);
            this.gboxParticipantes.Controls.Add(this.dtGParticipantesNS);
            this.gboxParticipantes.Controls.Add(this.btnRemove_1);
            this.gboxParticipantes.Controls.Add(this.btnAdd_1);
            this.gboxParticipantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gboxParticipantes.Font = new System.Drawing.Font("Adabra", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxParticipantes.Location = new System.Drawing.Point(5, 126);
            this.gboxParticipantes.Name = "gboxParticipantes";
            this.gboxParticipantes.Size = new System.Drawing.Size(941, 347);
            this.gboxParticipantes.TabIndex = 5;
            this.gboxParticipantes.TabStop = false;
            this.gboxParticipantes.Text = "Participantes";
            // 
            // dtGParticipantesS
            // 
            this.dtGParticipantesS.AllowUserToAddRows = false;
            this.dtGParticipantesS.AllowUserToDeleteRows = false;
            this.dtGParticipantesS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGParticipantesS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_perfil,
            this.id_usuario,
            this.apellido,
            this.nombre,
            this.establecimiento});
            this.dtGParticipantesS.Location = new System.Drawing.Point(541, 37);
            this.dtGParticipantesS.Name = "dtGParticipantesS";
            this.dtGParticipantesS.ReadOnly = true;
            this.dtGParticipantesS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGParticipantesS.Size = new System.Drawing.Size(372, 304);
            this.dtGParticipantesS.TabIndex = 10;
            // 
            // id_perfil
            // 
            this.id_perfil.HeaderText = "id_perfil";
            this.id_perfil.Name = "id_perfil";
            this.id_perfil.ReadOnly = true;
            this.id_perfil.Visible = false;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "id_usuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Visible = false;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // establecimiento
            // 
            this.establecimiento.HeaderText = "establecimiento";
            this.establecimiento.Name = "establecimiento";
            this.establecimiento.ReadOnly = true;
            // 
            // dtGParticipantesNS
            // 
            this.dtGParticipantesNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGParticipantesNS.Location = new System.Drawing.Point(36, 37);
            this.dtGParticipantesNS.Name = "dtGParticipantesNS";
            this.dtGParticipantesNS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGParticipantesNS.Size = new System.Drawing.Size(372, 304);
            this.dtGParticipantesNS.TabIndex = 9;
            this.dtGParticipantesNS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGParticipantesNS_CellContentClick);
            // 
            // btnRemove_1
            // 
            this.btnRemove_1.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove_1.Location = new System.Drawing.Point(452, 194);
            this.btnRemove_1.Name = "btnRemove_1";
            this.btnRemove_1.Size = new System.Drawing.Size(50, 39);
            this.btnRemove_1.TabIndex = 7;
            this.btnRemove_1.Text = "<";
            this.btnRemove_1.UseVisualStyleBackColor = false;
            this.btnRemove_1.Click += new System.EventHandler(this.btnRemove_1_Click);
            // 
            // btnAdd_1
            // 
            this.btnAdd_1.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd_1.Location = new System.Drawing.Point(452, 137);
            this.btnAdd_1.Name = "btnAdd_1";
            this.btnAdd_1.Size = new System.Drawing.Size(50, 39);
            this.btnAdd_1.TabIndex = 5;
            this.btnAdd_1.Text = ">";
            this.btnAdd_1.UseVisualStyleBackColor = false;
            this.btnAdd_1.Click += new System.EventHandler(this.btnAdd_1_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::front.Properties.Resources.Signiña1;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Adabra", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(727, 535);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(191, 58);
            this.btnNext.TabIndex = 6;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::front.Properties.Resources._1d8dda5c_48aa_486f_96a5_9525d09a38d6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 621);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.gboxParticipantes);
            this.Controls.Add(this.cbDificultad);
            this.Controls.Add(this.lblDificultad);
            this.Name = "frmJuego";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.frmJuego_Load);
            this.gboxParticipantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGParticipantesS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGParticipantesNS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.ComboBox cbDificultad;
        private System.Windows.Forms.GroupBox gboxParticipantes;
        private System.Windows.Forms.Button btnRemove_1;
        private System.Windows.Forms.Button btnAdd_1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dtGParticipantesNS;
        private System.Windows.Forms.DataGridView dtGParticipantesS;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn establecimiento;
    }
}