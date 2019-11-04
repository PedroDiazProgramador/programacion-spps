using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DHistorial_Estado
    {//inicio de clase
        private int _Id_historial;
        private int _Id_produccion;
        private int _Id_estado;
        private DateTime _Fecha_cambio_estado;
        private string _Detalle_estado;
        #region Propiedades
        public int Id_historial
        {
            get
            {
                return _Id_historial;
            }

            set
            {
                _Id_historial = value;
            }
        }

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

        public int Id_estado
        {
            get
            {
                return _Id_estado;
            }

            set
            {
                _Id_estado = value;
            }
        }

        public DateTime Fecha_cambio_estado
        {
            get
            {
                return _Fecha_cambio_estado;
            }

            set
            {
                _Fecha_cambio_estado = value;
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
        #endregion Propiedades

        #region Constructores
        public DHistorial_Estado()
        {

        }

        public DHistorial_Estado(int id_historial, int id_produccion, int id_estado, DateTime fecha_cambio_estado, string detalle_estado)
        {
            this.Id_historial = id_historial;
            this.Id_produccion = id_produccion;
            this.Id_estado = id_estado;
            this.Fecha_cambio_estado = fecha_cambio_estado;
            this.Detalle_estado = detalle_estado;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DHistorial_Estado Historial_Estado)
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
                SqlCmd.CommandText = "spinsertar_historial_estado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Historial = new SqlParameter();
                ParId_Historial.ParameterName = "@id_historial";
                ParId_Historial.SqlDbType = SqlDbType.Int;
                ParId_Historial.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Historial);

                SqlParameter ParId_Produccion = new SqlParameter();
                ParId_Produccion.ParameterName = "@id_produccion";
                ParId_Produccion.SqlDbType = SqlDbType.Int;
                ParId_Produccion.Value = Historial_Estado.Id_produccion;
                SqlCmd.Parameters.Add(ParId_Produccion);

                SqlParameter ParId_Estado = new SqlParameter();
                ParId_Estado.ParameterName = "@id_estado";
                ParId_Estado.SqlDbType = SqlDbType.Int;
                ParId_Estado.Value = Historial_Estado.Id_estado;
                SqlCmd.Parameters.Add(ParId_Estado);

                SqlParameter ParFecha_Cambio_Estado = new SqlParameter();
                ParFecha_Cambio_Estado.ParameterName = "@fecha_cambio_estado";
                ParFecha_Cambio_Estado.SqlDbType = SqlDbType.DateTime;
                ParFecha_Cambio_Estado.Value = Historial_Estado.Fecha_cambio_estado;
                SqlCmd.Parameters.Add(ParFecha_Cambio_Estado);

                SqlParameter ParDetalle_Estado = new SqlParameter();
                ParDetalle_Estado.ParameterName = "@detalle_estado";
                ParDetalle_Estado.SqlDbType = SqlDbType.VarChar;
                ParDetalle_Estado.Size = 255;
                ParDetalle_Estado.Value = Historial_Estado.Detalle_estado;
                SqlCmd.Parameters.Add(ParDetalle_Estado);


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
        public string Editar(DHistorial_Estado Historial_Estado)
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
                SqlCmd.CommandText = "speditar_historial_estado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Historial = new SqlParameter();
                ParId_Historial.ParameterName = "@id_historial";
                ParId_Historial.SqlDbType = SqlDbType.Int;
                ParId_Historial.Value = Historial_Estado.Id_historial;
                SqlCmd.Parameters.Add(ParId_Historial);

                SqlParameter ParId_Produccion = new SqlParameter();
                ParId_Produccion.ParameterName = "@id_produccion";
                ParId_Produccion.SqlDbType = SqlDbType.Int;
                ParId_Produccion.Value = Historial_Estado.Id_produccion;
                SqlCmd.Parameters.Add(ParId_Produccion);

                SqlParameter ParId_Estado = new SqlParameter();
                ParId_Estado.ParameterName = "@id_estado";
                ParId_Estado.SqlDbType = SqlDbType.Int;
                ParId_Estado.Value = Historial_Estado.Id_estado;
                SqlCmd.Parameters.Add(ParId_Estado);

                SqlParameter ParFecha_Cambio_Estado = new SqlParameter();
                ParFecha_Cambio_Estado.ParameterName = "@fecha_cambio_estado";
                ParFecha_Cambio_Estado.SqlDbType = SqlDbType.DateTime;
                ParFecha_Cambio_Estado.Value = Historial_Estado.Fecha_cambio_estado;
                SqlCmd.Parameters.Add(ParFecha_Cambio_Estado);

                SqlParameter ParDetalle_Estado = new SqlParameter();
                ParDetalle_Estado.ParameterName = "@detalle_estado";
                ParDetalle_Estado.SqlDbType = SqlDbType.VarChar;
                ParDetalle_Estado.Size = 255;
                ParDetalle_Estado.Value = Historial_Estado.Detalle_estado;
                SqlCmd.Parameters.Add(ParDetalle_Estado);


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
        public string Eliminar(DHistorial_Estado Historial_Estado)
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
                SqlCmd.CommandText = "speliminar_historial_estado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Historial = new SqlParameter();
                ParId_Historial.ParameterName = "@id_historial";
                ParId_Historial.SqlDbType = SqlDbType.Int;
                ParId_Historial.Value = Historial_Estado.Id_historial;
                SqlCmd.Parameters.Add(ParId_Historial);

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
            DataTable DtResultado = new DataTable("hisorial_estado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_historial_estado";

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
