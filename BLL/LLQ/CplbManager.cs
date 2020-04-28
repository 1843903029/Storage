using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.LLQ
{
    public class CplbManager
    {
        public static Models.PageList lbfenye(int pageIndex, int pageSize)
        {
            return DAL.LLQ.CplbService.lbfenye( pageIndex,  pageSize);
        }

        //新增
        public static int CplbAdd(Models.CpLbinfo cplb)
        {
            return DAL.LLQ.CplbService.CplbAdd(cplb);
        }

        //删除
        public static int CplbDet(int id)
        {
            return DAL.LLQ.CplbService.CplbDet(id);

        }
        //根据id单个查询
        public static IQueryable CplbGetById(int id)
        {
            return DAL.LLQ.CplbService.CplbGetById(id);
        }
        //修改
        public static int CplbEdit(CpLbinfo cplb)
        {
            return DAL.LLQ.CplbService.CplbEdit(cplb);
        }
        //模糊查询
        public static IQueryable CplbQuery(int pageIndex, int pageSize, string CpLbName)
        {
            return DAL.LLQ.CplbService.CplbQuery(pageIndex, pageSize, CpLbName);
        }

    }
}
