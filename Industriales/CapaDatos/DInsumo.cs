using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DInsumo
    {//inicio de clase
        private int _Id_insumo;
        private int _Codigo_insumo;
        private string _Denominacion;
        private int _Id_unidad_medida;
        private decimal _Precio_referencia;
        private string _Presentacion;
        private int _Id_marca;
        private int _Id_proveedor;
        private string _Textobuscar;
        #region Propiedades
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

        public int Codigo_insumo
        {
            get
            {
                return _Codigo_insumo;
            }

            set
            {
                _Codigo_insumo = value;
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

        public int Id_unidad_medida
        {
            get
            {
                return _Id_unidad_medida;
            }

            set
            {
                _Id_unidad_medida = value;
            }
        }

        public decimal Precio_referencia
        {
            get
            {
                return _Precio_referencia;
            }

            set
            {
                _Precio_referencia = value;
            }
        }

        public string Presentacion
        {
            get
            {
                return _Presentacion;
            }

            set
            {
                _Presentacion = value;
            }
        }

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

        #region Metodos
        public DInsumo()
        {

        }

        public DInsumo(int id_insumo, int codigo_insumo, string denominacion, int id_unidad_medida, decimal precio_referencia, string presentacion, int id_marca, int id_proveedor, string textobuscar)
        {
            this.Id_insumo = id_insumo;
            this.Codigo_insumo = codigo_insumo;
            this.Denominacion = denominacion;
            this.Id_unidad_medida = id_unidad_medida;
            this.Precio_referencia = precio_referencia;
            this.Presentacion = presentacion;
            this.Id_marca = id_marca;
            this.Id_proveedor = id_proveedor;
            this.Textobuscar = textobuscar;
        }
        #endregion Metodos

        #region Metodos        
        //metodo insertar   
        public string Insertar(DInsumo Insumo)
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
                SqlCmd.CommandText = "spinsertar_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Insumo);

                SqlParameter ParCodigo_Insumo = new SqlParameter();
                ParCodigo_Insumo.ParameterName = "@codigo_insumo";
                ParCodigo_Insumo.SqlDbType = SqlDbType.Int;
                ParCodigo_Insumo.Value = Insumo.Codigo_insumo;
                SqlCmd.Parameters.Add(ParCodigo_Insumo);

                SqlParameter ParDenominacion = new SqlParameter();
                ParDenominacion.ParameterName = "@denominacion";
                ParDenominacion.SqlDbType = SqlDbType.VarChar;
                ParDenominacion.Value = Insumo.Denominacion;
                SqlCmd.Parameters.Add(ParDenominacion);

                SqlParameter ParId_Unidad_Medida = new SqlParameter();
                ParId_Unidad_Medida.ParameterName = "@id_unidad_medida";
                ParId_Unidad_Medida.SqlDbType = SqlDbType.Int;
                ParId_Unidad_Medida.Value = Insumo.Id_unidad_medida;
                SqlCmd.Parameters.Add(ParId_Unidad_Medida);

                SqlParameter ParPrecio_Referencia = new SqlParameter();
                ParPrecio_Referencia.ParameterName = "@precio_referencia";
                ParPrecio_Referencia.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Referencia.Value = Insumo.Precio_referencia;
                SqlCmd.Parameters.Add(ParPrecio_Referencia);

                SqlParameter ParPresentacion = new SqlParameter();
                ParPresentacion.ParameterName = "@presentacion";
                ParPresentacion.SqlDbType = SqlDbType.VarChar;
                ParPresentacion.Value = Insumo.Presentacion;
                SqlCmd.Parameters.Add(ParPresentacion);

                SqlParameter ParId_Marca = new SqlParameter();
                ParId_Marca.ParameterName = "@id_marca";
                ParId_Marca.SqlDbType = SqlDbType.Int;
                ParId_Marca.Value = Insumo.Id_marca;
                SqlCmd.Parameters.Add(ParId_Marca);

                SqlParameter ParId_Proveedor = new SqlParameter();
                ParId_Proveedor.ParameterName = "@id_proveedor";
                ParId_Proveedor.SqlDbType = SqlDbType.Int;
                ParId_Proveedor.Value = Insumo.Id_proveedor;
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
        public string Editar(DInsumo Insumo)
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
                SqlCmd.CommandText = "speditar_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Value = Insumo.Id_insumo;
                SqlCmd.Parameters.Add(ParId_Insumo);

                SqlParameter ParCodigo_Insumo = new SqlParameter();
                ParCodigo_Insumo.ParameterName = "@codigo_insumo";
                ParCodigo_Insumo.SqlDbType = SqlDbType.Int;
                ParCodigo_Insumo.Value = Insumo.Codigo_insumo;
                SqlCmd.Parameters.Add(ParCodigo_Insumo);

                SqlParameter ParDenominacion = new SqlParameter();
                ParDenominacion.ParameterName = "@denominacion";
                ParDenominacion.SqlDbType = SqlDbType.VarChar;
                ParDenominacion.Size = 255;
                ParDenominacion.Value = Insumo.Denominacion;
                SqlCmd.Parameters.Add(ParDenominacion);

                SqlParameter ParId_Unidad_Medida = new SqlParameter();
                ParId_Unidad_Medida.ParameterName = "@id_unidad_medida";
                ParId_Unidad_Medida.SqlDbType = SqlDbType.Int;
                ParId_Unidad_Medida.Value = Insumo.Id_unidad_medida;
                SqlCmd.Parameters.Add(ParId_Unidad_Medida);

                SqlParameter ParPrecio_Referencia = new SqlParameter();
                ParPrecio_Referencia.ParameterName = "@precio_referencia";
                ParPrecio_Referencia.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Referencia.Value = Insumo.Precio_referencia;
                SqlCmd.Parameters.Add(ParPrecio_Referencia);

                SqlParameter ParPresentacion = new SqlParameter();
                ParPresentacion.ParameterName = "@presentacion";
                ParPresentacion.SqlDbType = SqlDbType.VarChar;
                ParPresentacion.Size = 255;
                ParPresentacion.Value = Insumo.Presentacion;
                SqlCmd.Parameters.Add(ParPresentacion);

                SqlParameter ParId_Marca = new SqlParameter();
                ParId_Marca.ParameterName = "@id_marca";
                ParId_Marca.SqlDbType = SqlDbType.Int;
                ParId_Marca.Value = Insumo.Id_marca;
                SqlCmd.Parameters.Add(ParId_Marca);

                SqlParameter ParId_Proveedor = new SqlParameter();
                ParId_Proveedor.ParameterName = "@id_proveedor";
                ParId_Proveedor.SqlDbType = SqlDbType.Int;
                ParId_Proveedor.Value = Insumo.Id_proveedor;
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
        public string Eliminar(DInsumo Insumo)
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
                SqlCmd.CommandText = "speliminar_insumo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Insumo = new SqlParameter();
                ParId_Insumo.ParameterName = "@id_insumo";
                ParId_Insumo.SqlDbType = SqlDbType.Int;
                ParId_Insumo.Value = Insumo.Id_insumo;
                SqlCmd.Parameters.Add(ParId_Insumo);

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
            DataTable DtResultado = new DataTable("insumo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_insumo";

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
        public DataTable Buscar(DInsumo Insumo)
        {//inicio buscar
            DataTable DtResultado = new DataTable("insumo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;

                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spbuscar_insumo";

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Insumo.Textobuscar;
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
    }//fin de clase
}
