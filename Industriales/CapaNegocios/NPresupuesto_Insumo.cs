using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NPresupuesto_Insumo
    {//inicio clase
        //metodo insertar
        public static string Insertar(int id_pre_insumo, int id_presupuesto, int id_insumo, int cantidad, decimal precio_unitario)
        {
            DPresupuesto_Insumo Obj = new DPresupuesto_Insumo();
            Obj.Id_pre_insumo = id_pre_insumo;
            Obj.Id_presupuesto = id_presupuesto;
            Obj.Id_insumo = id_insumo;
            Obj.Cantidad = cantidad;
            Obj.Precio_unitario = precio_unitario;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_pre_insumo, int id_presupuesto, int id_insumo, int cantidad, decimal precio_unitario)
        {
            DPresupuesto_Insumo Obj = new DPresupuesto_Insumo();
            Obj.Id_pre_insumo = id_pre_insumo;
            Obj.Id_presupuesto = id_presupuesto;
            Obj.Id_insumo = id_insumo;
            Obj.Cantidad = cantidad;
            Obj.Precio_unitario = precio_unitario;
            return Obj.Editar(Obj);
        }
        
        //metodo eliminar
        public static string Eliminar(int id_pre_insumo)
        {
            DPresupuesto_Insumo Obj = new DPresupuesto_Insumo();
            Obj.Id_pre_insumo = id_pre_insumo;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DPresupuesto_Insumo Obj = new DPresupuesto_Insumo();
            return Obj.Mostrar();
        }
    }//fin clase
}
