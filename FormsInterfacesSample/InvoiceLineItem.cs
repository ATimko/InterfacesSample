//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormsInterfacesSample
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceLineItem
    {
        public int InvoiceID { get; set; }
        public short InvoiceSequence { get; set; }
        public int AccountNo { get; set; }
        public decimal InvoiceLineItemAmount { get; set; }
        public string InvoiceLineItemDescription { get; set; }
    
        public virtual GLAccount GLAccount { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
