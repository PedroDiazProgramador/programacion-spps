using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPagos
    {//inicio de clase
        private int _Id_pago;
        private int _Id_venta;
        private int _Cuota_numero;
        private decimal _Monto_cuota;
        private int _Estado_cuota;
        private DateTime _Fecha_cuota;
        private int _Numero_comprobante;
        #region Propiedades
        public int Id_pago
        {
            get
            {
                return _Id_pago;
            }

            set
            {
                _Id_pago = value;
            }
        }

        public int Id_venta
        {
            get
            {
                return _Id_venta;
            }

            set
            {
                _Id_venta = value;
            }
        }

        public int Cuota_numero
        {
            get
            {
                return _Cuota_numero;
            }

            set
            {
                _Cuota_numero = value;
            }
        }

        public decimal Monto_cuota
        {
            get
            {
                return _Monto_cuota;
            }

            set
            {
                _Monto_cuota = value;
            }
        }

        public int Estado_cuota
        {
            get
            {
                return _Estado_cuota;
            }

            set
            {
                _Estado_cuota = value;
            }
        }

        public DateTime Fecha_cuota
        {
            get
            {
                return _Fecha_cuota;
            }

            set
            {
                _Fecha_cuota = value;
            }
        }

        public int Numero_comprobante
        {
            get
            {
                return _Numero_comprobante;
            }

            set
            {
                _Numero_comprobante = value;
            }
        }
        #endregion Propiedades

        #region Metodos
        public DPagos()
        {

        }

        public DPagos(int id_pago, int id_venta, int cuota_numero, decimal monto_cuota, int estado_cuota, DateTime fecha_cuota, int numero_comprobante)
        {
            this.Id_pago = id_pago;
            this.Id_venta = id_venta;
            this.Cuota_numero = cuota_numero;
            this.Monto_cuota = monto_cuota;
            this.Estado_cuota = estado_cuota;
            this.Fecha_cuota = fecha_cuota;
            this.Numero_comprobante = numero_comprobante;
        }
        #endregion Metodos

        #region Metodos
        //metodo insertar   
        public string Insertar(DPagos Pagos)
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
                SqlCmd.CommandText = "spinsertar_pago";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pago = new SqlParameter();
                ParId_Pago.ParameterName = "@id_pago";
                ParId_Pago.SqlDbType = SqlDbType.Int;
                ParId_Pago.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Pago);

                SqlParameter ParId_Venta = new SqlParameter();
                ParId_Venta.ParameterName = "@id_venta";
                ParId_Venta.SqlDbType = SqlDbType.Int;
                ParId_Venta.Value = Pagos.Id_venta;
                SqlCmd.Parameters.Add(ParId_Venta);

                SqlParameter ParCuota_Numero = new SqlParameter();
                ParCuota_Numero.ParameterName = "@cuota_numero";
                ParCuota_Numero.SqlDbType = SqlDbType.Int;
                ParCuota_Numero.Value = Pagos.Cuota_numero;
                SqlCmd.Parameters.Add(ParCuota_Numero);

                SqlParameter ParMonto_Cuota = new SqlParameter();
                ParMonto_Cuota.ParameterName = "@monto_cuota";
                ParMonto_Cuota.SqlDbType = SqlDbType.Decimal;
                ParMonto_Cuota.Value = Pagos.Monto_cuota;
                SqlCmd.Parameters.Add(ParMonto_Cuota);

                SqlParameter ParEstado_Cuota = new SqlParameter();
                ParEstado_Cuota.ParameterName = "@estado_cuota";
                ParEstado_Cuota.SqlDbType = SqlDbType.Int;
                ParEstado_Cuota.Value = Pagos.Estado_cuota;
                SqlCmd.Parameters.Add(ParEstado_Cuota);

                SqlParameter ParFecha_Cuota = new SqlParameter();
                ParFecha_Cuota.ParameterName = "@fecha_cuota";
                ParFecha_Cuota.SqlDbType = SqlDbType.DateTime;
                ParFecha_Cuota.Value = Pagos.Fecha_cuota;
                SqlCmd.Parameters.Add(ParFecha_Cuota);

                SqlParameter ParNumero_Comprobante = new SqlParameter();
                ParNumero_Comprobante.ParameterName = "@numero_comprobante";
                ParNumero_Comprobante.SqlDbType = SqlDbType.Int;
                ParNumero_Comprobante.Value = Pagos.Numero_comprobante;
                SqlCmd.Parameters.Add(ParNumero_Comprobante);


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
        public string Editar(DPagos Pagos)
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
                SqlCmd.CommandText = "speditar_pagos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pago = new SqlParameter();
                ParId_Pago.ParameterName = "@id_pago";
                ParId_Pago.SqlDbType = SqlDbType.Int;
                ParId_Pago.Value = Pagos.Id_pago;
                SqlCmd.Parameters.Add(ParId_Pago);

                SqlParameter ParId_Venta = new SqlParameter();
                ParId_Venta.ParameterName = "@id_venta";
                ParId_Venta.SqlDbType = SqlDbType.Int;
                ParId_Venta.Value = Pagos.Id_venta;
                SqlCmd.Parameters.Add(ParId_Venta);

                SqlParameter ParCuota_Numero = new SqlParameter();
                ParCuota_Numero.ParameterName = "@cuota_numero";
                ParCuota_Numero.SqlDbType = SqlDbType.Int;
                ParCuota_Numero.Value = Pagos.Cuota_numero;
                SqlCmd.Parameters.Add(ParCuota_Numero);

                SqlParameter ParMonto_Cuota = new SqlParameter();
                ParMonto_Cuota.ParameterName = "@monto_cuota";
                ParMonto_Cuota.SqlDbType = SqlDbType.Decimal;
                ParMonto_Cuota.Value = Pagos.Monto_cuota;
                SqlCmd.Parameters.Add(ParMonto_Cuota);

                SqlParameter ParEstado_Cuota = new SqlParameter();
                ParEstado_Cuota.ParameterName = "@estado_cuota";
                ParEstado_Cuota.SqlDbType = SqlDbType.Int;
                ParEstado_Cuota.Value = Pagos.Estado_cuota;
                SqlCmd.Parameters.Add(ParEstado_Cuota);

                SqlParameter ParFecha_Cuota = new SqlParameter();
                ParFecha_Cuota.ParameterName = "@fecha_cuota";
                ParFecha_Cuota.SqlDbType = SqlDbType.DateTime;
                ParFecha_Cuota.Value = Pagos.Fecha_cuota;
                SqlCmd.Parameters.Add(ParFecha_Cuota);

                SqlParameter ParNumero_Comprobante = new SqlParameter();
                ParNumero_Comprobante.ParameterName = "@numero_comprobante";
                ParNumero_Comprobante.SqlDbType = SqlDbType.Int;
                ParNumero_Comprobante.Value = Pagos.Numero_comprobante;
                SqlCmd.Parameters.Add(ParNumero_Comprobante);


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
        public string Eliminar(DPagos Pagos)
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
                SqlCmd.CommandText = "speliminar_pagos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Pago = new SqlParameter();
                ParId_Pago.ParameterName = "@id_pago";
                ParId_Pago.SqlDbType = SqlDbType.Int;
                ParId_Pago.Value = Pagos.Id_pago;
                SqlCmd.Parameters.Add(ParId_Pago);

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
            DataTable DtResultado = new DataTable("pagos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_pagos";

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
