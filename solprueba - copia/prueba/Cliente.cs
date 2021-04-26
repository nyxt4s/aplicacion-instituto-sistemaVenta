using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prueba
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            //nose
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet2.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.bdElCofreDelBordadoDataSet2.CLIENTES);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            //Buscador dentro de datagridview en la columna Nombre_C según lo ingresado en txtBuscar
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Nombre_C like '%" + txtCliente.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se crea obj desde la clase BD para la conexion
                BD obj = new BD();
                // Se declara en string query la sentencia para borrar una fila según el dato ingresado
                string query = "DELETE FROM CLIENTES WHERE ID_CLIENTE=@ID";
                //Se abre la conexion y se declara el comando que ejecutará como string
                SqlCommand comando = new SqlCommand(query, obj.AbrirCon());
                comando.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente Eliminado");

                //Se vuelve a llenar el datagridview con los datos actualizados
                this.cLIENTESTableAdapter.Fill(this.bdElCofreDelBordadoDataSet2.CLIENTES);

                //vacia el textbox al momento de clickear el botón
                Borrar.Text = "";
                obj.CerrarCon();
            }
            catch
            {
                MessageBox.Show("Selecciona el ID del cliente ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Botón para retroceder
            this.Hide();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Label que muestra el id de los datos que se borrarán en la fila correspondiente según lo seleccionado en el datagridview
            try
            {
                Borrar.Text = "La Id seleccionada es " + dataGridView1.CurrentRow.Cells[0].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Botón de menú para ingresar al formulario "Pedidos"
            this.Hide();
            Pedidos mv = new Pedidos();
            mv.ShowDialog();
            this.Show();
        }

        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validador para sólo ingresar números enteros
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void finanzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Botón de menú para ingresar al formulario "Finanzas"
            this.Hide();
            Finanzas mv = new Finanzas();
            mv.ShowDialog();
            this.Show();
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Botón de menú para ingresar al formulario "Materiales"
            this.Hide();
            Materiales mv = new Materiales();
            mv.ShowDialog();
            this.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Botón de menú para ingresar al formulario "Stock"
            this.Hide();
            Stock mv = new Stock();
            mv.ShowDialog();
            this.Show();
        }

        private void Fecha_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtApellido_M.Text == "" || txtApellido_P.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
                {
                    MessageBox.Show("Debes llenar los datos :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Se crea obj desde la clase BD para la conexion
                    BD obj = new BD();

                    // Se declara en string query un insert para la tabla Clientes con los campos de la tabla y los valores que tomará cada columna '@'
                    string query = "INSERT INTO CLIENTES (NOMBRE_C,APELLIDO_P,APELLIDO_M,DIRECCION_C,TELEFONO) VALUES (@Nombre,@Apellido_P,@Apellido_M,@Direccion,@Telefono)";
                    SqlCommand comando = new SqlCommand(query, obj.AbrirCon());
                    //Se abre la conexion y ejecuta el string query antes declarado en SqlServer
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@Apellido_P", txtApellido_P.Text);
                    comando.Parameters.AddWithValue("@Apellido_M", txtApellido_M.Text);
                    comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente Agregado");

                    //Se vuelve a llenar el datagridview con los datos actualizados
                    this.cLIENTESTableAdapter.Fill(this.bdElCofreDelBordadoDataSet2.CLIENTES);

                    //Se vacian los textbox para así agilizar el ingreso de clientes
                    txtNombre.Text = "";
                    txtApellido_M.Text = "";
                    txtApellido_P.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";

                    //Se cierra la conexion
                    obj.CerrarCon();
                }

            }
            catch
            {
                MessageBox.Show("No se pudo :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtApellido_P.Text == "" || txtApellido_M.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
                {
                    MessageBox.Show("Debe llenar los datos :D", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else 
                {
                    //Se crea el objeto 'obj' desde la clase BDCONSULTAS 
                    BDCONSULTAS obj = new BDCONSULTAS();
                    //Desde el objeto se llama al método IngresarAccesorios y se declaran los datos que se ingresarán además de convertirlos a string e int segun corresponda
                    obj.ModificarCliente(Convert.ToString(txtNombre.Text),
                        Convert.ToString(txtApellido_P.Text),
                        Convert.ToString(txtApellido_M.Text),
                        Convert.ToString(txtDireccion.Text),
                        Convert.ToInt32(txtTelefono.Text),
                        Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                    //Se lista la tabla con sus datos actualizados
                    this.cLIENTESTableAdapter.Fill(this.bdElCofreDelBordadoDataSet2.CLIENTES);

                    //Se vacian los textbox
                    txtNombre.Text = "";
                    txtApellido_P.Text = "";
                    txtApellido_M.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("No se pudo :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            LlenarDGV1(dataGridView1.CurrentRow.Index);
        }

        public void LlenarDGV1(int IndiceDGV)
        {
            txtNombre.Text = dataGridView1.Rows[IndiceDGV].Cells[1].Value.ToString();
            txtApellido_P.Text = dataGridView1.Rows[IndiceDGV].Cells[2].Value.ToString();
            txtApellido_M.Text = dataGridView1.Rows[IndiceDGV].Cells[3].Value.ToString();
            txtDireccion.Text = dataGridView1.Rows[IndiceDGV].Cells[4].Value.ToString();
            txtTelefono.Text = dataGridView1.Rows[IndiceDGV].Cells[5].Value.ToString();
        }
    }
}
