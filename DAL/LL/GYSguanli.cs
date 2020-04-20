using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.LL
{
    public class GYSguanli
    {
        static StorageEntities s = new StorageEntities();

        public static PageList Listfenye(int pageindex, int pagesize)
        {
            var obj = from p in s.Supplier
                      where p.State == true
                      orderby p.GysID
                      select new
                      {
                          GysID = p.GysID,
                          GysType = p.GysType,
                          GysName = p.GysName,
                          Hone = p.Hone,
                          ChuangZhen = p.ChuangZhen,
                          Email = p.Email,
                          Contacts = p.Contacts,
                          Address = p.Address,
                          Describe = p.Describe,
                          State = p.State
                      };
            PageList list = new PageList();
            list.DataList = obj.Skip((pageindex - 1) * pagesize).Take(pagesize);
            list.PageCount = obj.Count();
            return list;
        }
    }
}
