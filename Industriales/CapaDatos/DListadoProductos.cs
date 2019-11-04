using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{//iicio Capa de Datos
    public class DListadoProductos
    {//inicio de clase
        private string _Descripcion;
        private decimal _Precio_kilo;
        private decimal _Precio_unidad;
        private Int32 _Stock;
        private DateTime _Fecha_vencimiento;

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public decimal Precio_kilo
        {
            get
            {
                return _Precio_kilo;
            }

            set
            {
                _Precio_kilo = value;
            }
        }

        public decimal Precio_unidad
        {
            get
            {
                return _Precio_unidad;
            }

            set
            {
                _Precio_unidad = value;
            }
        }

        public int Stock
        {
            get
            {
                return _Stock;
            }

            set
            {
                _Stock = value;
            }
        }

        public DateTime Fecha_vencimiento
        {
            get
            {
                return _Fecha_vencimiento;
            }

            set
            {
                _Fecha_vencimiento = value;
            }
        }

    public DListadoProductos()
        {

        }

    public DListadoProductos(string descripcion, decimal precio_kilo, decimal precio_unidad, int stock, DateTime fecha_vencimianto)
        {
            this.Descripcion = descripcion;
            this.Precio_kilo = precio_kilo;
            this.Precio_unidad = precio_unidad;
            this.Stock = stock;
            this.Fecha_vencimiento = fecha_vencimianto;
        }
    }//fin clase
}//fin Capa de Datos
