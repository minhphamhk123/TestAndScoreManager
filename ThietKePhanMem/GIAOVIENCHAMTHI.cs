//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThietKePhanMem
{
    using System;
    using System.Collections.Generic;
    
    public partial class GIAOVIENCHAMTHI
    {
        public string maGV { get; set; }
        public string tenGV { get; set; }
        public string donvi { get; set; }
        public string chuvu { get; set; }
        public string maMH { get; set; }
    
        public virtual MONTHI MONTHI { get; set; }
    }
}
