using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DRecibo
    {//inicio clase
        private int _Id_recibo;
        private int _Numero_recibo;
        private DateTime _Fecha_recibo;
        private int _Id_taller;
        private string _Personal_recibe;
        #region Propiedades
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

        public int Numero_recibo
        {
            get
            {
                return _Numero_recibo;
            }

            set
            {
                _Numero_recibo = value;
            }
        }

        public DateTime Fecha_recibo
        {
            get
            {
                return _Fecha_recibo;
            }

            set
            {
                _Fecha_recibo = value;
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

        public string Personal_recibe
        {
            get
            {
                return _Personal_recibe;
            }

            set
            {
                _Personal_recibe = value;
            }
        }
        #endregion Propiedades

        #region Propiedades
        public DRecibo()
        {

        }

        public DRecibo(int id_recibo, int numero_recibo, DateTime fecha_recibo, int id_taller, string personal_recibe)
        {
            this.Id_recibo = id_recibo;
            this.Numero_recibo = numero_recibo;
            this.Fecha_recibo = fecha_recibo;
            this.Id_taller = id_taller;
            this.Personal_recibe = personal_recibe;
        }
        #endregion Propiedades

        #region Metodos
        //metodo insertar   
        public string Insertar(DRecibo Recibo)
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
                SqlCmd.CommandText = "spinsertar_recibo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Recibo = new SqlParameter();
                ParId_Recibo.ParameterName = "@id_recibo";
                ParId_Recibo.SqlDbType = SqlDbType.Int;
                ParId_Recibo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Recibo);

                SqlParameter ParNumero_Recibo = new SqlParameter();
                ParNumero_Recibo.ParameterName = "@numero_recibo";
                ParNumero_Recibo.SqlDbType = SqlDbType.Int;
                ParNumero_Recibo.Value = Recibo.Numero_recibo;
                SqlCmd.Parameters.Add(ParNumero_Recibo);

                SqlParameter ParFecha_Recibo = new SqlParameter();
                ParFecha_Recibo.ParameterName = "@fecha_recibo";
                ParFecha_Recibo.SqlDbType = SqlDbType.DateTime;
                ParFecha_Recibo.Value = Recibo.Fecha_recibo;
                SqlCmd.Parameters.Add(ParFecha_Recibo);

                SqlParameter ParId_Taller = new SqlParameter();
                ParId_Taller.ParameterName = "@id_taller";
                ParId_Taller.SqlDbType = SqlDbType.Int;
                ParId_Taller.Value = Recibo.Id_taller;
                SqlCmd.Parameters.Add(ParId_Taller);

                SqlParameter ParPersonal_Recibe = new SqlParameter();
                ParPersonal_Recibe.ParameterName = "@personal_recibe";
                ParPersonal_Recibe.SqlDbType = SqlDbType.VarChar;
                ParPersonal_Recibe.Size = 50;
                ParPersonal_Recibe.Value = Recibo.Personal_recibe;
                SqlCmd.Parameters.Add(ParPersonal_Recibe);


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
        public string Editar(DRecibo Recibo)
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
                SqlCmd.CommandText = "speditar_recibo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Recibo = new SqlParameter();
                ParId_Recibo.ParameterName = "@id_recibo";
                ParId_Recibo.SqlDbType = SqlDbType.Int;
                ParId_Recibo.Value = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Recibo);

                SqlParameter ParNumero_Recibo = new SqlParameter();
                ParNumero_Recibo.ParameterName = "@numero_recibo";
                ParNumero_Recibo.SqlDbType = SqlDbType.Int;
                ParNumero_Recibo.Value = Recibo.Numero_recibo;
                SqlCmd.Parameters.Add(ParNumero_Recibo);

                SqlParameter ParFecha_Recibo = new SqlParameter();
                ParFecha_Recibo.ParameterName = "@fecha_recibo";
                ParFecha_Recibo.SqlDbType = SqlDbType.DateTime;
                ParFecha_Recibo.Value = Recibo.Fecha_recibo;
                SqlCmd.Parameters.Add(ParFecha_Recibo);

                SqlParameter ParId_Taller = new SqlParameter();
                ParId_Taller.ParameterName = "@id_taller";
                ParId_Taller.SqlDbType = SqlDbType.Int;
                ParId_Taller.Value = Recibo.Id_taller;
                SqlCmd.Parameters.Add(ParId_Taller);

                SqlParameter ParPersonal_Recibe = new SqlParameter();
                ParPersonal_Recibe.ParameterName = "@personal_recibe";
                ParPersonal_Recibe.SqlDbType = SqlDbType.VarChar;
                ParPersonal_Recibe.Size = 50;
                ParPersonal_Recibe.Value = Recibo.Personal_recibe;
                SqlCmd.Parameters.Add(ParPersonal_Recibe);

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
        public string Eliminar(DRecibo Recibo)
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
                SqlCmd.CommandText = "speliminar_recibo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Recibo = new SqlParameter();
                ParId_Recibo.ParameterName = "@id_recibo";
                ParId_Recibo.SqlDbType = SqlDbType.Int;
                ParId_Recibo.Value = Recibo.Id_recibo;
                SqlCmd.Parameters.Add(ParId_Recibo);

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
            DataTable DtResultado = new DataTable("recibo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_recibo";

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
