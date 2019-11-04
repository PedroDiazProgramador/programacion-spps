using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DProvincia
    {//inicio clase
        private int _Id_provincia;
        private string _Provincia;
        private string _Textobuscar;
        #region Propiedades
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

        public string Provincia
        {
            get
            {
                return _Provincia;
            }

            set
            {
                _Provincia = value;
            }
        }

        public string Textobuscar
        {
            get
            {
                return _Textobuscar;
            }

            set
            {
                _Textobuscar = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DProvincia()
        {

        }

        public DProvincia(int id_provincia, string provincia, string textobuscar)
        {
            this.Id_provincia = id_provincia;
            this.Provincia = provincia;
            this.Textobuscar = textobuscar;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DProvincia Provincia)
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
                SqlCmd.CommandText = "spinsertar_provincia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Provincia = new SqlParameter();
                ParId_Provincia.ParameterName = "@id_provincia";
                ParId_Provincia.SqlDbType = SqlDbType.Int;
                ParId_Provincia.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Provincia);

                SqlParameter ParProvincia = new SqlParameter();
                ParProvincia.ParameterName = "@provincia";
                ParProvincia.SqlDbType = SqlDbType.VarChar;
                ParProvincia.Size = 50;
                ParProvincia.Value = Provincia.Provincia;
                SqlCmd.Parameters.Add(ParProvincia);

                
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
        public string Editar(DProvincia Provincia)
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
                SqlCmd.CommandText = "speditar_provincia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Provincia = new SqlParameter();
                ParId_Provincia.ParameterName = "@id_provincia";
                ParId_Provincia.SqlDbType = SqlDbType.Int;
                ParId_Provincia.Value = Provincia.Id_provincia;
                SqlCmd.Parameters.Add(ParId_Provincia);

                SqlParameter ParProvincia = new SqlParameter();
                ParProvincia.ParameterName = "@provincia";
                ParProvincia.SqlDbType = SqlDbType.VarChar;
                ParProvincia.Size = 50;
                ParProvincia.Value = Provincia.Provincia;
                SqlCmd.Parameters.Add(ParProvincia);

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
        public string Eliminar(DProvincia Provincia)
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
                SqlCmd.CommandText = "speliminar_provincia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Provincia = new SqlParameter();
                ParId_Provincia.ParameterName = "@id_provincia";
                ParId_Provincia.SqlDbType = SqlDbType.Int;
                ParId_Provincia.Value = Provincia.Id_provincia;
                SqlCmd.Parameters.Add(ParId_Provincia);

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
            DataTable DtResultado = new DataTable("provincia");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_provincia";

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);




            }
            catch (Exception)
            {

                return null;
            }
            return DtResultado;
        }//fin mostrar

        //metodo buscar 
        public DataTable Buscar(DProvincia Provincia)
        {//inicio buscar
            DataTable DtResultado = new DataTable("provincia");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;

                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spbuscar_provincia";

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 255;
                ParTextoBuscar.Value = Provincia.Textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);



            }
            catch (Exception)
            {

                return null;
            }
            return DtResultado;
        }//fin metodo buscar 
#endregion Metodos
    }//fin clase
}
