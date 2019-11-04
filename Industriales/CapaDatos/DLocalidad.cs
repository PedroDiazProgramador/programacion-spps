using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DLocalidad
    {//inicio clase
        private int _Id_localidad;
        private int _Id_provincia;
        private string _Localidad;
        #region Propiedades
        public int Id_localidad
        {
            get
            {
                return _Id_localidad;
            }

            set
            {
                _Id_localidad = value;
            }
        }

        public int Id_provincia
        {
            get
            {
                return _Id_provincia;
            }

            set
            {
                _Id_provincia = value;
            }
        }

        public string Localidad
        {
            get
            {
                return _Localidad;
            }

            set
            {
                _Localidad = value;
            }
        }
        #endregion Propiedades

        #region Metodos
        public DLocalidad()
        {

        }

        public DLocalidad(int id_localidad, int id_provincia, string localidad)
        {
            this.Id_localidad = id_localidad;
            this.Id_provincia = id_provincia;
            this.Localidad = localidad;
        }
        #endregion Metodos

        #region Metodos
        //metodo insertar   
        public string Insertar(DLocalidad Localidad)
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
                SqlCmd.CommandText = "spinsertar_localidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Localidad = new SqlParameter();
                ParId_Localidad.ParameterName = "@id_localidad";
                ParId_Localidad.SqlDbType = SqlDbType.Int;
                ParId_Localidad.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Localidad);

                SqlParameter ParId_Provincia = new SqlParameter();
                ParId_Provincia.ParameterName = "@id_provincia";
                ParId_Provincia.SqlDbType = SqlDbType.Int;
                ParId_Provincia.Value = Localidad.Localidad;
                SqlCmd.Parameters.Add(ParId_Provincia);

                SqlParameter ParLocalidad = new SqlParameter();
                ParLocalidad.ParameterName = "@localidad";
                ParLocalidad.SqlDbType = SqlDbType.VarChar;
                ParLocalidad.Size = 50;
                ParLocalidad.Value = Localidad.Localidad;
                SqlCmd.Parameters.Add(ParLocalidad);


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
        public string Editar(DLocalidad Localidad)
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
                SqlCmd.CommandText = "speditar_localidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Localidad = new SqlParameter();
                ParId_Localidad.ParameterName = "@id_localidad";
                ParId_Localidad.SqlDbType = SqlDbType.Int;
                ParId_Localidad.Value = Localidad.Localidad;
                SqlCmd.Parameters.Add(ParId_Localidad);

                SqlParameter ParId_Provincia = new SqlParameter();
                ParId_Provincia.ParameterName = "@id_provincia";
                ParId_Provincia.SqlDbType = SqlDbType.Int;
                ParId_Provincia.Value = Localidad.Localidad;
                SqlCmd.Parameters.Add(ParId_Provincia);

                SqlParameter ParLocalidad = new SqlParameter();
                ParLocalidad.ParameterName = "@localidad";
                ParLocalidad.SqlDbType = SqlDbType.VarChar;
                ParLocalidad.Size = 50;
                ParLocalidad.Value = Localidad.Localidad;
                SqlCmd.Parameters.Add(ParLocalidad);



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
        public string Eliminar(DLocalidad Localidad)
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
                SqlCmd.CommandText = "speliminar_localidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Localidad = new SqlParameter();
                ParId_Localidad.ParameterName = "@id_localidad";
                ParId_Localidad.SqlDbType = SqlDbType.Int;
                ParId_Localidad.Value = Localidad.Id_localidad;
                SqlCmd.Parameters.Add(ParId_Localidad);

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
            DataTable DtResultado = new DataTable("localidad");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_localidad";

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
