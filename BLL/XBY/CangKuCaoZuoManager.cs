using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.XBY
{
    public class CangKuCaoZuoManager
    {
        /// <summary>
        /// 通过id查找产品返回
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable IDCanPin(int id)
        {
            return DAL.XBY.CangKuCaoZuoService.IDCanPin(id);
        }

        /// <summary>
        /// 通过文字找到编号
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>

        public static IQueryable CpGlfenye(string text)
        {
            return DAL.XBY.CangKuCaoZuoService.CpGlfenye(text);
        }

        /// <summary>
        /// 通过文字找到库位编号
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>

        public static IQueryable Textkuw(string text)
        {
            return DAL.XBY.CangKuCaoZuoService.Textkuw(text);
        }



        /// <summary>
        /// 供应商查询
        /// </summary>
        /// <returns></returns>
        public static IQueryable gysList()
        {
            return DAL.XBY.CangKuCaoZuoService.Listfenye();
        }

        /// <summary>
        /// 通过供应商id找到供应商信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable IdGys(int id)
        {
            return DAL.XBY.CangKuCaoZuoService.IdGys(id);
        }


        /// <summary>
        /// 查询客户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable KeHu()
        {
            return DAL.XBY.CangKuCaoZuoService.KeHu();
        }

        /// <summary>
        /// 通过客户id找到客户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable IdKh(int id)
        {
            return DAL.XBY.CangKuCaoZuoService.IdKh(id);
        }

        /// <summary>
        /// 通过地址id找到地电话
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable IdDz(int id)
        {
            return DAL.XBY.CangKuCaoZuoService.IdDz(id);
        }

        }
}
