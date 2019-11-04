using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DTaller
    {//inicio de clase
        private int _Id_taller;
        private string _Denominacion;
        #region Propiedades
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

        public string Denominacion
        {
            get
            {
                return _Denominacion;
            }

            set
            {
                _Denominacion = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DTaller()
        {

        }

        public DTaller(int id_taller, string denominacion)
        {
            this.Id_taller = id_taller;
            this.Denominacion = denominacion;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DTaller Taller)
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
                SqlCmd.CommandText = "spinsertar_taller";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Taller = new SqlParameter();
                ParId_Taller.ParameterName = "@id_taller";
                ParId_Taller.SqlDbType = SqlDbType.Int;
                ParId_Taller.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Taller);

                SqlParameter ParDenominacion = new SqlParameter();
                ParDenominacion.ParameterName = "@denominacion";
                ParDenominacion.SqlDbType = SqlDbType.VarChar;
                ParDenominacion.Size = 50;
                ParDenominacion.Value = Taller.Denominacion;
                SqlCmd.Parameters.Add(ParDenominacion);


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
        public string Editar(DTaller Taller)
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
                SqlCmd.CommandText = "speditar_taller";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Taller = new SqlParameter();
                ParId_Taller.ParameterName = "@id_taller";
                ParId_Taller.SqlDbType = SqlDbType.Int;
                ParId_Taller.Value = Taller.Id_taller;
                SqlCmd.Parameters.Add(ParId_Taller);

                SqlParameter ParDenominacion = new SqlParameter();
                ParDenominacion.ParameterName = "@denominacion";
                ParDenominacion.SqlDbType = SqlDbType.VarChar;
                ParDenominacion.Size = 50;
                ParDenominacion.Value = Taller.Denominacion;
                SqlCmd.Parameters.Add(ParDenominacion);

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
        public string Eliminar(DTaller Taller)
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
                SqlCmd.CommandText = "speliminar_taller";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Taller = new SqlParameter();
                ParId_Taller.ParameterName = "@id_taller";
                ParId_Taller.SqlDbType = SqlDbType.Int;
                ParId_Taller.Value = Taller.Id_taller;
                SqlCmd.Parameters.Add(ParId_Taller);

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
            DataTable DtResultado = new DataTable("taller");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_taller";

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
