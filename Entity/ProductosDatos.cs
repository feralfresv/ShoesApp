﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductosDatos
    {
        public int Id { get; set; }
        public Nullable<int> IdType { get; set; }
        public Nullable<int> IdColor { get; set; }
        public Nullable<int> IdBrand { get; set; }
        public Nullable<int> IdProvider { get; set; }
        public int IdCatalog { get; set; }
        public string Title { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public string Observations { get; set; }
        public Nullable<decimal> PriceDistributor { get; set; }
        public decimal PriceClient { get; set; }
        public decimal PriceMember { get; set; }
        public bool IsEnabled { get; set; }
        public string Keywords { get; set; }
        public System.DateTime DateUpdate { get; set; }
    }

    public partial class ChangesOnProduct
    {
        public int IdLog { get; set; }
        public int IdProduct { get; set; }
        public byte ActionMade { get; set; }
    }
}
