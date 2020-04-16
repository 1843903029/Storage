using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.XBY
{
    public class ReturnsService
    {
        /// <summary>
        /// 退货分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList TuiHuoList(int PageIndex, int PageSize, int State)
        {
            StorageEntities ent = new StorageEntities();

            var obj = from p in ent.Returns
                      where p.State == State
                      && p.DataState == true
                      orderby p.ReturnsID ascending
                      select new
                      {
                          //[ReturnsID], [ReturnsType], [AssociatedNumber], [State], [EmployeeID], [StateText], [CreationTime], [DataState]
                          ReturnsID = p.ReturnsID,
                          ReturnsType = p.ReturnsType,
                          AssociatedNumber = p.AssociatedNumber,
                          State = p.State,
                          tuihuoSum = (from pp in p.ReturnsDetailed select pp.QuestionNum).Sum(),
                          EmployeeID = p.Admin.UserName,
                          StateText = p.StateText,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState
                      };
            PageList list = new PageList();
            list.DataList = obj;
            //.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();

            return list;

        }
    }
}
