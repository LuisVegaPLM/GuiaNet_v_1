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
    
    public partial class Editions
    {
        public Editions()
        {
            this.EditionClientProducts = new HashSet<EditionClientProducts>();
            this.EditionClients = new HashSet<EditionClients>();
            this.ParticipantProducts = new HashSet<ParticipantProducts>();
            this.EditionClientMedicalProducts = new HashSet<EditionClientMedicalProducts>();
            this.EditionClientCategories = new HashSet<EditionClientCategories>();
            this.EditionClientHeterogeneousCategories = new HashSet<EditionClientHeterogeneousCategories>();
            this.ClientHeterogeneousCategories = new HashSet<ClientHeterogeneousCategories>();
            this.EditionAttributes = new HashSet<EditionAttributes>();
            this.MentionatedProducts = new HashSet<MentionatedProducts>();
        }
    
        public int EditionId { get; set; }
        public int NumberEdition { get; set; }
        public string ISBN { get; set; }
        public string BarCode { get; set; }
        public bool Active { get; set; }
        public byte CountryId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public int BookId { get; set; }
        public string EditionCode { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Countries Countries { get; set; }
        public virtual Editions Editions1 { get; set; }
        public virtual Editions Editions2 { get; set; }
        public virtual ICollection<EditionClientProducts> EditionClientProducts { get; set; }
        public virtual ICollection<EditionClients> EditionClients { get; set; }
        public virtual ICollection<ParticipantProducts> ParticipantProducts { get; set; }
        public virtual ICollection<EditionClientMedicalProducts> EditionClientMedicalProducts { get; set; }
        public virtual ICollection<EditionClientCategories> EditionClientCategories { get; set; }
        public virtual ICollection<EditionClientHeterogeneousCategories> EditionClientHeterogeneousCategories { get; set; }
        public virtual ICollection<ClientHeterogeneousCategories> ClientHeterogeneousCategories { get; set; }
        public virtual ICollection<EditionAttributes> EditionAttributes { get; set; }
        public virtual ICollection<MentionatedProducts> MentionatedProducts { get; set; }
    }
}