//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TreeFormMenu.DB_Connect_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> CityState_Id { get; set; }
    
        public virtual State State { get; set; }
    }
}
