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
    
    public partial class plm_vwProductsByClientRegisterandBarcode
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<byte> TypeId { get; set; }
        public int ClientId { get; set; }
        public string RegisterSanitary { get; set; }
        public Nullable<int> BarCodeId { get; set; }
        public string BarCode { get; set; }
        public Nullable<int> PharmaFormId { get; set; }
        public string PharmaForm { get; set; }
        public Nullable<int> ActiveSubstanceId { get; set; }
        public string ActiveSubstance { get; set; }
        public Nullable<int> PresentationId { get; set; }
        public string Description { get; set; }
        public int PP { get; set; }
        public int MP { get; set; }
        public int SIDEF { get; set; }
    }
}
