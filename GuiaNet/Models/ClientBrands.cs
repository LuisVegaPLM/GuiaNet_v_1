//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuiaNet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientBrands
    {
        public Nullable<byte> ClientBrandTypeId { get; set; }
        public bool Active { get; set; }
        public string Page { get; set; }
        public string ExpireDescription { get; set; }
        public int EditionId { get; set; }
        public int ClientId { get; set; }
        public int BrandId { get; set; }
        public byte ClientTypeId { get; set; }
    
        public virtual Brands Brands { get; set; }
        public virtual ClientBrandTypes ClientBrandTypes { get; set; }
        public virtual EditionClients EditionClients { get; set; }
    }
}
