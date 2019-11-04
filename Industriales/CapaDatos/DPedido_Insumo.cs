using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPedido_Insumo
    {//inicio de clase
        private int _Id_pedido_insumo;
        private int _Id_pedido;
        private int _Id_insumo;
        private decimal _Cantidad_insumo;
        #region Propiedades
        public int Id_pedido_insumo
        {
            get
            {
                return _Id_pedido_insumo;
            }

            set
            {
                _Id_pedido_insumo = value;
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

        public decimal Cantidad_insumo
        {
            get
            {
                return _Cantidad_insumo;
            }

            set
            {
                _Cantidad_insumo = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DPedido_Insumo()
        {

        }

        public DPedido_Insumo(int id_pedido_insumo, int id_pedido, int id_insumo, decimal cantidad_insumo)
        {
            this.Id_pedido_insumo = id_pedido_insumo;
            this.Id_pedido = id_pedido;
            this.Id_insumo = id_insumo;
            this.Cantidad_insumo = cantidad_insumo;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DPedido_Insumo Pedido_Insumo)
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
                SqlCmd.CommandText = "spinsertar_pedido_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pedido_Insumo = new SqlParameter();
                ParId_Pedido_Insumo.ParameterName = "@id_pedido_insumo";
                ParId_Pedido_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Pedido_Insumo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Pedido_Insumo);

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = Pedido_Insumo.Id_pedido;
                SqlCmd.Parameters.Add(ParId_Pedido);

                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Value = Pedido_Insumo.Id_insumo;
                SqlCmd.Parameters.Add(ParId_Insumo);

                SqlParameter ParCantidad_Insumo = new SqlParameter();
                ParCantidad_Insumo.ParameterName = "@cantidad_insumo";
                ParCantidad_Insumo.SqlDbType = SqlDbType.Decimal;
                ParCantidad_Insumo.Value = Pedido_Insumo.Cantidad_insumo;
                SqlCmd.Parameters.Add(ParCantidad_Insumo);



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
        public string Editar(DPedido_Insumo Pedido_Insumo)
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
                SqlCmd.CommandText = "speditar_pedido_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pedido_Insumo = new SqlParameter();
                ParId_Pedido_Insumo.ParameterName = "@id_pedido_insumo";
                ParId_Pedido_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Pedido_Insumo.Value = Pedido_Insumo.Id_pedido_insumo;
                SqlCmd.Parameters.Add(ParId_Pedido_Insumo);

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = Pedido_Insumo.Id_pedido;
                SqlCmd.Parameters.Add(ParId_Pedido);

                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Value = Pedido_Insumo.Id_insumo;
                SqlCmd.Parameters.Add(ParId_Insumo);

                SqlParameter ParCantidad_Insumo = new SqlParameter();
                ParCantidad_Insumo.ParameterName = "@cantidad_insumo";
                ParCantidad_Insumo.SqlDbType = SqlDbType.Decimal;
                ParCantidad_Insumo.Value = Pedido_Insumo.Cantidad_insumo;
                SqlCmd.Parameters.Add(ParCantidad_Insumo);

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
        public string Eliminar(DPedido_Insumo Pedido_Insumo)
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
                SqlCmd.CommandText = "speliminar_pedido_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Pedido_Insumo = new SqlParameter();
                ParId_Pedido_Insumo.ParameterName = "@id_pedido_insumo";
                ParId_Pedido_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Pedido_Insumo.Value = Pedido_Insumo.Id_pedido_insumo;
                SqlCmd.Parameters.Add(ParId_Pedido_Insumo);

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
            DataTable DtResultado = new DataTable("pedido_insumo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_pedido_insumo";

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
