using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Conexion
{
    public class ConCategoria : Conexion
    {
        public List<Categoria> ObtenerCat()
        {
            List<Categoria> lista = new List<Categoria>();
            string orden = "SELECT IdCat, catProd From CATEGORIA";
            OleDbCommand cmd = new OleDbCommand(orden, con);
            OleDbDataReader dr;
            try
            {
                AbrirConexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Categoria cat = new Categoria();
                    cat.p_idCat = dr.GetInt32(0);
                    cat.p_CatProd = dr.GetString(1);
                    lista.Add(cat);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar.", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return lista;
        }
    }
}
