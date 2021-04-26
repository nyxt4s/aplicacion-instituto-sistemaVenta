using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace prueba
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();

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

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet14.AROS' Puede moverla o quitarla según sea necesario.
            this.aROSTableAdapter3.Fill(this.bdElCofreDelBordadoDataSet14.AROS);
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet11.AROS' Puede moverla o quitarla según sea necesario.
            this.aROSTableAdapter2.Fill(this.bdElCofreDelBordadoDataSet11.AROS);
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet10.BASTIDORES' Puede moverla o quitarla según sea necesario.
            this.bASTIDORESTableAdapter1.Fill(this.bdElCofreDelBordadoDataSet10.BASTIDORES);
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet9.ACCESORIOS' Puede moverla o quitarla según sea necesario.
            this.aCCESORIOSTableAdapter3.Fill(this.bdElCofreDelBordadoDataSet9.ACCESORIOS);
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet8.ACCESORIOS' Puede moverla o quitarla según sea necesario.
            this.aCCESORIOSTableAdapter2.Fill(this.bdElCofreDelBordadoDataSet8.ACCESORIOS);
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet7.ACCESORIOS' Puede moverla o quitarla según sea necesario.
            this.aCCESORIOSTableAdapter1.Fill(this.bdElCofreDelBordadoDataSet7.ACCESORIOS);
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet6.AROS' Puede moverla o quitarla según sea necesario.
            this.aROSTableAdapter1.Fill(this.bdElCofreDelBordadoDataSet6.AROS);
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet5.ACCESORIOS' Puede moverla o quitarla según sea necesario.
            this.aCCESORIOSTableAdapter.Fill(this.bdElCofreDelBordadoDataSet5.ACCESORIOS);
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet4.BASTIDORES' Puede moverla o quitarla según sea necesario.
            this.bASTIDORESTableAdapter.Fill(this.bdElCofreDelBordadoDataSet4.BASTIDORES);
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet3.AROS' Puede moverla o quitarla según sea necesario.
            this.aROSTableAdapter.Fill(this.bdElCofreDelBordadoDataSet3.AROS);

            

            //Datos para llenar en el combobox
            comboBox1.Items.Add("Aros");
            comboBox1.Items.Add("Bastidores");
            comboBox1.Items.Add("Accesorios");


        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Buscador dentro de datagridview 1 , 2, 3 en la columna NOMBRE según lo ingresado en txtBuscar
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "NOMBRE like '%" + txtBuscar.Text + "%'";
            bs.DataSource = dataGridView2.DataSource;
            bs.Filter = "NOMBRE like '%" + txtBuscar.Text + "%'";
            bs.DataSource = dataGridView3.DataSource;
            bs.Filter = "NOMBRE like '%" + txtBuscar.Text + "%'";

            dataGridView1.DataSource = bs;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Aros")
            {
                txtTipo.Enabled = false;
            }
            else if (comboBox1.Text == "Bastidores")
            {
                txtTipo.Enabled = false;
            }
            else if (comboBox1.Text == "Accesorios")
            {
                txtTipo.Enabled = true;
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {

                if (comboBox1.Text == "Accesorios")
                {
                    //Se crea el objeto 'obj' desde la clase BDCONSULTAS
                    BDCONSULTAS obj = new BDCONSULTAS();
                    //Desde el objeto se llama al método IngresarAccesorios y se declaran los datos que se ingresarán además de convertirlos a string e int segun corresponda
                    obj.IngresarAccesorios(Convert.ToString(txtNombre.Text),
                        Convert.ToString(txtTipo.Text),
                        Convert.ToString(txtDescripcion.Text),
                        Convert.ToInt32(txtPrecio.Text),
                        Convert.ToInt32(txtStock.Text));

                    //Se lista la tabla con sus datos actualizados 
                    this.aCCESORIOSTableAdapter3.Fill(this.bdElCofreDelBordadoDataSet9.ACCESORIOS);

                    //Se vacian los textbox
                    txtNombre.Text = "";
                    txtTipo.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";
                    
                }
                else if (comboBox1.Text == "Bastidores")
                {
                    //Se crea el objeto 'obj' desde la clase BDCONSULTAS
                    BDCONSULTAS obj = new BDCONSULTAS();
                    //Desde el objeto se llama al método IngresarBastidores y se declaran los datos que se ingresarán además de convertirlos a string e int segun corresponda
                    obj.IngresarBastidores(Convert.ToString(txtNombre.Text),
                        Convert.ToString(txtDescripcion.Text),
                        Convert.ToInt32(txtPrecio.Text),
                        Convert.ToInt32(txtStock.Text));

                    //Se lista la tabla con sus datos actualizados 
                    this.bASTIDORESTableAdapter1.Fill(this.bdElCofreDelBordadoDataSet10.BASTIDORES);

                    //Se vacian los textbox
                    txtNombre.Text = "";
                    txtTipo.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";

                }
                else if (comboBox1.Text == "Aros")
                {
                    //Se crea el objeto 'obj' desde la clase BDCONSULTAS
                    BDCONSULTAS obj = new BDCONSULTAS();
                    //Desde el objeto se llama al método IngresarAros y se declaran los datos que se ingresarán además de convertirlos a string e int segun corresponda
                    obj.IngresarAros(Convert.ToString(txtNombre.Text),
                        Convert.ToString(txtDescripcion.Text),
                        Convert.ToInt32(txtPrecio.Text),
                        Convert.ToInt32(txtStock.Text));

                    //Se lista la tabla con sus datos actualizados 
                    this.aROSTableAdapter3.Fill(this.bdElCofreDelBordadoDataSet14.AROS);

                    //Se vacian los textbox
                    txtNombre.Text = "";
                    txtTipo.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";

                }
                else {

                    MessageBox.Show("No se seleccionó una opción válida :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            } catch {

                MessageBox.Show("No se pudo :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validador para sólo ingresar números enteros
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten números enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validador para sólo ingresar números enteros
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten números enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Condición que borra la fila seleccionada dependiendo de la tabla seleccionada
                if (comboBox1.Text == "Accesorios")
                {
                    //Se crea el objeto 'obj' desde la clase BD
                    BD obj = new BD();
                    // Se declara en string query la sentencia para borrar una fila según el dato ingresado
                    string query = "DELETE FROM ACCESORIOS WHERE ID_ACCESORIOS=@ID";
                    //Se abre la conexion y se declara el comando que ejecutará como string
                    SqlCommand comando = new SqlCommand(query, obj.AbrirCon());
                    comando.Parameters.AddWithValue("@ID", dataGridView3.CurrentRow.Cells[0].Value);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Se vacia el textbox
                    txtWea.Text = "";
                    obj.CerrarCon();
                    //Se vuelve a llenar el datagridview con los datos actualizados
                    this.aCCESORIOSTableAdapter3.Fill(this.bdElCofreDelBordadoDataSet9.ACCESORIOS);
                }
                else if (comboBox1.Text == "Bastidores")
                {
                    //Se crea el objeto 'obj' desde la clase BD
                    BD obj = new BD();
                    // Se declara en string query la sentencia para borrar una fila según el dato ingresado
                    string query = "DELETE FROM BASTIDORES WHERE ID_BASTIDOR=@ID";
                    //Se abre la conexion y se declara el comando que ejecutará como string
                    SqlCommand comando = new SqlCommand(query, obj.AbrirCon());
                    comando.Parameters.AddWithValue("@ID", dataGridView2.CurrentRow.Cells[0].Value);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Se vacia el textbox
                    txtWea.Text = "";
                    obj.CerrarCon();
                    //Se vuelve a llenar el datagridview con los datos actualizados
                    this.bASTIDORESTableAdapter1.Fill(this.bdElCofreDelBordadoDataSet10.BASTIDORES);
                }
                else if (comboBox1.Text == "Aros")
                {
                    //Se crea el objeto 'obj' desde la clase BD
                    BD obj = new BD();
                    // Se declara en string query la sentencia para borrar una fila según el dato ingresado
                    string query = "DELETE FROM AROS WHERE ID_AROS=@ID";
                    //Se abre la conexion y se declara el comando que ejecutará como string
                    SqlCommand comando = new SqlCommand(query, obj.AbrirCon());
                    comando.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Se vacia el textbox
                    txtWea.Text = "";
                    obj.CerrarCon();
                    //Se vuelve a llenar el datagridview con los datos actualizados
                    this.aROSTableAdapter3.Fill(this.bdElCofreDelBordadoDataSet14.AROS);
                }
                else
                {
                    MessageBox.Show("No se seleccionó una opción válida :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {

                MessageBox.Show("No se pudo :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Label que muestra el id de los datos que se borrarán en la fila correspondiente según lo seleccionado en el datagridview correspondiente
            try
            {
                txtWea.Text = "La Id seleccionada es " + dataGridView1.CurrentRow.Cells[0].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            comboBox1.Text = "Aros";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Label que muestra el id de los datos que se borrarán en la fila correspondiente según lo seleccionado en el datagridview correspondiente
            try
            {
                txtWea.Text = "La Id seleccionada es " + dataGridView2.CurrentRow.Cells[0].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            comboBox1.Text = "Bastidores";
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Label que muestra el id de los datos que se borrarán en la fila correspondiente según lo seleccionado en el datagridview correspondiente
            try
            {
                txtWea.Text = "La Id seleccionada es " + dataGridView3.CurrentRow.Cells[0].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            comboBox1.Text = "Accesorios";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "sTOCKDataGridViewTextBoxColumn1")
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

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "dataGridViewTextBoxColumn2")
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
        
        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView3.Columns[e.ColumnIndex].Name == "dataGridViewTextBoxColumn1")
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.Text == "Accesorios")
                {
                    //Se crea el objeto 'obj' desde la clase BDCONSULTAS
                    BDCONSULTAS obj = new BDCONSULTAS();
                    //Desde el objeto se llama al método IngresarAccesorios y se declaran los datos que se ingresarán además de convertirlos a string e int segun corresponda
                    obj.ModificarAccesorios(Convert.ToString(txtNombre.Text),
                        Convert.ToString(txtTipo.Text),
                        Convert.ToString(txtDescripcion.Text),
                        Convert.ToInt32(txtPrecio.Text),
                        Convert.ToInt32(txtStock.Text),
                        Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));

                    //Se lista la tabla con sus datos actualizados
                    this.aCCESORIOSTableAdapter3.Fill(this.bdElCofreDelBordadoDataSet9.ACCESORIOS);

                    //Se vacian los textbox
                    txtNombre.Text = "";
                    txtTipo.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";

                }
                else if (comboBox1.Text == "Bastidores")
                {
                    //Se crea el objeto 'obj' desde la clase BDCONSULTAS
                    BDCONSULTAS obj = new BDCONSULTAS();
                    //Desde el objeto se llama al método IngresarBastidores y se declaran los datos que se ingresarán además de convertirlos a string e int segun corresponda
                    obj.ModificarBastidores(Convert.ToString(txtNombre.Text),
                        Convert.ToString(txtDescripcion.Text),
                        Convert.ToInt32(txtPrecio.Text),
                        Convert.ToInt32(txtStock.Text),
                         Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));

                    //Se lista la tabla con sus datos actualizados
                    this.bASTIDORESTableAdapter1.Fill(this.bdElCofreDelBordadoDataSet10.BASTIDORES);

                    //Se vacian los textbox
                    txtNombre.Text = "";
                    txtTipo.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";

                }
                else if (comboBox1.Text == "Aros")
                {
                    //Se crea el objeto 'obj' desde la clase BDCONSULTAS
                    BDCONSULTAS obj = new BDCONSULTAS();
                    //Desde el objeto se llama al método IngresarAros y se declaran los datos que se ingresarán además de convertirlos a string e int segun corresponda
                    obj.ModificarAros(Convert.ToString(txtNombre.Text),
                         Convert.ToString(txtDescripcion.Text),
                         Convert.ToInt32(txtPrecio.Text),
                         Convert.ToInt32(txtStock.Text),
                         Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                    //Se lista la tabla con sus datos actualizados 
                    this.aROSTableAdapter3.Fill(this.bdElCofreDelBordadoDataSet14.AROS);

                    //Se vacian los textbox
                    txtNombre.Text = "";
                    txtTipo.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";

                }
                else
                {

                    MessageBox.Show("No se seleccionó una opción válida :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch
            {

                MessageBox.Show("No se pudo :(", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = "Bastidores";
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = "Accesorios";
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Aros")
            {
                LlenarDGV1(dataGridView1.CurrentRow.Index);
            }
            else if (comboBox1.Text == "Bastidores")
            {
                LlenarDGV2(dataGridView2.CurrentRow.Index);
            }
            else if (comboBox1.Text == "Accesorios")
            {
                LlenarDGV3(dataGridView3.CurrentRow.Index);
            }
            
        }

        public void LlenarDGV1(int IndiceDGV)
        {
            txtNombre.Text = dataGridView1.Rows[IndiceDGV].Cells[1].Value.ToString();
            txtDescripcion.Text = dataGridView1.Rows[IndiceDGV].Cells[2].Value.ToString();
            txtPrecio.Text = dataGridView1.Rows[IndiceDGV].Cells[3].Value.ToString();
            txtStock.Text = dataGridView1.Rows[IndiceDGV].Cells[4].Value.ToString();

        }

        public void LlenarDGV2(int IndiceDGV)
        {
            txtNombre.Text = dataGridView2.Rows[IndiceDGV].Cells[1].Value.ToString();
            txtDescripcion.Text = dataGridView2.Rows[IndiceDGV].Cells[2].Value.ToString();
            txtPrecio.Text = dataGridView2.Rows[IndiceDGV].Cells[3].Value.ToString();
            txtStock.Text = dataGridView2.Rows[IndiceDGV].Cells[4].Value.ToString();
        }

        public void LlenarDGV3(int IndiceDGV)
        {
            txtNombre.Text = dataGridView3.Rows[IndiceDGV].Cells[1].Value.ToString();
            txtTipo.Text = dataGridView3.Rows[IndiceDGV].Cells[2].Value.ToString();
            txtDescripcion.Text = dataGridView3.Rows[IndiceDGV].Cells[3].Value.ToString();
            txtPrecio.Text = dataGridView3.Rows[IndiceDGV].Cells[4].Value.ToString();
            txtStock.Text = dataGridView3.Rows[IndiceDGV].Cells[5].Value.ToString();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
