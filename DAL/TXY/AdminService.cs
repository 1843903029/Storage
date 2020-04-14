using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.TXY
{
   public class AdminService
    {
        public static IQueryable Rogin(Admin a)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.Admin
                      where p.UserName == a.UserName && p.PassWord == a.PassWord
                      select p;
            return obj;
        }
    }
}
