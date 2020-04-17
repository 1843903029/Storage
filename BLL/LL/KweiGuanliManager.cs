using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL.LL
{
    public class KweiGuanliManager
    {
        public static PageList Listfenye(int pageindex, int pagesize)
        {
            return DAL.LL.KweiGuanli.Listfenye(pageindex, pagesize);
        }
    }
}
