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
    
    public partial class EditionSpecialityClientAdvers
    {
        public int EditionId { get; set; }
        public int ClientId { get; set; }
        public int SpecialityId { get; set; }
        public int AdvertId { get; set; }
        public byte ClientTypeId { get; set; }
        public Nullable<byte> Active { get; set; }
    
        public virtual Advertisements Advertisements { get; set; }
        public virtual EditionClientSpecialities EditionClientSpecialities { get; set; }
    }
}
