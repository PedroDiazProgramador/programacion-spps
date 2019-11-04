using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEstado_Cuota
    {//inicio clase
        private int _Id_estado;
        private string _Estado_cuota;
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

        public string Estado_cuota
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
        #endregion Propiedades

        #region Constructores
        public DEstado_Cuota()
        {

        }

        public DEstado_Cuota(int id_estado, string estado_cuota)
        {
            this.Id_estado = id_estado;
            this.Estado_cuota = estado_cuota;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DEstado_Cuota Estado_Cuota)
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
                SqlCmd.CommandText = "spinsertar_estado_cuota";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Estado = new SqlParameter();
                ParId_Estado.ParameterName = "@id_estado";
                ParId_Estado.SqlDbType = SqlDbType.Int;
                ParId_Estado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Estado);

                SqlParameter ParEstado_Cuota = new SqlParameter();
                ParEstado_Cuota.ParameterName = "@estado_cuota";
                ParEstado_Cuota.SqlDbType = SqlDbType.VarChar;
                ParEstado_Cuota.Size = 50;
                ParEstado_Cuota.Value = Estado_Cuota.Estado_cuota;
                SqlCmd.Parameters.Add(ParEstado_Cuota);


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
        public string Editar(DEstado_Cuota Estado_Cuota)
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
                SqlCmd.CommandText = "speditar_estado_cuota";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Estado = new SqlParameter();
                ParId_Estado.ParameterName = "@id_estado";
                ParId_Estado.SqlDbType = SqlDbType.Int;
                ParId_Estado.Value = Estado_Cuota.Estado_cuota;
                SqlCmd.Parameters.Add(ParId_Estado);

                SqlParameter ParEstado_Cuota = new SqlParameter();
                ParEstado_Cuota.ParameterName = "@estado_cuota";
                ParEstado_Cuota.SqlDbType = SqlDbType.VarChar;
                ParEstado_Cuota.Size = 50;
                ParEstado_Cuota.Value = Estado_Cuota.Estado_cuota;
                SqlCmd.Parameters.Add(ParEstado_Cuota);



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
        public string Eliminar(DEstado_Cuota Estado_Cuota)
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
                SqlCmd.CommandText = "speliminar_estado_cuota";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Estado = new SqlParameter();
                ParId_Estado.ParameterName = "@id_estado";
                ParId_Estado.SqlDbType = SqlDbType.Int;
                ParId_Estado.Value = Estado_Cuota.Estado_cuota;
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
            DataTable DtResultado = new DataTable("estado_cuota");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_estado_cuota";

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
