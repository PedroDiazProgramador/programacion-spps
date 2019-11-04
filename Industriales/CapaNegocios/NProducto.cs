using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NProducto
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_producto, int codigo_barra, string descripcion, decimal precio_kilo, decimal precio_unidad, int stock, int stock_minimo, string vencimiento, int id_taller, int id_materia_prima)
        {
            DProducto Obj = new DProducto();
            Obj.Id_producto = id_producto;
            Obj.Codigo_barra = codigo_barra;
            Obj.Descripcion = descripcion;
            Obj.Precio_kilo = precio_kilo;
            Obj.Precio_unidad = precio_unidad;
            Obj.Stock = stock;
            Obj.Stock_minimo = stock_minimo;
            if (vencimiento != string.Empty)
            {
                try
                {
                    Obj.Vencimiento = Convert.ToDateTime(vencimiento);
                }
                catch (Exception)
                {

                    Obj.Vencimiento = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Vencimiento= System.DateTime.Parse("1900-01-01");
            }
            Obj.Id_taller = id_taller;
            Obj.Id_materia_prima = id_materia_prima;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_producto, int codigo_barra, string descripcion, decimal precio_kilo, decimal precio_unidad, int stock, int stock_minimo, string vencimiento, int id_taller, int id_materia_prima)
        {
            DProducto Obj = new DProducto();
            Obj.Id_producto = id_producto;
            Obj.Codigo_barra = codigo_barra;
            Obj.Descripcion = descripcion;
            Obj.Precio_kilo = precio_kilo;
            Obj.Precio_unidad = precio_unidad;
            Obj.Stock = stock;
            Obj.Stock_minimo = stock_minimo;
            if (vencimiento != string.Empty)
            {
                try
                {
                    Obj.Vencimiento = Convert.ToDateTime(vencimiento);
                }
                catch (Exception)
                {

                    Obj.Vencimiento = System.DateTime.Parse("1900-01-01");

                }
            }
            else
            {
                Obj.Vencimiento = System.DateTime.Parse("1900-01-01");
            }
            Obj.Id_taller = id_taller;
            Obj.Id_materia_prima = id_materia_prima;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_producto)
        {
            DProducto Obj = new DProducto();
            Obj.Id_producto = id_producto;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DProducto Obj = new DProducto();
            return Obj.Mostrar();
        }

        //metodo buscar 
        public static DataTable Buscar(string textobuscar)
        {
            DProducto Obj = new DProducto();
            Obj.Textobuscar = textobuscar;
            return Obj.Buscar(Obj);
        }
    }//fin de clase
}
