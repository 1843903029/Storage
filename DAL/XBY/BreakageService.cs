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
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();

            return list;

        }


        /// <summary>
        /// 所有报损分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList SuoYouBaoSunList(int PageIndex, int PageSize)
        {
            StorageEntities ent = new StorageEntities();

            var obj = from p in ent.Breakage
                      where p.DataState == true
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


        /// <summary>
        /// 模糊查询分页
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="Danhao"></param>
        /// <param name="time1"></param>
        /// <param name="time2"></param>
        /// <returns></returns>
        public static PageList MoHuBaoSunList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            StorageEntities ent = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in ent.Breakage
                      where p.DataState == true
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

            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = obj.Count();


            if (obj.Count() != 0 && !string.IsNullOrEmpty(Danhao))
            {
                obj = obj.Where(p => p.BreakageID == Danhao);
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
        /// 通过单号查询报损信息
        /// </summary>
        /// <returns></returns>
        public static IQueryable Baoxuncha(string Danhao)
        {
            StorageEntities ent = new StorageEntities();

            PageList list = new PageList();
            var obj = from p in ent.Breakage
                      where p.DataState == true
                      && p.BreakageID == Danhao
                      orderby p.BreakageID ascending
                      select new
                      {

                          //[StorageID], [StorageType], [SupplierID], [AssociatedNumber], [GoodsCount],
                          //[Summoney], [State], [EmployeeID], [OperationType], [CreationTime], [DataState], [StateText]
                          BreakageID = p.BreakageID,
                          BreakageType = p.BreakageType,
                          AssociatedNumber = p.AssociatedNumber,
                          BreakageCount = p.BreakageCount,
                          State = p.State,
                          EmployeeID = p.Admin.UserName,
                          operationType = p.operationType,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState,
                          StateText = p.StateText,
                          xiangbiao = from pp in p.BreakageDetailed
                                      where pp.BreakageIDS==Danhao
                                      select new
                                      {
                                          //[BreakageDetailedID], [BreakageIDS], 
                                          //[ProductID], [Price], [BreakageNumber], [Batch], [WarehouseID]
                                          BreakageDetailedID = pp.BreakageDetailedID,
                                          BreakageIDS = pp.BreakageIDS,
                                          ProductID = pp.ProductID,
                                          productName = pp.CpGlinfo.CpXsName,
                                          cptiaoma = pp.CpGlinfo.Cpbh,
                                          cpguige = pp.CpGlinfo.Specification,
                                          cpjiage = pp.CpGlinfo.CpPrice,
                                          Price = pp.Price,
                                          BreakageNumber = pp.BreakageNumber,
                                          Summoney = pp.BreakageNumber,
                                          Batch = pp.Batch,
                                          kuweiname = pp.LocationManagement.kwName,
                                          WarehouseID = pp.WarehouseID
                                      }
                      };

            return obj;

        }


        /// <summary>
        /// 删除报损单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int ShanChuBaoSun(string id)
        {
            StorageEntities ent = new StorageEntities();
            Breakage obj = ent.Breakage.Find(id);
            obj.DataState = false;
            return ent.SaveChanges();
        }

    }
}
