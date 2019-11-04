using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NPagos
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_pago, int id_venta, int cuota_numero, decimal monto_cuota, int estado_cuota, string fecha_cuota, int numero_comprobante)
        {
            DPagos Obj = new DPagos();
            Obj.Id_pago = id_pago;
            Obj.Id_venta = id_venta;
            Obj.Cuota_numero = cuota_numero;
            Obj.Monto_cuota = monto_cuota;
            Obj.Estado_cuota = estado_cuota;
            if (fecha_cuota != string.Empty)
            {
                try
                {
                    Obj.Fecha_cuota = Convert.ToDateTime(fecha_cuota);
                }
                catch (Exception)
                {

                    Obj.Fecha_cuota = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_cuota = System.DateTime.Parse("1900-01-01");
            }
            Obj.Numero_comprobante = numero_comprobante;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_pago, int id_venta, int cuota_numero, decimal monto_cuota, int estado_cuota, string fecha_cuota, int numero_comprobante)
        {
            DPagos Obj = new DPagos();
            Obj.Id_pago = id_pago;
            Obj.Id_venta = id_venta;
            Obj.Cuota_numero = cuota_numero;
            Obj.Monto_cuota = monto_cuota;
            Obj.Estado_cuota = estado_cuota;
            if (fecha_cuota != string.Empty)
            {
                try
                {
                    Obj.Fecha_cuota = Convert.ToDateTime(fecha_cuota);
                }
                catch (Exception)
                {

                    Obj.Fecha_cuota = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_cuota = System.DateTime.Parse("1900-01-01");
            }
            Obj.Numero_comprobante = numero_comprobante;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_pago)
        {
            DPagos Obj = new DPagos();
            Obj.Id_pago = id_pago;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DPagos Obj = new DPagos();
            return Obj.Mostrar();
        }
    }//fin de clase
}
