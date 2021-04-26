using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace prueba
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            AbrirFormContenedor(new Menú());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContenedor_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void AbrirFormContenedor(object formcontenedor)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fc = formcontenedor as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fc);
            this.PanelContenedor.Tag = fc;
            fc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormContenedor(new Clientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormContenedor(new Pedidos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormContenedor(new Finanzas());
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            AbrirFormContenedor(new Materiales());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            AbrirFormContenedor(new Stock());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormContenedor(new Menú());
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            // Formato para entregar la hora y fecha a través de un Timer habilitado
            Hora.Text = DateTime.Now.ToString("HH:mm");
            Fecha.Text = DateTime.Now.ToString("dd / MM / yy");
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Login mv = new Login();
            this.Hide();
            mv.ShowDialog();
            this.Show();
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
