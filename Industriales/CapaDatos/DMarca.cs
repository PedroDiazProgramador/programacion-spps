using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DMarca
    {
        private int _Id_marca;
        private string _Denominacion;

        #region propiedades
        public int Id_marca
        {
            get
            {
                return _Id_marca;
            }

            set
            {
                _Id_marca = value;
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
        #endregion propiedades

        #region constructores
        public DMarca() { }

        public DMarca(int _Id_marca, string _Denominacion)
        {
            this._Id_marca = _Id_marca;
            this._Denominacion = _Denominacion;
        }

        #endregion constructores

        #region metodos
        //Insertar
        public string Insertar(DMarca marca)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spinsertar_marca";

                //parametros
                SqlParameter ParIdMarca = new SqlParameter();
                ParIdMarca.ParameterName = "@id_marca";
                ParIdMarca.SqlDbType = SqlDbType.Int;
                ParIdMarca.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdMarca);

                SqlParameter ParDenominacion = new SqlParameter();
                ParDenominacion.ParameterName = "@denominacion";
                ParDenominacion.SqlDbType = SqlDbType.VarChar;
                ParDenominacion.Size = 50;
                ParDenominacion.Value = marca.Denominacion;
                SqlCmd.Parameters.Add(ParDenominacion);

                rpta = (SqlCmd.ExecuteNonQuery() == 1) ? "OK" : "NO SE AGREGADO LA CATEGORIA DE LA TABLA MARCA";


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
        }
        //fin Insertar

        //metodo editar
        public string Editar(DMarca marca)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "speditar_marca";

                //parametros
                SqlParameter ParIdMarca = new SqlParameter();
                ParIdMarca.ParameterName = "@id_marca";
                ParIdMarca.SqlDbType = SqlDbType.Int;
                ParIdMarca.Value = marca.Id_marca;
                SqlCmd.Parameters.Add(ParIdMarca);

                SqlParameter ParDenominacion = new SqlParameter();
                ParDenominacion.ParameterName = "@denominacion";
                ParDenominacion.SqlDbType = SqlDbType.VarChar;
                ParDenominacion.Size = 50;
                ParDenominacion.Value = marca.Denominacion;
                SqlCmd.Parameters.Add(ParDenominacion);

                rpta = (SqlCmd.ExecuteNonQuery() == 1) ? "OK" : "HA FALLADO LA ACTUALIZACION DEL ESTADO CIVIL";


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
        }
        //Fin editar

        //metodo eliminar
        public string Eliminar(DMarca Marca)
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
                SqlCmd.CommandText = "speliminar_marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Marca = new SqlParameter();
                ParId_Marca.ParameterName = "@id_marca";
                ParId_Marca.SqlDbType = SqlDbType.Int;
                ParId_Marca.Value = Marca.Id_marca;
                SqlCmd.Parameters.Add(ParId_Marca);

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
        DataTable DtResultado = new DataTable("marca");
        SqlConnection SqlCon = new SqlConnection();
        try
        {
            SqlCon.ConnectionString = Conexion.Cn;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.CommandText = "spmostrar_marca";

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

    }

}
