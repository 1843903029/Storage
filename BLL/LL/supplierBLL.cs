using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL.LL
{
    public class supplierBLL
    {
        public static IQueryable selectAll()
        {
            return DAL.LL.supplierService.selectAll();
        }
        }
}
