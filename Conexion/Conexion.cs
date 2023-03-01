using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class Conexion
    {
        //Parámetros para manejar la conexión a la base de datos
        protected OleDbConnection con;
        public OleDbDataReader reader;
        protected string cadena = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Juani\abm\DbHelado2002.mdb";


        public Conexion()
        {
            con = new OleDbConnection(cadena);
        }

        //Métodos para manejar la Base de datos
        public void AbrirConexion()
        {
            try
            {
                if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error\n\n", e);
            }
        }
        public void CerrarConexion()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error\n\n", e);
            }
        }
    }
}
