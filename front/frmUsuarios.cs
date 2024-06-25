using capaNegocio;
using capaEntidad;
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
    public partial class frmUsuarios : Form
    {
        CNUsuario cNUsuario = new CNUsuario();
        

        public struct Datos
        {
            public string id_usuario;
            public string apellido;
            public string nombre;
            public string dni;
            public string email;
            public string fecha_naciemiento;
            public string id_perfil;
            public string password;
            public string entidad;
            public string grado;
            public string id_dificultad;
        }

                     

        public void cargarGrid()
        {
            dataGridView1.DataSource = cNUsuario.usuarios().Tables["usuarios"];
            //int ncols = dataGridView1.ColumnCount;
            
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            columnsName();
        }

        private void cargarGridborrados()
        {
            dataGridView1.DataSource = cNUsuario.usuariosBorrados().Tables["usuarios"];
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            //dataGridView1.Columns[11].Visible = false;
            //dataGridView1.Columns[12].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            columnsNameBorrados();
        }

        public void columnsName()
        {
            dataGridView1.Columns[1].HeaderText = "Apellido";
            dataGridView1.Columns[2].HeaderText = "Nombre";
            dataGridView1.Columns[3].HeaderText = "DNI";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Fecha de Naciemiento";
            dataGridView1.Columns[6].HeaderText = "Estableciomiento";
            dataGridView1.Columns[7].HeaderText = "Grado";
            dataGridView1.Columns[9].HeaderText = "dificultad";
            dataGridView1.Columns[11].HeaderText = "Borrado";
            dataGridView1.Columns[13].HeaderText = "Perfil";    
        }


        public void columnsNameBorrados()
        {
            dataGridView1.Columns[1].HeaderText = "Apellido";
            dataGridView1.Columns[2].HeaderText = "Nombre";
            dataGridView1.Columns[3].HeaderText = "DNI";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Fecha de Naciemiento";
            dataGridView1.Columns[6].HeaderText = "Estableciomiento";
            dataGridView1.Columns[7].HeaderText = "Grado";
            dataGridView1.Columns[9].HeaderText = "borrado";

            if (chkBorrados.Checked == false)
            {
                dataGridView1.Columns[13].HeaderText = "Perfil";
            }

        }


        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            AddOwnedForm(frmUsuario);
            frmUsuario.ShowDialog();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarGrid();   
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            datos.id_usuario = dataGridView1.CurrentRow.Cells["id_usuario"].Value.ToString();
            //datos.id_usuario = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            datos.apellido = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            datos.nombre = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            datos.dni = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            datos.email = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            datos.fecha_naciemiento = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            datos.id_perfil = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            datos.password = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            datos.entidad = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            datos.grado = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            datos.id_dificultad = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        frmUsuario frmUsuario = new frmUsuario(datos);
            AddOwnedForm(frmUsuario);
            //Encuentro el id del usuario a modificar
            //debo pasar los valores al form y hacer el update
            frmUsuario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se eliminaran los datos de usuaro");
            CEUsuario usuario = new CEUsuario();
            usuario.id_usuario = (int)dataGridView1.CurrentRow.Cells["id_usuario"].Value;

            cNUsuario.borrarUsuario(usuario);

        }

        private void chkBorrados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBorrados.Checked)
            {
                cargarGridborrados();
                btnEditar.Enabled = false;  
            }
            else {
                cargarGrid();
                btnEditar.Enabled = true;
            }
        }

        private void frmUsuarios_Activated(object sender, EventArgs e)
        {

            /*
             * acá debo verificar el perfil del usuario y activar o desactivar los botones según  el tipo de perfil
             * ya tengo el id de perfil ahora debo buscar en la tabla de permiso según el id encontrado y trabajar en función de los permisos
            */


            CNPermisos cNPermisos = new CNPermisos();
            DataTable permis = cNPermisos.getpermis();
            bool modificacion_usuario = true;
            bool baja_usuario = true;
            bool alta_usuario = true;
            foreach (DataRow row in permis.Rows)
            {
                modificacion_usuario = Convert.ToBoolean(row["modificacion_usuario"]);
                baja_usuario = Convert.ToBoolean(row["baja_usuario"]);
                alta_usuario = Convert.ToBoolean(row["alta_usuario"]);
            }
            //int permiso0 = int.Parse(permisoRow[2].ToString());

            if (!modificacion_usuario)
            {
                btnEditar.Enabled = false;
            }
            if (!baja_usuario)
            {
                btnBorrar.Enabled = false;
            }
            

            


        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            //debo llamar al metodo para gacer la consulta y cargar la grilla
            if (txtBoxBuscar.Text.Length > 0)
            {
                dataGridView1.DataSource = cNUsuario.obtenerUsuarioPA(txtBoxBuscar.Text).Tables["usuarios"];
            }
            else
            {
                dataGridView1.DataSource = cNUsuario.usuarios().Tables["usuarios"];
            }

            //int ncols = dataGridView1.ColumnCount;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

         
        }
    }
}
