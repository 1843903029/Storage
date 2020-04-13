//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Admin()
        {
            this.Authority = new HashSet<Authority>();
            this.Breakage = new HashSet<Breakage>();
            this.CpLbinfo = new HashSet<CpLbinfo>();
            this.CycleCount = new HashSet<CycleCount>();
            this.Movement = new HashSet<Movement>();
            this.Returns = new HashSet<Returns>();
            this.StockRemoval = new HashSet<StockRemoval>();
            this.Storage = new HashSet<Storage>();
        }
    
        public int AdminID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string UserCode { get; set; }
        public string RealName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateIp { get; set; }
        public string CreateUser { get; set; }
        public Nullable<int> LoginCount { get; set; }
        public string Picture { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> Status_id { get; set; }
        public Nullable<int> DepartNum_id { get; set; }
        public Nullable<int> RoleNum { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        public virtual SysDepart SysDepart { get; set; }
        public virtual SysRole SysRole { get; set; }
        public virtual SysStatus SysStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Authority> Authority { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Breakage> Breakage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CpLbinfo> CpLbinfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CycleCount> CycleCount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movement> Movement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Returns> Returns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockRemoval> StockRemoval { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Storage> Storage { get; set; }
    }
}