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

        public static IQueryable textkuw(string text)
        {
            return DAL.XBY.CangKuCaoZuoService.textkuw(text);
        }
        }
}
