using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.LLJ
{
  public  class CdanManager
    {
        public static int GetCount(int pageSize)
        {
            int rows = DAL.LLJ.CdanService.GetRows();
            if (rows % pageSize == 0)
            {
                return rows / pageSize;
            }
            return rows / pageSize + 1;
        }
        public static Models.PageList fy(int pageIndex, int pageSize, SysRole role)
        {

            return DAL.LLJ.CdanService.fy(pageIndex, pageSize, role);
        }
    }
}
