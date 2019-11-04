using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;


namespace CapaNegocios
{
    public class NAnticipo
    {//inicio de clase
        public static string Insertar(int id_anticipo, string numero_anticipo, decimal cantidad_dinero, string fecha_recibido)
        {
            DAnticipo Obj = new DAnticipo();
            Obj.Id_anticipo = id_anticipo;
            Obj.Numero_anticipo = numero_anticipo;
            Obj.Cantidad_dinero = cantidad_dinero;
            if (fecha_recibido != string.Empty)
            {
                try
                {
                    Obj.Fecha_recibido = Convert.ToDateTime(fecha_recibido);
                }
                catch (Exception)
                {

                    Obj.Fecha_recibido = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_recibido = System.DateTime.Parse("1900-01-01");
            }
            return Obj.Insertar(Obj);

        }

        public static string Editar(int id_anticipo, string numero_anticipo, decimal cantidad_dinero, string fecha_recibido)
        {
            DAnticipo Obj = new DAnticipo();
            Obj.Id_anticipo = id_anticipo;
            Obj.Numero_anticipo = numero_anticipo;
            Obj.Cantidad_dinero = cantidad_dinero;
            if (fecha_recibido != string.Empty)
            {
                try
                {
                    Obj.Fecha_recibido = Convert.ToDateTime(fecha_recibido);
                }
                catch (Exception)
                {

                    Obj.Fecha_recibido = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_recibido = System.DateTime.Parse("1900-01-01");
            }
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int id_anticipo)
        {
            DAnticipo Obj = new DAnticipo();
            Obj.Id_anticipo = id_anticipo;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            DAnticipo Obj = new DAnticipo();
            return Obj.Mostrar();
        }

        public static DataTable Buscar(string textobuscar)
        {
            DAnticipo Obj = new DAnticipo();
            Obj.Textobuscar = textobuscar;
            return Obj.Buscar(Obj);
        }

    }//fin clase
}
