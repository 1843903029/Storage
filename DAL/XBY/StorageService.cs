using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.XBY
{
    public class StorageService
    {
        /// <summary>
        /// 查询入库信息
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList RuKuList(int PageSize, int PageIndex, int State)
        {
            StorageEntities ent = new StorageEntities();

            PageList list = new PageList();
            var obj = from p in ent.Storage
                      where p.DataState == true && p.State == State
                      orderby p.StorageID ascending
                      select new
                      {

                          //[StorageID], [StorageType], [SupplierID], [AssociatedNumber], [GoodsCount],
                          //[Summoney], [State], [EmployeeID], [OperationType], [CreationTime], [DataState], [StateText]
                          StorageID = p.StorageID,
                          StorageType = p.StorageType,
                          SupplierID = p.SupplierID,
                          AssociatedNumber = p.AssociatedNumber,
                          GoodsCount = p.GoodsCount,
                          Summoney = p.Summoney,
                          State = p.State,
                          EmployeeID = p.Admin.UserName,
                          OperationType = p.OperationType,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState,
                          StateText = p.StateText
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = obj.Count();
            return list;

        }

        /// <summary>
        /// 查询所有入库信息
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static PageList RuKuList(int PageSize, int PageIndex)
        {
            StorageEntities ent = new StorageEntities();

            PageList list = new PageList();
            var obj = from p in ent.Storage
                      where p.DataState == true
                      orderby p.StorageID ascending
                      select new
                      {

                          //[StorageID], [StorageType], [SupplierID], [AssociatedNumber], [GoodsCount],
                          //[Summoney], [State], [EmployeeID], [OperationType], [CreationTime], [DataState], [StateText]
                          StorageID = p.StorageID,
                          StorageType = p.StorageType,
                          SupplierID = p.SupplierID,
                          AssociatedNumber = p.AssociatedNumber,
                          GoodsCount = p.GoodsCount,
                          Summoney = p.Summoney,
                          State = p.State,
                          EmployeeID = p.Admin.UserName,
                          OperationType = p.OperationType,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState,
                          StateText = p.StateText
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = obj.Count();
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
        public static PageList MoHuRuKuList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            StorageEntities ent = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in ent.Storage
                      where p.DataState == true
                      orderby p.StorageID ascending
                      select new
                      {

                          //[StorageID], [StorageType], [SupplierID], [AssociatedNumber], [GoodsCount],
                          //[Summoney], [State], [EmployeeID], [OperationType], [CreationTime], [DataState], [StateText]
                          StorageID = p.StorageID,
                          StorageType = p.StorageType,
                          SupplierID = p.SupplierID,
                          AssociatedNumber = p.AssociatedNumber,
                          GoodsCount = p.GoodsCount,
                          Summoney = p.Summoney,
                          State = p.State,
                          EmployeeID = p.Admin.UserName,
                          OperationType = p.OperationType,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState,
                          StateText = p.StateText
                      };

            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = obj.Count();


            if (obj.Count() != 0 && !string.IsNullOrEmpty(Danhao))
            {
                obj = obj.Where(p => p.StorageID == Danhao);
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
        /// 通过单号查询入库信息
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public static IQueryable RuKuList(string Danhao)
        {
            StorageEntities ent = new StorageEntities();

            PageList list = new PageList();
            var obj = from p in ent.Storage
                      where p.DataState == true
                      && p.StorageID == Danhao
                      orderby p.StorageID ascending
                      select new
                      {

                          //[StorageID], [StorageType], [SupplierID], [AssociatedNumber], [GoodsCount],
                          //[Summoney], [State], [EmployeeID], [OperationType], [CreationTime], [DataState], [StateText]
                          StorageID = p.StorageID,
                          StorageType = p.StorageType,
                          SupplierID = p.SupplierID,
                          SupplierName = p.Supplier.GysName,
                          lianxiren = p.Supplier.Contacts,
                          dianhua = p.Supplier.Hone,
                          AssociatedNumber = p.AssociatedNumber,
                          GoodsCount = p.GoodsCount,
                          Summoney = p.Summoney,
                          State = p.State,
                          EmployeeID = p.Admin.UserName,
                          OperationType = p.OperationType,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState,
                          StateText = p.StateText,
                          xiangbiao = from pp in p.StorageDetailed
                                      select new
                                      {
                                          //[StoragedetailedID], [StorageIDS], [productID], [Price],
                                          //[StorageNumber], [Summoney], [WarehouseID], [Batch]
                                          StoragedetailedID = pp.StoragedetailedID,
                                          StorageIDS = pp.StorageIDS,
                                          productID = pp.productID,
                                          productName=pp.CpGlinfo.CpXsName,
                                          cptiaoma=pp.CpGlinfo.Cpbh,
                                          cpguige=pp.CpGlinfo.Specification,
                                          cpjiage=pp.CpGlinfo.CpPrice,
                                          Price = pp.Price,
                                          StorageNumber = pp.StorageNumber,
                                          Summoney = pp.Summoney,
                                          WarehouseID = pp.WarehouseID,
                                          kuweiname=pp.LocationManagement.kwName,
                                          Batch = pp.Batch
                                      }
                      };

            return obj;

        }

        /// <summary>
        /// 添加入库单
        /// </summary>
        /// <param name="xiang"></param>
        /// <param name="zhu"></param>
        /// <returns></returns>
        public static int ADDRuku(Storage zhu, List<StorageDetailed> xiang)
        {
            StorageEntities ent = new StorageEntities();
            ent.Storage.Add(zhu);
            ent.StorageDetailed.AddRange(xiang);
            return ent.SaveChanges();

        }



    }
}
