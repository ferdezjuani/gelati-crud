using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;
using Entidades;

namespace Negocio
{
    public class NegCategoria
    {
        ConCategoria ObjDatosCategoria = new ConCategoria();
        public List<Categoria> ObtenerCat()
        {
            return ObjDatosCategoria.ObtenerCat();
        }
    }
}
