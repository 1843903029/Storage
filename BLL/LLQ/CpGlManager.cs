using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.LLQ
{
    public class CpGlManager
    {
        public static Models.PageList CpGlfenye(int pageIndex, int pageSize)
        {
            return DAL.LLQ.CpGlService.CpGlfenye(pageIndex, pageSize);
        }

        public static int CpGlAdd(Models.CpGlinfo cpgl)
        {
            return DAL.LLQ.CpGlService.CpGlAdd(cpgl);
        }

        //删除
        public static int CpGlDet(int CpID)
        {
            return DAL.LLQ.CpGlService.CpGlDet(CpID);
        }
        //根据id单个查询
        public static IQueryable CpGlGetById(int CpID)
        {
            return DAL.LLQ.CpGlService.CpGlGetById(CpID);
        }
        //修改
        public static int CpGlEdit(CpGlinfo cpgl)
        {
            return DAL.LLQ.CpGlService.CpGlEdit(cpgl);
        }
        //模糊查询
        public static IQueryable CpGlQuery(int pageIndex, int pageSize, string CpXsName)
        {
            return DAL.LLQ.CpGlService.CpGlQuery(pageIndex,  pageSize,  CpXsName);
        }

        //查询客户表
        public static IQueryable selectAd()
        {
            return DAL.LLQ.CpGlService.selectAd();
        }
    }
}
