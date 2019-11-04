using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DFactura
    {//inicio de clase
        private int _Id_factura;
        private int _Id_cliente;
        private DateTime _Fecha_venta;
        private decimal _Costo_total;
        private int _Numero_factura;
        private int _Comprobante_exposicion;
        private int _Id_tipo_pago;
        private int _Emite_factura;
        private int _Tipo_factura;
        #region Propiedades
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

        public int Id_cliente
        {
            get
            {
                return _Id_cliente;
            }

            set
            {
                _Id_cliente = value;
            }
        }

        public DateTime Fecha_venta
        {
            get
            {
                return _Fecha_venta;
            }

            set
            {
                _Fecha_venta = value;
            }
        }

        public decimal Costo_total
        {
            get
            {
                return _Costo_total;
            }

            set
            {
                _Costo_total = value;
            }
        }

        public int Numero_factura
        {
            get
            {
                return _Numero_factura;
            }

            set
            {
                _Numero_factura = value;
            }
        }

        public int Comprobante_exposicion
        {
            get
            {
                return _Comprobante_exposicion;
            }

            set
            {
                _Comprobante_exposicion = value;
            }
        }

        public int Id_tipo_pago
        {
            get
            {
                return _Id_tipo_pago;
            }

            set
            {
                _Id_tipo_pago = value;
            }
        }

        public int Emite_factura
        {
            get
            {
                return _Emite_factura;
            }

            set
            {
                _Emite_factura = value;
            }
        }

        public int Tipo_factura
        {
            get
            {
                return _Tipo_factura;
            }

            set
            {
                _Tipo_factura = value;
            }
        }
        #endregion Propiedades

        #region Metodos
        public DFactura()
        {

        }

        public DFactura(int id_factura, int id_cliente, DateTime fecha_venta, decimal costo_total, int numero_factura, int comprobante_exposicion, int id_tipo_pago, int emite_factura, int tipo_factura)
        {
            this.Id_factura = id_factura;
            this.Id_cliente = id_cliente;
            this.Fecha_venta = fecha_venta;
            this.Costo_total = costo_total;
            this.Numero_factura = numero_factura;
            this.Comprobante_exposicion = comprobante_exposicion;
            this.Id_tipo_pago = id_tipo_pago;
            this.Emite_factura = emite_factura;
            this.Tipo_factura = tipo_factura;
        }
        #endregion Propiedades

        #region Metodos        
        //metodo insertar   
        public string Insertar(DFactura Factura)
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
                SqlCmd.CommandText = "spinsertar_factura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Factura = new SqlParameter();
                ParId_Factura.ParameterName = "@id_factura";
                ParId_Factura.SqlDbType = SqlDbType.Int;
                ParId_Factura.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Factura);

                SqlParameter ParId_Cliente= new SqlParameter();
                ParId_Cliente.ParameterName = "@id_cliente";
                ParId_Cliente.SqlDbType = SqlDbType.Int;
                ParId_Cliente.Value = Factura.Id_cliente;
                SqlCmd.Parameters.Add(ParId_Cliente);

                SqlParameter ParFecha_Venta = new SqlParameter();
                ParFecha_Venta.ParameterName = "@fecha_venta";
                ParFecha_Venta.SqlDbType = SqlDbType.DateTime;
                ParFecha_Venta.Value = Factura.Fecha_venta;
                SqlCmd.Parameters.Add(ParFecha_Venta);

                SqlParameter ParCosto_Total = new SqlParameter();
                ParCosto_Total.ParameterName = "@costo_total";
                ParCosto_Total.SqlDbType = SqlDbType.Decimal;
                ParCosto_Total.Value = Factura.Costo_total;
                SqlCmd.Parameters.Add(ParCosto_Total);

                SqlParameter ParNumero_Factura = new SqlParameter();
                ParNumero_Factura.ParameterName = "@numero_factura";
                ParNumero_Factura.SqlDbType = SqlDbType.Int;
                ParNumero_Factura.Value = Factura.Numero_factura;
                SqlCmd.Parameters.Add(ParNumero_Factura);

                SqlParameter ParComprobante_Exposicion = new SqlParameter();
                ParComprobante_Exposicion.ParameterName = "@comprobante_exposicion";
                ParComprobante_Exposicion.SqlDbType = SqlDbType.Int;
                ParComprobante_Exposicion.Value = Factura.Comprobante_exposicion;
                SqlCmd.Parameters.Add(ParComprobante_Exposicion);

                SqlParameter ParId_Tipo_Pago = new SqlParameter();
                ParId_Tipo_Pago.ParameterName = "@id_tipo_pago";
                ParId_Tipo_Pago.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Pago.Value = Factura.Id_tipo_pago;
                SqlCmd.Parameters.Add(ParId_Tipo_Pago);

                SqlParameter ParEmite_Factura = new SqlParameter();
                ParEmite_Factura.ParameterName = "@emite_factura";
                ParEmite_Factura.SqlDbType = SqlDbType.Int;
                ParEmite_Factura.Value = Factura.Emite_factura;
                SqlCmd.Parameters.Add(ParEmite_Factura);

                SqlParameter ParTipo_Factura = new SqlParameter();
                ParTipo_Factura.ParameterName = "@tipo_factura";
                ParTipo_Factura.SqlDbType = SqlDbType.Int;
                ParTipo_Factura.Value = Factura.Tipo_factura;
                SqlCmd.Parameters.Add(ParTipo_Factura);

               
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
        public string Editar(DFactura Factura)
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
                SqlCmd.CommandText = "speditar_factura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Factura = new SqlParameter();
                ParId_Factura.ParameterName = "@id_factura";
                ParId_Factura.SqlDbType = SqlDbType.Int;
                ParId_Factura.Value = Factura.Id_factura;
                SqlCmd.Parameters.Add(ParId_Factura);

                SqlParameter ParId_Cliente = new SqlParameter();
                ParId_Cliente.ParameterName = "@id_cliente";
                ParId_Cliente.SqlDbType = SqlDbType.Int;
                ParId_Cliente.Value = Factura.Id_cliente;
                SqlCmd.Parameters.Add(ParId_Cliente);

                SqlParameter ParFecha_Venta = new SqlParameter();
                ParFecha_Venta.ParameterName = "@fecha_venta";
                ParFecha_Venta.SqlDbType = SqlDbType.DateTime;
                ParFecha_Venta.Value = Factura.Fecha_venta;
                SqlCmd.Parameters.Add(ParFecha_Venta);

                SqlParameter ParCosto_Total = new SqlParameter();
                ParCosto_Total.ParameterName = "@costo_total";
                ParCosto_Total.SqlDbType = SqlDbType.Decimal;
                ParCosto_Total.Value = Factura.Costo_total;
                SqlCmd.Parameters.Add(ParCosto_Total);

                SqlParameter ParNumero_Factura = new SqlParameter();
                ParNumero_Factura.ParameterName = "@numero_factura";
                ParNumero_Factura.SqlDbType = SqlDbType.Int;
                ParNumero_Factura.Value = Factura.Numero_factura;
                SqlCmd.Parameters.Add(ParNumero_Factura);

                SqlParameter ParComprobante_Exposicion = new SqlParameter();
                ParComprobante_Exposicion.ParameterName = "@comprobante_exposicion";
                ParComprobante_Exposicion.SqlDbType = SqlDbType.Int;
                ParComprobante_Exposicion.Value = Factura.Comprobante_exposicion;
                SqlCmd.Parameters.Add(ParComprobante_Exposicion);

                SqlParameter ParId_Tipo_Pago = new SqlParameter();
                ParId_Tipo_Pago.ParameterName = "@id_tipo_pago";
                ParId_Tipo_Pago.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Pago.Value = Factura.Id_tipo_pago;
                SqlCmd.Parameters.Add(ParId_Tipo_Pago);

                SqlParameter ParEmite_Factura = new SqlParameter();
                ParEmite_Factura.ParameterName = "@emite_factura";
                ParEmite_Factura.SqlDbType = SqlDbType.Int;
                ParEmite_Factura.Value = Factura.Emite_factura;
                SqlCmd.Parameters.Add(ParEmite_Factura);

                SqlParameter ParTipo_Factura = new SqlParameter();
                ParTipo_Factura.ParameterName = "@tipo_factura";
                ParTipo_Factura.SqlDbType = SqlDbType.Int;
                ParTipo_Factura.Value = Factura.Tipo_factura;
                SqlCmd.Parameters.Add(ParTipo_Factura);




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
        public string Eliminar(DFactura Factura)
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
                SqlCmd.CommandText = "speliminar_factura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Factura = new SqlParameter();
                ParId_Factura.ParameterName = "@id_factura";
                ParId_Factura.SqlDbType = SqlDbType.Int;
                ParId_Factura.Value = Factura.Id_factura;
                SqlCmd.Parameters.Add(ParId_Factura);

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
            DataTable DtResultado = new DataTable("factura");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_factura";

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
