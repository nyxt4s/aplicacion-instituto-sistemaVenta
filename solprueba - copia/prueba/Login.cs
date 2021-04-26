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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            // Formato para entregar la hora y fecha a través de un Timer habilitado
            Hora.Text = DateTime.Now.ToString("HH:mm");
            Fecha.Text = DateTime.Now.ToString("dd / MM / yy");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (us.Text == "USUARIO")
            {
                us.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (us.Text == "")
            {
                us.Text = "USUARIO";
            }
        }
        private void pas_Enter(object sender, EventArgs e)
        {
            if (pas.Text == "CONTRASEÑA")
            {
                pas.Text = "";
                pas.UseSystemPasswordChar = true;
            }
        }

        private void pas_Leave(object sender, EventArgs e)
        {
            if (pas.Text == "")
            {
                pas.Text = "CONTRASEÑA";
                pas.UseSystemPasswordChar = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // validación del login
            Validacion objconsulta = new Validacion();

            BDCONSULTAS obj = new BDCONSULTAS();

            if (objconsulta.val_login(us.Text, pas.Text) == true)
            {
                //  Si se cumple la condición es porque los campos de usuario y contraseña están vacíos
                men.Text = "Debe ingresar credenciales!!!";
            }
            else
            {
                if (obj.Login(us.Text, pas.Text) == "Bienvenido " + us.Text)
                {
                    // Si se cumple el obj.Login este devuelve un mensaje desde el procedimiento almacenado, por ende, 
                    //si las credenciales coinciden se devuelve el mensaje "Bienvenido 'Usuario' y se concede el acceso al menú"

                    obj.Login(us.Text, pas.Text);

                    Lobby mv = new Lobby();
                    this.Hide();
                    mv.ShowDialog();
                }
                else
                {
                    // en caso contrario de lo anterior debe volver a ingresar las credenciales
                    men.Text = "Ingresa credenciales válidas.";
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
