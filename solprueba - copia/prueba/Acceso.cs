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
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();

            // código para agregar fondo al webforms
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\si.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

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
                MessageBox.Show("Debe ingresar credenciales!!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (obj.Login(us.Text, pas.Text) == "Bienvenido " + us.Text)
                {
                    // Si se cumple el obj.Login este devuelve un mensaje desde el procedimiento almacenado, por ende, 
                    //si las credenciales coinciden se devuelve el mensaje "Bienvenido 'Usuario' y se concede el acceso al menú"
                    
                    obj.Login(us.Text, pas.Text);

                    Menú mv = new Menú();
                    this.Hide();
                    mv.ShowDialog();
                    this.Show();

                }
                else 
                {
                    // en caso contrario de lo anterior debe volver a ingresar las credenciales
                    men.Text = "Ingresa credenciales válidas.";
                    MessageBox.Show("Ingresa credenciales válidas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Acceso_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hora_Click(object sender, EventArgs e)
        {

        }

        

        private void men_Click(object sender, EventArgs e)
        {

        }

        private void us_TextChanged(object sender, EventArgs e)
        {

        }

        private void pas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
