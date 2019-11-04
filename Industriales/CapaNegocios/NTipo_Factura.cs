using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NTipo_Factura
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_tipo_factura, string tipo_factura)
        {
            DTipo_Factura Obj = new DTipo_Factura();
            Obj.Id_tipo_factura = id_tipo_factura;
            Obj.Tipo_factura = tipo_factura;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_tipo_factura, string tipo_factura)
        {
            DTipo_Factura Obj = new DTipo_Factura();
            Obj.Id_tipo_factura = id_tipo_factura;
            Obj.Tipo_factura = tipo_factura;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_tipo_factura)
        {
            DTipo_Factura Obj = new DTipo_Factura();
            Obj.Id_tipo_factura = id_tipo_factura;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DTipo_Factura Obj = new DTipo_Factura();
            return Obj.Mostrar();
        }
    }//fin de clase
}
