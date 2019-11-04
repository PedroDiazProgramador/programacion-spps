using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NTipo_Cliente
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_tipo_cliente, string tipo_cliente)
        {
            DTipo_Cliente Obj = new DTipo_Cliente();
            Obj.Id_tipo_cliente = id_tipo_cliente;
            Obj.Tipo_cliente = tipo_cliente;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_tipo_cliente, string tipo_cliente)
        {
            DTipo_Cliente Obj = new DTipo_Cliente();
            Obj.Id_tipo_cliente = id_tipo_cliente;
            Obj.Tipo_cliente = tipo_cliente;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_tipo_cliente)
        {
            DTipo_Cliente Obj = new DTipo_Cliente();
            Obj.Id_tipo_cliente = id_tipo_cliente;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DTipo_Cliente Obj = new DTipo_Cliente();
            return Obj.Mostrar();
        }
    }//fin de clase
}
