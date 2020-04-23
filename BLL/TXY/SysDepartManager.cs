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
        //删除
        public static int SysDepartdelete(int SysDepartID)
        {
            return DAL.TXY.SysDepartService.SysDepartdelete(SysDepartID);

        }
        //新增
        public static int SysDepartadd(SysDepart depart)
        {
            return DAL.TXY.SysDepartService.SysDepartadd(depart);
        }
    }
}
