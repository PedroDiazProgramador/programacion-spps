using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NPedido_Insumo
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_pedido_insumo, int id_pedido, int id_insumo, decimal cantidad_insumo)
        {
            DPedido_Insumo Obj = new DPedido_Insumo();
            Obj.Id_pedido_insumo = id_pedido_insumo;
            Obj.Id_pedido = id_pedido;
            Obj.Id_insumo = id_insumo;
            Obj.Cantidad_insumo = cantidad_insumo;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_pedido_insumo, int id_pedido, int id_insumo, decimal cantidad_insumo)
        {
            DPedido_Insumo Obj = new DPedido_Insumo();
            Obj.Id_pedido_insumo = id_pedido_insumo;
            Obj.Id_pedido = id_pedido;
            Obj.Id_insumo = id_insumo;
            Obj.Cantidad_insumo = cantidad_insumo;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_pedido_insumo)
        {
            DPedido_Insumo Obj = new DPedido_Insumo();
            Obj.Id_pedido_insumo = id_pedido_insumo;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DPedido_Insumo Obj = new DPedido_Insumo();
            return Obj.Mostrar();
        }
    }//fin de clase
}
