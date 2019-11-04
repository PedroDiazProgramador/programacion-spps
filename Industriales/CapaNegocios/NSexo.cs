using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NSexo
    {//inicio de clase
        //metodo insertar
        public static string Insertar(int id_sexo, string sexo)
        {
            DSexo Obj = new DSexo();
            Obj.Id_sexo = id_sexo;
            Obj.Sexo = sexo;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int id_sexo, string sexo)
        {
            DSexo Obj = new DSexo();
            Obj.Id_sexo = id_sexo;
            Obj.Sexo = sexo;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int id_sexo)
        {
            DSexo Obj = new DSexo();
            Obj.Id_sexo = id_sexo;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()
        {
            DSexo Obj = new DSexo();
            return Obj.Mostrar();
        }
    }//finn de clase
}
