using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class BDCONSULTAS
    {
        //LOGIN 
        public string Login(string us, string pass)
        {
            //Se crea el objeto de la clase BD para abrir la conexion
            BD obj = new BD();
            //string mensaje almacenará el dato devuelto del procedimiento almacenado LOGIN_BD
            string mensaje;
            //Se abre la conexion desde BD y se declara el procedimiento almacenado a ejecutar
            SqlCommand cmd = new SqlCommand("LOGIN_BD", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            // Se declaran los valores a ingresar dentro del procedimiento almacenado 'us' , 'pass' y sus 
            cmd.Parameters.AddWithValue("@Nombre", us);
            cmd.Parameters.AddWithValue("@Contraseña", pass);
            SqlParameter paramId = new SqlParameter("mensaje", SqlDbType.VarChar, 1000);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);
            cmd.ExecuteNonQuery();
            mensaje = Convert.ToString(cmd.Parameters["mensaje"].Value);
            obj.CerrarCon();
            return mensaje;
        }

        public SqlDataReader LeerFilas;
        //LISTAR DATOS

        public DataTable ListarAccesorios()
        {
            DataTable Tabla = new DataTable();
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ListarAccesorios", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            LeerFilas = cmd.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            obj.CerrarCon();
            return Tabla;
        }

        public DataTable ListarAros()
        {
            DataTable Tabla = new DataTable();
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ListarAros", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            LeerFilas = cmd.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            obj.CerrarCon();
            return Tabla;
        }

        public DataTable ListarBastidores()
        {
            DataTable Tabla = new DataTable();
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ListarBastidores", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            LeerFilas = cmd.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            obj.CerrarCon();
            return Tabla;
        }

        public DataTable ListarClientes() 
        {
            DataTable Tabla = new DataTable();
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ListarClientes", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            LeerFilas = cmd.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            obj.CerrarCon();
            return Tabla;
        }

        public DataTable ListarPedidos()
        {
            DataTable Tabla = new DataTable();
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ListarPedidos", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            LeerFilas = cmd.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            obj.CerrarCon();
            return Tabla;
        }

        public DataTable ListarMateriales() 
        {
            DataTable Tabla = new DataTable();
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ListarMateriales", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            LeerFilas = cmd.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            obj.CerrarCon();
            return Tabla;
        }
        //INGRESO DE DATOS

        public void IngresarMateriales(string tipo, string descripcion, int costo, string stock) 
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("InsertarMateriales", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TIPO", tipo);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("@COSTO", costo);
            cmd.Parameters.AddWithValue("@STOCK", stock);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        public void IngresarPedido(int id_clientes, int precio, DateTime fecha, string estado, int id_aros, int id_bastidor, int id_accesorios) 
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("InsertarPedido", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_CLIENTES", id_clientes);
            cmd.Parameters.AddWithValue("@PRECIO", precio);
            cmd.Parameters.AddWithValue("@FECHA", fecha);
            cmd.Parameters.AddWithValue("@ESTADO", estado);
            cmd.Parameters.AddWithValue("@ID_AROS", id_aros);
            cmd.Parameters.AddWithValue("@ID_BASTIDOR", id_bastidor);
            cmd.Parameters.AddWithValue("@ID_ACCESORIOS", id_accesorios);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        public void IngresarAccesorios(string nombre, string tipo, string descripcion, int precio, int stock) 
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("InsertarAccesorios", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@TIPO", tipo);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("@PRECIO", precio);
            cmd.Parameters.AddWithValue("@STOCK", stock);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        public void IngresarAros(string nombre, string descripcion, int precio, int stock) 
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("InsertarAros", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("@PRECIO", precio);
            cmd.Parameters.AddWithValue("@STOCK", stock);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        public void IngresarBastidores(string nombre, string descripcion, int precio, int stock) 
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("InsertarBastidores", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("@PRECIO", precio);
            cmd.Parameters.AddWithValue("@STOCK", stock);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        //ELIMINAR 
        public void EliminarPedido(int id_pedido)
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("", obj.AbrirCon());
            cmd.CommandText = "DELETE PEDIDOS WHERE ID_PEDIDOS =" + id_pedido;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            obj.CerrarCon();
        }

        //MODIFICACIONES
        public void ModificarCliente(string nombre, string apellidoP, string apellidoM, string direccion, int telefono, int id) 
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ModificarCliente", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@APELLIDO_P", apellidoP);
            cmd.Parameters.AddWithValue("@APELLIDO_M", apellidoM);
            cmd.Parameters.AddWithValue("@DIRECCION", direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", telefono);
            cmd.Parameters.AddWithValue("ID", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        public void ModificarPedido(int idClientes, int precio, DateTime fecha, string estado, int idAros, int idBastidor, int idAccesorios, int id) 
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ModificarPedidos", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_CLIENTES", idClientes);
            cmd.Parameters.AddWithValue("@PRECIO", precio);
            cmd.Parameters.AddWithValue("@FECHA", fecha);
            cmd.Parameters.AddWithValue("@ESTADO", estado);
            cmd.Parameters.AddWithValue("@ID_AROS", idAros);
            cmd.Parameters.AddWithValue("@ID_BASTIDOR", idBastidor);
            cmd.Parameters.AddWithValue("@ID_ACCESORIOS", idAccesorios);
            cmd.Parameters.AddWithValue("ID", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        public void ModificarMateriales(string tipo, string descripcion, int costo, string stock, int id) 
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ModificarMateriales", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TIPO", tipo);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("@COSTO", costo);
            cmd.Parameters.AddWithValue("@STOCK", stock);
            cmd.Parameters.AddWithValue("ID", id);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        public void ModificarAros(string nombre, string descripcion, int precio, int stock, int id)
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ModificarAros", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("@PRECIO", precio);
            cmd.Parameters.AddWithValue("@STOCK", stock);
            cmd.Parameters.AddWithValue("ID", id);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        public void ModificarBastidores(string nombre, string descripcion, int precio, int stock, int id)
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ModificarBastidores", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("@PRECIO", precio);
            cmd.Parameters.AddWithValue("@STOCK", stock);
            cmd.Parameters.AddWithValue("ID", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        public void ModificarAccesorios(string nombre, string tipo, string descripcion, int precio, int stock, int id)
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ModificarAccesorios", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            cmd.Parameters.AddWithValue("@TIPO", tipo);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
            cmd.Parameters.AddWithValue("@PRECIO", precio);
            cmd.Parameters.AddWithValue("@STOCK", stock);
            cmd.Parameters.AddWithValue("ID", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        //Ganancias y Gastos

        public string Ganancia() 
        {
            BD obj = new BD();
            string result;
            SqlCommand cmd = new SqlCommand("CalculoGanancia", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@suma", 0);
            cmd.Parameters.AddWithValue("@suma2", 0);
            SqlParameter paramId = new SqlParameter("result", SqlDbType.VarChar, 1000);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);
            cmd.ExecuteNonQuery();
            result = Convert.ToString(cmd.Parameters["result"].Value);
            obj.CerrarCon();
            return result;
        }
        public string Gastos()
        {
            BD obj = new BD();
            string result;
            SqlCommand cmd = new SqlCommand("CalculoGastos", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@gasto", 0);
            SqlParameter paramId = new SqlParameter("result", SqlDbType.VarChar, 1000);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);
            cmd.ExecuteNonQuery();
            result = Convert.ToString(cmd.Parameters["result"].Value);
            obj.CerrarCon();
            return result;
        }

        //Disminución de stock

        public void ActualizarStock()
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ActualizarStock", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        public void ActualizarStockExistente(int id)
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ActualizarStockExistente", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }

        public void ActualizarStockModificado(int id_ac, int id_ba, int id_ar)
        {
            BD obj = new BD();
            SqlCommand cmd = new SqlCommand("ActualizarStockModificado", obj.AbrirCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_AC", id_ac);
            cmd.Parameters.AddWithValue("@ID_BA", id_ba);
            cmd.Parameters.AddWithValue("@ID_AR", id_ar);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            obj.CerrarCon();
        }
    }
}
