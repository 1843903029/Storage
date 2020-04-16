using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.XBY
{
    public class BreakageService
    {
        /// <summary>
        /// 报损分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList BaoSunList(int PageIndex, int PageSize, int State)
        {
            StorageEntities ent = new StorageEntities();

            var obj = from p in ent.Breakage
                      where p.State == State
                      && p.DataState == true
                      orderby p.BreakageID ascending
                      select new
                      {
                          //[BreakageID], [BreakageType], [AssociatedNumber], [BreakageCount],
                          //[State], [EmployeeID], [operationType], [CreationTime], [DataState], [StateText]
                          BreakageID = p.BreakageID,
                          BreakageType = p.BreakageType,
                          AssociatedNumber = p.AssociatedNumber,
                          BreakageCount = p.BreakageCount,
                          State = p.State,
                          EmployeeID = p.Admin.UserName,
                          operationType = p.operationType,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState,
                          StateText = p.StateText
                      };
            PageList list = new PageList();
            list.DataList = obj;
            //.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();

            return list;

        }
    }
}
