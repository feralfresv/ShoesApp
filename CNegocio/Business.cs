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
        public BindingList<ProductosDatos> ListarProductos()
        {

            try
            {
                using (DataProductsEntities dbCntexto = new DataProductsEntities())
                {
                    List<ProductosDatos> QueryAll = (from n in dbCntexto.Products
                                                     select new ProductosDatos
                                                     {
                                                         Id = n.Id,
                                                         IdType = n.IdType,
                                                         IdColor = n.IdColor,
                                                         IdBrand = n.IdBrand,
                                                         IdProvider = n.IdProvider,
                                                         IdCatalog = n.IdCatalog,
                                                         Title = n.Title,
                                                         Nombre = n.Nombre,
                                                         Description = n.Description,
                                                         Observations = n.Observations,
                                                         PriceDistributor = n.PriceDistributor,
                                                         PriceClient = n.PriceClient,
                                                         PriceMember = n.PriceMember,
                                                         IsEnabled = n.IsEnabled,
                                                         Keywords = n.Keywords,
                                                         //DateUpdate = n.DateUpdate,

                                                     }).ToList();





                    BindingList<ProductosDatos> Resultado = new BindingList<ProductosDatos>(QueryAll);

                    return Resultado;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
