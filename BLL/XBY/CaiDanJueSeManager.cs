using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.XBY
{
    public class CaiDanJueSeManager
    {
        public static IQueryable CaiDanList()
        {
            return DAL.XBY.CaiDanJueSeService.CaiDanList();
        }
        /// <summary>
        /// 查副模块菜单
        /// </summary>
        /// <returns></returns>
        public static IQueryable CaiDanListXiang(String id)
        {
            return DAL.XBY.CaiDanJueSeService.CaiDanListXiang(id);
        }

        }
}
