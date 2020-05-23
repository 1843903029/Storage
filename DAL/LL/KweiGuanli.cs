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
                      orderby p.kwID ascending
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
        //高级查询
        public static PageList GaojiService(int pageindex, int pagesize,int CangKu,int kwType,string kwName)
        {
            
            var obj = from p in s.LocationManagement
                      where p.Shuju == true
                      orderby p.kwID ascending
                      select new
                      {
                          kwID = p.kwID,
                          kwName = p.kwName,
                          kwType = p.LocationManagementType.KwName,
                          CKName = p.Cangku1.CKName,
                          Zhuangtai = p.Zhuangtai,
                          Isdefault = p.Isdefault,
                          Time = p.Time,
                          Shuju = p.Shuju,
                          CKid=p.Cangku1.Ckid,
                          kuweiID=p.LocationManagementType.KwID
                      };
            if (CangKu != -1)
            {
                obj = obj.Where(item => item.CKid == CangKu);
            }
            if (kwType != -1)
            {
                obj = obj.Where(item => item.kuweiID == kwType);
            }
            if (!string.IsNullOrEmpty(kwName))
            {
                obj = obj.Where(item => item.kwName.IndexOf(kwName) != -1);
            }
            PageList list = new PageList();
            list.DataList = obj.Skip((pageindex - 1) * pagesize).Take(pagesize);
            list.PageCount = obj.Count();
            return list;
        }
        public static int add(LocationManagement lo) {
            s.LocationManagement.Add(lo);
            return s.SaveChanges();
        }
        public static int del(int id)
        {
            var obj = s.LocationManagement.Find(id);
            obj.Shuju=false;
            return s.SaveChanges();

        }
        public static IQueryable KwGetById(int kwID)
        {
            
            var obj = from p in s.LocationManagement
                      where p.kwID == kwID
                      select new
                      {
                        kwID=p.kwID,
                        kwName=p.kwName,
                        KwTypeID =p.LocationManagementType.KwID,
                        Ckid=p.Cangku1.Ckid,
                        Zhuangtai = p.Zhuangtai,
                        Time=p.Time
                      };
            return obj;
        }


        public static IQueryable selectType() {
            var obj = from p in s.LocationManagementType
                      select new
                      {
                          KwID=p.KwID,
                          KwName=p.KwName
                      };
            return obj;

        }
        public static IQueryable selectCK() {
            var obj = from p in s.Cangku
                      select new
                      {
                          Ckid=p.Ckid,
                         CKName= p.CKName
                      };
            return obj;
        }
        public static int KwEdit(LocationManagement lo)
        {
            
            var obj = (from p in s.LocationManagement where p.kwID == lo.kwID select p).First();
            obj.kwName = lo.kwName;
            obj.kwType = lo.kwType;
            obj.CangKu = lo.CangKu;
            obj.Zhuangtai = lo.Zhuangtai;
            obj.Time = lo.Time;
            return s.SaveChanges();

        }


    }
}