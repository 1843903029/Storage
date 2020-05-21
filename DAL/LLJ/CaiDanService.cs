using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.LLJ

{
   public class CaiDanService
    {
        public static PageList caidan(int pageIndex, int pageSize)
        {
            StorageEntities ent = new StorageEntities();
            var obj = from p in ent.Function
                      where p.State == true
                      orderby p.NodeId ascending
                      select new
                      {
                          NodeId = p.NodeId,
                          DisplayName = p.DisplayName,
                          NodeURL = p.NodeURL,
                          DisplayOrder = p.DisplayOrder,
                          ParentNodeId = p.ParentNodeId,
                          ADDTime = p.ADDTime,
                          State = p.State,
                      };
         

            PageList list = new PageList();
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();
            return list;

           
        }
        //删除
        public static int caidandel(string NodeId)
        {
            StorageEntities entity = new StorageEntities();
            var aa = entity.Function.Find(NodeId);
            aa.NodeId = NodeId;
            aa.State = false;
            //var obj = (from p in entity.SysDepart where p.SysDepartID == cd.SysDepartID select p).First();
            //obj.IsDelete = cd.IsDelete;
            return entity.SaveChanges();

        }
        //新增
        public static int caidanadd(Function cd)
        {
            StorageEntities entity = new StorageEntities();
            entity.Function.Add(cd);
            return entity.SaveChanges();

        }
        //
        public static IQueryable FunctionGetById(string NodeId)
        {
            StorageEntities entity = new StorageEntities();
            var obj = from p in entity.Function
                      where p.NodeId == NodeId
                      select new
                      {
                          NodeId = p.NodeId,
                          DisplayName = p.DisplayName,
                          NodeURL = p.NodeURL,
                          DisplayOrder = p.DisplayOrder,
                          ParentNodeId = p.ParentNodeId,
                          ADDTime = p.ADDTime,
                          State = p.State,
                      };
            return obj;
        }

        //
        public static int FunctionEdit(string NodeId, string DisplayName)
        {
            StorageEntities entity = new StorageEntities();
            var obj = (from p in entity.Function where p.NodeId == NodeId select p).First();
            obj.DisplayName = DisplayName;
            return entity.SaveChanges();
        }
            //
            public static IQueryable FunctionQuery(int pageIndex, int pageSize, string DisplayName)
        {
            StorageEntities entity = new StorageEntities();

            var obj = from p in entity.Function
                      where p.DisplayName.IndexOf(DisplayName) != -1
                      && p.State == true
                      orderby p.NodeId
                      select new
                      {
                          NodeId = p.NodeId,
                          DisplayName = p.DisplayName,
                          NodeURL = p.NodeURL,
                          DisplayOrder = p.DisplayOrder,
                          ParentNodeId = p.ParentNodeId,
                          ADDTime = p.ADDTime,
                          State = p.State,
                      };

            PageList list = new PageList();
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            list.PageCount = obj.Count();
            return list.DataList;

        }
    }
}

