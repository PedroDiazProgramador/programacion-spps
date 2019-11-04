using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NFactura
    {//inicio de clase
     //metodo insertar
        public static string Insertar(int id_factura, int id_cliente, string fecha_venta, decimal costo_total, int numero_factura, int comprobante_exposicion, int id_tipo_pago, int emite_factura, int tipo_factura)
        {
            DFactura Obj = new DFactura();
            Obj.Id_factura = id_factura;
            Obj.Id_cliente = id_cliente;
            if (fecha_venta != string.Empty)
            {
                try
                {
                    Obj.Fecha_venta = Convert.ToDateTime(fecha_venta);
                }
                catch (Exception)
                {

                    Obj.Fecha_venta = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_venta = System.DateTime.Parse("1900-01-01");
            }
            Obj.Costo_total = costo_total;
            Obj.Numero_factura = numero_factura;
            Obj.Comprobante_exposicion = comprobante_exposicion;
            Obj.Id_tipo_pago = id_tipo_pago;
            Obj.Emite_factura = emite_factura;
            Obj.Tipo_factura = tipo_factura;
            return Obj.Insertar(Obj);
        }
        //metodo editar
        public static string Editar(int id_factura, int id_cliente, string fecha_venta, decimal costo_total, int numero_factura, int comprobante_exposicion, int id_tipo_pago, int emite_factura, int tipo_factura)
        {
            DFactura Obj = new DFactura();
            Obj.Id_factura = id_factura;
            Obj.Id_cliente = id_cliente;
            if (fecha_venta != string.Empty)
            {
                try
                {
                    Obj.Fecha_venta = Convert.ToDateTime(fecha_venta);
                }
                catch (Exception)
                {

                    Obj.Fecha_venta = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Fecha_venta = System.DateTime.Parse("1900-01-01");
            }
            Obj.Costo_total = costo_total;
            Obj.Numero_factura = numero_factura;
            Obj.Comprobante_exposicion = comprobante_exposicion;
            Obj.Id_tipo_pago = id_tipo_pago;
            Obj.Emite_factura = emite_factura;
            Obj.Tipo_factura = tipo_factura;
            return Obj.Editar(Obj);
        }
        //metodo eliminar
        public static string Eliminar(int id_factura)
        {
            DFactura Obj = new DFactura();
            Obj.Id_factura = id_factura;
            return Obj.Eliminar(Obj);
        }
        //metodo mostrar
        public static DataTable Mostrar()
        {
            DFactura Obj = new DFactura();
            return Obj.Mostrar();
        }
    }//fin de clase
}
