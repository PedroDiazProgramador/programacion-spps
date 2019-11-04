using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NTaller
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_taller, string denominacion)
        {
            DTaller Obj = new DTaller();
            Obj.Id_taller = id_taller;
            Obj.Denominacion = denominacion;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_taller, string denominacion)
        {
            DTaller Obj = new DTaller();
            Obj.Id_taller = id_taller;
            Obj.Denominacion = denominacion;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_taller)
        {
            DTaller Obj = new DTaller();
            Obj.Id_taller = id_taller;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DTaller Obj = new DTaller();
            return Obj.Mostrar();
        }
    }//fin de clase
}
