using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Conexion
{
    public class ConProducto : Conexion
    {
        public int ABM_Producto(string accion, Producto ObjProducto)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "INSERT INTO PRODUCTO (Producto, idCat, Fecha, Cant, Descripcion) VALUES ('" + ObjProducto.p_prod + "', " + ObjProducto.p_idCat + ", '" + ObjProducto.p_fecha + "', " + ObjProducto.p_cant + ", '" + ObjProducto.p_desc + "');";
            if (accion == "Borrar")
                orden = "DELETE FROM PRODUCTO WHERE(idProd = " + ObjProducto.p_idProd + ")";
            if (accion == "Editar")
                orden = "UPDATE PRODUCTO SET Producto = '" + ObjProducto.p_prod + "', idCat = " + ObjProducto.p_idCat + ", Fecha = '" + ObjProducto.p_fecha + "', Cant = " + ObjProducto.p_cant + ", Descripcion = '" + ObjProducto.p_desc + "' WHERE idProd= " + ObjProducto.p_idProd + ";";

            OleDbCommand cmd = new OleDbCommand(orden, con);
            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de Agregar, Borrar o Modificar", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listaProducto(string cual)
        {
            string orden = string.Empty;

            if (cual != "Cargar")
                orden = "SELECT PRODUCTO.idProd, PRODUCTO.Producto, PRODUCTO.idCat, CATEGORIA.CatProd, PRODUCTO.Fecha, PRODUCTO.Cant, PRODUCTO.Descripcion FROM CATEGORIA INNER JOIN PRODUCTO ON CATEGORIA.idCat = PRODUCTO.idCat WHERE idProd = " + int.Parse(cual) + ";";
            else
                orden = "SELECT PRODUCTO.idProd, PRODUCTO.Producto, PRODUCTO.idCat, CATEGORIA.CatProd, PRODUCTO.Fecha, PRODUCTO.Cant, PRODUCTO.Descripcion FROM CATEGORIA INNER JOIN PRODUCTO ON CATEGORIA.idCat = PRODUCTO.idCat;";

            OleDbCommand cmd = new OleDbCommand(orden, con);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();

            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }

        public DataSet BuscarProducto(string cual, string dato)
        {
            string orden = string.Empty;

            if (cual != "Buscar")
                orden = "SELECT PRODUCTO.idProd, PRODUCTO.Producto, PRODUCTO.idCat, CATEGORIA.CatProd, PRODUCTO.Fecha, PRODUCTO.Cant, PRODUCTO.Descripcion FROM CATEGORIA INNER JOIN PRODUCTO ON CATEGORIA.idCat = PRODUCTO.idCat WHERE idProd = " + int.Parse(cual) + ";";
            else
                orden = "SELECT PRODUCTO.idProd, PRODUCTO.Producto, PRODUCTO.idCat, CATEGORIA.CatProd, PRODUCTO.Fecha, PRODUCTO.Cant, PRODUCTO.Descripcion FROM CATEGORIA INNER JOIN PRODUCTO ON CATEGORIA.idCat = PRODUCTO.idCat WHERE PRODUCTO.Producto LIKE ('%" + dato +"%');";

            OleDbCommand cmd = new OleDbCommand(orden, con);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();

            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
