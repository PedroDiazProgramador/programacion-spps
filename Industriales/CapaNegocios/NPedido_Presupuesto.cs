using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NPedido_Presupuesto
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_pedido_presupuesto, int id_pedido, int id_presupuesto)
        {
            DPedido_Presupuesto Obj = new DPedido_Presupuesto();
            Obj.Id_pedido_presupuesto = id_pedido_presupuesto;
            Obj.Id_pedido = id_pedido;
            Obj.Id_presupuesto = id_presupuesto;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_pedido_presupuesto, int id_pedido, int id_presupuesto)
        {
            DPedido_Presupuesto Obj = new DPedido_Presupuesto();
            Obj.Id_pedido_presupuesto = id_pedido_presupuesto;
            Obj.Id_pedido = id_pedido;
            Obj.Id_presupuesto = id_presupuesto;
            return Obj.Editar(Obj);
        }

        //metodo Eliminar
        public static string Eliminar(int id_pedido_presupuesto)
        {
            DPedido_Presupuesto Obj = new DPedido_Presupuesto();
            Obj.Id_pedido_presupuesto = id_pedido_presupuesto;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DPedido_Presupuesto Obj = new DPedido_Presupuesto();
            return Obj.Mostrar();
        }
    }//fin de clase
}
