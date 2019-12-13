using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CDatos;
using System.ComponentModel;
using CNegocio;
using Entity;

namespace CNegocio
{
    public class Business
    {
        ConexionDB BsProd = new ConexionDB();


        public List<FASV1_GetAllProducts_Result> ObtenerProductos()
        {
            return BsProd.ListarProductos();
        }

        public List<FASV_FilterById_Result> FiltroId(int id)
        {
            return BsProd.FiltroId(id);
        }

        public List<FASV1_FilterByTitle_Result> FiltroTitle(string nombre)
        {
            return BsProd.FiltroTitle(nombre);
        }

        public  void EliminarId(int id)
        {
            BsProd.DeleteLogic(id);
        }
    }
}
