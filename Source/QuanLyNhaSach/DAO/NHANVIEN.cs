//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        public NHANVIEN()
        {
            this.HOADONs = new HashSet<HOADON>();
            this.PHIEUTHUNOes = new HashSet<PHIEUTHUNO>();
            this.TAIKHOANs = new HashSet<TAIKHOAN>();
            this.PHIEUCHIs = new HashSet<PHIEUCHI>();
        }
    
        public string MANV { get; set; }
        public string HOTEN { get; set; }
        public string SDT { get; set; }
        public string DIACHI { get; set; }
        public string EMAIL { get; set; }
        public string MACV { get; set; }
    
        public virtual ICollection<HOADON> HOADONs { get; set; }
        public virtual ICollection<PHIEUTHUNO> PHIEUTHUNOes { get; set; }
        public virtual CHUCVU CHUCVU { get; set; }
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual ICollection<PHIEUCHI> PHIEUCHIs { get; set; }
    }
}