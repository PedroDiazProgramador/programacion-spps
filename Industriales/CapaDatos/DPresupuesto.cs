using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPresupuesto
    {//inicio de clase
        private int _Id_presupuesto;
        private DateTime _Fecha_emision;
        private int _Id_insumo;
        private decimal _Precio_total;
        private int _Id_proveedor;
        #region Propiedades
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

        public DateTime Fecha_emision
        {
            get
            {
                return _Fecha_emision;
            }

            set
            {
                _Fecha_emision = value;
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

        public decimal Precio_total
        {
            get
            {
                return _Precio_total;
            }

            set
            {
                _Precio_total = value;
            }
        }

        public int Id_proveedor
        {
            get
            {
                return _Id_proveedor;
            }

            set
            {
                _Id_proveedor = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DPresupuesto()
        {

        }

        public DPresupuesto(int id_presupuesto, DateTime fecha_emision, int id_insumo, decimal presio_total, int id_proveedor)
        {
            this.Id_presupuesto = id_presupuesto;
            this.Fecha_emision = fecha_emision;
            this.Id_insumo = id_insumo;
            this.Precio_total = presio_total;
            this.Id_proveedor = id_proveedor;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DPresupuesto Presupuesto)
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
                SqlCmd.CommandText = "spinsertar_presupuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Presupuesto = new SqlParameter();
                ParId_Presupuesto.ParameterName = "@id_presupuesto";
                ParId_Presupuesto.SqlDbType = SqlDbType.Int;
                ParId_Presupuesto.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Presupuesto);

                SqlParameter ParFecha_Emision = new SqlParameter();
                ParFecha_Emision.ParameterName = "@fecha_emision";
                ParFecha_Emision.SqlDbType = SqlDbType.DateTime;
                ParFecha_Emision.Value = Presupuesto.Fecha_emision;
                SqlCmd.Parameters.Add(ParFecha_Emision);

                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Value = Presupuesto.Id_insumo;
                SqlCmd.Parameters.Add(ParId_Insumo);

                SqlParameter ParPrecio_Total = new SqlParameter();
                ParPrecio_Total.ParameterName = "@precio_total";
                ParPrecio_Total.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Total.Value = Presupuesto.Precio_total;
                SqlCmd.Parameters.Add(ParPrecio_Total);

                SqlParameter ParId_Proveedor = new SqlParameter();
                ParId_Proveedor.ParameterName = "@id_proveedor";
                ParId_Proveedor.SqlDbType = SqlDbType.Int;
                ParId_Proveedor.Value = Presupuesto.Id_proveedor;
                SqlCmd.Parameters.Add(ParId_Proveedor);


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
        public string Editar(DPresupuesto Presupuesto)
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
                SqlCmd.CommandText = "speditar_presupuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Presupuesto = new SqlParameter();
                ParId_Presupuesto.ParameterName = "@id_presupuesto";
                ParId_Presupuesto.SqlDbType = SqlDbType.Int;
                ParId_Presupuesto.Value = Presupuesto.Id_proveedor;
                SqlCmd.Parameters.Add(ParId_Presupuesto);

                SqlParameter ParFecha_Emision = new SqlParameter();
                ParFecha_Emision.ParameterName = "@fecha_emision";
                ParFecha_Emision.SqlDbType = SqlDbType.DateTime;
                ParFecha_Emision.Value = Presupuesto.Fecha_emision;
                SqlCmd.Parameters.Add(ParFecha_Emision);

                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Value = Presupuesto.Id_insumo;
                SqlCmd.Parameters.Add(ParId_Insumo);

                SqlParameter ParPrecio_Total = new SqlParameter();
                ParPrecio_Total.ParameterName = "@precio_total";
                ParPrecio_Total.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Total.Value = Presupuesto.Precio_total;
                SqlCmd.Parameters.Add(ParPrecio_Total);

                SqlParameter ParId_Proveedor = new SqlParameter();
                ParId_Proveedor.ParameterName = "@id_proveedor";
                ParId_Proveedor.SqlDbType = SqlDbType.Int;
                ParId_Proveedor.Value = Presupuesto.Id_proveedor;
                SqlCmd.Parameters.Add(ParId_Proveedor);

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
        public string Eliminar(DPresupuesto Presupuesto)
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
                SqlCmd.CommandText = "speliminar_presupuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Presupuesto = new SqlParameter();
                ParId_Presupuesto.ParameterName = "@id_presupuesto";
                ParId_Presupuesto.SqlDbType = SqlDbType.Int;
                ParId_Presupuesto.Value = Presupuesto.Id_proveedor;
                SqlCmd.Parameters.Add(ParId_Presupuesto);

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
            DataTable DtResultado = new DataTable("presupuesto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_presupuesto";

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
