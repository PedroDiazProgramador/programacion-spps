using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NPedido_Producto
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_pedido_producto, int id_pedido, int id_producto, int cantidad_producto)
        {
            DPedido_Producto Obj = new DPedido_Producto();
            Obj.Id_pedido_producto = id_pedido_producto;
            Obj.Id_pedido = id_pedido;
            Obj.Id_producto = id_producto;
            Obj.Cantidad_producto = cantidad_producto;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_pedido_producto, int id_pedido, int id_producto, int cantidad_producto)
        {
            DPedido_Producto Obj = new DPedido_Producto();
            Obj.Id_pedido_producto = id_pedido_producto;
            Obj.Id_pedido = id_pedido;
            Obj.Id_producto = id_producto;
            Obj.Cantidad_producto = cantidad_producto;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_pedido_producto)
        {
            DPedido_Producto Obj = new DPedido_Producto();
            Obj.Id_pedido_producto = id_pedido_producto;
            return Obj.Eliminar(Obj);
        }
        //metodo mostrar
        public static DataTable Mostrar()
        {
            DPedido_Producto Obj = new DPedido_Producto();
            return Obj.Mostrar();
        }
    }//fin de clase
}
