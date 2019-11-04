using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NEstado_Cuota
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_estado, string estado_cuota)
        {
            DEstado_Cuota Obj = new DEstado_Cuota();
            Obj.Id_estado = id_estado;
            Obj.Estado_cuota = estado_cuota;
            return Obj.Insertar(Obj);
        }
        //metodo Editar
        public static string Editar(int id_estado, string estado_cuota)
        {
            DEstado_Cuota Obj = new DEstado_Cuota();
            Obj.Id_estado = id_estado;
            Obj.Estado_cuota = estado_cuota;
            return Obj.Editar(Obj);
        }
        //metodo eliminar
        public static string Eliminar(int id_estado)
        {
            DEstado_Cuota Obj = new DEstado_Cuota();
            Obj.Id_estado = id_estado;
            return Obj.Eliminar(Obj);
        }
        //metodo Mostrar
        public static DataTable Mostrar()
        {
            DEstado_Cuota Obj = new DEstado_Cuota();
            return Obj.Mostrar();
        }

    }//fin de clase
}
