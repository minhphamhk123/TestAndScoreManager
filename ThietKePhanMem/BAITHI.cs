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
    
    public partial class BAITHI
    {
        public string sbd { get; set; }
        public string maMH { get; set; }
        public Nullable<double> diemthi { get; set; }
    
        public virtual MONTHI MONTHI { get; set; }
        public virtual THISINH THISINH { get; set; }
    }
}
