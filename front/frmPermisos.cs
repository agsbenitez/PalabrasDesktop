using capaEntidad;
using capaNegocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace front
{
    public partial class frmPermisos : Form
    {

        CNPerfil cNPerfil = new CNPerfil();
        CNPermisos cNPermisos = new CNPermisos();

        
        public frmPermisos()
        {
            InitializeComponent();
        }
        public void cargarListPefiles()
        {
                       
            cmbPerfil.DataSource = cNPerfil.perfiles().Tables["perfiles"];
            cmbPerfil.ValueMember = "id";
            cmbPerfil.DisplayMember = "Descripcion";

        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            cargarListPefiles();

        }

     

        private void cmbPerfil_Leave(object sender, EventArgs e)
        {
            



        }

        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtengo el id de perfil
            string indexSelected = cmbPerfil.SelectedValue.ToString();
            //Consulto los permisos para el perfil y activo/desactivo los checkbox
            //Me devolverá un conjuto de datos
            bool cargado = int.TryParse(indexSelected, out int result); //al estarcargadose el formulario ejecuta el metodo changevalue del combo y genera un error por eso controlo que este totalmente cargado el combo
            if (cargado)
            {
                //se obtiene el dataset desde ka tabla de permiso
                DataSet permisos = cNPermisos.Permisos(int.Parse(indexSelected));


                foreach (DataTable table in permisos.Tables)
                {
                    foreach (DataRow item in table.Rows)
                    {

                        chkAltaAdmin.Checked = Convert.ToBoolean(item["alta_usuario_admin"]);

                        chkAlta.Checked = Convert.ToBoolean(item["alta_usuario"]);

                        chkMod.Checked = Convert.ToBoolean(item["modificacion_usuario"]);

                        chkBaja.Checked = Convert.ToBoolean(item["baja_usuario"]);

                        chkAltaP.Checked = Convert.ToBoolean(item["alta_palabras"]);

                        chkModP.Checked = Convert.ToBoolean(item["modificacion_palabras"]);
                        
                        chkBajaP.Checked = Convert.ToBoolean(item["baja_palabras"]);

                        chkNJuego.Checked = Convert.ToBoolean(item["nuevo_juego"]);

                        choReportes.Checked = Convert.ToBoolean(item["reportes"]);

                        chkBkp.Checked = Convert.ToBoolean(item["backup"]);

                        chkBoxListPalabras.Checked = Convert.ToBoolean(item["listado_palabras"]);

                        chkPermisos.Checked = Convert.ToBoolean(item["permisos"]);
                    }

                }

            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.cargarListPefiles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //debo controlar que el usuario logueado tenga permisos para cambiar los permisos
            //debo grabar los nuevos permisos en la tabla
            CEPermisos cEPermisos = new CEPermisos();
            cEPermisos.id_pefil_permisos = int.Parse(cmbPerfil.SelectedValue.ToString());
            cEPermisos.alta_usuario_admin = chkAltaAdmin.Checked;
            cEPermisos.alta_usuario = chkAlta.Checked;
            cEPermisos.modificacion_usuario = chkMod.Checked;
            cEPermisos.baja_usuario = chkBaja.Checked;
            cEPermisos.alta_palabras = chkAltaP.Checked;
            cEPermisos.modificacion_palabras = chkModP.Checked;
            cEPermisos.baja_palabras =  chkBajaP.Checked;
            cEPermisos.nuevo_juego = chkNJuego.Checked;
            cEPermisos.reportes = choReportes.Checked;
            cEPermisos.backup = chkBkp.Checked;
            cEPermisos.listado_palabras = chkBoxListPalabras.Checked;
            cEPermisos.permisos = chkPermisos.Checked;

            cNPermisos.Editarpermisos(cEPermisos);
        }
    }
}
