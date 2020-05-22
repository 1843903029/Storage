using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL.LL
{
    public class GYSguanliManager
    {
        public static PageList Listfenye(int pageindex, int pagesize)
        {
            return DAL.LL.GYSguanli.Listfenye(pageindex,pagesize);
        }
        public static IQueryable huishou()
        {
            return DAL.LL.GYSguanli.huishou();
        }
        public static int huanyuan(int id)
        {
            return DAL.LL.GYSguanli.huanyuan(id);
        }
            public static int del(int id)
        {
            return DAL.LL.GYSguanli.del(id);
        }
        public static IQueryable mohu(int pageindex, int pagesize, string GysName)
        {
            return DAL.LL.GYSguanli.mohu(pageindex,pagesize,GysName);
        }
            public static int add(Supplier sup)
        {
            return DAL.LL.GYSguanli.add(sup);
        }

        public static IQueryable GYSGetById(int ID)
        {
            return DAL.LL.GYSguanli.GYSGetById(ID);
        }

        public static int GYSEdit(Supplier sup)
        {
            return DAL.LL.GYSguanli.GYSEdit(sup);
        }
        }
}
