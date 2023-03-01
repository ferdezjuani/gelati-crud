using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;
using Entidades;

namespace Negocio
{
    public class NegProducto
    {
        ConProducto DatosObjProducto = new ConProducto();

        public int ABM_Producto(string accion, Producto objProducto)
        {
            return DatosObjProducto.ABM_Producto(accion, objProducto);
        }
        public DataSet listaDeProd(string cual)
        {
            return DatosObjProducto.listaProducto(cual);
        }

        public DataSet buscaDeProd(string cual, string dato)
        {
            return DatosObjProducto.BuscarProducto(cual, dato);
        }
    }
}
