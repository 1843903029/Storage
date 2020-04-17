using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL.TXY
{
    public class AdminManager
    {
        //登录
        public static IQueryable Rogin(Admin a)
        {
            return DAL.TXY.AdminService.Rogin(a);
        }
        //fenye
        public static PageList Adminfenye(int pageIndex, int pageSize,int Stuate)
        {
            return DAL.TXY.AdminService.Adminfenye(pageIndex, pageSize, Stuate);
        }
    }
}
