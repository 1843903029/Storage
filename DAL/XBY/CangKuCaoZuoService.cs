using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.XBY
{
    public class CangKuCaoZuoService
    {
        /// <summary>
        /// 通过id查找产品返回
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable IDCanPin(int id)
        {
            StorageEntities ent = new StorageEntities();

            var obj = from p in ent.CpGlinfo
                      where p.CpID == id
                      select new
                      {
                          CpID = p.CpID,
                          Cpbh = p.Cpbh,
                          CpXsName = p.CpXsName,
                          CpSx = p.CpSx,
                          CpXx = p.CpXx,
                          CpPrice = p.CpPrice,
                          CpShuLiang = p.CpShuLiang,
                          Specification = p.Specification,
                          UserName = p.Client.KhName,                   //客户 用户名
                          CpLbName = p.CpLbinfo.CpLbName,                //产品类别的名称
                          CkName = p.Cangku.CKName,                      //仓库的名称
                          KwName = p.LocationManagement.kwName,          //仓库库位的名称
                          JlName = p.JLinfo.JlName,           //计量单位的名称
                          State = p.State,                    //是否删除
                          remark = p.remark
                      };
            return obj;
        }

        /// <summary>
        /// 通过文字找到编号
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>

        public static IQueryable CpGlfenye(string text)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.CpGlinfo
                      where p.State == true
                      && p.Cpbh == text
                      orderby p.CpID ascending
                      select new
                      {
                          CpID = p.CpID,
                          Cpbh = p.Cpbh,
                          CpXsName = p.CpXsName,
                          CpSx = p.CpSx,
                          CpXx = p.CpXx,
                          CpPrice = p.CpPrice,
                          CpShuLiang = p.CpShuLiang,
                          Specification = p.Specification,
                          UserName = p.Client.KhName,                   //客户 用户名
                          CpLbName = p.CpLbinfo.CpLbName,                //产品类别的名称
                          CkName = p.Cangku.CKName,                      //仓库的名称
                          KwName = p.LocationManagement.kwName,          //仓库库位的名称
                          JlName = p.JLinfo.JlName,           //计量单位的名称
                          State = p.State,                    //是否删除
                          remark = p.remark
                      };


            return obj;
        }


        /// <summary>
        /// 通过文字找到库位编号
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>

        public static IQueryable Textkuw(string text)
        {
            StorageEntities ent = new StorageEntities();
            var obj = from p in ent.LocationManagement
                      where p.Shuju == true
                      && p.kwName == text
                      orderby p.kwID
                      select new
                      {
                          kwID = p.kwID,
                          kwName = p.kwName,
                          kwType = p.LocationManagementType.KwName,
                          CKName = p.Cangku1.CKName,
                          Zhuangtai = p.Zhuangtai,
                          Isdefault = p.Isdefault,
                          Time = p.Time,
                          Shuju = p.Shuju
                      };

            return obj;
        }



        /// <summary>
        /// 供应商查询
        /// </summary>
        /// <returns></returns>
        public static IQueryable Listfenye()
        {
            StorageEntities ent = new StorageEntities();
            var obj = from p in ent.Supplier
                      where p.State == true
                      orderby p.GysID ascending
                      select new
                      {
                          GysID = p.GysID,
                          GysType = p.GysType,
                          GysName = p.GysName,
                          Hone = p.Hone,
                          ChuangZhen = p.ChuangZhen,
                          Email = p.Email,
                          Contacts = p.Contacts,
                          Address = p.Address,
                          Describe = p.Describe,
                          State = p.State
                      };
            return obj;
        }


        /// <summary>
        /// 通过供应商id找到供应商信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable IdGys(int id)
        {
            StorageEntities ent = new StorageEntities();
            var obj = from p in ent.Supplier
                      where p.State == true
                      && p.GysID == id
                      orderby p.GysID ascending
                      select new
                      {
                          GysID = p.GysID,
                          GysType = p.GysType,
                          GysName = p.GysName,
                          Hone = p.Hone,
                          ChuangZhen = p.ChuangZhen,
                          Email = p.Email,
                          Contacts = p.Contacts,
                          Address = p.Address,
                          Describe = p.Describe,
                          State = p.State
                      };
            return obj;
        }


        /// <summary>
        /// 查询客户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable KeHu()
        {
            StorageEntities ent = new StorageEntities();
            var obj = from p in ent.Client
                      where p.State == true
                      orderby p.KhID ascending
                      select new
                      {
                          ID = p.ID,
                          KhID = p.KhID,
                          KhName = p.KhName,
                          beizhu = p.beizhu,
                          Hone = p.Hone,
                          chuanzhen = p.chuanzhen,
                          youxiang = p.youxiang,
                          Time = p.Time,
                          State = p.State
                      };
            return obj;
        }
        /// <summary>
        /// 通过客户id找到客户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable IdKh(int id)
        {
            StorageEntities ent = new StorageEntities();
            var obj = from p in ent.Client
                      where p.State == true
                      && p.ID == id
                      orderby p.KhID ascending
                      select new
                      {
                          ID = p.ID,
                          KhID = p.KhID,
                          KhName = p.KhName,
                          beizhu = p.beizhu,
                          Hone = p.Hone,
                          chuanzhen = p.chuanzhen,
                          youxiang = p.youxiang,
                          Time = p.Time,
                          State = p.State,
                          dizhi = from pp in p.CustomerAddress
                                  where pp.KehuID == id
                                  select new
                                  {
                                      //[ID], [KehuID], [CustomerAddressID],
                                      //[CustomerAddressName], [Lianxiren], [phone], [State]
                                      ID = pp.ID,
                                      KehuID = pp.KehuID,
                                      CustomerAddressID = pp.CustomerAddressID,
                                      CustomerAddressName = pp.CustomerAddressName,
                                      Lianxiren = pp.Lianxiren,
                                      phone = pp.phone,
                                      State = pp.State
                                  }
                      };
            return obj;
        }

        /// <summary>
        /// 通过地址id找到地电话
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable IdDz(int id)
        {
            StorageEntities ent = new StorageEntities();
            var obj = from p in ent.CustomerAddress
                      where p.State == true
                      && p.ID == id
                      orderby p.ID ascending
                      select new
                      {

                          //[ID], [KehuID], [CustomerAddressID],
                          //[CustomerAddressName], [Lianxiren], [phone], [State]
                          ID = p.ID,
                          KehuID = p.KehuID,
                          CustomerAddressID = p.CustomerAddressID,
                          CustomerAddressName = p.CustomerAddressName,
                          Lianxiren = p.Lianxiren.Trim(),
                          phone = p.phone,
                          State = p.State


                      };
            return obj;
        }
    }
}
