using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NLocalidad
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_localidad, int id_provincia, string localidad)
        {
            DLocalidad Obj = new DLocalidad();
            Obj.Id_localidad = id_localidad;
            Obj.Id_provincia = id_provincia;
            Obj.Localidad = localidad;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_localidad, int id_provincia, string localidad)
        {
            DLocalidad Obj = new DLocalidad();
            Obj.Id_localidad = id_localidad;
            Obj.Id_provincia = id_provincia;
            Obj.Localidad = localidad;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_localidad)
        {
            DLocalidad Obj = new DLocalidad();
            Obj.Id_localidad = id_localidad;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DLocalidad Obj = new DLocalidad();
            return Obj.Mostrar();
        }
    }//fin de clase
}
