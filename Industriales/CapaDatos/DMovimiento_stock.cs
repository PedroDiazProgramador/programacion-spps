using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DMovimiento_stock
    {//inicio de clase
        private int _Id_movimiento_stock;
        private int _Cantidad;
        private int _Id_tipo_movimiento;
        private int _Id_producto;
        private DateTime _Fecha;
        private DateTime _Hora;
        private int _Id_usuario;

        #region Propiedades
        public int Id_movimiento_stock
        {
            get
            {
                return _Id_movimiento_stock;
            }

            set
            {
                _Id_movimiento_stock = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return _Cantidad;
            }

            set
            {
                _Cantidad = value;
            }
        }

        public int Id_tipo_movimiento
        {
            get
            {
                return _Id_tipo_movimiento;
            }

            set
            {
                _Id_tipo_movimiento = value;
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

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
            }
        }

        public DateTime Hora
        {
            get
            {
                return _Hora;
            }

            set
            {
                _Hora = value;
            }
        }

        public int Id_usuario
        {
            get
            {
                return _Id_usuario;
            }

            set
            {
                _Id_usuario = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DMovimiento_stock()
        {

        }

        public DMovimiento_stock(int id_movimiento_stock, int cantidad, int id_tipo_movimiento, int id_producto, DateTime fecha, DateTime hora, int id_usuario)
        {
            this.Id_movimiento_stock = id_movimiento_stock;
            this.Cantidad = cantidad;
            this.Id_tipo_movimiento = id_tipo_movimiento;
            this.Id_producto = id_producto;
            this.Fecha = fecha;
            this.Hora = hora;
            this.Id_usuario = id_usuario;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DMovimiento_stock Movimiento_stock)
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
                SqlCmd.CommandText = "spinsertar_movimiento_stock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Movimiento_stock = new SqlParameter();
                ParId_Movimiento_stock.ParameterName = "@id_movimiento_stock";
                ParId_Movimiento_stock.SqlDbType = SqlDbType.Int;
                ParId_Movimiento_stock.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Movimiento_stock);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Movimiento_stock.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParTipoMovimiento = new SqlParameter();
                ParTipoMovimiento.ParameterName = "@id_tipo_movimiento";
                ParTipoMovimiento.SqlDbType = SqlDbType.Int;
                ParTipoMovimiento.Value = Movimiento_stock.Id_tipo_movimiento;
                SqlCmd.Parameters.Add(ParTipoMovimiento);

                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@id_producto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = Movimiento_stock.Id_producto;
                SqlCmd.Parameters.Add(ParTipoMovimiento);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.VarChar;
                ParFecha.Size = 50;
                ParFecha.Value = Movimiento_stock.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParHora = new SqlParameter();
                ParHora.ParameterName = "@hora";
                ParHora.SqlDbType = SqlDbType.VarChar;
                ParHora.Size = 50;
                ParHora.Value = Movimiento_stock.Hora;
                SqlCmd.Parameters.Add(ParHora);

                SqlParameter ParIdUsusario = new SqlParameter();
                ParIdUsusario.ParameterName = "@id_usuario";
                ParIdUsusario.SqlDbType = SqlDbType.Int;
                ParIdUsusario.Value = Movimiento_stock.Id_usuario;
                SqlCmd.Parameters.Add(ParIdUsusario);

                
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
        #endregion Metodos
    }//fin de clase
}
