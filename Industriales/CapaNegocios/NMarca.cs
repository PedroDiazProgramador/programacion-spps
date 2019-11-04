using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NMarca
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_marca, string denominacion)
        {
            DMarca Obj = new DMarca();
            Obj.Id_marca = id_marca;
            Obj.Denominacion = denominacion;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_marca, string denominacion)
        {
            DMarca Obj = new DMarca();
            Obj.Id_marca = id_marca;
            Obj.Denominacion = denominacion;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_marca)
        {
            DMarca Obj = new DMarca();
            Obj.Id_marca = id_marca;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DMarca Obj = new DMarca();
            return Obj.Mostrar();
        }
    }//fin clase
}
