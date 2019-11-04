using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDetalle
    {//inicio clase
        private int _Id_detalle;
        private int _Id_factura;
        private int _Id_producto;
        private decimal _Precio_producto;
        private int _Cantidad_producto;
        private string _Descripcion_producto;
        #region Propiedades
        public int Id_detalle
        {
            get
            {
                return _Id_detalle;
            }

            set
            {
                _Id_detalle = value;
            }
        }

        public int Id_factura
        {
            get
            {
                return _Id_factura;
            }

            set
            {
                _Id_factura = value;
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

        public decimal Precio_producto
        {
            get
            {
                return _Precio_producto;
            }

            set
            {
                _Precio_producto = value;
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

        public string Descripcion_producto
        {
            get
            {
                return _Descripcion_producto;
            }

            set
            {
                _Descripcion_producto = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DDetalle()
        {

        }

        public DDetalle(int id_detalle, int id_factura, int id_producto, decimal precio_producto, int cantidad_producto, string descripcion_producto)
        {
            this.Id_detalle = id_detalle;
            this.Id_factura = id_factura;
            this.Id_producto = id_producto;
            this.Precio_producto = precio_producto;
            this.Cantidad_producto = cantidad_producto;
            this.Descripcion_producto = descripcion_producto;
        }
        #endregion Constructores

        #region Metodos        
        //metodo insertar   
        public string Insertar(DDetalle Detalle)
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
                SqlCmd.CommandText = "spinsertar_detalle";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Detalle = new SqlParameter();
                ParId_Detalle.ParameterName = "@id_detalle";
                ParId_Detalle.SqlDbType = SqlDbType.Int;
                ParId_Detalle.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Detalle);

                SqlParameter ParId_Factura = new SqlParameter();
                ParId_Factura.ParameterName = "@id_factura";
                ParId_Factura.SqlDbType = SqlDbType.Int;
                ParId_Factura.Value = Detalle.Id_factura;
                SqlCmd.Parameters.Add(ParId_Factura);

                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@id_producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Value = Detalle.Id_producto;
                SqlCmd.Parameters.Add(ParId_Producto);

                SqlParameter ParPrecio_Producto = new SqlParameter();
                ParPrecio_Producto.ParameterName = "@precio_producto";
                ParPrecio_Producto.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Producto.Value = Detalle.Precio_producto;
                SqlCmd.Parameters.Add(ParPrecio_Producto);

                SqlParameter ParCantidad_Producto = new SqlParameter();
                ParCantidad_Producto.ParameterName = "@cantidad_producto";
                ParCantidad_Producto.SqlDbType = SqlDbType.Int;
                ParCantidad_Producto.Value = Detalle.Cantidad_producto;
                SqlCmd.Parameters.Add(ParCantidad_Producto);

                SqlParameter ParDescripcion_Producto = new SqlParameter();
                ParDescripcion_Producto.ParameterName = "@descripcion_producto";
                ParDescripcion_Producto.SqlDbType = SqlDbType.VarChar;
                ParDescripcion_Producto.Size = 255;
                ParDescripcion_Producto.Value = Detalle.Descripcion_producto;
                SqlCmd.Parameters.Add(ParDescripcion_Producto);

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
        public string Editar(DDetalle Detalle)
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
                SqlCmd.CommandText = "speditar_detalle";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Detalle = new SqlParameter();
                ParId_Detalle.ParameterName = "@id_detalle";
                ParId_Detalle.SqlDbType = SqlDbType.Int;
                ParId_Detalle.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Detalle);

                SqlParameter ParId_Factura = new SqlParameter();
                ParId_Factura.ParameterName = "@id_factura";
                ParId_Factura.SqlDbType = SqlDbType.Int;
                ParId_Factura.Value = Detalle.Id_factura;
                SqlCmd.Parameters.Add(ParId_Factura);

                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@id_producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Value = Detalle.Id_producto;
                SqlCmd.Parameters.Add(ParId_Producto);

                SqlParameter ParPrecio_Producto = new SqlParameter();
                ParPrecio_Producto.ParameterName = "@precio_producto";
                ParPrecio_Producto.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Producto.Value = Detalle.Precio_producto;
                SqlCmd.Parameters.Add(ParPrecio_Producto);

                SqlParameter ParCantidad_Producto = new SqlParameter();
                ParCantidad_Producto.ParameterName = "@cantidad_producto";
                ParCantidad_Producto.SqlDbType = SqlDbType.Int;
                ParCantidad_Producto.Value = Detalle.Cantidad_producto;
                SqlCmd.Parameters.Add(ParCantidad_Producto);

                SqlParameter ParDescripcion_Producto = new SqlParameter();
                ParDescripcion_Producto.ParameterName = "@descripcion_producto";
                ParDescripcion_Producto.SqlDbType = SqlDbType.VarChar;
                ParDescripcion_Producto.Size = 255;
                ParDescripcion_Producto.Value = Detalle.Descripcion_producto;
                SqlCmd.Parameters.Add(ParDescripcion_Producto);


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
        public string Eliminar(DDetalle Detalle)
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
                SqlCmd.CommandText = "speliminar_detalle";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Detalle = new SqlParameter();
                ParId_Detalle.ParameterName = "@id_detalle";
                ParId_Detalle.SqlDbType = SqlDbType.Int;
                ParId_Detalle.Value = Detalle.Id_detalle;
                SqlCmd.Parameters.Add(ParId_Detalle);

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
            DataTable DtResultado = new DataTable("detalle");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_detalle";

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
    }//fin clase
}
