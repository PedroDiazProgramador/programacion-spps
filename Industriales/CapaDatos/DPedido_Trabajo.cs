using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPedido_Trabajo
    {//inicio de clase
        private int _Id_pedido;
        private int _Id_taller;
        private DateTime _Fecha_pedido;
        private int _Numero_transaccion;
        private string _Numero_nota;
        private string _Numero_contratacion;
        private int _Cumplimentado;
        private string _Comentario;
        #region Propiedades
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

        public DateTime Fecha_pedido
        {
            get
            {
                return _Fecha_pedido;
            }

            set
            {
                _Fecha_pedido = value;
            }
        }

        public int Numero_transaccion
        {
            get
            {
                return _Numero_transaccion;
            }

            set
            {
                _Numero_transaccion = value;
            }
        }

        public string Numero_nota
        {
            get
            {
                return _Numero_nota;
            }

            set
            {
                _Numero_nota = value;
            }
        }

        public string Numero_contratacion
        {
            get
            {
                return _Numero_contratacion;
            }

            set
            {
                _Numero_contratacion = value;
            }
        }

        public int Cumplimentado
        {
            get
            {
                return _Cumplimentado;
            }

            set
            {
                _Cumplimentado = value;
            }
        }

        public string Comentario
        {
            get
            {
                return _Comentario;
            }

            set
            {
                _Comentario = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DPedido_Trabajo()
        {

        }

        public DPedido_Trabajo(int id_pedido, int id_taller, DateTime fecha_pedido, int numero_transaccion, string numero_nota, string numero_contratacion, int cumplimentado, string comentario)
        {
            this.Id_pedido = id_pedido;
            this.Id_taller = id_taller;
            this.Fecha_pedido = fecha_pedido;
            this._Numero_transaccion = numero_transaccion;
            this.Numero_nota = numero_nota;
            this.Numero_contratacion = numero_contratacion;
            this.Cumplimentado = cumplimentado;
            this.Comentario = comentario;
        }
        #endregion Consrtuctores

        #region Metodos
        //metodo insertar   
        public string Insertar(DPedido_Trabajo Pedido_Trabajo)
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
                SqlCmd.CommandText = "spinsertar_pedido_trabajo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Pedido);

                SqlParameter ParId_Taller = new SqlParameter();
                ParId_Taller.ParameterName = "@id_taller";
                ParId_Taller.SqlDbType = SqlDbType.Int;
                ParId_Taller.Value = Pedido_Trabajo.Id_taller;
                SqlCmd.Parameters.Add(ParId_Taller);

                SqlParameter ParFecha_Pedido = new SqlParameter();
                ParFecha_Pedido.ParameterName = "@fecha_pedido";
                ParFecha_Pedido.SqlDbType = SqlDbType.DateTime;
                ParFecha_Pedido.Value = Pedido_Trabajo.Fecha_pedido;
                SqlCmd.Parameters.Add(ParFecha_Pedido);

                SqlParameter ParNumero_Transaccion = new SqlParameter();
                ParNumero_Transaccion.ParameterName = "@numero_transaccion";
                ParNumero_Transaccion.SqlDbType = SqlDbType.Int;
                ParNumero_Transaccion.Value = Pedido_Trabajo.Numero_transaccion;
                SqlCmd.Parameters.Add(ParNumero_Transaccion);

                SqlParameter ParNumero_Nota = new SqlParameter();
                ParNumero_Nota.ParameterName = "@numero_nota";
                ParNumero_Nota.SqlDbType = SqlDbType.VarChar;
                ParNumero_Nota.Size = 50;
                ParNumero_Nota.Value = Pedido_Trabajo.Numero_nota;
                SqlCmd.Parameters.Add(ParNumero_Nota);

                SqlParameter ParNumero_Contratacion = new SqlParameter();
                ParNumero_Contratacion.ParameterName = "@numero_contratacion";
                ParNumero_Contratacion.SqlDbType = SqlDbType.VarChar;
                ParNumero_Contratacion.Size = 50;
                ParNumero_Contratacion.Value = Pedido_Trabajo.Numero_contratacion;
                SqlCmd.Parameters.Add(ParNumero_Contratacion);

                SqlParameter ParCumplimetado = new SqlParameter();
                ParCumplimetado.ParameterName = "@cumplimentado";
                ParCumplimetado.SqlDbType = SqlDbType.Int;
                ParCumplimetado.Value = Pedido_Trabajo.Cumplimentado;
                SqlCmd.Parameters.Add(ParCumplimetado);

                SqlParameter ParComentario = new SqlParameter();
                ParComentario.ParameterName = "@comentario";
                ParComentario.SqlDbType = SqlDbType.VarChar;
                ParComentario.Size = 1000;
                ParComentario.Value = Pedido_Trabajo.Comentario;
                SqlCmd.Parameters.Add(ParComentario);


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
        public string Editar(DPedido_Trabajo Pedido_Trabajo)
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
                SqlCmd.CommandText = "speditar_pedido_trabajo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.Value = Pedido_Trabajo.Id_pedido;
                ParId_Pedido.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Pedido);

                SqlParameter ParId_Taller = new SqlParameter();
                ParId_Taller.ParameterName = "@id_taller";
                ParId_Taller.SqlDbType = SqlDbType.Int;
                ParId_Taller.Value = Pedido_Trabajo.Id_taller;
                SqlCmd.Parameters.Add(ParId_Taller);

                SqlParameter ParFecha_Pedido = new SqlParameter();
                ParFecha_Pedido.ParameterName = "@fecha_pedido";
                ParFecha_Pedido.SqlDbType = SqlDbType.DateTime;
                ParFecha_Pedido.Value = Pedido_Trabajo.Fecha_pedido;
                SqlCmd.Parameters.Add(ParFecha_Pedido);

                SqlParameter ParNumero_Transaccion = new SqlParameter();
                ParNumero_Transaccion.ParameterName = "@numero_transaccion";
                ParNumero_Transaccion.SqlDbType = SqlDbType.Int;
                ParNumero_Transaccion.Value = Pedido_Trabajo.Numero_transaccion;
                SqlCmd.Parameters.Add(ParNumero_Transaccion);

                SqlParameter ParNumero_Nota = new SqlParameter();
                ParNumero_Nota.ParameterName = "@numero_nota";
                ParNumero_Nota.SqlDbType = SqlDbType.VarChar;
                ParNumero_Nota.Size = 50;
                ParNumero_Nota.Value = Pedido_Trabajo.Numero_nota;
                SqlCmd.Parameters.Add(ParNumero_Nota);

                SqlParameter ParNumero_Contratacion = new SqlParameter();
                ParNumero_Contratacion.ParameterName = "@numero_contratacion";
                ParNumero_Contratacion.SqlDbType = SqlDbType.VarChar;
                ParNumero_Contratacion.Size = 50;
                ParNumero_Contratacion.Value = Pedido_Trabajo.Numero_contratacion;
                SqlCmd.Parameters.Add(ParNumero_Contratacion);

                SqlParameter ParCumplimetado = new SqlParameter();
                ParCumplimetado.ParameterName = "@cumplimentado";
                ParCumplimetado.SqlDbType = SqlDbType.Int;
                ParCumplimetado.Value = Pedido_Trabajo.Cumplimentado;
                SqlCmd.Parameters.Add(ParCumplimetado);

                SqlParameter ParComentario = new SqlParameter();
                ParComentario.ParameterName = "@comentario";
                ParComentario.SqlDbType = SqlDbType.VarChar;
                ParComentario.Size = 1000;
                ParComentario.Value = Pedido_Trabajo.Comentario;
                SqlCmd.Parameters.Add(ParComentario);


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
        public string Eliminar(DPedido_Trabajo Pedido_Trabajo)
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
                SqlCmd.CommandText = "speliminar_pedido_trabajo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@id_pedido";
                ParId_Pedido.Value = Pedido_Trabajo.Id_pedido;
                ParId_Pedido.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Pedido);
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
            DataTable DtResultado = new DataTable("pedido_trabajo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_pedido_trabajo";

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
