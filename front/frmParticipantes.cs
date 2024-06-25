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
    public partial class frmParticipantes : Form
    {
        public frmParticipantes()
        {
            InitializeComponent();
        }

            
        private void btnAgrgar_Click(object sender, EventArgs e)
        {
            frmParticipante frmParticipante = new frmParticipante();
            //frmParticipante.MdiParent = this;
            frmParticipante.ShowDialog();
        }

        private void frmParticipantes_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
