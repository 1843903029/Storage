using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.LLQ
{
   public  class JldwManager
    {
        /// <summary>
        /// 计量单位分页查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PageList Jldwfenye(int pageIndex, int pageSize)
        {
            return DAL.LLQ.JldwService.Jldwfenye(pageIndex, pageSize);
        }

        /// <summary>
        /// 计量单位新增
        /// </summary>
        /// <param name="jldw"></param>
        /// <returns></returns>
        public static int JldwAdd(Models.JLinfo jldw)
        {
            return DAL.LLQ.JldwService.JldwAdd(jldw);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="jldw"></param>
        /// <returns></returns>
        public static int JldwDet(int jlid)
        {
            return DAL.LLQ.JldwService.JldwDet(jlid);
        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="jlName"></param>
        /// <returns></returns>

        public static IQueryable JldwGetByQuery(int pageIndex, int pageSize, string jlName)
        {
            return DAL.LLQ.JldwService.JldwGetByQuery(pageIndex,  pageSize,  jlName);
        }

        //根据id查询单个
        public static IQueryable JldwGetById(int Jlid)
        {
            return DAL.LLQ.JldwService.JldwGetById(Jlid);
       }
        //修改
        public static int JldwEdit(JLinfo jldw)
        {
            return DAL.LLQ.JldwService.JldwEdit(jldw);

        }

    }
}
