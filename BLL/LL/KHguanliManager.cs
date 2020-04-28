using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL.LL
{
     public class KHguanliManager
    {
        public static PageList Listfenye(int pageindex, int pagesize)
        {
            return DAL.LL.KHguanli.Listfenye(pageindex,pagesize);
        }
        public static int del(int id)
        {
            return DAL.LL.KHguanli.del(id);
        }
        public static int add(Client c) {

            return DAL.LL.KHguanli.add(c);
        }

        public static IQueryable KhGetById(int ID)
        {
            return DAL.LL.KHguanli.KhGetById(ID);
        }
        public static int KhEdit(Client c)
        {
            return DAL.LL.KHguanli.KhEdit(c);
        }
        }
}
