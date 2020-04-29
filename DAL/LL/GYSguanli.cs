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
        public static PageList mohu(int pageindex, int pagesize,string GysName)
        {
            var obj = from p in s.Supplier
                      where p.GysName.IndexOf(GysName) != -1
                      && p.State == true
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

        public static int del(int id)
        {
            var obj = (from p in s.Supplier where p.GysID == id select p).First();
            obj.State = false;
            return s.SaveChanges();

        }
        public static int add(Supplier sup)
        {
            s.Supplier.Add(sup);
            return s.SaveChanges();
        }

        public static IQueryable GYSGetById(int ID)
        {

            var obj = from p in s.Supplier
                      where p.GysID == ID
                      select new
                      {
                        GysID= p.GysID,
                        GysName= p.GysName,
                        GysType= p.GysType,
                        Hone= p.Hone,
                        ChuangZhen= p.ChuangZhen,
                        Email= p.Email,
                        Contacts= p.Contacts,
                        Address= p.Address,
                        Describe = p.Describe
                      };
            return obj;
        }

        public static int GYSEdit(Supplier sup)
        {

            var obj = (from p in s.Supplier where p.GysID == sup.GysID select p).First();
            obj.GysName = sup.GysName;
            obj.GysType = sup.GysType;
            obj.Hone = sup.Hone;
            obj.ChuangZhen = sup.ChuangZhen;
            obj.Email = sup.Email;
            obj.Contacts = sup.Contacts;
            obj.Address = sup.Address;
            obj.Describe = sup.Describe;
            
            return s.SaveChanges();

        }
    }
}
