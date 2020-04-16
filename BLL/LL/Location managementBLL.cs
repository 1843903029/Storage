using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL.LL
{
    public class Location_managementBLL
    {
        public static IQueryable selectAll()
        {
            return DAL.LL.Location_managementService.selectAll();
        }
        }
}
