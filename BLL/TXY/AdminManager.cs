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
        public static IQueryable Rogin(Admin a)
        {
            return DAL.TXY.AdminService.Rogin(a);
        }
        }
}
