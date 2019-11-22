using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NDetalle
    {//inicio de clase
        //metodo insertar que llama a Insertar de la clase DDetalle
        public static string Insertar(int id_detalle, int id_factura, int id_producto, decimal precio_producto, int cantidad_producto)
        {
            DDetalle Obj = new DDetalle();
            Obj.Id_detalle = id_detalle;
            Obj.Id_factura = id_factura;
            Obj.Id_producto = id_producto;
            Obj.Cantidad_producto = cantidad_producto;
            return Obj.Insertar(Obj);
        }

        //metodo editar que llama a Editar de la clase DDetlle
        public static string Editar(int id_detalle, int id_factura, int id_producto, decimal precio_producto, int cantidad_producto)
        {
            DDetalle Obj = new DDetalle();
            Obj.Id_detalle = id_detalle;
            Obj.Id_factura = id_factura;
            Obj.Id_producto = id_producto;
            Obj.Cantidad_producto = cantidad_producto;
            return Obj.Editar(Obj);
        }

        //metodo eliminar que llama a Eliminar de la clase DDetalle
        public static string Eliminar(int id_detalle)
        {
            DDetalle Obj = new DDetalle();
            Obj.Id_detalle = id_detalle;
            return Obj.Eliminar(Obj);
        } 

        //metodo mostrar que llama a Mostrar de la clase DDetalle
        public static DataTable Mostrar()
        {
            DDetalle Obj = new DDetalle();
            return Obj.Mostrar();
        }
    }//fin de clase
}
