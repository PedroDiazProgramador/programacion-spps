using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{//inicio capa de datos
    public class DVentas
    {//inicio clase
        private int _Id_detalle;
        private int _Id_factura;
        private int _Id_producto;
        private decimal _Precio_producto;
        private int _Cantidad_producto;
        private string _Descripcion_producto;

        #region Propiedades
        public int Id_detalle
        {
            get
            {
                return _Id_detalle;
            }

            set
            {
                _Id_detalle = value;
            }
        }

        public int Id_factura
        {
            get
            {
                return _Id_factura;
            }

            set
            {
                _Id_factura = value;
            }
        }

        public int Id_producto
        {
            get
            {
                return _Id_producto;
            }

            set
            {
                _Id_producto = value;
            }
        }

        public decimal Precio_producto
        {
            get
            {
                return _Precio_producto;
            }

            set
            {
                _Precio_producto = value;
            }
        }

        public int Cantidad_producto
        {
            get
            {
                return _Cantidad_producto;
            }

            set
            {
                _Cantidad_producto = value;
            }
        }

        public string Descripcion_producto
        {
            get
            {
                return _Descripcion_producto;
            }

            set
            {
                _Descripcion_producto = value;
            }
        }
        #endregion Propiedades

        public DVentas()
        {

        }

        public DVentas(int id_detalle, int id_factura, int id_producto, decimal precio_producto, int cantidad_producto, string descripcion_producto)
        {
            this.Id_detalle = id_detalle;
            this.Id_factura = id_factura;
            this.Id_producto = id_producto;
            this.Precio_producto = precio_producto;
            this.Cantidad_producto = cantidad_producto;
            this.Descripcion_producto = descripcion_producto;
        }
    }//fin clase
}//fin capa de datos
