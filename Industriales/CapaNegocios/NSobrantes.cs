using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NSobrantes
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_sobrante, int id_insumo, int id_pedido, decimal cantidad)
        {
            DSobrantes Obj = new DSobrantes();
            Obj.Id_sobrante = id_sobrante;
            Obj.Id_insumo = id_insumo;
            Obj.Id_pedido = id_pedido;
            Obj.Cantidad = cantidad;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_sobrante, int id_insumo, int id_pedido, decimal cantidad)
        {
            DSobrantes Obj = new DSobrantes();
            Obj.Id_sobrante = id_sobrante;
            Obj.Id_insumo = id_insumo;
            Obj.Id_pedido = id_pedido;
            Obj.Cantidad = cantidad;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_sobrante)
        {
            DSobrantes Obj = new DSobrantes();
            Obj.Id_sobrante = id_sobrante;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DSobrantes Obj = new DSobrantes();
            return Obj.Mostrar();
        }
    }//fin de clase
}
