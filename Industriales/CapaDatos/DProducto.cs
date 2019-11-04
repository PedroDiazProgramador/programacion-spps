using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DProducto
    {//inicio capa
        private int _Id_producto;
        private int _Codigo_barra;
        private string _Descripcion;
        private decimal _Precio_kilo;
        private decimal _Precio_unidad;
        private int _Stock;
        private int _Stock_minimo;
        private DateTime _Vencimiento;
        private int _Id_taller;
        private int _Id_materia_prima;
        private string _Textobuscar;
        #region Propiedades
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

        public int Codigo_barra
        {
            get
            {
                return _Codigo_barra;
            }

            set
            {
                _Codigo_barra = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public int Stock
        {
            get
            {
                return _Stock;
            }

            set
            {
                _Stock = value;
            }
        }

        public int Stock_minimo
        {
            get
            {
                return _Stock_minimo;
            }

            set
            {
                _Stock_minimo = value;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return _Vencimiento;
            }

            set
            {
                _Vencimiento = value;
            }
        }

        public int Id_taller
        {
            get
            {
                return _Id_taller;
            }

            set
            {
                _Id_taller = value;
            }
        }

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

        public decimal Precio_kilo
        {
            get
            {
                return _Precio_kilo;
            }

            set
            {
                _Precio_kilo = value;
            }
        }

        public decimal Precio_unidad
        {
            get
            {
                return _Precio_unidad;
            }

            set
            {
                _Precio_unidad = value;
            }
        }
        #endregion Propiedades

        #region Metodos
        public DProducto()
        {

        }

        public DProducto(int id_producto, int codigo_barra, string descripcion, decimal precio_kilo, decimal precio_unidad, int stock, int stock_minimo, DateTime vencimiento, int id_taller, int id_materia_prima, string textobuscar)
        {
            this.Id_producto = id_producto;
            this.Codigo_barra = codigo_barra;
            this.Descripcion = descripcion;
            this.Precio_kilo = precio_kilo;
            this.Precio_unidad = precio_unidad;
            this.Stock = stock;
            this.Stock_minimo = stock_minimo;
            this.Vencimiento = vencimiento;
            this.Id_taller = id_taller;
            this.Id_materia_prima = id_materia_prima;
            this.Textobuscar = textobuscar;
        }
        #endregion Metodos

        #region Metodos        
        //metodo insertar   
        public string Insertar(DProducto Producto)
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
                SqlCmd.CommandText = "spinsertar_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@id_producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Producto);

                SqlParameter ParCodigo_Barra = new SqlParameter();
                ParCodigo_Barra.ParameterName = "@codigo_barra";
                ParCodigo_Barra.SqlDbType = SqlDbType.Int;
                ParCodigo_Barra.Value = Producto.Codigo_barra;
                SqlCmd.Parameters.Add(ParCodigo_Barra);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = (255);
                ParDescripcion.Value = Producto.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParPrecio_Kilo = new SqlParameter();
                ParPrecio_Kilo.ParameterName = "@precio_kilo";
                ParPrecio_Kilo.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Kilo.Value = Producto.Precio_kilo;
                SqlCmd.Parameters.Add(ParPrecio_Kilo);

                SqlParameter ParPrecio_Unidad = new SqlParameter();
                ParPrecio_Unidad.ParameterName = "@precio_unidad";
                ParPrecio_Unidad.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Unidad.Value = Producto.Precio_unidad;
                SqlCmd.Parameters.Add(ParPrecio_Unidad);

                SqlParameter ParStock = new SqlParameter();
                ParStock.ParameterName = "@stock";
                ParStock.SqlDbType = SqlDbType.Int;
                ParStock.Value = Producto.Stock;
                SqlCmd.Parameters.Add(ParStock);

                SqlParameter ParStock_Minimo = new SqlParameter();
                ParStock_Minimo.ParameterName = "@stock_minimo";
                ParStock_Minimo.SqlDbType = SqlDbType.Int;
                ParStock_Minimo.Value = Producto.Stock_minimo;
                SqlCmd.Parameters.Add(ParStock_Minimo);

                SqlParameter ParVencimiento = new SqlParameter();
                ParVencimiento.ParameterName = "@vencimiento";
                ParVencimiento.SqlDbType = SqlDbType.VarChar;
                ParVencimiento.Size = 50;
                ParVencimiento.Value = Producto.Vencimiento;
                SqlCmd.Parameters.Add(ParVencimiento);

                SqlParameter ParId_Taller = new SqlParameter();
                ParId_Taller.ParameterName = "@id_taller";
                ParId_Taller.SqlDbType = SqlDbType.Int;
                ParId_Taller.Value = Producto.Id_taller;
                SqlCmd.Parameters.Add(ParId_Taller);

                SqlParameter ParId_Materia_Prima = new SqlParameter();
                ParId_Materia_Prima.ParameterName = "@id_materia_prima";
                ParId_Materia_Prima.SqlDbType = SqlDbType.Int;
                ParId_Materia_Prima.Value = Producto.Id_materia_prima;
                SqlCmd.Parameters.Add(ParId_Materia_Prima);

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
        public string Editar(DProducto Producto)
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
                SqlCmd.CommandText = "speditar_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@id_producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Value = Producto.Id_producto;
                SqlCmd.Parameters.Add(ParId_Producto);

                SqlParameter ParCodigo_Barra = new SqlParameter();
                ParCodigo_Barra.ParameterName = "@codigo_barra";
                ParCodigo_Barra.SqlDbType = SqlDbType.Int;
                ParCodigo_Barra.Value = Producto.Codigo_barra;
                SqlCmd.Parameters.Add(ParCodigo_Barra);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = (255);
                ParDescripcion.Value = Producto.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParPrecio_Kilo = new SqlParameter();
                ParPrecio_Kilo.ParameterName = "@precio_kilo";
                ParPrecio_Kilo.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Kilo.Value = Producto.Precio_kilo;
                SqlCmd.Parameters.Add(ParPrecio_Kilo);

                SqlParameter ParPrecio_Unidad = new SqlParameter();
                ParPrecio_Unidad.ParameterName = "@precio_unidad";
                ParPrecio_Unidad.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Unidad.Value = Producto.Precio_unidad;
                SqlCmd.Parameters.Add(ParPrecio_Unidad);

                SqlParameter ParStock = new SqlParameter();
                ParStock.ParameterName = "@stock";
                ParStock.SqlDbType = SqlDbType.Int;
                ParStock.Value = Producto.Stock;
                SqlCmd.Parameters.Add(ParStock);

                SqlParameter ParStock_Minimo = new SqlParameter();
                ParStock_Minimo.ParameterName = "@stock_minimo";
                ParStock_Minimo.SqlDbType = SqlDbType.Int;
                ParStock_Minimo.Value = Producto.Stock_minimo;
                SqlCmd.Parameters.Add(ParStock_Minimo);

                SqlParameter ParVencimiento = new SqlParameter();
                ParVencimiento.ParameterName = "@vencimiento";
                ParVencimiento.SqlDbType = SqlDbType.DateTime;
                ParVencimiento.Value = Producto.Vencimiento;
                SqlCmd.Parameters.Add(ParVencimiento);

                SqlParameter ParId_Taller = new SqlParameter();
                ParId_Taller.ParameterName = "@id_taller";
                ParId_Taller.SqlDbType = SqlDbType.Int;
                ParId_Taller.Value = Producto.Id_taller;
                SqlCmd.Parameters.Add(ParId_Taller);

                SqlParameter ParId_Materia_Prima = new SqlParameter();
                ParId_Materia_Prima.ParameterName = "@id_materia_prima";
                ParId_Materia_Prima.SqlDbType = SqlDbType.Int;
                ParId_Materia_Prima.Value = Producto.Id_materia_prima;
                SqlCmd.Parameters.Add(ParId_Materia_Prima);

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
        public string Eliminar(DProducto Producto)
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
                SqlCmd.CommandText = "speliminar_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@id_producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Value = Producto.Id_producto;
                SqlCmd.Parameters.Add(ParId_Producto);

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
            DataTable DtResultado = new DataTable("producto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_producto";

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
        public DataTable Buscar(DProducto Producto)
        {//inicio buscar
            DataTable DtResultado = new DataTable("producto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;

                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spbuscar_producto";

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 255;
                ParTextoBuscar.Value = Producto.Textobuscar;
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
    }//fin capa
}
