using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CDatos
{
    public class ConexionDB
    {
        DataProductsEntities fff = new DataProductsEntities();

        public List<FASV1_GetAllProducts_Result> ListarProductos()
        {//ShowAllProducts 
#region
            try
            {
                using (DataProductsEntities dbProd = new DataProductsEntities()) //Aqui ya se ahce la conexion 
                {
#region
                    //List<ProductosDatos> QueryAll = (from n in dbCntexto.Products
                    //                                 select new ProductosDatos
                    //                                 {
                    //                                     Id = n.Id,
                    //                                     IdType = n.IdType,
                    //                                     IdColor = n.IdColor,
                    //                                     IdBrand = n.IdBrand,
                    //                                     IdProvider = n.IdProvider,
                    //                                     IdCatalog = n.IdCatalog,
                    //                                     Title = n.Title,
                    //                                     Nombre = n.Nombre,
                    //                                     Description = n.Description,
                    //                                     Observations = n.Observations,
                    //                                     PriceDistributor = n.PriceDistributor,
                    //                                     PriceClient = n.PriceClient,
                    //                                     PriceMember = n.PriceMember,
                    //                                     IsEnabled = n.IsEnabled,
                    //                                     Keywords = n.Keywords,
                    //                                     DateUpdate = n.DateUpdate,

                    //                                 }).ToList();
                    #endregion //LINQ 
                    List<FASV1_GetAllProducts_Result> listProducts = new List<FASV1_GetAllProducts_Result>();
                    foreach (var n in fff.Products.ToList())
                    {
                        FASV1_GetAllProducts_Result m = new FASV1_GetAllProducts_Result();
                        {
                            m.Id = n.Id;
                            m.IdType = n.IdType;
                            m.IdColor = n.IdColor;
                            m.IdBrand = n.IdBrand;
                            m.IdProvider = n.IdProvider;
                            m.IdCatalog = n.IdCatalog;
                            m.Title = n.Title;
                            m.Nombre = n.Nombre;
                            m.Description = n.Description;
                            m.Observations = n.Observations;
                            m.PriceDistributor = n.PriceDistributor;
                            m.PriceClient = n.PriceClient;
                            m.PriceMember = n.PriceMember;
                            m.IsEnabled = n.IsEnabled;
                            m.Keywords = n.Keywords;
                            m.DateUpdate = n.DateUpdate;
                            listProducts.Add(m);
                        }
                }
                return listProducts;
                }               
            }
            catch (Exception)
            {
                throw;
            }          
#endregion
        }

        public List<FASV_FilterById_Result> FiltroId(int Id)
        {//FilterById
#region
            try
            {
                List<FASV_FilterById_Result> listTitle = new List<FASV_FilterById_Result>();
                foreach (var n in fff.FASV_FilterById(Id))
                {
                    if (Id == n.Id)
                    {
                        FASV_FilterById_Result m = new FASV_FilterById_Result();
                        {
                            m.Id = n.Id;
                            m.IdType = n.IdType;
                            m.IdColor = n.IdColor;
                            m.IdBrand = n.IdBrand;
                            m.IdProvider = n.IdProvider;
                            m.IdCatalog = n.IdCatalog;
                            m.Title = n.Title;
                            m.Nombre = n.Nombre;
                            m.Description = n.Description;
                            m.Observations = n.Observations;
                            m.PriceDistributor = n.PriceDistributor;
                            m.PriceClient = n.PriceClient;
                            m.PriceMember = n.PriceMember;
                            m.IsEnabled = n.IsEnabled;
                            m.Keywords = n.Keywords;
                            m.DateUpdate = n.DateUpdate;
                            listTitle.Add(m);
                        }
                    }
                }
                return listTitle;
            }
            catch (Exception)
            {

                throw;
            }
#endregion
        }

        public List<FASV1_FilterByTitle_Result> FiltroTitle(string Title)
        {//FilterByTitle
#region
            try
            {
                List<FASV1_FilterByTitle_Result> listTitle = new List<FASV1_FilterByTitle_Result>();
                foreach (var n in fff.FASV1_FilterByTitle(Title))
                {
                    //Mostrar registros:

                    //var charrray = n.Title.ToCharArray();
                    //Boolean isContained = false;
                    //foreach (var item in charrray)
                    //{
                    //    if (Title.Contains((item)))
                    //    {

                    //        isContained = true;   
                    //    }
                    //}

                        FASV1_FilterByTitle_Result m = new FASV1_FilterByTitle_Result();
                        {
                            m.Id = n.Id;
                            m.IdType = n.IdType;
                            m.IdColor = n.IdColor;
                            m.IdBrand = n.IdBrand;
                            m.IdProvider = n.IdProvider;
                            m.IdCatalog = n.IdCatalog;
                            m.Title = n.Title;
                            m.Nombre = n.Nombre;
                            m.Description = n.Description;
                            m.Observations = n.Observations;
                            m.PriceDistributor = n.PriceDistributor;
                            m.PriceClient = n.PriceClient;
                            m.PriceMember = n.PriceMember;
                            m.IsEnabled = n.IsEnabled;
                            m.Keywords = n.Keywords;
                            m.DateUpdate = n.DateUpdate;
                            listTitle.Add(m);
                    }
                }
                return listTitle;
            }
            catch (Exception)
            {

                throw;
            }
            #endregion
        }

        public void  DeleteLogic(int id)
        {
            fff.FASV_DeleteLogic(id);
        }





    }
}
