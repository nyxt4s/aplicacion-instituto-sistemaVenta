using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class Finanzas : Form
    {
        public Finanzas()
        {
            InitializeComponent();
            BDCONSULTAS obj = new BDCONSULTAS();

            Ganancia.Text = obj.Ganancia();
            Gastos.Text = obj.Gastos();
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

        private void Finanzas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet13.MATERIALES' Puede moverla o quitarla según sea necesario.
            this.mATERIALESTableAdapter.Fill(this.bdElCofreDelBordadoDataSet13.MATERIALES);
            // TODO: esta línea de código carga datos en la tabla 'bdElCofreDelBordadoDataSet12.PEDIDOS' Puede moverla o quitarla según sea necesario.
            this.pEDIDOSTableAdapter.Fill(this.bdElCofreDelBordadoDataSet12.PEDIDOS);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
