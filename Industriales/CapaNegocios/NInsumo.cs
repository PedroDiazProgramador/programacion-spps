using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NInsumo
    {//inicio de clase
        //metodo insertar
        public static string Insetar(int id_insumo, int codigo_insumo, string denominacion, int id_unidad_medida, decimal precio_referencia, string presentacion, int id_marca, int id_proveedor)
        {
            DInsumo Obj = new DInsumo();
            Obj.Id_insumo = id_insumo;
            Obj.Codigo_insumo = codigo_insumo;
            Obj.Denominacion = denominacion;
            Obj.Id_unidad_medida = id_unidad_medida;
            Obj.Precio_referencia = precio_referencia;
            Obj.Presentacion = presentacion;
            Obj.Id_marca = id_marca;
            Obj.Id_proveedor = id_proveedor;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_insumo, int codigo_insumo, string denominacion, int id_unidad_medida, decimal precio_referencia, string presentacion, int id_marca, int id_proveedor)
        {
            DInsumo Obj = new DInsumo();
            Obj.Id_insumo = id_insumo;
            Obj.Codigo_insumo = codigo_insumo;
            Obj.Denominacion = denominacion;
            Obj.Id_unidad_medida = id_unidad_medida;
            Obj.Precio_referencia = precio_referencia;
            Obj.Presentacion = presentacion;
            Obj.Id_marca = id_marca;
            Obj.Id_proveedor = id_proveedor;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_insumo)
        {
            DInsumo Obj = new DInsumo();
            Obj.Id_insumo = id_insumo;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DInsumo Obj = new DInsumo();
            return Obj.Mostrar();
        }


    }//fin de clase
}
