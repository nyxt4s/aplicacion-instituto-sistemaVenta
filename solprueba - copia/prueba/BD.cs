using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class BD
    {
        //Se establecen las credenciales para realizar la conexion a la base de datos
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-6UMFPOE\SQLEXPRESS; initial catalog=BdElCofreDelBordado; User ID=sa; Password=12345qwert;
        Connect Timeout=30;
        Encrypt=False;
        TrustServerCertificate=False;
        ApplicationIntent=ReadWrite;
        MultiSubnetFailover=False");

        //Se declara el método para abrir la conexion
        public SqlConnection AbrirCon()
        {
            try
            {
                cnn.Open();
                return cnn;
            }
            catch
            {
                return cnn;
            }
        }
        //Se declara el método para cerrar la conexion
        public SqlConnection CerrarCon()
        {
            try
            {
                cnn.Close();
                return cnn;
            }
            catch
            {
                return cnn;
            }
        }
    }
}
