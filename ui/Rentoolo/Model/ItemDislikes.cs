//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemDislikes
    {
        public long Id { get; set; }
        public int ObjectType { get; set; }
        public long ObjectId { get; set; }
        public System.Guid UserId { get; set; }
        public System.DateTime Date { get; set; }
    }
}
