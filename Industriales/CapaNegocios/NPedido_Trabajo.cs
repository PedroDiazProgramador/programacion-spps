using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NPedido_Trabajo
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_pedido, int id_taller, string fecha_pedido, int numero_transaccion, string numero_nota, string numero_contratacion, int cumplimentado, string comentario)
        {
            DPedido_Trabajo Obj = new DPedido_Trabajo();
            Obj.Id_pedido = id_pedido;
            Obj.Id_taller = id_taller;
            if (fecha_pedido != string.Empty)
            {
                try
                {
                    Obj.Fecha_pedido = Convert.ToDateTime(fecha_pedido);
                }
                catch (Exception)
                {

                    Obj.Fecha_pedido = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_pedido = System.DateTime.Parse("1900-01-01");
            }
            Obj.Numero_transaccion = numero_transaccion;
            Obj.Numero_nota = numero_nota;
            Obj.Numero_contratacion = numero_contratacion;
            Obj.Cumplimentado = cumplimentado;
            Obj.Comentario = comentario;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_pedido, int id_taller, string fecha_pedido, int numero_transaccion, string numero_nota, string numero_contratacion, int cumplimentado, string comentario)
        {
            DPedido_Trabajo Obj = new DPedido_Trabajo();
            Obj.Id_pedido = id_pedido;
            Obj.Id_taller = id_taller;
            if (fecha_pedido != string.Empty)
            {
                try
                {
                    Obj.Fecha_pedido = Convert.ToDateTime(fecha_pedido);
                }
                catch (Exception)
                {

                    Obj.Fecha_pedido = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_pedido = System.DateTime.Parse("1900-01-01");
            }
            Obj.Numero_transaccion = numero_transaccion;
            Obj.Numero_nota = numero_nota;
            Obj.Numero_contratacion = numero_contratacion;
            Obj.Cumplimentado = cumplimentado;
            Obj.Comentario = comentario;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_pedido)
        {
            DPedido_Trabajo Obj = new DPedido_Trabajo();
            Obj.Id_pedido = id_pedido;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DPedido_Trabajo Obj = new DPedido_Trabajo();
            return Obj.Mostrar();
        }
    }//fin de clase
}
