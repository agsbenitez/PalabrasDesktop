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
    public partial class frmJuego : Form

    {
        public struct Datos
        {
            public string id_perfil;
            public string id_usuario;
            public string apellido;
            public string nombre;
            public string establecimiento;
            
        }

        
           
        public frmJuego()
        {
            InitializeComponent();
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            /*
            /*
             * al  hacer click en siguiente se deben cargar las tablas del nuevo juego,
             * fecha de inicio,
             * alumnos que participan,
             * palabras por alumno.
             * 
             * debo pasar un datatable con los datos de la grilla de participates sellecionados
            */

            DataTable dt = recuperoTable_sel();
            CNJuego cNJuego = new CNJuego();
            int id_juego = cNJuego.nuevoJuego(dt);
            //frmPlay fg = new frmPlay(id_juego);
            
            frmJuez frmJuez = new frmJuez(id_juego, dt);
            frmJuez.MdiParent = this.MdiParent;
            this.Hide();
            frmJuez.Show();
   

        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            
            CNPermisos cNPermisos = new CNPermisos();
            //obtengo el listado de permisos
            DataTable permis = cNPermisos.getpermis();

            bool nuevo_juego = true;
            

            foreach (DataRow row in permis.Rows)
            {
                nuevo_juego = Convert.ToBoolean(row["nuevo_juego"]);
            }
            
            


            if (!nuevo_juego)
            {
                btnNext.Enabled = false;
                cbDificultad.Enabled = false;
            }
        }

        private void cbDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CNUsuario cNUsuario = new CNUsuario();
            if (cbDificultad.SelectedItem.ToString() == "Primario")
            {
                //debo filtar todos los almunos de primaria y crgarlos en el list
                DataSet primarios = cNUsuario.primarios();
                dtGParticipantesNS.DataSource = primarios.Tables[0];
            }
            else
            {
                DataSet secundarios = cNUsuario.secundarios();
                dtGParticipantesNS.DataSource = secundarios.Tables[0];
            } 

            dtGParticipantesNS.Columns[0].Visible = false;
            dtGParticipantesNS.Columns[1].Visible = false;
            dtGParticipantesNS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void tablaParticipanessel(DataGridViewRow fila)
        {
            //creo los  datos para al grid de paticipantes seleccionados
            Datos datos = cargaData(fila);


            this.dtGParticipantesS.Rows.Add(new[] { datos.id_perfil, datos.id_usuario, datos.apellido, datos.nombre, datos.establecimiento });
            dtGParticipantesNS.Rows.Remove(fila);
        }

        public void tablaParticipanesNsel(DataGridViewRow fila)
        {
            //creo las columnas de datos para al grid de paticipantes seleccionados
            Datos datos = cargaData(fila);
            this.dtGParticipantesS.Rows.Remove(fila);

            DataTable dt = recuperoTable();

            dt.Rows.Add(new Object[] { datos.id_perfil, datos.id_usuario, datos.apellido, datos.nombre, datos.establecimiento });
            this.dtGParticipantesNS.DataSource = dt;
        }
        public DataTable recuperoTable()
        {
            

            //this.dtGParticipantesNS.Rows.Add(new[] { datos.id_perfil, datos.id_usuario, datos.apellido, datos.nombre, datos.establecimiento });
            DataTable dt = new DataTable();
            dt.Columns.Add("id_perfil");
            dt.Columns.Add("id_usuario");
            dt.Columns.Add("apellido");
            dt.Columns.Add("nombre");
            dt.Columns.Add("establecimiento");
            int n = dtGParticipantesNS.Rows.GetLastRow(DataGridViewElementStates.Visible);
            

            foreach (DataGridViewRow rowGrid in dtGParticipantesNS.Rows)
            {
                DataRow row = dt.NewRow();
                row["id_perfil"] = Convert.ToDouble(rowGrid.Cells[0].Value);
                row["id_usuario"] = Convert.ToDouble(rowGrid.Cells[1].Value);
                row["apellido"] = rowGrid.Cells[2].Value;
                row["nombre"] = rowGrid.Cells[3].Value;
                row["establecimiento"] = rowGrid.Cells[3].Value;

                dt.Rows.Add(row);
            }

            dt.Rows.RemoveAt(n);

            return dt;
        }


        public DataTable recuperoTable_sel()
        {
            //recupera en DataTable todos los alum,nos seleccionados para jugar
            DataTable dt = new DataTable();
            dt.Columns.Add("id_perfil");
            dt.Columns.Add("id_usuario");
            dt.Columns.Add("apellido");
            dt.Columns.Add("nombre");
            dt.Columns.Add("establecimiento");
            

            foreach (DataGridViewRow rowGrid in dtGParticipantesS.Rows)
            {
                DataRow row = dt.NewRow();
                row["id_perfil"] = Convert.ToDouble(rowGrid.Cells[0].Value);
                row["id_usuario"] = Convert.ToDouble(rowGrid.Cells[1].Value);
                row["apellido"] = rowGrid.Cells[2].Value;
                row["nombre"] = rowGrid.Cells[3].Value;
                row["establecimiento"] = rowGrid.Cells[3].Value;

                dt.Rows.Add(row);
            }

            //dt.Rows.RemoveAt(n);

            return dt;
        }
        public Datos cargaData(DataGridViewRow fila)
        {
            //previo tengoq ue crear una estructura de datos
            Datos datos = new Datos();
            datos.id_perfil = fila.Cells["id_perfil"].Value.ToString();
            datos.id_usuario = fila.Cells["id_usuario"].Value.ToString();
            datos.apellido = fila.Cells["apellido"].Value.ToString();
            datos.nombre = fila.Cells["nombre"].Value.ToString();
            datos.establecimiento = fila.Cells["establecimiento"].Value.ToString();

            return datos;
        }

        private void btnAdd_1_Click(object sender, EventArgs e)
        {
            //se toma la fila seleccionada y se lo pasa a la tabla de participantes seleccionados
            DataGridViewRow fila = dtGParticipantesNS.SelectedRows[0] as DataGridViewRow;
            this.tablaParticipanessel(fila);
            if (btnNext.Enabled == false)
            {
                btnNext.Enabled = true;
            }
        }

        private void dtGParticipantesNS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnRemove_1_Click(object sender, EventArgs e)
        {
            //se toma la fila seleccionada y se lo pasa a la tabla de participantes No seleccionados para indicar que un alumno no participa del juego
            DataGridViewRow fila = dtGParticipantesS.SelectedRows[0] as DataGridViewRow;
            this.tablaParticipanesNsel(fila);
        }

        private void btnRemove_all_Click(object sender, EventArgs e)
        {

        }
    }
}
