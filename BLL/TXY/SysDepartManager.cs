using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.TXY
{
    public class SysDepartManager
    {
        public static PageList SysDepartfenye(int pageIndex, int pageSize)
        {
            return DAL.TXY.SysDepartService.SysDepartfenye(pageIndex,pageSize);
        }
    }
}
