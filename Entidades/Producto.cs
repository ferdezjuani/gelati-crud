using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        //CONSTRUCTORES
        public Producto(string c_prod) 
        {
            prod = c_prod;
        }
        public Producto(int c_idProd, string c_prod, int c_idCat, DateTime c_fecha, int c_cant, string c_desc)
        {
            idProd = c_idProd;
            prod = c_prod;
            idCat = c_idCat;
            fecha = c_fecha;
            cant = c_cant;
            desc = c_desc;
        }
        public Producto(string c_prod, int c_idCat, DateTime c_fecha, int c_cant, string c_desc)
        {
            prod = c_prod;
            idCat = c_idCat;
            fecha = c_fecha;
            cant = c_cant;
            desc = c_desc;
        }

        //ATRIBUTOS
        private int idProd;
        private string prod;
        private int idCat;
        private DateTime fecha;
        private int cant;
        private string desc;

        //PROPIEDADES
        public int p_idProd
        { get { return idProd; } set {  idProd = value; } }
        public string p_prod
        { get { return prod; } set { prod = value; } }
        public int p_idCat
        { get { return idCat; } set { idCat = value; } }
        public DateTime p_fecha
        { get { return fecha; } set {  fecha = value; } }
        public int p_cant
        { get {  return cant; } set {  cant = value; } }
        public string p_desc
        { get {  return desc; } set { desc = value; } }
    }
}
