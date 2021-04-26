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
    public partial class Materiales : Form
    {
        public Materiales()
        {
            InitializeComponent();
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet.MATERIALES' Puede moverla o quitarla según sea necesario.
            this.mATERIALESTableAdapter.Fill(this.bdElCofreDelBordadoDataSet.MATERIALES);

            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Botón de menú para ingresar al formulario "Clientes"
            this.Hide();
            Clientes mv = new Clientes();
            mv.ShowDialog();
            this.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Botón de menú para ingresar al formulario "Pedidos"
            this.Hide();
            Pedidos mv = new Pedidos();
            mv.ShowDialog();
            this.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            //Botón para retroceder
            this.Hide();
        }

        private void Materiales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet15.MATERIALES' Puede moverla o quitarla según sea necesario.
            this.mATERIALESTableAdapter1.Fill(this.bdElCofreDelBordadoDataSet15.MATERIALES);
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet.MATERIALES' Puede moverla o quitarla según sea necesario.
            this.mATERIALESTableAdapter.Fill(this.bdElCofreDelBordadoDataSet.MATERIALES);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se crea el objeto 'obj' desde la clase BDCONSULTAS
                BDCONSULTAS obj = new BDCONSULTAS();
                //Desde el objeto se llama al método 'IngresarMateriales' y se declaran los datos que se ingresarán además de convertirlos a string e int segun corresponda
                obj.IngresarMateriales(Convert.ToString(txtTipo.Text),
                    Convert.ToString(txtDescripcion.Text),
                    Convert.ToInt32(txtCosto.Text),
                    Convert.ToString(txtStock.Text));

                //Se lista la tabla con sus datos actualizados 
                this.mATERIALESTableAdapter1.Fill(this.bdElCofreDelBordadoDataSet15.MATERIALES);


                //Se vacian los textbox
                txtTipo.Text = "";
                txtDescripcion.Text = "";
                txtCosto.Text = "";
                txtStock.Text = "";

            }
            catch 
            {
                MessageBox.Show("No se pudo :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validador para sólo ingresar números enteros
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se crea obj desde la clase BD para la conexion
                BD obj = new BD();
                // Se declara en string query la sentencia para borrar una fila según el dato ingresado
                string query = "DELETE FROM MATERIALES WHERE ID_MATERIALES=@ID";
                //Se abre la conexion y se declara el comando que ejecutará como string
                SqlCommand comando = new SqlCommand(query, obj.AbrirCon());
                comando.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
                comando.ExecuteNonQuery();
                MessageBox.Show("Material Eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Se vuelve a llenar el datagridview con los datos actualizados
                this.mATERIALESTableAdapter1.Fill(this.bdElCofreDelBordadoDataSet15.MATERIALES);

                //Se vacia el textbox
                txtWea.Text = "";
                obj.CerrarCon();
            }
            catch
            {
                MessageBox.Show("Selecciona el ID del Material ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Buscador de datos para datagridview en la columa TIPO según lo ingresado en txtBuscar
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "TIPO like '%" + txtBuscar.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Se crea el objeto 'obj' desde la clase BDCONSULTAS
                BDCONSULTAS obj = new BDCONSULTAS();
                //Desde el objeto se llama al método IngresarAccesorios y se declaran los datos que se ingresarán además de convertirlos a string e int segun corresponda
                obj.ModificarMateriales(Convert.ToString(txtTipo.Text),
                    Convert.ToString(txtDescripcion.Text),
                    Convert.ToInt32(txtCosto.Text),
                    Convert.ToString(txtStock.Text),
                    Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                //Se lista la tabla con sus datos actualizados
                this.mATERIALESTableAdapter1.Fill(this.bdElCofreDelBordadoDataSet15.MATERIALES);


                //Se vacian los textbox
                txtTipo.Text = "";
                txtDescripcion.Text = "";
                txtCosto.Text = "";
                txtStock.Text = "";
            }
            catch
            {
                MessageBox.Show("No se pudo :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void LlenarDGV1(int IndiceDGV)
        {
            txtTipo.Text = dataGridView1.Rows[IndiceDGV].Cells[1].Value.ToString();
            txtDescripcion.Text = dataGridView1.Rows[IndiceDGV].Cells[2].Value.ToString();
            txtCosto.Text = dataGridView1.Rows[IndiceDGV].Cells[3].Value.ToString();
            txtStock.Text = dataGridView1.Rows[IndiceDGV].Cells[4].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlenarDGV1(dataGridView1.CurrentRow.Index);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "STOCK")
            {
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        if (Convert.ToInt32(e.Value) < 10000)
                        {
                            e.CellStyle.ForeColor = Color.Green;

                            if (Convert.ToInt32(e.Value) <= 50)
                            {
                                e.CellStyle.ForeColor = Color.Yellow;

                                if (Convert.ToInt32(e.Value) <= 20)
                                {
                                    e.CellStyle.ForeColor = Color.Red;

                                }
                            }
                        }
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
