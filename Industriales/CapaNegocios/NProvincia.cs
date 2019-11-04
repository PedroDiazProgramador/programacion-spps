using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NProvincia
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_provincia, string provincia)
        {
            DProvincia Obj = new DProvincia();
            Obj.Id_provincia = id_provincia;
            Obj.Provincia = provincia;
            return Obj.Insertar(Obj); 
        }

        //metodo editar
        public static string Editar(int id_provincia, string provincia)
        {
            DProvincia Obj = new DProvincia();
            Obj.Id_provincia = id_provincia;
            Obj.Provincia = provincia;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_provincia)
        {
            DProvincia Obj = new DProvincia();
            Obj.Id_provincia = id_provincia;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public  static DataTable Mostrar()
        {
            DProvincia Obj = new DProvincia();
            return Obj.Mostrar();
        }
    }//fin de clase
}
