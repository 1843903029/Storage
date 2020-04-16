using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.XBY
{
    public class CycleCountService
    {
        /// <summary>
        /// 盘点分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList PanDianList(int PageIndex, int PageSize, int State)
        {
            StorageEntities ent = new StorageEntities();

            var obj = from p in ent.CycleCount
                      where p.State == State
                      && p.dataState == true
                      orderby p.CycleCountID ascending
                      select new
                      {
                          //[CycleCountID], [CycleCountType], [AssociatedNumber], [State], [StateText], [EmployeeID], [CreationTime], [dataState]
                          CycleCountID = p.CycleCountID,
                          CycleCountType = p.CycleCountType,
                          AssociatedNumber = p.AssociatedNumber,
                          State = p.State,
                          StateText = p.StateText,
                          UserName = p.Admin.UserName,
                          CreationTime = p.CreationTime,
                          dataState = p.dataState
                      };
            PageList list = new PageList();
            list.DataList = obj;
            //.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();

            return list;

        }
    }
}
