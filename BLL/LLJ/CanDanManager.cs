using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.LLJ
{
   public class CanDanManager
    {
        public static Models.PageList Functionfenye(int pageIndex, int pageSize)
        {

            return DAL.LLJ.CaiDanService.caidan(pageIndex, pageSize);
        }
        public static int caidandel(int NodeId)
        {
            return DAL.LLJ.CaiDanService.caidandel(NodeId);
        }
        public static int caidanadd(Function cd)
        {
            return DAL.LLJ.CaiDanService.caidanadd(cd);
        }
        public static IQueryable FunctionGetById(int NodeId)
        {
            return DAL.LLJ.CaiDanService.FunctionGetById(NodeId);
        }

        public static int FunctionEdit(int NodeId, string DisplayName)
        {
            return DAL.LLJ.CaiDanService.FunctionEdit( NodeId, DisplayName);

        }
        //模糊查询
        public static IQueryable FunctionQuery(int pageIndex, int pageSize, string DisplayName)
        {
            return DAL.LLJ.CaiDanService.FunctionQuery(pageIndex, pageSize, DisplayName);
        }
    }
}

