using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPedido_Producto
    {//inicio de clase
        private int _Id_pedido_producto;
        private int _Id_pedido;
        private int _Id_producto;
        private int _Cantidad_producto;
        #region Propiedades
        public int Id_pedido_producto
        {
            get
            {
                return _Id_pedido_producto;
            }

            set
            {
                _Id_pedido_producto = value;
            }
        }

        public int Id_pedido
        {
            get
            {
                return _Id_pedido;
            }

            set
            {
                _Id_pedido = value;
            }
        }

        public int Id_producto
        {
            get
            {
                return _Id_producto;
            }

            set
            {
                _Id_producto = value;
            }
        }

        public int Cantidad_producto
        {
            get
            {
                return _Cantidad_producto;
            }

            set
            {
                _Cantidad_producto = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DPedido_Producto()
        {

        }

        public DPedido_Producto(int id_pedido_producto, int id_pedido, int id_producto, int cantidad_producto)
        {
            this.Id_pedido_producto = id_pedido_producto;
            this.Id_pedido = id_pedido;
            this.Id_producto = id_producto;
            this.Cantidad_producto = cantidad_producto;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DPedido_Producto Pedido_Producto)
        {//inicio insertar
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_pedido_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pedido_Producto = new SqlParameter();
                ParId_Pedido_Producto.ParameterName = "@id_pedido_producto";
                ParId_Pedido_Producto.SqlDbType = SqlDbType.Int;
                ParId_Pedido_Producto.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Pedido_Producto);

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = Pedido_Producto.Id_pedido;
                SqlCmd.Parameters.Add(ParId_Pedido);

                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@id_producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Value = Pedido_Producto.Id_producto;
                SqlCmd.Parameters.Add(ParId_Producto);

                SqlParameter ParCantidad_Producto = new SqlParameter();
                ParCantidad_Producto.ParameterName = "@cantidad_producto";
                ParCantidad_Producto.SqlDbType = SqlDbType.Int;
                ParCantidad_Producto.Value = Pedido_Producto.Cantidad_producto;
                SqlCmd.Parameters.Add(ParCantidad_Producto);


                //ejecutar el codigo
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "EL REGISTRO NO HA SIDO AGREGADO";


            }
            catch (Exception ex)
            {

                rpta = ex.Message + ex.StackTrace;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }

            }
            return rpta;

        }//fin insertar

        //metodo editar
        public string Editar(DPedido_Producto Pedido_Producto)
        {//inicio editar
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_pedido_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pedido_Producto = new SqlParameter();
                ParId_Pedido_Producto.ParameterName = "@id_pedido_producto";
                ParId_Pedido_Producto.SqlDbType = SqlDbType.Int;
                ParId_Pedido_Producto.Value = Pedido_Producto.Id_pedido_producto;
                SqlCmd.Parameters.Add(ParId_Pedido_Producto);

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = Pedido_Producto.Id_pedido;
                SqlCmd.Parameters.Add(ParId_Pedido);

                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@id_producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Value = Pedido_Producto.Id_producto;
                SqlCmd.Parameters.Add(ParId_Producto);

                SqlParameter ParCantidad_Producto = new SqlParameter();
                ParCantidad_Producto.ParameterName = "@cantidad_producto";
                ParCantidad_Producto.SqlDbType = SqlDbType.Int;
                ParCantidad_Producto.Value = Pedido_Producto.Cantidad_producto;
                SqlCmd.Parameters.Add(ParCantidad_Producto);

                //ejecutar el codigo
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "HA FALLADO LA EDICION DEL REGISTRO";



            }
            catch (Exception ex)
            {

                rpta = ex.Message + ex.StackTrace;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }

            }
            return rpta;
        }//fin editar

        //metodo eliminar
        public string Eliminar(DPedido_Producto Pedido_Producto)
        {//inicio eliminar
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_pedido_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pedido_Producto = new SqlParameter();
                ParId_Pedido_Producto.ParameterName = "@id_pedido_producto";
                ParId_Pedido_Producto.SqlDbType = SqlDbType.Int;
                ParId_Pedido_Producto.Value = Pedido_Producto.Id_pedido_producto;
                SqlCmd.Parameters.Add(ParId_Pedido_Producto);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO SE HA ELIMINADO EL REGISTRO";



            }
            catch (Exception ex)
            {

                rpta = ex.Message + ex.StackTrace;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }

            }
            return rpta;
        }//fin eliminar

        //metodo mostrar
        public DataTable Mostrar()
        {//inicio mostrar
            DataTable DtResultado = new DataTable("pedido_producto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_pedido_producto";

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);




            }
            catch (Exception)
            {

                return null;
            }
            return DtResultado;
        }//fin mostrar


        #endregion Metodos

    }//fin de clase
}
