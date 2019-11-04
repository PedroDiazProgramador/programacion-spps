using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NHistorial_Estado
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_historial, int id_produccion, int id_estado, string fecha_cambio_estado, string detalle_estado)
        {
            DHistorial_Estado Obj = new DHistorial_Estado();
            Obj.Id_historial = id_historial;
            Obj.Id_produccion = id_produccion;
            Obj.Id_estado = id_estado;
            if (fecha_cambio_estado != string.Empty)
            {
                try
                {
                    Obj.Fecha_cambio_estado = Convert.ToDateTime(fecha_cambio_estado);
                }
                catch (Exception)
                {

                    Obj.Fecha_cambio_estado = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_cambio_estado = System.DateTime.Parse("1900-01-01");
            }
            Obj.Detalle_estado = detalle_estado;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_historial, int id_produccion, int id_estado, string fecha_cambio_estado, string detalle_estado)
        {
            DHistorial_Estado Obj = new DHistorial_Estado();
            Obj.Id_historial = id_historial;
            Obj.Id_produccion = id_produccion;
            Obj.Id_estado = id_estado;
            if (fecha_cambio_estado != string.Empty)
            {
                try
                {
                    Obj.Fecha_cambio_estado = Convert.ToDateTime(fecha_cambio_estado);
                }
                catch (Exception)
                {

                    Obj.Fecha_cambio_estado = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_cambio_estado = System.DateTime.Parse("1900-01-01");
            }
            Obj.Detalle_estado = detalle_estado;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string eliminar(int id_historial)
        {
            DHistorial_Estado Obj = new DHistorial_Estado();
            Obj.Id_historial = id_historial;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DHistorial_Estado Obj = new DHistorial_Estado();
            return Obj.Mostrar();
        }
    }//fin clase
}
