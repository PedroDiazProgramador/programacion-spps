using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NTipo_Pago
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_tipo_pago, string tipo_pago)
        {
            DTipo_Pago Obj = new DTipo_Pago();
            Obj.Id_tipo_pago = id_tipo_pago;
            Obj.Tipo_pago = tipo_pago;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_tipo_pago, string tipo_pago)
        {
            DTipo_Pago Obj = new DTipo_Pago();
            Obj.Id_tipo_pago = id_tipo_pago;
            Obj.Tipo_pago = tipo_pago;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_tipo_pago)
        {
            DTipo_Pago Obj = new DTipo_Pago();
            Obj.Id_tipo_pago = id_tipo_pago;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DTipo_Pago Obj = new DTipo_Pago();
            return Obj.Mostrar();
        }
    }//fin de clase
}
