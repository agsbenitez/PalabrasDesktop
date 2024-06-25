using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using capaEntidad;
using capaNegocio;
//using capaDatos;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace front
{
    public partial class frmPalabras : Form
    {
       
        CNPalabras cNPalabra = new CNPalabras();
        int idPalabra = 0;
        public frmPalabras()
        {
            InitializeComponent();
        }

        private void LimpiarForm()
        {
            txtIdDificultad.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
          
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
            //desactivar los botones si el usuario tiene perfil 4
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

            if (consultas && alta_palabras)
            {
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = true;
                txtIdDificultad.Enabled = true;
                txtDescripcion.Enabled = true;
            }
            else
            {
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = false;
                txtIdDificultad.Enabled = false;
                txtDescripcion.Enabled = false;
                
            }
        }

        private void CargarDatos() {
            gripDatos.DataSource = cNPalabra.obtenerPalabras().Tables["tbl"];
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //bool Resultado;
            if (txtDescripcion.Text == "") 
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else { 
            CEPalabras cEPalabra = new CEPalabras();
            cEPalabra.id = idPalabra;
            cEPalabra.idDificultad = int.Parse(txtIdDificultad.Text);
            cEPalabra.descripcion = txtDescripcion.Text;
            
            if(idPalabra == 0)
            {
                cNPalabra.nuevaPalabra(cEPalabra);
            }
            else
            {
                cNPalabra.editarPalabra(cEPalabra);
            }
            CargarDatos();
            LimpiarForm();
            }

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

       

        private void gripDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idPalabra =  (int)gripDatos.CurrentRow.Cells["idPalabra"].Value;
            txtIdDificultad.Text = gripDatos.CurrentRow.Cells["idDificultad"].Value.ToString();
            txtDescripcion.Text = gripDatos.CurrentRow.Cells["descripcion"].Value.ToString();
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idPalabra = 0;
            LimpiarForm();
            CargarDatos();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return
;
            }
        }

        private void gripDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idPalabra == 0)
            {
                return;
                // cNPalabra.NuevaPalabra(cEPalabra);
            }
            else {
                CEPalabras cEPalabra = new CEPalabras();
                 cEPalabra.id = idPalabra;
                 cNPalabra.borradoLogico(cEPalabra);
                 }

            }
        }
}
