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









    }
}
