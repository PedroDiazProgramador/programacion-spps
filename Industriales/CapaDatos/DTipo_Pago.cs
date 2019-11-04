using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DTipo_Pago
    {//inicio de clase
        private int _Id_tipo_pago;
        private string _Tipo_pago;
        #region Propiedades
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

        public string Tipo_pago
        {
            get
            {
                return _Tipo_pago;
            }

            set
            {
                _Tipo_pago = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DTipo_Pago()
        {

        }

        public DTipo_Pago(int id_tipo_pago, string tipo_pago)
        {
            this.Id_tipo_pago = id_tipo_pago;
            this.Tipo_pago = tipo_pago;
        }
        #endregion Propiedades

        #region Metodos
        //metodo insertar   
        public string Insertar(DTipo_Pago Tipo_Pago)
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
                SqlCmd.CommandText = "spinsertar_tipo_pago";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Tipo_Pago = new SqlParameter();
                ParId_Tipo_Pago.ParameterName = "@id_tipo_pago";
                ParId_Tipo_Pago.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Pago.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Tipo_Pago);

                SqlParameter ParTipo_Pago = new SqlParameter();
                ParTipo_Pago.ParameterName = "@tipo_pago";
                ParTipo_Pago.SqlDbType = SqlDbType.VarChar;
                ParTipo_Pago.Size = 50;
                ParTipo_Pago.Value = Tipo_Pago.Tipo_pago;
                SqlCmd.Parameters.Add(ParTipo_Pago);


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
        public string Editar(DTipo_Pago Tipo_Pago)
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
                SqlCmd.CommandText = "speditar_tipo_pago";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Tipo_Pago = new SqlParameter();
                ParId_Tipo_Pago.ParameterName = "@id_tipo_pago";
                ParId_Tipo_Pago.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Pago.Value = Tipo_Pago.Id_tipo_pago;
                SqlCmd.Parameters.Add(ParId_Tipo_Pago);

                SqlParameter ParTipo_Pago = new SqlParameter();
                ParTipo_Pago.ParameterName = "@tipo_pago";
                ParTipo_Pago.SqlDbType = SqlDbType.VarChar;
                ParTipo_Pago.Size = 50;
                ParTipo_Pago.Value = Tipo_Pago.Tipo_pago;
                SqlCmd.Parameters.Add(ParTipo_Pago);


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
        public string Eliminar(DTipo_Pago Tipo_Pago)
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
                SqlCmd.CommandText = "speliminar_tipo_pago";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Tipo_Pago = new SqlParameter();
                ParId_Tipo_Pago.ParameterName = "@id_tipo_pago";
                ParId_Tipo_Pago.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Pago.Value = Tipo_Pago.Id_tipo_pago;
                SqlCmd.Parameters.Add(ParId_Tipo_Pago);

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
            DataTable DtResultado = new DataTable("tipo_pago");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_tipo_pago";

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
