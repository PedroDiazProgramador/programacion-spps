using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DProduccion
    {//inicio de clase
        private int _Id_produccion;
        private int _Numero_serie;
        private int _Id_producto;
        private string _Detalle_estado;
        private int _Id_pedido;
        #region Propiedades
        public int Id_produccion
        {
            get
            {
                return _Id_produccion;
            }

            set
            {
                _Id_produccion = value;
            }
        }

        public int Numero_serie
        {
            get
            {
                return _Numero_serie;
            }

            set
            {
                _Numero_serie = value;
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

        public string Detalle_estado
        {
            get
            {
                return _Detalle_estado;
            }

            set
            {
                _Detalle_estado = value;
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
        #endregion Propiedades

        #region Constructores
        public DProduccion()
        {

        }

        public DProduccion(int id_produccion, int numero_serie, int id_producto, string detalle_estado, int id_pedido)
        {
            this.Id_produccion = id_produccion;
            this.Numero_serie = numero_serie;
            this.Id_producto = id_producto;
            this.Detalle_estado = detalle_estado;
            this.Id_pedido = id_pedido;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DProduccion Produccion)
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
                SqlCmd.CommandText = "spinsertar_produccion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Produccion = new SqlParameter();
                ParId_Produccion.ParameterName = "@id_produccion";
                ParId_Produccion.SqlDbType = SqlDbType.Int;
                ParId_Produccion.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Produccion);

                SqlParameter ParNumero_Serie = new SqlParameter();
                ParNumero_Serie.ParameterName = "@numero_serie";
                ParNumero_Serie.SqlDbType = SqlDbType.Int;
                ParNumero_Serie.Value = Produccion.Numero_serie;
                SqlCmd.Parameters.Add(ParNumero_Serie);

                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@id_producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Value = Produccion.Id_producto;
                SqlCmd.Parameters.Add(ParId_Producto);

                SqlParameter ParDetalle_Estado = new SqlParameter();
                ParDetalle_Estado.ParameterName = "@detalle_estado";
                ParDetalle_Estado.SqlDbType = SqlDbType.VarChar;
                ParDetalle_Estado.Size = 1000;
                ParDetalle_Estado.Value = Produccion.Detalle_estado;
                SqlCmd.Parameters.Add(ParDetalle_Estado);

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = Produccion.Id_pedido;
                SqlCmd.Parameters.Add(ParId_Pedido);


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
        public string Editar(DProduccion Produccion)
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
                SqlCmd.CommandText = "speditar_produccion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Produccion = new SqlParameter();
                ParId_Produccion.ParameterName = "@id_produccion";
                ParId_Produccion.SqlDbType = SqlDbType.Int;
                ParId_Produccion.Value = Produccion.Id_produccion;
                SqlCmd.Parameters.Add(ParId_Produccion);

                SqlParameter ParNumero_Serie = new SqlParameter();
                ParNumero_Serie.ParameterName = "@numero_serie";
                ParNumero_Serie.SqlDbType = SqlDbType.Int;
                ParNumero_Serie.Value = Produccion.Numero_serie;
                SqlCmd.Parameters.Add(ParNumero_Serie);

                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@id_producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Value = Produccion.Id_producto;
                SqlCmd.Parameters.Add(ParId_Producto);

                SqlParameter ParDetalle_Estado = new SqlParameter();
                ParDetalle_Estado.ParameterName = "@detalle_estado";
                ParDetalle_Estado.SqlDbType = SqlDbType.VarChar;
                ParDetalle_Estado.Size = 1000;
                ParDetalle_Estado.Value = Produccion.Detalle_estado;
                SqlCmd.Parameters.Add(ParDetalle_Estado);

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = Produccion.Id_pedido;
                SqlCmd.Parameters.Add(ParId_Pedido);


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
        public string Eliminar(DProduccion Produccion)
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
                SqlCmd.CommandText = "speliminar_produccion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Produccion = new SqlParameter();
                ParId_Produccion.ParameterName = "@id_produccion";
                ParId_Produccion.SqlDbType = SqlDbType.Int;
                ParId_Produccion.Value = Produccion.Id_produccion;
                SqlCmd.Parameters.Add(ParId_Produccion);

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
            DataTable DtResultado = new DataTable("produccion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_produccion";

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
