using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            //Se listan los datos correspondientes del datagridview
            ListarAccesorios();
            ListarAros();
            ListarBastidores();
            ListarClientes();
            ListarPedidos();
        }

        public void ListarAccesorios()
        {
            //Se listan los datos a través del método "ListarAccesorios" de la clase BDCONSULTAS en el combobox correspondiente
            BDCONSULTAS Util = new BDCONSULTAS();
            cmbAccesorios.DataSource = Util.ListarAccesorios();
            cmbAccesorios.DisplayMember = "NOMBRE";
            cmbAccesorios.ValueMember = "ID_ACCESORIOS";
        }

        public void ListarAros()
        {
            //Se listan los datos a través del método "ListarAros" de la clase BDCONSULTAS en el combobox correspondiente
            BDCONSULTAS Util = new BDCONSULTAS();
            cmbAros.DataSource = Util.ListarAros();
            cmbAros.DisplayMember = "NOMBRE";
            cmbAros.ValueMember = "ID_AROS";

        }

        public void ListarBastidores()
        {
            //Se listan los datos a través del método "ListarBastidores" de la clase BDCONSULTAS en el combobox correspondiente
            BDCONSULTAS Util = new BDCONSULTAS();
            cmbBastidores.DataSource = Util.ListarBastidores();
            cmbBastidores.DisplayMember = "NOMBRE";
            cmbBastidores.ValueMember = "ID_BASTIDOR";

        }

        public void ListarClientes()
        {
            //Se listan los datos a través del método "ListarClientes" de la clase BDCONSULTAS en el combobox correspondiente
            BDCONSULTAS Util = new BDCONSULTAS();
            cmbNombreC.DataSource = Util.ListarClientes();
            cmbNombreC.DisplayMember = "NOMBRE_C";
            cmbNombreC.ValueMember = "ID_CLIENTE";
        }

        public void ListarPedidos()
        {
            //Se listan los datos a través del método "ListarPedidos" de la clase BDCONSULTAS en el datagridview correspondiente
            BDCONSULTAS Util = new BDCONSULTAS();
            dataGridView1.DataSource = Util.ListarPedidos();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Se crea el objeto 'obj' desde la clase BDCONSULTAS
                BDCONSULTAS obj = new BDCONSULTAS();
                //Desde el objeto se llama al método IngresarPedido y se declaran los datos que se ingresarán además de convertirlos a string, int o datetime segun corresponda
                obj.IngresarPedido(Convert.ToInt32(cmbNombreC.SelectedValue),
                    Convert.ToInt32(txtPrecio.Text),
                    Convert.ToDateTime(txtFecha.Text),
                    Convert.ToString(txtEstado.Text),
                    Convert.ToInt32(cmbAros.SelectedValue),
                    Convert.ToInt32(cmbBastidores.SelectedValue),
                    Convert.ToInt32(cmbAccesorios.SelectedValue));

                //Se lista la tabla pedidos con sus datos actualizados 
                ListarAccesorios();
                ListarAros();
                ListarBastidores();
                ListarClientes();
                ListarPedidos();

                //Se desminuye el stock del producto seleccionado
                obj.ActualizarStock();


                //Se vacian los textbox
                cmbNombreC.Text = "";
                txtPrecio.Text = "";
                txtFecha.Text = "";
                txtEstado.Text = "";
                cmbAros.Text = "";
                cmbBastidores.Text = "";
                cmbAccesorios.Text = "";



            }
            catch
            {
                MessageBox.Show("No se pudo :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Botón para retroceder
            this.Hide();

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validador para sólo ingresar números enteros
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validador para sólo ingresar números enteros y '-' 
            if (e.KeyChar >= 32 && e.KeyChar <= 44 || e.KeyChar >= 46 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 106 || e.KeyChar >= 108 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten números enteros,  y ' - ' ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //Buscador dentro de datagridview en la columna CLIENTE según lo ingresado en txtBuscar
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "CLIENTE like '%" + txtBuscar.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Se rellena el stock de los pediddos realizados
                BDCONSULTAS cos = new BDCONSULTAS();
                cos.ActualizarStockExistente(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                // Se crea obj desde la clase BD para la conexion
                BD obj = new BD();
                // Se declara en string query la sentencia para borrar una fila según el dato ingresado
                string query = "DELETE FROM PEDIDOS WHERE ID_PEDIDOS=@ID";
                //Se abre la conexion y se declara el comando que ejecutará como string
                SqlCommand comando = new SqlCommand(query, obj.AbrirCon());
                comando.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
                comando.ExecuteNonQuery();
                MessageBox.Show("Pedido Eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                //Se vuelve a llenar el datagridview con los datos actualizados
                ListarAccesorios();
                ListarAros();
                ListarBastidores();
                ListarClientes();
                ListarPedidos();

                //Se vacia el textbox
                txtWea.Text = "";
                obj.CerrarCon();
            }
            catch
            {
                MessageBox.Show("Selecciona el ID del cliente ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtWea_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Label que muestra el id de los datos que se borrarán en la fila correspondiente según lo seleccionado en el datagridview

            try
            {
                txtWea.Text = "La Id seleccionada es " + dataGridView1.CurrentRow.Cells[0].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbNombreC.Text == "" || cmbAccesorios.Text == "" || cmbAros.Text == "" || cmbBastidores.Text == "" || txtPrecio.Text == "" || txtFecha.Text == "" || txtEstado.Text == "")
                {
                    MessageBox.Show("Debe llenar los datos :D", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Se crea el objeto 'obj' desde la clase BDCONSULTAS 
                    BDCONSULTAS obj = new BDCONSULTAS();

                    //Se Aumenta el stock del producto existente a modificar
                    obj.ActualizarStockExistente(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                    //Desde el objeto se llama al método IngresarAccesorios y se declaran los datos que se ingresarán además de convertirlos a string e int segun corresponda
                    obj.ModificarPedido(Convert.ToInt32(cmbNombreC.SelectedValue),
                    Convert.ToInt32(txtPrecio.Text),
                    Convert.ToDateTime(txtFecha.Text),
                    Convert.ToString(txtEstado.Text),
                    Convert.ToInt32(cmbAros.SelectedValue),
                    Convert.ToInt32(cmbBastidores.SelectedValue),
                    Convert.ToInt32(cmbAccesorios.SelectedValue),
                    Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                    //Se descuenta el stock del producto existente modificado
                    obj.ActualizarStockModificado(Convert.ToInt32(cmbAccesorios.SelectedValue), 
                    Convert.ToInt32(cmbBastidores.SelectedValue), 
                    Convert.ToInt32(cmbAros.SelectedValue));

                    //Se lista la tabla con sus datos actualizados
                    ListarAccesorios();
                    ListarAros();
                    ListarBastidores();
                    ListarClientes();
                    ListarPedidos();

                    //Se vacian los textbox
                    txtPrecio.Text = "";
                    txtFecha.Text = "";
                    txtEstado.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("No se pudo :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LlenarDGV1(dataGridView1.CurrentRow.Index);
        }

        public void LlenarDGV1(int IndiceDGV)
        {
            cmbNombreC.Text = dataGridView1.Rows[IndiceDGV].Cells[1].Value.ToString();
            cmbAccesorios.Text = dataGridView1.Rows[IndiceDGV].Cells[2].Value.ToString();
            cmbAros.Text = dataGridView1.Rows[IndiceDGV].Cells[3].Value.ToString();
            cmbBastidores.Text = dataGridView1.Rows[IndiceDGV].Cells[4].Value.ToString();
            txtPrecio.Text = dataGridView1.Rows[IndiceDGV].Cells[5].Value.ToString();
            txtFecha.Text = dataGridView1.Rows[IndiceDGV].Cells[6].Value.ToString();
            txtEstado.Text = dataGridView1.Rows[IndiceDGV].Cells[7].Value.ToString();

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void finanzasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hora_Click(object sender, EventArgs e)
        {

        }

        private void cmbAros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
