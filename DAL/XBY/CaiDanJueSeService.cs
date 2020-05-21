using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.XBY
{
    public class CaiDanJueSeService
    {
        /// <summary>
        /// 查主模块菜单
        /// </summary>
        /// <returns></returns>
        public static IQueryable CaiDanList()
        {
            StorageEntities ent = new StorageEntities();
            var obj = from p in ent.Function
                      where p.ParentNodeId == "0"
                      && p.State==true
                      select new
                      {
                          //[NodeId], [DisplayName], [NodeURL], [DisplayOrder], [ParentNodeId], [ADDTime], [State]
                          NodeId = p.NodeId,
                          DisplayName = p.DisplayName,
                          NodeURL = p.NodeURL,
                          DisplayOrder = p.DisplayOrder,
                          ParentNodeId = p.ParentNodeId,
                          ADDTime = p.ADDTime,
                          State = p.State
                      };
            return obj;
        }


        /// <summary>
        /// 查副模块菜单
        /// </summary>
        /// <returns></returns>
        public static IQueryable CaiDanListXiang(String id)
        {
            StorageEntities ent = new StorageEntities();
            var obj = from p in ent.Function
                      where p.ParentNodeId == id
                      && p.State == true
                      select new
                      {
                          //[NodeId], [DisplayName], [NodeURL], [DisplayOrder], [ParentNodeId], [ADDTime], [State]
                          NodeId = p.NodeId,
                          DisplayName = p.DisplayName,
                          NodeURL = p.NodeURL,
                          DisplayOrder = p.DisplayOrder,
                          ParentNodeId = p.ParentNodeId,
                          ADDTime = p.ADDTime,
                          State = p.State
                      };
            return obj;
        }
    }
}
