//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public int IdComent { get; set; }
        public int IdProduct { get; set; }
        public int IdRating { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public System.DateTime DateCommnet { get; set; }
    
        public virtual CatRatings CatRatings { get; set; }
        public virtual Products Products { get; set; }
    }
}
