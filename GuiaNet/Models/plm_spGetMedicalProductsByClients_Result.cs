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
    
    public partial class plm_spGetMedicalProductsByClients_Result
    {
        public int ClientId { get; set; }
        public string CompanyName { get; set; }
        public string ShortName { get; set; }
        public byte CountryId { get; set; }
        public string CountryName { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string ProductName { get; set; }
        public Nullable<byte> TypeId { get; set; }
        public int PharmaFormId { get; set; }
        public string PharmaForm { get; set; }
        public int ActiveSubstanceId { get; set; }
        public string ActiveSubstance { get; set; }
        public int PresentationId { get; set; }
        public string Description { get; set; }
        public int EditionId { get; set; }
        public int NumberEdition { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }
    }
}
