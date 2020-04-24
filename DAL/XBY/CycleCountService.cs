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


        /// <summary>
        /// 盘点分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList PanDianList(int PageIndex, int PageSize)
        {
            StorageEntities ent = new StorageEntities();

            var obj = from p in ent.CycleCount
                      where p.dataState == true
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
        public static PageList MoHuPanDianList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            StorageEntities ent = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in ent.CycleCount
                      where p.dataState == true
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

            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = obj.Count();


            if (obj.Count() != 0 && !string.IsNullOrEmpty(Danhao))
            {
                obj = obj.Where(p => p.CycleCountID == Danhao);
                list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
                rows = obj.Count();
                return list;
            }
            if (obj.Count() != 0 && !string.IsNullOrEmpty(time1) && !string.IsNullOrEmpty(time2))
            {
                obj = obj.Where(p => p.CreationTime > Convert.ToDateTime(time1) && p.CreationTime < Convert.ToDateTime(time2));
                list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
                rows = obj.Count();
                return list;

            }
            return list;


        }

        /// <summary>
        /// 删除盘点单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int ShanChuPanDian(string id)
        {
            StorageEntities ent = new StorageEntities();
            CycleCount obj = ent.CycleCount.Find(id);
            obj.dataState = false;
            return ent.SaveChanges();
        }

    }
}
