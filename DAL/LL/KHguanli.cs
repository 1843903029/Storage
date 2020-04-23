using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.LL
{
    public class KHguanli
    {

        static StorageEntities s = new StorageEntities();

        public static PageList Listfenye(int pageindex, int pagesize)
        {
            var obj = from p in s.Client
                      //where p.State == true
                      orderby p.KhID
                      select new
                      {
                          ID=p.ID,
                          KhID = p.KhID,
                          KhName = p.KhName,
                          beizhu = p.beizhu,
                          Hone = p.Hone,
                          chuanzhen = p.chuanzhen,
                          youxiang = p.youxiang,
                          Time = p.Time,
                          State = p.State
                      };
            PageList list = new PageList();
            list.DataList = obj.Skip((pageindex - 1) * pagesize).Take(pagesize);
            list.PageCount = obj.Count();
            return list;
        }

        public static int del( int id) {
            Client c = s.Client.Find(id);
            s.Client.Remove(c);
            return s.SaveChanges();

        }
        public static int add(Client c)
        {
            s.Client.Add(c);
            return s.SaveChanges();
        }
        }
}
