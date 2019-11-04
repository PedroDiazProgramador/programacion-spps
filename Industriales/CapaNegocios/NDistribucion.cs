using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NDistribucion
    {//inicio de clase
        //metodo insertar que llama a Insertar de la clase DDistribucion
        public static string Insertar(int id_distribucion, int id_taller, int id_anticipo, string fecha_anticipo, decimal monto, int id_recibo)
        {
            DDistribucion Obj = new DDistribucion();
            Obj.Id_distribucion = id_distribucion;
            Obj.Id_taller = id_taller;
            Obj.Id_anticipo = id_anticipo;
            if (fecha_anticipo != string.Empty)
            {
                try
                {
                    Obj.Fecha_anticipo = Convert.ToDateTime(fecha_anticipo);
                }
                catch (Exception)
                {

                    Obj.Fecha_anticipo = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_anticipo = System.DateTime.Parse("1900-01-01");
            }
            Obj.Monto = monto;
            Obj.Id_recibo = id_recibo;
            return Obj.Insertar(Obj);
        }

        //metodo editar que llama a Editar de la clase DDistribucion
        public static string Editar(int id_distribucion, int id_taller, int id_anticipo, string fecha_anticipo, decimal monto, int id_recibo)
        {
            DDistribucion Obj = new DDistribucion();
            Obj.Id_distribucion = id_distribucion;
            Obj.Id_taller = id_taller;
            Obj.Id_anticipo = id_anticipo;
            if (fecha_anticipo != string.Empty)
            {
                try
                {
                    Obj.Fecha_anticipo = Convert.ToDateTime(fecha_anticipo);
                }
                catch (Exception)
                {

                    Obj.Fecha_anticipo = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_anticipo = System.DateTime.Parse("1900-01-01");
            }
            Obj.Monto = monto;
            Obj.Id_recibo = id_recibo;
            return Obj.Editar(Obj);
        }

        //metodo eliminar que llama a Eliminar de la clase DDistribucion
        public static string Eliminar(int id_distribucion)
        {
            DDistribucion Obj = new DDistribucion();
            Obj.Id_distribucion = id_distribucion;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar que llama a Mostrar de la clase DDistribucion
        public static DataTable Mostrar()
        {
            DDistribucion Obj = new DDistribucion();
            return Obj.Mostrar();
        }
    }//fin de clase
}
