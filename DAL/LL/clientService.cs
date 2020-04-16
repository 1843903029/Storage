using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.LL
{
    public  class clientService
    {
        static StorageEntities s = new StorageEntities();

        public static IQueryable selectAll() {
            var obj = from p in s.Client
                      select new
                      {
                        ID=p.ID,
                        KhID=p.KhID,
                        KhName=p.KhName,
                        beizhu=p.beizhu,
                        chuanzhen=p.chuanzhen,
                        youxiang=p.youxiang,
                        Hone=p.Hone,
                        Time=p.Time,
                        State = p.State
                      };
            return obj;
        }
    }
}
