using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DSobrantes
    {//inicio clase
        private int _Id_sobrante;
        private int _Id_insumo;
        private int _Id_pedido;
        private decimal _Cantidad;
        #region Propiedades
        public int Id_sobrante
        {
            get
            {
                return _Id_sobrante;
            }

            set
            {
                _Id_sobrante = value;
            }
        }

        public int Id_insumo
        {
            get
            {
                return _Id_insumo;
            }

            set
            {
                _Id_insumo = value;
            }
        }

        public int Id_pedido
        {
            get
            {
                return _Id_pedido;
            }

            set
            {
                _Id_pedido = value;
            }
        }

        public decimal Cantidad
        {
            get
            {
                return _Cantidad;
            }

            set
            {
                _Cantidad = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DSobrantes()
        {

        }

        public DSobrantes(int id_sobrante, int id_insumo, int id_pedido, decimal cantidad)
        {
            this.Id_sobrante = id_sobrante;
            this.Id_insumo = id_insumo;
            this.Id_pedido = id_pedido;
            this.Cantidad = cantidad;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DSobrantes Sobrantes)
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
                SqlCmd.CommandText = "spinsertar_sobrantes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Sobrante = new SqlParameter();
                ParId_Sobrante.ParameterName = "@id_sobrante";
                ParId_Sobrante.SqlDbType = SqlDbType.Int;
                ParId_Sobrante.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Sobrante);

                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Value = Sobrantes.Id_insumo;
                SqlCmd.Parameters.Add(ParId_Insumo);

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = Sobrantes.Id_pedido;
                SqlCmd.Parameters.Add(ParId_Pedido);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Decimal;
                ParCantidad.Value = Sobrantes.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);


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
        public string Editar(DSobrantes Sobrantes)
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
                SqlCmd.CommandText = "speditar_sobrantes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Sobrante = new SqlParameter();
                ParId_Sobrante.ParameterName = "@id_sobrante";
                ParId_Sobrante.SqlDbType = SqlDbType.Int;
                ParId_Sobrante.Value = Sobrantes.Id_sobrante;
                SqlCmd.Parameters.Add(ParId_Sobrante);

                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Value = Sobrantes.Id_insumo;
                SqlCmd.Parameters.Add(ParId_Insumo);

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = Sobrantes.Id_pedido;
                SqlCmd.Parameters.Add(ParId_Pedido);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Decimal;
                ParCantidad.Value = Sobrantes.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

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
        public string Eliminar(DSobrantes Sobrantes)
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
                SqlCmd.CommandText = "speliminar_sobrantes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Sobrante = new SqlParameter();
                ParId_Sobrante.ParameterName = "@id_sobrante";
                ParId_Sobrante.SqlDbType = SqlDbType.Int;
                ParId_Sobrante.Value = Sobrantes.Id_sobrante;
                SqlCmd.Parameters.Add(ParId_Sobrante);

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
            DataTable DtResultado = new DataTable("sobrantes");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_sobrantes";

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
