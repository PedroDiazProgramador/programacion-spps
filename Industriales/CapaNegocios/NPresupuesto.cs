using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;    

namespace CapaNegocios
{
    public class NPresupuesto
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_presupuesto, string fecha_emision, int id_insumo, decimal precio_total, int id_proveedor)
        {
            DPresupuesto Obj = new DPresupuesto();
            Obj.Id_presupuesto = id_presupuesto;
            if (fecha_emision != string.Empty)
            {
                try
                {
                    Obj.Fecha_emision = Convert.ToDateTime(fecha_emision);
                }
                catch (Exception)
                {

                    Obj.Fecha_emision = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_emision = System.DateTime.Parse("1900-01-01");
            }
            Obj.Id_insumo = id_insumo;
            Obj.Precio_total = precio_total;
            Obj.Id_proveedor = id_proveedor;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_presupuesto, string fecha_emision, int id_insumo, decimal precio_total, int id_proveedor)
        {
            DPresupuesto Obj = new DPresupuesto();
            Obj.Id_presupuesto = id_presupuesto;
            if (fecha_emision != string.Empty)
            {
                try
                {
                    Obj.Fecha_emision = Convert.ToDateTime(fecha_emision);
                }
                catch (Exception)
                {

                    Obj.Fecha_emision = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_emision = System.DateTime.Parse("1900-01-01");
            }
            Obj.Id_insumo = id_insumo;
            Obj.Precio_total = precio_total;
            Obj.Id_proveedor = id_proveedor;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_presupuesto)
        {
            DPresupuesto Obj = new DPresupuesto();
            Obj.Id_presupuesto = id_presupuesto;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DPresupuesto Obj = new DPresupuesto();
            return Obj.Mostrar();
        }

    }//fin de clase
}
