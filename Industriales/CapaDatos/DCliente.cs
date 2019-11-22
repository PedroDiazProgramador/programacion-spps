using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCliente
    {//inicio de clase
        private int _Id_cliente;
        private int _Dni;
        private int _Legajo;
        private string _Apellido;
        private string _Nombre;
        private string _Telefono;
        private string _Direccion;
        private string _Email;
        private int _Habilitado;
        private DateTime _Fecha_nac;
        private int _Localidad;
        private decimal _Monto_alcance;
        private int _Cuenta_bancaria;
        private byte[] _Foto;
        private int _Id_tipo_cliente;
        private int _Id_sexo;
        private string _Textobuscar;
        private DateTime _Fecha_compra;
        private int _Cupo_compra;

        #region Propiedades
        public int Id_cliente
        {
            get
            {
                return _Id_cliente;
            }

            set
            {
                _Id_cliente = value;
            }
        }

        public int Dni
        {
            get
            {
                return _Dni;
            }

            set
            {
                _Dni = value;
            }
        }

        public int Legajo
        {
            get
            {
                return _Legajo;
            }

            set
            {
                _Legajo = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _Apellido;
            }

            set
            {
                _Apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

       public int Habilitado
        {
            get
            {
                return _Habilitado;
            }

            set
            {
                _Habilitado = value;
            }
        }

        public DateTime Fecha_nac
        {
            get
            {
                return _Fecha_nac;
            }

            set
            {
                _Fecha_nac = value;
            }
        }

        public int Localidad
        {
            get
            {
                return _Localidad;
            }

            set
            {
                _Localidad = value;
            }
        }

        public decimal Monto_alcance
        {
            get
            {
                return _Monto_alcance;
            }

            set
            {
                _Monto_alcance = value;
            }
        }

        public int Cuenta_bancaria
        {
            get
            {
                return _Cuenta_bancaria;
            }

            set
            {
                _Cuenta_bancaria = value;
            }
        }

        public byte[] Foto
        {
            get
            {
                return _Foto;
            }

            set
            {
                _Foto = value;
            }
        }

        public int Id_tipo_cliente
        {
            get
            {
                return _Id_tipo_cliente;
            }

            set
            {
                _Id_tipo_cliente = value;
            }
        }

        public int Id_sexo
        {
            get
            {
                return _Id_sexo;
            }

            set
            {
                _Id_sexo = value;
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

        public DateTime Fecha_compra
        {
            get
            {
                return _Fecha_compra;
            }

            set
            {
                _Fecha_compra = value;
            }
        }

        public int Cupo_compra
        {
            get
            {
                return _Cupo_compra;
            }

            set
            {
                _Cupo_compra = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public DCliente()
        {

        }

        public DCliente(int id_cliente, int dni, int legajo, string apellido, string nombre, string telefono, string direccion, string email, int habilitado, DateTime fecha_nac, int localidad, decimal monto_alcance, int cuenta_bancaria, byte[] foto, int id_tipo_cliente, int id_sexo, string textobuscar, DateTime fecha_compra, int cupo_compra)
        {
            this.Id_cliente = id_cliente;
            this.Dni = dni;
            this.Legajo = legajo;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Email = email;
            this.Habilitado = habilitado;
            this.Fecha_nac = fecha_nac;
            this.Localidad = localidad;
            this.Monto_alcance = monto_alcance;
            this.Cuenta_bancaria = cuenta_bancaria;
            this.Foto = foto;
            this.Id_tipo_cliente = id_tipo_cliente;
            this.Id_sexo = id_sexo;
            this.Textobuscar = textobuscar;
            this.Fecha_compra = fecha_compra;
            this.Cupo_compra = cupo_compra; 
        }

        #endregion Constructores

        #region Metodos        
        //metodo insertar   
        public string Insertar(DCliente Cliente)
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
                SqlCmd.CommandText = "spinsertar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Cliente = new SqlParameter();
                ParId_Cliente.ParameterName = "@id_cliente";
                ParId_Cliente.SqlDbType = SqlDbType.Int;
                ParId_Cliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Cliente);

                SqlParameter ParDni = new SqlParameter();
                ParDni.ParameterName = "@dni";
                ParDni.SqlDbType = SqlDbType.Int;
                ParDni.Value = Cliente.Dni;
                SqlCmd.Parameters.Add(ParDni);

                SqlParameter ParLegajo = new SqlParameter();
                ParLegajo.ParameterName = "@legajo";
                ParLegajo.SqlDbType = SqlDbType.Int;
                ParLegajo.Value = Cliente.Legajo;
                SqlCmd.Parameters.Add(ParLegajo);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = (50);
                ParApellido.Value = Cliente.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = (50);
                ParNombre.Value = Cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = (50);
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = (100);
                ParDireccion.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = (50);
                ParEmail.Value = Cliente.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParHabilitado = new SqlParameter();
                ParHabilitado.ParameterName = "@habilitado";
                ParHabilitado.SqlDbType = SqlDbType.Int;
                ParHabilitado.Value = Cliente.Habilitado;
                SqlCmd.Parameters.Add(ParHabilitado);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@fecha_nac";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.VarChar;
                ParFecha_Nacimiento.Size = 50;
                ParFecha_Nacimiento.Value = Cliente.Fecha_nac;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParLocalidad = new SqlParameter();
                ParLocalidad.ParameterName = "@localidad";
                ParLocalidad.SqlDbType = SqlDbType.Int;
                ParLocalidad.Value = Cliente.Localidad;
                SqlCmd.Parameters.Add(ParLocalidad);

                SqlParameter ParMonto_Alcance = new SqlParameter();
                ParMonto_Alcance.ParameterName = "@monto_alcance";
                ParMonto_Alcance.SqlDbType = SqlDbType.Decimal;
                ParMonto_Alcance.Value = Cliente.Monto_alcance;
                SqlCmd.Parameters.Add(ParMonto_Alcance);

                SqlParameter ParCuenta_Bancaria = new SqlParameter();
                ParCuenta_Bancaria.ParameterName = "@cuenta_bancaria";
                ParCuenta_Bancaria.SqlDbType = SqlDbType.Int;
                ParCuenta_Bancaria.Value = Cliente.Cuenta_bancaria;
                SqlCmd.Parameters.Add(ParCuenta_Bancaria);

                //SqlParameter ParFoto = new SqlParameter();
                //ParFoto.ParameterName = "@foto";
                //ParFoto.SqlDbType = SqlDbType.Image;
                //ParFoto.Value = Cliente.Foto;
                //SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParId_Tipo_Cliente = new SqlParameter();
                ParId_Tipo_Cliente.ParameterName = "@id_tipo_cliente";
                ParId_Tipo_Cliente.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Cliente.Value = Cliente.Id_tipo_cliente;
                SqlCmd.Parameters.Add(ParId_Tipo_Cliente);

                SqlParameter ParId_Sexo = new SqlParameter();
                ParId_Sexo.ParameterName = "@id_sexo";
                ParId_Sexo.SqlDbType = SqlDbType.Int;
                ParId_Sexo.Value = Cliente.Id_sexo;
                SqlCmd.Parameters.Add(ParId_Sexo);

                SqlParameter ParFecha_Compra = new SqlParameter();
                ParFecha_Compra.ParameterName = "@fecha_compra";
                ParFecha_Compra.SqlDbType = SqlDbType.VarChar;
                ParFecha_Compra.Size = 50;
                ParFecha_Compra.Value = Cliente.Fecha_nac;
                SqlCmd.Parameters.Add(ParFecha_Compra);

                SqlParameter ParCupo_Compra = new SqlParameter();
                ParCupo_Compra.ParameterName = "@cupo_compra";
                ParCupo_Compra.SqlDbType = SqlDbType.Int;
                ParCupo_Compra.Value = Cliente.Cupo_compra;
                SqlCmd.Parameters.Add(ParCupo_Compra);

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
        public string Editar(DCliente Cliente)
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
                SqlCmd.CommandText = "speditar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Cliente = new SqlParameter();
                ParId_Cliente.ParameterName = "@id_cliente";
                ParId_Cliente.SqlDbType = SqlDbType.Int;
                ParId_Cliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_Cliente);

                SqlParameter ParDni = new SqlParameter();
                ParDni.ParameterName = "@dni";
                ParDni.SqlDbType = SqlDbType.Int;
                ParDni.Value = Cliente.Dni;
                SqlCmd.Parameters.Add(ParDni);

                SqlParameter ParLegajo = new SqlParameter();
                ParLegajo.ParameterName = "@legajo";
                ParLegajo.SqlDbType = SqlDbType.Int;
                ParLegajo.Value = Cliente.Legajo;
                SqlCmd.Parameters.Add(ParLegajo);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = (50);
                ParApellido.Value = Cliente.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = (50);
                ParNombre.Value = Cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = (50);
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direcion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = (100);
                ParDireccion.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = (50);
                ParEmail.Value = Cliente.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParHabilitado = new SqlParameter();
                ParHabilitado.ParameterName = "@habilitado";
                ParHabilitado.SqlDbType = SqlDbType.Int;
                ParHabilitado.Value = Cliente.Habilitado;
                SqlCmd.Parameters.Add(ParHabilitado);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@fecha_nac";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_Nacimiento.Value = Cliente.Fecha_nac;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParLocalidad = new SqlParameter();
                ParLocalidad.ParameterName = "@localidad";
                ParLocalidad.SqlDbType = SqlDbType.Int;
                ParLocalidad.Value = Cliente.Localidad;
                SqlCmd.Parameters.Add(ParLocalidad);

                SqlParameter ParMonto_Alcance = new SqlParameter();
                ParMonto_Alcance.ParameterName = "@monto_alcance";
                ParMonto_Alcance.SqlDbType = SqlDbType.Decimal;
                ParMonto_Alcance.Value = Cliente.Monto_alcance;
                SqlCmd.Parameters.Add(ParMonto_Alcance);

                SqlParameter ParCuenta_Bancaria = new SqlParameter();
                ParCuenta_Bancaria.ParameterName = "@cuenta_bancaria";
                ParCuenta_Bancaria.SqlDbType = SqlDbType.Int;
                ParCuenta_Bancaria.Value = Cliente.Cuenta_bancaria;
                SqlCmd.Parameters.Add(ParCuenta_Bancaria);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Cliente.Foto;
                SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParId_Tipo_Cliente = new SqlParameter();
                ParId_Tipo_Cliente.ParameterName = "@id_tipo_cliente";
                ParId_Tipo_Cliente.SqlDbType = SqlDbType.Int;
                ParId_Tipo_Cliente.Value = Cliente.Id_tipo_cliente;
                SqlCmd.Parameters.Add(ParId_Tipo_Cliente);

                SqlParameter ParId_Sexo = new SqlParameter();
                ParId_Sexo.ParameterName = "@id_sexo";
                ParId_Sexo.SqlDbType = SqlDbType.Int;
                ParId_Sexo.Value = Cliente.Id_sexo;
                SqlCmd.Parameters.Add(ParId_Sexo);

                SqlParameter ParFecha_Compra = new SqlParameter();
                ParFecha_Compra.ParameterName = "@fecha_compra";
                ParFecha_Compra.SqlDbType = SqlDbType.DateTime;
                ParFecha_Compra.Value = Cliente.Fecha_nac;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParCupo_Compra = new SqlParameter();
                ParCupo_Compra.ParameterName = "@cupo_compra";
                ParCupo_Compra.SqlDbType = SqlDbType.Int;
                ParCupo_Compra.Value = Cliente.Id_sexo;
                SqlCmd.Parameters.Add(ParId_Sexo);



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
        public string Eliminar(DCliente Cliente)
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
                SqlCmd.CommandText = "speliminar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId_Cliente = new SqlParameter();
                ParId_Cliente.ParameterName = "@id_cliente";
                ParId_Cliente.SqlDbType = SqlDbType.Int;
                ParId_Cliente.Value = Cliente.Id_cliente;
                SqlCmd.Parameters.Add(ParId_Cliente);

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
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_cliente";

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
        public DataTable Buscar(DCliente Cliente)
        {//inicio buscar x clave
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;

                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spbuscar_cliente";

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.Textobuscar;
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

        //metodo buscar por dni
        public DataTable BuscarDni(DCliente Cliente)
        {//inicio buscar x clave
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;

                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spbuscar_dni_cliente";

                SqlParameter ParDni = new SqlParameter();
                ParDni.ParameterName = "@dni";
                ParDni.SqlDbType = SqlDbType.Int;
                ParDni.Value = Cliente.Dni;
                SqlCmd.Parameters.Add(ParDni);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);



            }
            catch (Exception)
            {

                return null;
            }
            return DtResultado;
        }//fin metodo buscar por dni
        #endregion Metodos

    }//fin clase
}
