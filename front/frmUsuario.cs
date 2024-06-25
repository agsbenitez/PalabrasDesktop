using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Se usa capaEntidad
using capaEntidad;
// se usa la capa de negocio pues en ella está la logica de nogicio de la entidad Usuario
using capaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace front
{
    public partial class frmUsuario : Form
    {
        //creo una instancia de la capa de negocio de usuario y la dejo publica poara que este disponible 
        
        CNPerfil cNPerfil = new CNPerfil();
        CNUsuario CNUsuario = new CNUsuario();  



        public void cargarListPefiles(bool removeAdmin)
        {
            if(removeAdmin)
            {
                cmbPerfil.DataSource = cNPerfil.perfiles().Tables["perfiles"];
                cmbPerfil.ValueMember = "id";
                cmbPerfil.DisplayMember = "Descripcion";
            }else
            {
                cmbPerfil.DataSource = cNPerfil.perfiles(removeAdmin).Tables["perfiles"];
                cmbPerfil.ValueMember = "id";
                cmbPerfil.DisplayMember = "Descripcion";
            }
            
           
        }

        public bool text(String cadena)
        {
            if (!(cadena == ""))
            {
                if (!cadena.All(char.IsLetter))
                {
                    MessageBox.Show("Ingrese Solo letras");
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Campo Vacio");
                return false;
            }
        }

        public bool text2(String cadena)
        {
            if (!(cadena == ""))
            {
                
                return true;
            }
            else
            {
                MessageBox.Show("Campo Vacio");
                return false;
            }

        }

        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        
    

        public bool numerico(String cadena)
        {
            int i = 0;
            string cadena_ = cadena;
            bool test = int.TryParse(cadena_, out i);
           
            if (!test)
            {
                MessageBox.Show("Ingrese solo números enteros");
                return false;
            }
            else
            {
                if (cadena.Length < 8)
                {
                    MessageBox.Show("Dni no Valido");
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
        }
        public frmUsuario()
        {
            InitializeComponent();
        }
        public frmUsuario(frmUsuarios.Datos datos)
        {
            InitializeComponent();
            //acá debo tomar la fecha de nacimiento que vine en el tipo datos y pasarsela al picker
            dtFehcaNac.Value = DateTime.Parse(datos.fecha_naciemiento);
            txtId.Text = datos.id_usuario;
            txtApellido.Text = datos.apellido;
            txtNombre.Text = datos.nombre;
            txtDni.Text = datos.dni;
            txtEmail.Text = datos.email;
            cmbPerfil.SelectedValue = datos.id_perfil;
            txtEstablecimiento.Text = datos.entidad;
            txtGrado.Text = datos.grado;
            //ver ell error que da al editar!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (Convert.ToInt32(datos.id_dificultad) == 4)
            {
                chkPrimario.Checked = true;
            }
            else
            {
                chkPrimario.Checked = false;
            }
            
            //cmbPerfil.SelectedValue = 2;


        }

        private void txtBoxApellido_Validated(object sender, EventArgs e)
        {
            if (!(text(txtApellido.Text)))
            {
                txtApellido.Clear();
                txtApellido.Focus();
            }
            else
            {
                txtApellido.Text = txtApellido.Text.ToUpper();
                txtNombre.Enabled = true;
                txtNombre.Focus();
            }
        }

        private void txtBoxApellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter | e.KeyChar == (char)Keys.Tab)
            {
                txtBoxApellido_Validated(sender, e);
            }

        }

        private void clear()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtDni.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPassword2.Clear();
            txtEstablecimiento.Clear();
            txtGrado.Clear();
            //cmbPerfil.Value = 0;
            txtNombre.Enabled = false;
            txtDni.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword2.Enabled = false;
            txtEstablecimiento.Enabled = false;
            txtGrado.Enabled = false;
            txtEstablecimiento.Visible = false;
            txtGrado.Visible = false;

        }

    

        private void txtBoxNombre_Validated(object sender, EventArgs e)
        {
            if (!(text(txtNombre.Text)))
            {
                txtNombre.Clear();
                txtNombre.Focus();
            }
            else
            {
                txtNombre.Text = txtNombre.Text.ToUpper();
                txtDni.Enabled = true;
                txtDni.Focus();
            }
        }

        private void txtBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter | e.KeyChar == (char)Keys.Tab)
            {
                txtBoxNombre_Validated(sender, e);
            }
        }

        private void txtBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter | e.KeyChar == (char)Keys.Tab)
            {
                txtBoxDni_Validated(sender, e);
            }
        }

        private void txtBoxDni_Validated(object sender, EventArgs e)
        {
            if (!(numerico(txtDni.Text)))
            {
                txtDni.Clear();
                txtDni.Focus();
            }
            else
            {
                txtEmail.Enabled = true;
                txtEmail.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUsuarios fUsuarios = Owner as frmUsuarios;
            bool resul;
            CEUsuario cEUsuario = new CEUsuario();
            if (txtId.Text != string.Empty)
            {
                cEUsuario.id_usuario = Convert.ToInt32(txtId.Text);
            }
            cEUsuario.apellido = txtApellido.Text;
            cEUsuario.nombre = txtNombre.Text;
            cEUsuario.email = txtEmail.Text;
            cEUsuario.id_perfil = Convert.ToInt32(cmbPerfil.SelectedValue);
            //DateTime date = dtFehcaNac.Value;
            //String fe_nac_string = date.ToShortDateString();
            cEUsuario.fecha_nacimiento = dtFehcaNac.Value;
            //cEUsuario.id_perfil = 1;
            cEUsuario.password = txtPassword.Text;
            var sele = cmbPerfil.SelectedText;
            
            cEUsuario.grado = txtGrado.Text;
            cEUsuario.entidad = txtEstablecimiento.Text;
            if (Convert.ToInt32(cmbPerfil.SelectedValue) == 4)
            {
                if (chkPrimario.Checked)
                {
                    cEUsuario.id_dificultad = 4;
                }
                else
                {
                    cEUsuario.id_dificultad = 5;
                }
            }
            else
            {
                cEUsuario.id_dificultad = 6;
            }
            

            int dni = int.Parse(txtDni.Text);
            cEUsuario.dni = dni;

            resul = CNUsuario.validadorDatos(cEUsuario);

            if (resul == false)
            {
                MessageBox.Show("Algo a salido mal");
                return;
            }

            if (txtId.Text == string.Empty)
            {
                CNUsuario.crearUsuario(cEUsuario);
            }
            else
            {
                CNUsuario.editarUsuario(cEUsuario);
            }
            fUsuarios.cargarGrid();
            
            
            this.clear();
        }

     

        private void frmUsuario_Load(object sender, EventArgs e)
        {

            
            CNPermisos cNPermisos = new CNPermisos();
            DataTable permis = cNPermisos.getpermis();
            
            bool alta_usuario_admin = true;
            bool modificacion_usuario = true;


            foreach (DataRow row in permis.Rows)
            {
                alta_usuario_admin = Convert.ToBoolean(row["alta_usuario_admin"]);
                //baja_usuario = Convert.ToBoolean(row["baja_usuario"]);
                modificacion_usuario = Convert.ToBoolean(row["modificacion_usuario"]);
            }
            //int permiso0 = int.Parse(permisoRow[2].ToString());

             cargarListPefiles(alta_usuario_admin);

           
           
            if (!modificacion_usuario)
            {
                btnGuardar.Enabled = false;
            }
            

        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            //Validar el correo.
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email inválido");
            }else
            {
                dtFehcaNac.Enabled = true;
                dtFehcaNac.Focus();
                  
            }
            
            
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == (char)Keys.Enter | e.KeyChar == (char)Keys.Tab)
            {
                txtEmail_Validated(sender, e);
            }
        }

       

        private void dtFehcaNac_Validated(object sender, EventArgs e)
        {
            if (dtFehcaNac.Text.Equals(DateTime.Now.ToShortDateString()))
            {
                MessageBox.Show("la Fecha de Nacimiento no puede ser hoy");
            }
            else
            {
                txtPassword.Enabled = true;
                txtPassword.Focus();
            }
        }

        private void dtFehcaNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtFehcaNac_Validated(sender, e);
            }
        }

       

        private void cmbPerfil_Leave(object sender, EventArgs e)
        {
            var sele = cmbPerfil.SelectedText;
            if (sele.ToString() == "Jugador")
            {
                lblEstablecimiento.Visible = true;
                lblGrado.Visible = true;
                txtEstablecimiento.Visible=true;
                txtGrado.Visible=true;
                chkPrimario.Visible = true;
                chkPrimario.Enabled = true;
               
            }
            else
            {
                lblEstablecimiento.Visible = false;
                lblGrado.Visible = false;
                txtEstablecimiento.Visible = false;
                txtGrado.Visible = false;
                chkPrimario.Visible = false;
                chkPrimario.Enabled = false;

            }
            txtApellido.Enabled = true;
            txtApellido.Focus();
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("La Contraseña es Obligatoria");
            }
            else
            {
                if (9 > txtPassword.Text.Length)
                {
                    MessageBox.Show("Contraseña my corta, debe tener mas de 8 caracteres");
                    txtPassword.Clear();
                    txtPassword.Focus();
                }else
                {
                    txtPassword2.Enabled = true;
                    txtPassword2.Focus();
                }
                
            }

        }

  
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter | e.KeyChar == (char)Keys.Tab)
            {
                txtPassword_Validated(sender, e);
            }
        }

        private void cmbPerfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter | e.KeyChar == (char)Keys.Tab)
            {
                txtApellido.Enabled = true;
                txtApellido.Focus();
            }
        }

        private void txtPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter | e.KeyChar == (char)Keys.Tab)
            {
                txtPassword2_Validated(sender, e);
            }

            
        }

        private void txtPassword2_Validated(object sender, EventArgs e)
        {
            if (txtPassword2.Text == txtPassword.Text)
            {
                if (txtEstablecimiento.Visible)
                {
                    txtEstablecimiento.Enabled = true;
                    txtEstablecimiento.Focus();
                }else
                {
                    btnGuardar.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Contraseñas No Coinciden");
                txtPassword2.Clear();
                txtPassword.Clear();
                txtPassword.Focus();

            }
        }

        private void txtEstablecimiento_Validated(object sender, EventArgs e)
        {
            if (!(text2(txtEstablecimiento.Text)))
            {
                txtEstablecimiento.Clear();
                txtEstablecimiento.Focus();
            }
            else
            {
                txtEstablecimiento.Text = txtEstablecimiento.Text.ToUpper();
                txtGrado.Enabled = true;
                txtGrado.Focus();
            }
        }

        private void txtEstablecimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter | e.KeyChar == (char)Keys.Tab)
            {
                txtEstablecimiento_Validated(sender, e);
            }
        }

        private void txtGrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter | e.KeyChar == (char)Keys.Tab)
            {
                txtGrado_Validated(sender, e);
            }
        }

        private void txtGrado_Validated(object sender, EventArgs e)
        {
            if (!(text2(txtGrado.Text)))
            {
                txtGrado.Clear();
                txtGrado.Focus();
            }
            else
            {
                txtEstablecimiento.Text = txtEstablecimiento.Text.ToUpper();
                btnGuardar.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
