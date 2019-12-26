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
using System.Xml.Serialization;
using System.IO;

namespace CNegocio
{
    public class Business
    {
        ConexionDB BsProd = new ConexionDB();


        public List<FASV1_GetAllProducts_Result> ObtenerProductos()
        {
            return BsProd.ListarProductos();
        }

        public List<FASV1_GetAllProducts_Result> ObtenerProductos2()//Refrescar2
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

        public void InsertarPro(string aTitle, string aDescription, int aPrice, int aColor, DateTime aDate)
        {
            BsProd.InsertProd(aTitle, aDescription, aPrice, aColor, aDate);
        }

        public void ModifyProduct(int aId, string aTitle, string aDescripcion, int aPriceClient, int aColor)
        {
            BsProd.ModifyProduc(aId, aTitle, aDescripcion, aPriceClient, aColor);
        }

        public List<FASV1_GetChangesOnProduct_Desc_Result> GetCambios()
        {
            return BsProd.GetCambiosPro();
        }

        public void SerializeToXml<T>(T obj, string fileName)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            //Create a FileStream object connected to the target file 
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fileStream, obj);
            fileStream.Close();
        }

        public T DeserializeFromXml<T>(string xml)
        {
            T result;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }
    }
}
