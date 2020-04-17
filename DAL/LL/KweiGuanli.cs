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
        public static PageList Listfenye(int pageindex,int pagesize)
        {
            StorageEntities ent = new StorageEntities();
            var obj = from p in ent.LocationManagement
                      where p.Shuju == true
                      orderby p.kwID
                      select new
                      {
                          kwID = p.kwID,
                         kwType =p.kwType
                      };
            PageList list = new PageList();
            list.DataList = obj.Skip((pageindex - 1) * pagesize).Take(pagesize);
            list.PageCount = obj.Count();
            return list;
        }
    }
}