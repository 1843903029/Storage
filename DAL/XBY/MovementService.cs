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
                          name = p.Admin.UserName,
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
        /// 所有移库分页查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static PageList YiKuList(int PageIndex, int PageSize)
        {
            StorageEntities ent = new StorageEntities();

            var obj = from p in ent.Movement
                      where  p.DataState == true
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
                          name = p.Admin.UserName,
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
        /// 模糊查询分页
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="Danhao"></param>
        /// <param name="time1"></param>
        /// <param name="time2"></param>
        /// <returns></returns>
        public static PageList MoHuYiKuList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            StorageEntities ent = new StorageEntities();
            PageList list = new PageList();
            var obj = from p in ent.Movement
                      where p.DataState == true
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
                          name = p.Admin.UserName,
                          StateText = p.StateText,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState
                      };

            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = obj.Count();


            if (obj.Count() != 0 && !string.IsNullOrEmpty(Danhao))
            {
                obj = obj.Where(p => p.MovementID == Danhao);
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

        // <summary>
        /// 通过单号查询移库信息
        /// </summary>
        /// <returns></returns>
        public static IQueryable YiKucha(string Danhao)
        {
            StorageEntities ent = new StorageEntities();

            PageList list = new PageList();
            var obj = from p in ent.Movement
                      where p.DataState == true
                      && p.MovementID == Danhao
                      orderby p.MovementID ascending
                      select new
                      {

                          //[StorageID], [StorageType], [SupplierID], [AssociatedNumber], [GoodsCount],
                          //[Summoney], [State], [EmployeeID], [OperationType], [CreationTime], [DataState], [StateText]
                          MovementID = p.MovementID,
                          MovementType = p.MovementType,
                          Associatednumber = p.Associatednumber,
                          MovementCount = p.MovementCount,
                          State = p.State,
                          EmployeeID = p.EmployeeID,
                          name = p.Admin.UserName,
                          StateText = p.StateText,
                          CreationTime = p.CreationTime,
                          DataState = p.DataState,
                          xiangbiao = from pp in p.MovementDetailed
                                      where pp.MovementIDS == Danhao
                                      select new
                                      {
                                          //[MovementDetailedID], [MovementIDS], [ProductID], [Price],
                                          //[MovementNumber], [Batch], [WarehouseID], [WarehouseIDs]
                                          MovementDetailedID = pp.MovementDetailedID,
                                          MovementIDS = pp.MovementIDS,
                                          ProductID = pp.ProductID,
                                          productName = pp.CpGlinfo.CpXsName,
                                          cptiaoma = pp.CpGlinfo.Cpbh,
                                          cpguige = pp.CpGlinfo.Specification,
                                          cpjiage = pp.CpGlinfo.CpPrice,
                                          cpid=pp.CpGlinfo.CpID,

                                          Price = pp.Price,
                                          MovementNumber = pp.MovementNumber,
                                          WarehouseID = pp.WarehouseID,
                                          Batch = pp.Batch,
                                          kuweiname = pp.LocationManagement.kwName,
                                          WarehouseIDs = pp.WarehouseIDs
                                      }
                      };

            return obj;

        }


        /// <summary>
        /// 删除移库单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int ShanChuYiKu(string id)
        {
            StorageEntities ent = new StorageEntities();
            Movement obj = ent.Movement.Find(id);
            obj.DataState = false;
            return ent.SaveChanges();
        }

    }
}
