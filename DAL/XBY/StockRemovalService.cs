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
                          EmployeeID = p.Admin.UserName,
                          OperationType = p.OperationType,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState,
                          StateText = p.StateText,
                      };
            PageList list = new PageList();
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            list.PageCount = obj.Count();

            return list;

        }


        /// <summary>
        /// 所有出库分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList ChuKuList(int PageIndex, int PageSize)
        {
            StorageEntities ent = new StorageEntities();

            var obj = from p in ent.StockRemoval
                      where p.DataState == true
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
                          EmployeeID = p.Admin.UserName,
                          OperationType = p.OperationType,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState,
                          StateText = p.StateText,
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
        public static PageList MoHuChuKuList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            StorageEntities ent = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in ent.StockRemoval
                      where p.DataState == true
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
                          EmployeeID = p.Admin.UserName,
                          OperationType = p.OperationType,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState,
                          StateText = p.StateText,
                      };

            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = obj.Count();


            if (obj.Count() != 0 && !string.IsNullOrEmpty(Danhao))
            {
                obj = obj.Where(p => p.StockRemovalID == Danhao);
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
        /// 通过单号查询CHU库信息
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static IQueryable ChuKuList(string Danhao)
        {
            StorageEntities ent = new StorageEntities();

            PageList list = new PageList();
            var obj = from p in ent.StockRemoval
                      where p.DataState == true
                      && p.StockRemovalID == Danhao
                      orderby p.StockRemovalID ascending
                      select new
                      {

                          //[StorageID], [StorageType], [SupplierID], [AssociatedNumber], [GoodsCount],
                          //[Summoney], [State], [EmployeeID], [OperationType], [CreationTime], [DataState], [StateText]
                          StockRemovalID = p.StockRemovalID,
                          StockRemovalType = p.StockRemovalType,
                          SupplierID = p.SupplierID,
                          AssociatedNumber = p.AssociatedNumber,
                          GoodsCount = p.GoodsCount,
                          Summoney = p.Summoney,
                          State = p.State,
                          EmployeeID = p.Admin.UserName,
                          OperationType = p.OperationType,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState,
                          StateText = p.StateText,
                          xiangbiao = from pp in p.StockRemovalDetailed
                                      select new
                                      {
                                          //[StockRemovalDetailedID], [StockRemovalIDS], [ProductID], 
                                          //[Price], [StockRemovalNumber], [Summoney], [WarehouseID], [Batch]
                                          StoragedetailedID = pp.StockRemovalDetailedID,
                                          StorageIDS = pp.StockRemovalIDS,
                                          productID = pp.ProductID,
                                          Price = pp.Price,
                                          StockRemovalNumber = pp.StockRemovalNumber,
                                          Summoney = pp.Summoney,
                                          WarehouseID = pp.WarehouseID,
                                          Batch = pp.Batch,
                                          
                                      }
                      };

            return obj;

        }


    }
}
