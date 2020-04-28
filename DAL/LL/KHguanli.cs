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
                      where p.State == true
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
            var obj = s.Client.Find(id);
            obj.State = false;
            return s.SaveChanges();

        }
        public static int add(Client c)
        {
            s.Client.Add(c);
            return s.SaveChanges();
        }

        public static IQueryable KhGetById(int ID)
        {

            var obj = from p in s.Client
                      where p.ID == ID
                      select new
                      {
                          ID = p.ID,
                          KhID = p.KhID,
                          KhName = p.KhName,
                          beizhu = p.beizhu,
                          Hone = p.Hone,
                          chuanzhen = p.chuanzhen,
                          youxiang = p.youxiang,
                          Time = p.Time,
                          State = p.State
                      };
            return obj;
        }
        public static int KhEdit(Client c)
        {

            var obj = (from p in s.Client where p.ID == c.ID select p).First();
            obj.KhID = c.KhID;
            obj.KhName = c.KhName;
            obj.beizhu = c.beizhu;
            obj.chuanzhen = c.chuanzhen;
            obj.youxiang = c.youxiang;
            obj.Hone = c.Hone;
            obj.Time = c.Time;
            return s.SaveChanges();

        }
    }
}
