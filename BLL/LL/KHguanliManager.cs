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
        }
}
