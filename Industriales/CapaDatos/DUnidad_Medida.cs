using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DUnidad_Medida
    {//inicio de clase
        private int _Id_unidad_medida;
        private string _Descripcion;
        #region Propiedades
        public int Id_unidad_medida
        {
            get
            {
                return _Id_unidad_medida;
            }

            set
            {
                _Id_unidad_medida = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DUnidad_Medida()
        {

        }

        public DUnidad_Medida(int id_unidad_medida, string descripcion)
        {
            this.Id_unidad_medida = id_unidad_medida;
            this.Descripcion = descripcion;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DUnidad_Medida Unidad_Medida)
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
                SqlCmd.CommandText = "spinsertar_unidad_medida";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Unidad_Medida = new SqlParameter();
                ParId_Unidad_Medida.ParameterName = "@id_unidad_medida";
                ParId_Unidad_Medida.SqlDbType = SqlDbType.Int;
                ParId_Unidad_Medida.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Unidad_Medida);

                SqlParameter ParUnidad_Medida = new SqlParameter();
                ParId_Unidad_Medida.ParameterName = "@descripcion";
                ParUnidad_Medida.SqlDbType = SqlDbType.VarChar;
                ParUnidad_Medida.Size = 50;
                ParUnidad_Medida.Value = Unidad_Medida.Descripcion;
                SqlCmd.Parameters.Add(ParUnidad_Medida);


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
        public string Editar(DUnidad_Medida Unidad_Medida)
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
                SqlCmd.CommandText = "speditar_unidad_medida";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Unidad_Medida = new SqlParameter();
                ParId_Unidad_Medida.ParameterName = "@id_unidad_medida";
                ParId_Unidad_Medida.SqlDbType = SqlDbType.Int;
                ParId_Unidad_Medida.Value = Unidad_Medida.Id_unidad_medida;
                SqlCmd.Parameters.Add(ParId_Unidad_Medida);

                SqlParameter ParUnidad_Medida = new SqlParameter();
                ParId_Unidad_Medida.ParameterName = "@descripcion";
                ParUnidad_Medida.SqlDbType = SqlDbType.VarChar;
                ParUnidad_Medida.Size = 50;
                ParUnidad_Medida.Value = Unidad_Medida.Descripcion;
                SqlCmd.Parameters.Add(ParUnidad_Medida);



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
        public string Eliminar(DUnidad_Medida Unidad_Medida)
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
                SqlCmd.CommandText = "speliminar_unidad_medida";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Unidad_Medida = new SqlParameter();
                ParId_Unidad_Medida.ParameterName = "@id_unidad_medida";
                ParId_Unidad_Medida.SqlDbType = SqlDbType.Int;
                ParId_Unidad_Medida.Value = Unidad_Medida.Id_unidad_medida;
                SqlCmd.Parameters.Add(ParId_Unidad_Medida);

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
            DataTable DtResultado = new DataTable("unidad_medida");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_unidad_medida";

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
