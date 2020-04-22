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

        public static IQueryable textkuw(string text)
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
    }
}
