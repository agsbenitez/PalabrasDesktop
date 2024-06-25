using capaEntidad;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace front
{
    public partial class frmLogin : Form
    {
       
        CNUsuario cNUsuario = new CNUsuario();
        bool login;
        public frmLogin()
        {
            InitializeComponent();
        }

        public void loginfile(string dni)
        {
            //se crea un archivo de textoplano con el dni del usuario loguado
            System.IO.File.WriteAllText(@"..\loged.txt", dni);
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

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter | e.KeyChar == (char)Keys.Tab)
            {
                txtDni_Validated(sender, e);
            }
        }

        private void txtDni_Validated(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtDni.Text))
            {
                if (!(numerico(txtDni.Text)))
                {
                    txtDni.Clear();
                    txtDni.Focus();
                }
                else
                {
                    txtPassword.Enabled = true;
                    txtPassword.Focus();
                }
            }
            
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //CDUsua
            // debo recupara el salt y la password almacenada en la base para comparar si lo ingresado y lo almacenado son iguales.
            if (cNUsuario.login(int.Parse(txtDni.Text), txtPassword.Text))
            {
                login = true;
                CNLogOnUser cNLogOnUser = new CNLogOnUser();
                cNLogOnUser.Login(int.Parse(txtDni.Text));
                //se crea una pseudo cooki
                this.loginfile(txtDni.Text);
                this.Close();

            }else
            {
                MessageBox.Show("Usuario o Password Incorrecto");
                txtDni.Clear();
                txtPassword.Clear();
                txtDni.Focus();
            }

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
                }
                else
                {
                    btnAceptar.Enabled = true;
                    btnAceptar.Focus();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!login)
           Application.Exit();
           
                
        }
    }
}
