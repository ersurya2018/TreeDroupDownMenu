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
    
    public partial class State
    {
        public State()
        {
            this.Cities = new HashSet<City>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> StateCounty_Id { get; set; }
    
        public virtual ICollection<City> Cities { get; set; }
        public virtual country country { get; set; }
    }
}
