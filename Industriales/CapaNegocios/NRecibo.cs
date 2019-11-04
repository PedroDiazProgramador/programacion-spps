using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NRecibo
    {//inicio de clase
     //metodo insertar
        public static string Insertar(int id_recibo, int numero_recibo, string fecha_recibo, int id_taller, string personal_recibe)
        {
            DRecibo Obj = new DRecibo();
            Obj.Id_recibo = id_recibo;
            Obj.Numero_recibo = numero_recibo;
            if (fecha_recibo != string.Empty)
            {
                try
                {
                    Obj.Fecha_recibo = Convert.ToDateTime(fecha_recibo);
                }
                catch (Exception)
                {

                    Obj.Fecha_recibo = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_recibo = System.DateTime.Parse("1900-01-01");
            }
            Obj.Id_taller = id_taller;
            Obj.Personal_recibe = personal_recibe;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_recibo, int numero_recibo, string fecha_recibo, int id_taller, string personal_recibe)
        {
            DRecibo Obj = new DRecibo();
            Obj.Id_recibo = id_recibo;
            Obj.Numero_recibo = numero_recibo;
            if (fecha_recibo != string.Empty)
            {
                try
                {
                    Obj.Fecha_recibo = Convert.ToDateTime(fecha_recibo);
                }
                catch (Exception)
                {

                    Obj.Fecha_recibo = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_recibo = System.DateTime.Parse("1900-01-01");
            }
            Obj.Id_taller = id_taller;
            Obj.Personal_recibe = personal_recibe;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_recibo)
        {
            DRecibo Obj = new DRecibo();
            Obj.Id_recibo = id_recibo;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DRecibo Obj = new DRecibo();
            return Obj.Mostrar();
        }
    }//fin de clase
}
