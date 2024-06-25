
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace front
{
    public partial class frmMainMDI : Form
    {
       

        public frmMainMDI()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            frmPrincipal fp = new frmPrincipal();

            fp.MdiParent = this;

            fp.Show();
            

            //Desactivo el Loguin para poder hacer un alata
            frmLogin f2 = new frmLogin();
            f2.ShowDialog();
            //Shows Form2
        }

      
     

       

        private void frmMainMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            CNLogOnUser cNLogOnUser = new CNLogOnUser();

            string logUser = System.IO.File.ReadAllText("..\\loged.txt");
            cNLogOnUser.Logout(int.Parse(logUser));
            System.Windows.Forms.Application.Exit();

          
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParticipantes frmParticipantes = new frmParticipantes();
            frmParticipantes.MdiParent = this;
            frmParticipantes.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CNPermisos cNPermisos = new CNPermisos();
            DataTable permis = cNPermisos.getpermis();
            bool modificacion_usuario = true;
            bool baja_usuario = true;
            bool alta_usuario = true;
            bool alta_usuario_admin = true;
            foreach (DataRow row in permis.Rows)
            {
                alta_usuario_admin = Convert.ToBoolean(row["alta_usuario_admin"]); 
                modificacion_usuario = Convert.ToBoolean(row["modificacion_usuario"]);
                baja_usuario = Convert.ToBoolean(row["baja_usuario"]);
                alta_usuario = Convert.ToBoolean(row["alta_usuario"]);
            }

            if (modificacion_usuario && alta_usuario)
            {
                frmUsuarios frmUsuarios = new frmUsuarios();
                frmUsuarios.MdiParent = this;
                frmUsuarios.Show();
            }else
            {
                MessageBox.Show("No tiepermisos para usuarios");
            }
            

            

        }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CNPermisos cNPermisos = new CNPermisos();
            DataTable permis = cNPermisos.getpermis();
            bool nuevo_juego = true;
            foreach (DataRow row in permis.Rows)
            {
                nuevo_juego = Convert.ToBoolean(row["nuevo_juego"]);
            }

            if (nuevo_juego)
            {
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.MdiParent = this;
                frmPrincipal.Show();
            }
            else
            {
                MessageBox.Show("No tiepermisos para Iniciar Un Nuevo Juego");
            }
            
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CNPermisos cNPermisos = new CNPermisos();
            DataTable permis = cNPermisos.getpermis();
            bool permisos = true;
            foreach (DataRow row in permis.Rows)
            {
                permisos = Convert.ToBoolean(row["permisos"]);

            }

            if (permisos)
            {
                frmPermisos frmPermisos = new frmPermisos();
                frmPermisos.MdiParent = this;
                frmPermisos.Show();
            }
            else
            {
                MessageBox.Show("No tiepermisos para permisos");
            }

            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verifico si hay m juego activo y le consulto al usuario. si sale se termia el juego 
            CNJuego cNJuego = new CNJuego();
            DataSet ds = cNJuego.juegoActivo();
            
            if (ds.Tables[0].Rows.Count>0)
            {
                int id_juego = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
                DialogResult respuesta = MessageBox.Show("Hay Juegos en activos, si sale se perderán", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (respuesta == DialogResult.OK)
                {
                    cNJuego.finjuegoActivo(id_juego);
                    System.Windows.Forms.Application.Exit();
                }
                
            }else
            {
                System.Windows.Forms.Application.Exit();
            }
            
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {

            /*
           
            Tengo confirmado que el usuario esta logueado coorrectamente, con el dni tengo que buscar su id de perfil
            y cerciorarme que tenga los permisos para lo que quiere hacer
             */
        }

        private void palabbrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CNPermisos cNPermisos = new CNPermisos();
            DataTable permis = cNPermisos.getpermis();
            bool alta_palabras = true;
            bool modificacion_palabras = true;
            bool baja_palabras = true;
            bool consultas = true;
            foreach (DataRow row in permis.Rows)
            {
                alta_palabras = Convert.ToBoolean(row["alta_palabras"]);
                modificacion_palabras = Convert.ToBoolean(row["modificacion_palabras"]);
                baja_palabras = Convert.ToBoolean(row["baja_palabras"]);
                consultas = Convert.ToBoolean(row["reportes"]);


            }

            if (alta_palabras && modificacion_palabras || consultas)
            {
                frmPalabras frmPalabras = new frmPalabras();
                frmPalabras.MdiParent = this;
                frmPalabras.Show();
            }
            else
            {
                MessageBox.Show("No tiepermisos para palabras");
            }
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CNPermisos cNPermisos = new CNPermisos();
            DataTable permis = cNPermisos.getpermis();
            bool alta_palabras = true;
            bool modificacion_palabras = true;
            bool baja_palabras = true;
            bool consultas = true;
            foreach (DataRow row in permis.Rows)
            {
                alta_palabras = Convert.ToBoolean(row["alta_palabras"]);
                modificacion_palabras = Convert.ToBoolean(row["modificacion_palabras"]);
                baja_palabras = Convert.ToBoolean(row["baja_palabras"]);
                consultas = Convert.ToBoolean(row["reportes"]);

            }

            if (consultas)
            {

                //abrir el frm aca
                frmPalabraCorrecta frmPalabras = new frmPalabraCorrecta();
                //frmPalabras frmPalabras = new frmPalabras();
                frmPalabras.MdiParent = this;
                frmPalabras.Show();
            }
            else
            {
                MessageBox.Show("No tiepermisos para palabras");
            }
        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
