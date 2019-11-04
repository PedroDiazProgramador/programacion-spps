using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NUnidad_Medida
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_unidad_medida, string descripcion)
        {
            DUnidad_Medida Obj = new DUnidad_Medida();
            Obj.Id_unidad_medida = id_unidad_medida;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_unidad_medida, string descripcion)
        {
            DUnidad_Medida Obj = new DUnidad_Medida();
            Obj.Id_unidad_medida = id_unidad_medida;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_unidad_medida)
        {
            DUnidad_Medida Obj = new DUnidad_Medida();
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DUnidad_Medida Obj = new DUnidad_Medida();
            return Obj.Mostrar();
        }

    }//fin  de clase
}
