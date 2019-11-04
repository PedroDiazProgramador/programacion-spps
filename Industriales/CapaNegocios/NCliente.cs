using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NCliente
    {//inicio de clase
        
        //metodo insertar que llama al metodo Insertar de la clase DCliente
        public static string Insertar(int id_cliente, int dni, int legajo, string apellido, string nombre, string telefono, string direccion, string email, int habilitado, string fecha_nac, int localidad, decimal monto_alcance, int cuenta_bancaria, byte[] foto, int id_tipo_cliente, int id_sexo, string fecha_compra, int cupo_compra)
        {
            DCliente Obj = new DCliente();
            Obj.Id_cliente = id_cliente;
            Obj.Dni = dni;
            Obj.Legajo = legajo;
            Obj.Apellido = apellido;
            Obj.Nombre = nombre;
            Obj.Telefono = telefono;
            Obj.Direccion = direccion;
            Obj.Email = email;
            Obj.Habilitado = habilitado;
            if (fecha_nac != string.Empty)
            {
                try
                {
                    Obj.Fecha_nac = Convert.ToDateTime(fecha_nac);
                }
                catch (Exception)
                {

                    Obj.Fecha_nac = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_nac = System.DateTime.Parse("1900-01-01");
            }
            Obj.Localidad = localidad;
            Obj.Monto_alcance = monto_alcance;
            Obj.Cuenta_bancaria = cuenta_bancaria;
            Obj.Foto = foto;
            Obj.Id_tipo_cliente = id_tipo_cliente;
            Obj.Id_sexo = id_sexo;
            if (fecha_compra != string.Empty)
            {
                try
                {
                    Obj.Fecha_compra = Convert.ToDateTime(fecha_compra);
                }
                catch (Exception)
                {

                    Obj.Fecha_compra = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_compra = System.DateTime.Parse("1900-01-01");
            }
            Obj.Cupo_compra = cupo_compra;
            return Obj.Insertar(Obj);
           }

        //metodo editar que llama al metodo Editar de la clase DCliente
        public static string Editar(int id_cliente, int dni, int legajo, string apellido, string nombre, string telefono, string direccion, string email, int habilitado, string fecha_nac, int localidad, decimal monto_alcance, int cuenta_bancaria, byte[] foto, int id_tipo_cliente, int id_sexo, string fecha_compra, int cupo_compra)
        {
            DCliente Obj = new DCliente();
            Obj.Id_cliente = id_cliente;
            Obj.Dni = dni;
            Obj.Legajo = legajo;
            Obj.Apellido = apellido;
            Obj.Nombre = nombre;
            Obj.Telefono = telefono;
            Obj.Direccion = direccion;
            Obj.Email = email;       
            Obj.Habilitado = habilitado;
            if (fecha_nac != string.Empty)
            {
                try
                {
                    Obj.Fecha_nac = Convert.ToDateTime(fecha_nac);
                }
                catch (Exception)
                {

                    Obj.Fecha_nac = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_nac = System.DateTime.Parse("1900-01-01");
            }
            Obj.Localidad = localidad;
            Obj.Monto_alcance = monto_alcance;
            Obj.Cuenta_bancaria = cuenta_bancaria;
            Obj.Foto = foto;
            Obj.Id_tipo_cliente = id_tipo_cliente;
            Obj.Id_sexo = id_sexo;
            if (fecha_compra != string.Empty)
            {
                try
                {
                    Obj.Fecha_compra = Convert.ToDateTime(fecha_compra);
                }
                catch (Exception)
                {

                    Obj.Fecha_compra = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_compra = System.DateTime.Parse("1900-01-01");
            }
            Obj.Cupo_compra = cupo_compra;
            return Obj.Editar(Obj);

        }

        //metodo eliminar que llama al metodo Eliminar de la clase DCliente

        public static string Eliminar(int id_cliente)
        {
            DCliente Obj = new DCliente();
            Obj.Id_cliente = id_cliente;
            return Obj.Eliminar(Obj);
        }

        //metodo Mostrar que llama al metodo Mostrar de la clase DCliente

        public static DataTable Mostrar()
        {
            DCliente Obj = new DCliente();
            return Obj.Mostrar();
        }

        //metodo Buscar que llama al metodo Buscar de la clase DCliente

        public static DataTable Buscar(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.Textobuscar = textobuscar;
            return Obj.Buscar(Obj);
        }

        //metodo Buscar que llama al metodo Buscar por dni de la clase DCliente

        public static DataTable BuscarDni(int dni)
        {
            DCliente Obj = new DCliente();
            Obj.Dni = dni;
            return Obj.BuscarDni(Obj);
        }

    }//fin de clase
}
