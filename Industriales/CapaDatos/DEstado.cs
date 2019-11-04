using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEstado
    {//inicio de clase
        private int _Id_estado;
        private string _Estado;
        #region Propiedades
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

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }
        #endregion Propiedades

        #region Constrctores
    public DEstado()
    {

    }

    public DEstado(int id_estado, string estado)
    {
            this.Id_estado = id_estado;
            this.Estado = estado;
    }
        #endregion Constructores

        #region Metodos

        //metodo insertar   
        public string Insertar(DEstado Estado)
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
                SqlCmd.CommandText = "spinsertar_estado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Estado = new SqlParameter();
                ParId_Estado.ParameterName = "@id_estado";
                ParId_Estado.SqlDbType = SqlDbType.Int;
                ParId_Estado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Estado);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 50;
                ParEstado.Value = Estado.Estado;
                SqlCmd.Parameters.Add(ParEstado);

               
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
        public string Editar(DEstado Estado)
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
                SqlCmd.CommandText = "speditar_estado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Estado = new SqlParameter();
                ParId_Estado.ParameterName = "@id_estado";
                ParId_Estado.SqlDbType = SqlDbType.Int;
                ParId_Estado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Estado);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 50;
                ParEstado.Value = Estado.Estado;
                SqlCmd.Parameters.Add(ParEstado); 



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
        public string Eliminar(DEstado Estado)
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
                SqlCmd.CommandText = "speliminar_estado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Estado = new SqlParameter();
                ParId_Estado.ParameterName = "@id_estado";
                ParId_Estado.SqlDbType = SqlDbType.Int;
                ParId_Estado.Value = Estado.Estado;
                SqlCmd.Parameters.Add(ParId_Estado);
                
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
            DataTable DtResultado = new DataTable("estado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_estado";

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
