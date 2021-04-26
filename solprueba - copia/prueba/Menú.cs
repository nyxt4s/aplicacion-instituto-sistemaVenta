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
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menú_Load(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Botón de menú para ingresar al formulario "Clientes"
            try
            {
                this.Hide();
                Clientes mv = new Clientes();
                mv.ShowDialog();
                this.Show();
            }
            catch
            {
                MessageBox.Show("CUIDAO");
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

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Botón de menú para ingresar al formulario "Materiales"
            this.Hide();
            Stock mv = new Stock();
            mv.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
