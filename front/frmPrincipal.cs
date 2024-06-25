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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pbJugar_Click(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            CNPermisos cNPermisos = new CNPermisos();
            //obtengo el listado de permisos
            DataTable permis = cNPermisos.getpermis();

            bool nuevo_juego = true;


            foreach (DataRow row in permis.Rows)
            {
                nuevo_juego = Convert.ToBoolean(row["nuevo_juego"]);
            }
            //int permiso0 = int.Parse(permisoRow[2].ToString());




            if (!nuevo_juego)
            {
                MessageBox.Show("El Usuario no dispone de permisos para iniciar un Juego");
                btnJugar.Enabled = false;
                
            }else
            {

                //Verificar que no haya un juego activo:

                frmJuego frmj = new frmJuego();
                frmj.MdiParent = this.MdiParent;
                frmj.Show();
                this.Close();
            }
            
        }

        
    }
}
