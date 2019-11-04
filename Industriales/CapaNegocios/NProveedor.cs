using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NProveedor
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_proveedor, string denominacion, string direccion, string telefono, string email)
        {
            DProveedor Obj = new DProveedor();
            Obj.Id_proveedor = id_proveedor;
            Obj.Denominacion = denominacion;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_proveedor, string denominacion, string direccion, string telefono, string email)
        {
            DProveedor Obj = new DProveedor();
            Obj.Id_proveedor = id_proveedor;
            Obj.Denominacion = denominacion;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_proveedor)
        {
            DProveedor Obj = new DProveedor();
            Obj.Id_proveedor = id_proveedor;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DProveedor Obj = new DProveedor();
            return Obj.Mostrar();
        }

        //metodo buscar 
        public static DataTable Buscar(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.Textobuscar = textobuscar;
            return Obj.Buscar(Obj);
        }
    }//fin de clase
}
