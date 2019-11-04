using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPedido_Presupuesto
    {//inicio de clase
        private int _Id_pedido_presupuesto;
        private int _Id_pedido;
        private int _Id_presupuesto;
        #region Propiedades
        public int Id_pedido_presupuesto
        {
            get
            {
                return _Id_pedido_presupuesto;
            }

            set
            {
                _Id_pedido_presupuesto = value;
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

        public int Id_presupuesto
        {
            get
            {
                return _Id_presupuesto;
            }

            set
            {
                _Id_presupuesto = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DPedido_Presupuesto()
        {

        }

        public DPedido_Presupuesto(int id_pedido_presupuesto, int id_pedido, int id_presupuesto)
        {
            this.Id_pedido_presupuesto = id_pedido_presupuesto;
            this.Id_pedido = id_pedido;
            this.Id_presupuesto = id_presupuesto;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DPedido_Presupuesto Pedido_Presupuesto)
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
                SqlCmd.CommandText = "spinsertar_pedido_presupuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pedido_Presupuesto = new SqlParameter();
                ParId_Pedido_Presupuesto.ParameterName = "@id_pedido_presupuesto";
                ParId_Pedido_Presupuesto.SqlDbType = SqlDbType.Int;
                ParId_Pedido_Presupuesto.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Pedido_Presupuesto);

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = Pedido_Presupuesto.Id_pedido;
                SqlCmd.Parameters.Add(ParId_Pedido);

                SqlParameter ParId_Presupuesto = new SqlParameter();
                ParId_Presupuesto.ParameterName = "@id_presupuesto";
                ParId_Presupuesto.SqlDbType = SqlDbType.Int;
                ParId_Presupuesto.Value = Pedido_Presupuesto.Id_presupuesto;
                SqlCmd.Parameters.Add(ParId_Presupuesto);


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
        public string Editar(DPedido_Presupuesto Pedido_Presupuesto)
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
                SqlCmd.CommandText = "speditar_pedido_presupuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pedido_Presupuesto = new SqlParameter();
                ParId_Pedido_Presupuesto.ParameterName = "@id_pedido_presupuesto";
                ParId_Pedido_Presupuesto.SqlDbType = SqlDbType.Int;
                ParId_Pedido_Presupuesto.Value = Pedido_Presupuesto.Id_pedido_presupuesto;
                SqlCmd.Parameters.Add(ParId_Pedido_Presupuesto);

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = Pedido_Presupuesto.Id_pedido;
                SqlCmd.Parameters.Add(ParId_Pedido);

                SqlParameter ParId_Presupuesto = new SqlParameter();
                ParId_Presupuesto.ParameterName = "@id_presupuesto";
                ParId_Presupuesto.SqlDbType = SqlDbType.Int;
                ParId_Presupuesto.Value = Pedido_Presupuesto.Id_presupuesto;
                SqlCmd.Parameters.Add(ParId_Presupuesto);

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
        public string Eliminar(DPedido_Presupuesto Pedido_Presupuesto)
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
                SqlCmd.CommandText = "speliminar_pedido_presupuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pedido_Presupuesto = new SqlParameter();
                ParId_Pedido_Presupuesto.ParameterName = "@id_pedido_presupuesto";
                ParId_Pedido_Presupuesto.SqlDbType = SqlDbType.Int;
                ParId_Pedido_Presupuesto.Value = Pedido_Presupuesto.Id_pedido_presupuesto;
                SqlCmd.Parameters.Add(ParId_Pedido_Presupuesto);

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
            DataTable DtResultado = new DataTable("pedido_presupuesto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_pedido_presupuesto";

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
