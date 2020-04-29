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


        /// <summary>
        /// 退货分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList TuiHuoList(int PageIndex, int PageSize)
        {
            StorageEntities ent = new StorageEntities();

            var obj = from p in ent.Returns
                      where p.DataState == true
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
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();

            return list;

        }

        /// <summary>
        /// 模糊查询分页
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="Danhao"></param>
        /// <param name="time1"></param>
        /// <param name="time2"></param>
        /// <returns></returns>
        public static PageList MoHuTuiHuoList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            StorageEntities ent = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in ent.Returns
                      where p.DataState == true
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

            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();


            if (obj.Count() != 0 && !string.IsNullOrEmpty(Danhao))
            {
                obj = obj.Where(p => p.ReturnsID == Danhao);
                list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
                list.PageCount = obj.Count();
                return list;
            }
            if (obj.Count() != 0 && !string.IsNullOrEmpty(time1) && !string.IsNullOrEmpty(time2))
            {
                obj = obj.Where(p => p.CreationTime > Convert.ToDateTime(time1) && p.CreationTime < Convert.ToDateTime(time2));
                list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
                list.PageCount = obj.Count();
                return list;

            }
            return list;


        }

        /// <summary>
        /// 删除退货单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int ShanChuTuiHuo(string id)
        {
            StorageEntities ent = new StorageEntities();
            Returns obj = ent.Returns.Find(id);
            obj.DataState = false;
            return ent.SaveChanges();
        }

    }
}
