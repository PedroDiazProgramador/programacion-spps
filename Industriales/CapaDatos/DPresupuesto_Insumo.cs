using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPresupuesto_Insumo
    {//inicio de clase
        private int _Id_pre_insumo;
        private int _Id_presupuesto;
        private int _Id_insumo;
        private int _Cantidad;
        private decimal _Precio_unitario;
        #region Propiedades
        public int Id_pre_insumo
        {
            get
            {
                return _Id_pre_insumo;
            }

            set
            {
                _Id_pre_insumo = value;
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

        public int Cantidad
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

        public decimal Precio_unitario
        {
            get
            {
                return _Precio_unitario;
            }

            set
            {
                _Precio_unitario = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DPresupuesto_Insumo()
        {

        }

        public DPresupuesto_Insumo(int id_pre_insumo, int id_presupuesto, int id_insumo, int cantidad, decimal precio_unitario)
        {
            this.Id_pre_insumo = id_pre_insumo;
            this.Id_presupuesto = id_presupuesto;
            this.Id_insumo = id_insumo;
            this.Cantidad = cantidad;
            this.Precio_unitario = precio_unitario;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DPresupuesto_Insumo Presupuesto_Insumo)
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
                SqlCmd.CommandText = "spinsertar_presupuesto_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pre_Insumo = new SqlParameter();
                ParId_Pre_Insumo.ParameterName = "@id_pre_insumo";
                ParId_Pre_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Pre_Insumo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Pre_Insumo);

                SqlParameter ParId_Presupuesto = new SqlParameter();
                ParId_Presupuesto.ParameterName = "@id_presupuesto";
                ParId_Presupuesto.SqlDbType = SqlDbType.Int;
                ParId_Presupuesto.Value = Presupuesto_Insumo.Id_presupuesto;
                SqlCmd.Parameters.Add(ParId_Presupuesto);

                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Value = Presupuesto_Insumo.Id_insumo;
                SqlCmd.Parameters.Add(ParId_Insumo);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Presupuesto_Insumo.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParPrecio_Unitario = new SqlParameter();
                ParPrecio_Unitario.ParameterName = "@precio_unitario";
                ParPrecio_Unitario.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Unitario.Value = Presupuesto_Insumo.Precio_unitario;
                SqlCmd.Parameters.Add(ParPrecio_Unitario);


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
        public string Editar(DPresupuesto_Insumo Presupuesto_Insumo)
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
                SqlCmd.CommandText = "speditar_presupuesto_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pre_Insumo = new SqlParameter();
                ParId_Pre_Insumo.ParameterName = "@id_pre_insumo";
                ParId_Pre_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Pre_Insumo.Value = Presupuesto_Insumo.Id_pre_insumo;
                SqlCmd.Parameters.Add(ParId_Pre_Insumo);

                SqlParameter ParId_Presupuesto = new SqlParameter();
                ParId_Presupuesto.ParameterName = "@id_presupuesto";
                ParId_Presupuesto.SqlDbType = SqlDbType.Int;
                ParId_Presupuesto.Value = Presupuesto_Insumo.Id_presupuesto;
                SqlCmd.Parameters.Add(ParId_Presupuesto);

                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Value = Presupuesto_Insumo.Id_insumo;
                SqlCmd.Parameters.Add(ParId_Insumo);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Presupuesto_Insumo.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParPrecio_Unitario = new SqlParameter();
                ParPrecio_Unitario.ParameterName = "@precio_unitario";
                ParPrecio_Unitario.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Unitario.Value = Presupuesto_Insumo.Precio_unitario;
                SqlCmd.Parameters.Add(ParPrecio_Unitario);

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
        public string Eliminar(DPresupuesto_Insumo Presupuesto_Insumo)
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
                SqlCmd.CommandText = "speliminar_presupuesto_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pre_Insumo = new SqlParameter();
                ParId_Pre_Insumo.ParameterName = "@id_pre_insumo";
                ParId_Pre_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Pre_Insumo.Value = Presupuesto_Insumo.Id_pre_insumo;
                SqlCmd.Parameters.Add(ParId_Pre_Insumo);

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
            DataTable DtResultado = new DataTable("presupuesto_insumo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_presupuesto_insumo";

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
