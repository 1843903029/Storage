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
    
    public partial class ReturnsDetailed
    {
        public int ReturnsdetailedID { get; set; }
        public string ReturnsIDS { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> WarehouseID { get; set; }
        public Nullable<int> CheckNum { get; set; }
        public Nullable<int> QuestionNum { get; set; }
        public Nullable<decimal> Batch { get; set; }
    
        public virtual CpGlinfo CpGlinfo { get; set; }
        public virtual LocationManagement LocationManagement { get; set; }
        public virtual Returns Returns { get; set; }
    }
}