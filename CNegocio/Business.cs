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
        public List<FASV1_GetAllProducts_Result> ObtenerProductos2()
        {
            return BsProd.ListarProductos();
        }

        public List<FASV1_AllColor_Result> Allcolor()
        {
            return BsProd.AllColor();

        }


        public List<FASV1_FilterById_Result> FiltroId(int aId)
        {
            return BsProd.FiltroId(aId);
        }

        public List<FASV1_FilterByTitle_Result> FiltroTitle(string aNombre)
        {
            return BsProd.FiltroTitle(aNombre);
        }

        public void EliminarId(int aId)
        {
            BsProd.DeleteLogic(aId);
        }

        public void InsertarPro(string aTitle, string aDescription, int aPrice, int aColor)
        {
            BsProd.InsertProd(aTitle, aDescription, aPrice, aColor);
        }

        public void ModifyProduct(int aId, string aTitle, string aDescripcion, Int64 aPriceClient, int aColor)
        {
            BsProd.ModifyProduc(aId, aTitle, aDescripcion, aPriceClient, aColor);
        }


    }
}
