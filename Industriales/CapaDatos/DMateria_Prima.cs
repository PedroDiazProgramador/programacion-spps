using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DMateria_Prima
    {//inicio de clase
        private int _Id_materia_prima;
        private int _Id_insumo;
        private decimal _Cantidad_utilizada;
        private int _Id_producto;
        #region Propiedades
        public int Id_materia_prima
        {
            get
            {
                return _Id_materia_prima;
            }

            set
            {
                _Id_materia_prima = value;
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

        public decimal Cantidad_utilizada
        {
            get
            {
                return _Cantidad_utilizada;
            }

            set
            {
                _Cantidad_utilizada = value;
            }
        }

        public int Id_producto
        {
            get
            {
                return _Id_producto;
            }

            set
            {
                _Id_producto = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DMateria_Prima()
        {

        }

        public DMateria_Prima(int id_materia_prima, int id_insumo, decimal cantidad_utilizada, int id_producto)
        {
            this.Id_materia_prima = id_materia_prima;
            this.Id_insumo = id_insumo;
            this.Cantidad_utilizada = cantidad_utilizada;
            this.Id_producto = id_producto;
        }
        #endregion Constructores

        #region Metodos
        //metodo insertar   
        public string Insertar(DMateria_Prima Materia_Prima)
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
                SqlCmd.CommandText = "spinsertar_materia_prima";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Materia_Prima = new SqlParameter();
                ParId_Materia_Prima.ParameterName = "@id_materia_prima";
                ParId_Materia_Prima.SqlDbType = SqlDbType.Int;
                ParId_Materia_Prima.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Materia_Prima);

                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Value = Materia_Prima.Id_insumo;
                SqlCmd.Parameters.Add(ParId_Insumo);

                SqlParameter ParCantidad_Utilizada = new SqlParameter();
                ParCantidad_Utilizada.ParameterName = "@cantidad_utilizada";
                ParCantidad_Utilizada.SqlDbType = SqlDbType.Decimal;
                ParCantidad_Utilizada.Value = Materia_Prima.Cantidad_utilizada;
                SqlCmd.Parameters.Add(ParCantidad_Utilizada);

                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@id_producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Value = Materia_Prima.Id_producto;
                SqlCmd.Parameters.Add(ParId_Producto);


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
        public string Editar(DMateria_Prima Materia_Prima)
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
                SqlCmd.CommandText = "speditar_materia_prima";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Materia_Prima = new SqlParameter();
                ParId_Materia_Prima.ParameterName = "@id_materia_prima";
                ParId_Materia_Prima.SqlDbType = SqlDbType.Int;
                ParId_Materia_Prima.Value = Materia_Prima.Id_materia_prima;
                SqlCmd.Parameters.Add(ParId_Materia_Prima);

                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Value = Materia_Prima.Id_insumo;
                SqlCmd.Parameters.Add(ParId_Insumo);

                SqlParameter ParCantidad_Utilizada = new SqlParameter();
                ParCantidad_Utilizada.ParameterName = "@cantidad_utilizada";
                ParCantidad_Utilizada.SqlDbType = SqlDbType.Decimal;
                ParCantidad_Utilizada.Value = Materia_Prima.Cantidad_utilizada;
                SqlCmd.Parameters.Add(ParCantidad_Utilizada);

                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@id_producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Value = Materia_Prima.Id_producto;
                SqlCmd.Parameters.Add(ParId_Producto);

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
        public string Eliminar(DMateria_Prima Materia_Prima)
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
                SqlCmd.CommandText = "speliminar_materia_prima";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Materia_Prima = new SqlParameter();
                ParId_Materia_Prima.ParameterName = "@id_materia_prima";
                ParId_Materia_Prima.SqlDbType = SqlDbType.Int;
                ParId_Materia_Prima.Value = Materia_Prima.Id_materia_prima;
                SqlCmd.Parameters.Add(ParId_Materia_Prima);

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
            DataTable DtResultado = new DataTable("materia_prima");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_materia_prima";

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
