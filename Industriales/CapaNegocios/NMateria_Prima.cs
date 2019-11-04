using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NMateria_Prima
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_materia_prima, int id_insumo, decimal cantidad_utilizada, int id_producto)
        {
            DMateria_Prima Obj = new DMateria_Prima();
            Obj.Id_materia_prima = id_materia_prima;
            Obj.Id_insumo = id_insumo;
            Obj.Cantidad_utilizada = cantidad_utilizada;
            Obj.Id_producto = id_producto;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_materia_prima, int id_insumo, decimal cantidad_utilizada, int id_producto)
        {
            DMateria_Prima Obj = new DMateria_Prima();
            Obj.Id_materia_prima = id_materia_prima;
            Obj.Id_insumo = id_insumo;
            Obj.Cantidad_utilizada = cantidad_utilizada;
            Obj.Id_producto = id_producto;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_materia_prima)
        {
            DMateria_Prima Obj = new DMateria_Prima();
            Obj.Id_materia_prima = id_materia_prima;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DMateria_Prima Obj = new DMateria_Prima();
            return Obj.Mostrar();
        }
    }//fin de clase 
}
