using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DTipo_Factura
    {//inicio clase
        private int _Id_tipo_factura;
        private string _Tipo_factura;
        #region Propiedades
        public int Id_tipo_factura
        {
            get
            {
                return _Id_tipo_factura;
            }

            set
            {
                _Id_tipo_factura = value;
            }
        }

        public string Tipo_factura
        {
            get
            {
                return _Tipo_factura;
            }

            set
            {
                _Tipo_factura = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DTipo_Factura()
        {

        }

        public DTipo_Factura(int id_tipo_factura, string tipo_factura)
        {
            this.Id_tipo_factura = id_tipo_factura;
            this.Tipo_factura = tipo_factura;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DTipo_Factura Tipo_Factura)
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
                SqlCmd.CommandText = "spinsertar_tipo_factura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Tipo_Factura = new SqlParameter();
                ParId_Tipo_Factura.ParameterName = "@id_tipo_factura";
                ParId_Tipo_Factura.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Factura.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Tipo_Factura);

                SqlParameter ParTipo_Factura = new SqlParameter();
                ParTipo_Factura.ParameterName = "@tipo_factura";
                ParTipo_Factura.SqlDbType = SqlDbType.VarChar;
                ParTipo_Factura.Size = 50;
                ParTipo_Factura.Value = Tipo_Factura.Tipo_factura;
                SqlCmd.Parameters.Add(ParTipo_Factura);


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
        public string Editar(DTipo_Factura Tipo_Factura)
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
                SqlCmd.CommandText = "speditar_tipo_factura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Tipo_Factura = new SqlParameter();
                ParId_Tipo_Factura.ParameterName = "@id_tipo_factura";
                ParId_Tipo_Factura.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Factura.Value = Tipo_Factura.Id_tipo_factura;
                SqlCmd.Parameters.Add(ParId_Tipo_Factura);

                SqlParameter ParTipo_Factura = new SqlParameter();
                ParTipo_Factura.ParameterName = "@tipo_factura";
                ParTipo_Factura.SqlDbType = SqlDbType.VarChar;
                ParTipo_Factura.Size = 50;
                ParTipo_Factura.Value = Tipo_Factura.Tipo_factura;
                SqlCmd.Parameters.Add(ParTipo_Factura);

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
        public string Eliminar(DTipo_Factura Tipo_Factura)
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
                SqlCmd.CommandText = "speliminar_tipo_factura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Tipo_Factura = new SqlParameter();
                ParId_Tipo_Factura.ParameterName = "@id_tipo_factura";
                ParId_Tipo_Factura.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Factura.Value = Tipo_Factura.Id_tipo_factura;
                SqlCmd.Parameters.Add(ParId_Tipo_Factura);


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
            DataTable DtResultado = new DataTable("tipo_Factura");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_tipo_factura";

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
