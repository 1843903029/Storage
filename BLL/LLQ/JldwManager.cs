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
        public static PageList Jldwfenye(int pageIndex, int pageSize)
        {
            return DAL.LLQ.JldwService.Jldwfenye(pageIndex, pageSize);
        }

    }
}
