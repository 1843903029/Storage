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
    
    public partial class StockRemoval
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockRemoval()
        {
            this.StockRemovalDetailed = new HashSet<StockRemovalDetailed>();
        }
    
        public string StockRemovalID { get; set; }
        public string StockRemovalType { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public string AssociatedNumber { get; set; }
        public Nullable<int> GoodsCount { get; set; }
        public Nullable<decimal> Summoney { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string OperationType { get; set; }
        public Nullable<System.DateTime> CreationTime { get; set; }
        public Nullable<bool> DataState { get; set; }
        public string StateText { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockRemovalDetailed> StockRemovalDetailed { get; set; }
        public virtual Client Client { get; set; }
    }
}
