using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NProduccion
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_produccion, int numero_serie, int id_producto, string detalle_estado, int id_pedido)
        {
            DProduccion Obj = new DProduccion();
            Obj.Id_produccion = id_produccion;
            Obj.Numero_serie = numero_serie;
            Obj.Id_producto = id_producto;
            Obj.Detalle_estado = detalle_estado;
            Obj.Id_pedido = id_pedido;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_produccion, int numero_serie, int id_producto, string detalle_estado, int id_pedido)
        {
            DProduccion Obj = new DProduccion();
            Obj.Id_produccion = id_produccion;
            Obj.Numero_serie = numero_serie;
            Obj.Id_producto = id_producto;
            Obj.Detalle_estado = detalle_estado;
            Obj.Id_pedido = id_pedido;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_produccion)
        {
            DProduccion Obj = new DProduccion();
            Obj.Id_produccion = id_produccion;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DProduccion Obj = new DProduccion();
            return Obj.Mostrar();
        }
        }//fin de clase
}
