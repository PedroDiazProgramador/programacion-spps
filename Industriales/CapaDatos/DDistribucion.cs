using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDistribucion
    {//inicio clase
        private int _Id_distribucion;
        private int _Id_taller;
        private int _Id_anticipo;
        private DateTime _Fecha_anticipo;
        private decimal _Monto;
        private int _Id_recibo;
        #region Propiedades
        public int Id_distribucion
        {
            get
            {
                return _Id_distribucion;
            }

            set
            {
                _Id_distribucion = value;
            }
        }

        public int Id_taller
        {
            get
            {
                return _Id_taller;
            }

            set
            {
                _Id_taller = value;
            }
        }

        public int Id_anticipo
        {
            get
            {
                return _Id_anticipo;
            }

            set
            {
                _Id_anticipo = value;
            }
        }

        public DateTime Fecha_anticipo
        {
            get
            {
                return _Fecha_anticipo;
            }

            set
            {
                _Fecha_anticipo = value;
            }
        }

        public decimal Monto
        {
            get
            {
                return _Monto;
            }

            set
            {
                _Monto = value;
            }
        }

        public int Id_recibo
        {
            get
            {
                return _Id_recibo;
            }

            set
            {
                _Id_recibo = value;
            }
        }
        #endregion Propiedades

        #region Metodos
        public DDistribucion()
        {

        }

        public DDistribucion(int id_distribucion, int id_taller, int id_anticipo, DateTime fecha_anticipo, decimal monto, int id_recibo)
        {
            this.Id_distribucion = id_distribucion;
            this.Id_taller = id_taller;
            this.Id_anticipo = id_anticipo;
            this.Fecha_anticipo = fecha_anticipo;
            this.Monto = monto;
            this.Id_recibo = id_recibo;
        }
        #endregion Metodos

        //metodo insertar   
        public string Insertar(DDistribucion Distribucion)
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
                SqlCmd.CommandText = "spinsertar_distribucion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Distribucion = new SqlParameter();
                ParId_Distribucion.ParameterName = "@id_distribucion";
                ParId_Distribucion.SqlDbType = SqlDbType.Int;
                ParId_Distribucion.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Distribucion);

                SqlParameter ParId_Taller = new SqlParameter();
                ParId_Taller.ParameterName = "@id_taller";
                ParId_Taller.SqlDbType = SqlDbType.Int;
                ParId_Taller.Value = Distribucion.Id_taller;
                SqlCmd.Parameters.Add(ParId_Taller);

                SqlParameter ParId_Anticipo = new SqlParameter();
                ParId_Anticipo.ParameterName = "@id_anticipo";
                ParId_Anticipo.SqlDbType = SqlDbType.Int;
                ParId_Anticipo.Value = Distribucion.Id_anticipo;
                SqlCmd.Parameters.Add(ParId_Anticipo);

                SqlParameter ParFecha_Entrega = new SqlParameter();
                ParFecha_Entrega.ParameterName = "@fecha_entrega";
                ParFecha_Entrega.SqlDbType = SqlDbType.DateTime;
                ParFecha_Entrega.Value = Distribucion.Fecha_anticipo;
                SqlCmd.Parameters.Add(ParFecha_Entrega);

                SqlParameter ParMonto = new SqlParameter();
                ParMonto.ParameterName = "@monto";
                ParMonto.SqlDbType = SqlDbType.Decimal;
                ParMonto.Value = Distribucion.Monto;
                SqlCmd.Parameters.Add(ParMonto);

                SqlParameter ParId_Recibido = new SqlParameter();
                ParId_Recibido.ParameterName = "@id_recibido";
                ParId_Recibido.SqlDbType = SqlDbType.Int;
                ParMonto.Value = Distribucion.Monto;
                SqlCmd.Parameters.Add(ParMonto);


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
        public string Editar(DDistribucion Distribucion)
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
                SqlCmd.CommandText = "speditar_distribucion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Distribucion = new SqlParameter();
                ParId_Distribucion.ParameterName = "@id_distribucion";
                ParId_Distribucion.SqlDbType = SqlDbType.Int;
                ParId_Distribucion.Value = Distribucion.Id_distribucion;
                SqlCmd.Parameters.Add(ParId_Distribucion);

                SqlParameter ParId_Taller = new SqlParameter();
                ParId_Taller.ParameterName = "@id_taller";
                ParId_Taller.SqlDbType = SqlDbType.Int;
                ParId_Taller.Value = Distribucion.Id_taller;
                SqlCmd.Parameters.Add(ParId_Taller);

                SqlParameter ParId_Anticipo = new SqlParameter();
                ParId_Anticipo.ParameterName = "@id_anticipo";
                ParId_Anticipo.SqlDbType = SqlDbType.Int;
                ParId_Anticipo.Value = Distribucion.Id_anticipo;
                SqlCmd.Parameters.Add(ParId_Anticipo);

                SqlParameter ParFecha_Entrega = new SqlParameter();
                ParFecha_Entrega.ParameterName = "@fecha_entrega";
                ParFecha_Entrega.SqlDbType = SqlDbType.DateTime;
                ParFecha_Entrega.Value = Distribucion.Fecha_anticipo;
                SqlCmd.Parameters.Add(ParFecha_Entrega);

                SqlParameter ParMonto = new SqlParameter();
                ParMonto.ParameterName = "@monto";
                ParMonto.SqlDbType = SqlDbType.Decimal;
                ParMonto.Value = Distribucion.Monto;
                SqlCmd.Parameters.Add(ParMonto);

                SqlParameter ParId_Recibido = new SqlParameter();
                ParId_Recibido.ParameterName = "@id_recibido";
                ParId_Recibido.SqlDbType = SqlDbType.Int;
                ParMonto.Value = Distribucion.Monto;
                SqlCmd.Parameters.Add(ParMonto);



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
        public string Eliminar(DDistribucion Distribucion)
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
                SqlCmd.CommandText = "speliminar_distribucion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Distribucion = new SqlParameter();
                ParId_Distribucion.ParameterName = "@id_distribucion";
                ParId_Distribucion.SqlDbType = SqlDbType.Int;
                ParId_Distribucion.Value = Distribucion.Id_distribucion;
                SqlCmd.Parameters.Add(ParId_Distribucion);

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
            DataTable DtResultado = new DataTable("distribucion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_distribucion";

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);




            }
            catch (Exception)
            {

                return null;
            }
            return DtResultado;
        }//fin mostrar

    }//fin clase
}
