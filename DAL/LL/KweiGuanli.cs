//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Models;

namespace DAL.LL
{
    public class KweiGuanli
    {
        static StorageEntities s = new StorageEntities();
        public static PageList Listfenye(int pageindex,int pagesize)
        {
            
            var obj = from p in s.LocationManagement
                      where p.Shuju == true
                      orderby p.kwID
                      select new
                      {
                          kwID = p.kwID,
                          kwName = p.kwName,
                          kwType = p.LocationManagementType.KwName,
                          CKName=p.Cangku1.CKName,
                          Zhuangtai=p.Zhuangtai,
                          Isdefault=p.Isdefault,
                          Time=p.Time,
                          Shuju = p.Shuju
                      };
            PageList list = new PageList();
            list.DataList = obj.Skip((pageindex - 1) * pagesize).Take(pagesize);
            list.PageCount = obj.Count();
            return list;
        }
        public static int add(LocationManagement lo) {
            s.LocationManagement.Add(lo);
            return s.SaveChanges();
        }
    }
}