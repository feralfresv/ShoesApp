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
    
    public partial class CatSizes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatSizes()
        {
            this.SizeForProduct = new HashSet<SizeForProduct>();
        }
    
        public int IdSize { get; set; }
        public int IdType { get; set; }
        public string Code { get; set; }
        public string Unity { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SizeForProduct> SizeForProduct { get; set; }
        public virtual CatTypeProduct CatTypeProduct { get; set; }
    }
}
