using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.XBY
{
    public class StockRemovalService
    {
        /// <summary>
        /// 出库分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList ChuKuList(int PageIndex, int PageSize, int State)
        {
            StorageEntities ent = new StorageEntities();

            var obj = from p in ent.StockRemoval
                      where p.State == State
                      && p.DataState == true
                      orderby p.StockRemovalID ascending
                      select new
                      {
                          //[StockRemovalID], [StockRemovalType], [SupplierID], [AssociatedNumber], [GoodsCount], [Summoney]
                          //, [State], [EmployeeID], [OperationType], [CreationTime], [DataState], [StateText]
                          StockRemovalID = p.StockRemovalID,
                          StockRemovalType = p.StockRemovalType,
                          SupplierID = p.SupplierID,
                          AssociatedNumber = p.AssociatedNumber,
                          GoodsCount = p.GoodsCount,
                          Summoney = p.Summoney,
                          State = p.State,
                          EmployeeID = p.EmployeeID,
                          OperationType = p.OperationType,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState,
                          StateText = p.StateText,
                      };
            PageList list = new PageList();
            list.DataList = obj;
                //.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();

            return list;

        }



    }
}
