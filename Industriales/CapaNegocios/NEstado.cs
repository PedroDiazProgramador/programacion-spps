using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NEstado
    {//inicio de clase
        //metodo insertar que llama a Insertar de la clase DEstado
        public static string Insertar(int id_estado, string estado)
        {
            DEstado Obj = new DEstado();
            Obj.Id_estado = id_estado;
            Obj.Estado = estado;
            return Obj.Insertar(Obj);
        } 

        //metodo editar que llama a Editar de la clase DEstado
        public static string Editar(int id_estado, string estado)
        {
            DEstado Obj = new DEstado();
            Obj.Id_estado = id_estado;
            Obj.Estado = estado;
            return Obj.Editar(Obj);
        }

        //metodo eliminar que llama a Eliminar de la clase DEstado
        public static string Eliminar(int id_estado)
        {
            DEstado Obj = new DEstado();
            Obj.Id_estado = id_estado;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar que llama a Mostrar de la clase DEstado
        public static DataTable Mostrar()
        {
            DEstado Obj = new DEstado();
            return Obj.Mostrar();
        } 
    }//fin de clase
}
