using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.LL
{
    public class Location_managementService
    {
        static StorageEntities s = new StorageEntities();

        public static IQueryable selectAll() {
            var obj = from p in s.LocationManagement
                      select new
                      {
                         kwID=p.kwID,
                         kwName =p.kwName,
                         CangKu =p.Cangku1.CKName,
                         kwType =p.LocationManagementType.KwName,
                         Zhuangtai =p.Zhuangtai,
                         Isdefault =p.Isdefault,
                         Time=p.Time,
                         Shuju = p.Shuju
                      };
            return obj;
        }
    }
}
