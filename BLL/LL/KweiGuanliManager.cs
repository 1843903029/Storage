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
        public static IQueryable selectType()
        {
            return DAL.LL.KweiGuanli.selectType();
        }
        public static IQueryable selectCK()
        {
            return DAL.LL.KweiGuanli.selectCK();
        }
            public static int add(LocationManagement lo)
        {
            return DAL.LL.KweiGuanli.add(lo);
        }

        public static int del(int id)
        {
            return DAL.LL.KweiGuanli.del(id);
        }
        public static PageList GaojiService(int pageindex, int pagesize, int CangKu, int kwType, string kwName)
        {
            return DAL.LL.KweiGuanli.GaojiService(pageindex,pagesize,CangKu,kwType,kwName);
        }
            public static IQueryable KwGetById(int kwID)
        {
            return DAL.LL.KweiGuanli.KwGetById(kwID);
        }
        public static int KwEdit(LocationManagement lo)
        {
            return DAL.LL.KweiGuanli.KwEdit(lo);
        }
        }
}
