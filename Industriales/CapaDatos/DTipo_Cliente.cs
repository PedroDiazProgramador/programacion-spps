using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DTipo_Cliente
    {//inicio de clase
        private int _Id_tipo_cliente;
        private string _Tipo_cliente;
        #region Propiedades
        public int Id_tipo_cliente
        {
            get
            {
                return _Id_tipo_cliente;
            }

            set
            {
                _Id_tipo_cliente = value;
            }
        }

        public string Tipo_cliente
        {
            get
            {
                return _Tipo_cliente;
            }

            set
            {
                _Tipo_cliente = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DTipo_Cliente()
        {

        }

        public DTipo_Cliente(int id_tipo_cliente, string tipo_cliente)
        {
            this.Id_tipo_cliente = id_tipo_cliente;
            this.Tipo_cliente = tipo_cliente;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DTipo_Cliente Tipo_Cliente)
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
                SqlCmd.CommandText = "spinsertar_tipo_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Tipo_Cliente = new SqlParameter();
                ParId_Tipo_Cliente.ParameterName = "@id_tipo_cliente";
                ParId_Tipo_Cliente.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Cliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Tipo_Cliente);

                SqlParameter ParTipo_Cliente = new SqlParameter();
                ParTipo_Cliente.ParameterName = "@tipo_cliente";
                ParId_Tipo_Cliente.SqlDbType = SqlDbType.VarChar;
                ParId_Tipo_Cliente.Size = 50;
                ParId_Tipo_Cliente.Value = Tipo_Cliente.Tipo_cliente;
                SqlCmd.Parameters.Add(ParId_Tipo_Cliente);


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
        public string Editar(DTipo_Cliente Tipo_Cliente)
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
                SqlCmd.CommandText = "speditar_tipo_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Tipo_Cliente = new SqlParameter();
                ParId_Tipo_Cliente.ParameterName = "@id_tipo_cliente";
                ParId_Tipo_Cliente.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Cliente.Value = Tipo_Cliente.Id_tipo_cliente;
                SqlCmd.Parameters.Add(ParId_Tipo_Cliente);

                SqlParameter ParTipo_Cliente = new SqlParameter();
                ParTipo_Cliente.ParameterName = "@tipo_cliente";
                ParId_Tipo_Cliente.SqlDbType = SqlDbType.VarChar;
                ParId_Tipo_Cliente.Size = 50;
                ParId_Tipo_Cliente.Value = Tipo_Cliente.Tipo_cliente;
                SqlCmd.Parameters.Add(ParId_Tipo_Cliente);

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
        public string Eliminar(DTipo_Cliente Tipo_cliente)
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
                SqlCmd.CommandText = "speliminar_tipo_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Tipo_Cliente = new SqlParameter();
                ParId_Tipo_Cliente.ParameterName = "@id_tipo_cliente";
                ParId_Tipo_Cliente.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Cliente.Value = Tipo_cliente.Id_tipo_cliente;
                SqlCmd.Parameters.Add(ParId_Tipo_Cliente);

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
            DataTable DtResultado = new DataTable("tipo_cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_tipo_cliente";

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
