using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.XBY
{
    public class MovementService
    {
        /// <summary>
        /// 移库分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList YiKuList(int PageIndex, int PageSize, int State)
        {
            StorageEntities ent = new StorageEntities();

            var obj = from p in ent.Movement
                      where p.State == State
                      && p.DataState == true
                      orderby p.MovementID ascending
                      select new
                      {
                          //[MovementID], [MovementType], [Associatednumber], [MovementCount], 
                          //[State], [EmployeeID], [StateText], [CreationTime], [DataState]
                          MovementID = p.MovementID,
                          MovementType = p.MovementType,
                          Associatednumber = p.Associatednumber,
                          MovementCount = p.MovementCount,
                          State = p.State,
                          EmployeeID = p.EmployeeID,
                          name=p.Admin.UserName,
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
