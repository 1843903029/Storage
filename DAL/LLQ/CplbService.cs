﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.LLQ
{
    public class CplbService
    {
        public static Models.PageList lbfenye(int pageIndex, int pageSize)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.CpLbinfo
                      where p.Delit == true
                      orderby p.ID ascending
                      select new
                      {
                          ID = p.ID,
                          CpId = p.CpId,
                          CpLbName = p.CpLbName,
                          UserName = p.Admin.UserName,//管理员的名称
                          CpTime = p.CpTime,
                          remark = p.remark,
                          Delit = p.Delit//是否删除
                      };
            PageList list = new PageList();
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();

            return list;
        }

        /// <summary>
        /// 产品类别新增
        /// </summary>
        /// <param name="cplb"></param>
        /// <returns></returns>
        public static int CplbAdd(Models.CpLbinfo cplb)
        {
            StorageEntities b = new StorageEntities();
            b.CpLbinfo.Add(cplb);
            return b.SaveChanges();
        }

        //删除
        public static int CplbDet(int id)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.CpLbinfo where p.ID == id select p).First();
            obj.Delit = false;
            return entity.SaveChanges();

        }


    }
}
