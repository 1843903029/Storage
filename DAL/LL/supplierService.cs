using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.LL
{
    public class supplierService
    {
        static StorageEntities s = new StorageEntities();

        public static IQueryable selectAll() {
            var obj = from p in s.Supplier
                      select new
                      {
                        GysID=p.GysID,
                        GysType=p.GysType,
                        GysName=p.GysName,
                        Hone=p.Hone,
                        ChuangZhen=p.ChuangZhen,
                        Email=p.Email,
                        Contacts=p.Contacts,
                        Address=p.Address,
                        Describe=p.Describe,
                        State = p.State
                      };
            return obj;
        }
    }
}
