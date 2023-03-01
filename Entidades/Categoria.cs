using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        //CONSTRUCTORES
        public Categoria(int c_idCat, string c_CatProd)
        {
            idCat = c_idCat;
            CatProd = c_CatProd;
        }

        public Categoria(string c_CatProd)
        {
            CatProd = c_CatProd;
        }

        public Categoria()
        { }

        //ATRIBUTOS
        private int idCat;
        private string CatProd;

        //PROPIEDADES
        public int p_idCat
        { get { return idCat; } set { idCat = value; } }
        public string p_CatProd
        { get { return CatProd; } set { CatProd = value; } }

    }
}
