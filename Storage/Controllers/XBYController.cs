﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace Storage.Controllers
{
    public class XBYController : Controller
    {
        // GET: XBY
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        ///菜单主
        /// </summary>
        /// <returns></returns>
        public ActionResult CaiDanList()
        {
            return Json(BLL.XBY.CaiDanJueSeManager.CaiDanList(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        ///菜单副
        /// </summary>
        /// <returns></returns>
        public ActionResult CaiDanListXiang(String id)
        {
            return Json(BLL.XBY.CaiDanJueSeManager.CaiDanListXiang(id), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 入库管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RukuGuanli()
        {
            return View();
        }

        /// <summary>
        /// 入库管理新增订单页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RukuGuanliAdd()
        {
            return View();
        }


        /// <summary>
        /// 入库管理修改订单页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RukuGuanliXiuGai()
        {
            return View();
        }


        /// <summary>
        /// 入库管理修改时 修改主表
        /// </summary>
        /// <returns></returns>
        public ActionResult RuKuXiuZhu(Models.Storage zhu)
        {
            zhu.State = 2;
            zhu.OperationType = "电脑";
            zhu.CreationTime = DateTime.Now;
            zhu.DataState = true;
            return Json(BLL.XBY.StorageManager.RuKuXiuZhu(zhu),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 入库管理修改时 修改主表后的删除详表
        /// </summary>
        /// <returns></returns>
        public ActionResult RuKuDel(string id)
        {
            return Json(BLL.XBY.StorageManager.RuKuDel(id), JsonRequestBehavior.AllowGet);
        }



        /// <summary>
        /// 入库审核
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult RuKuShenHe(string danhao, int state)
        {
            return Json(BLL.XBY.StorageManager.RuKuShenHe(danhao, state), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 通过审核后修改相应库存数量
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult RuKuSHHou(int cpid, int Count)
        {
            return Json(BLL.XBY.StorageManager.RuKuSHHou(cpid, Count), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GYSlist()
        {
            return Json(BLL.XBY.CangKuCaoZuoManager.gysList(), JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 通过供应商id找到供应商信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult IdGys(int id)
        {
            return Json(BLL.XBY.CangKuCaoZuoManager.IdGys(id), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 添加入库主表
        /// </summary>
        /// <param name="xiang"></param>
        /// <param name="zhu"></param>
        /// <returns></returns>
        public ActionResult ADDRuku(Models.Storage zhu)
        {
            //Random a = new Random();
            //zhu.StorageID = a.Next().ToString();
            zhu.State = 2;
            zhu.OperationType = "电脑";
            zhu.CreationTime = DateTime.Now;
            zhu.DataState = true;
            return Json(BLL.XBY.StorageManager.ADDRuku(zhu), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 添加入库详表
        /// </summary>
        /// <param name="xiang"></param>
        /// <returns></returns>
        public ActionResult ADDRukuxiang(StorageDetailed xiang)
        {
            return Json(BLL.XBY.StorageManager.ADDRukuXiang(xiang), JsonRequestBehavior.AllowGet);
        }

        public ActionResult ShanChuRuKu(string id)
        {
            return Json(BLL.XBY.StorageManager.ShanChuRuKu(id), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 通过单号查详情
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="Danhao"></param>
        /// <returns></returns>
        public ActionResult IDRuku(string Danhao)
        {
            return Json(BLL.XBY.StorageManager.RuKuList(Danhao), JsonRequestBehavior.AllowGet);
        }
        

        /// <summary>
        /// 通过文字找到编号
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public ActionResult CpGlfenye(string text)
        {
            return Json(BLL.XBY.CangKuCaoZuoManager.CpGlfenye(text), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 通过文字找到库位编号
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public ActionResult Textkuw(string text)
        {
            return Json(BLL.XBY.CangKuCaoZuoManager.Textkuw(text), JsonRequestBehavior.AllowGet);
        }


        public ActionResult RuKuList(int PageSize, int PageIndex, int State)
        {
            return Json(BLL.XBY.StorageManager.RuKuList(PageSize, PageIndex, State), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SuoYouRuKuList(int PageSize, int PageIndex)
        {
            return Json(BLL.XBY.StorageManager.RuKuList(PageSize, PageIndex), JsonRequestBehavior.AllowGet);
        }

        public ActionResult MoHuRuKuList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            return Json(BLL.XBY.StorageManager.MoHuRuKuList(PageSize, PageIndex, Danhao, time1, time2), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 出库管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChukuGuanli()
        {
            return View();
        }

        /// <summary>
        /// 出库管理新增订单页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChukuGuanliAdd()
        {
            return View();
        }

        /// <summary>
        /// 出库管理修改订单页面
        /// </summary>
        /// <returns></returns>
        public ActionResult CukuGuanliXiuGai()
        {
            return View();
        }

        /// <summary>
        /// 出库审核
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult ChuKuShenHe(string danhao, int state)
        {
            return Json(BLL.XBY.StockRemovalManager.ChuKuShenHe(danhao, state), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 通过审核后修改相应库存数量
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult ChuKuSHHou(int cpid, int Count)
        {
            return Json(BLL.XBY.StockRemovalManager.ChuKuSHHou(cpid, Count), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        ///添加出库主表
        /// </summary>
        /// <param name="zhu"></param>
        /// <returns></returns>
        public ActionResult ChuKuAddZhu(StockRemoval zhu)
        {
            zhu.State = 2;
            zhu.OperationType = "电脑";
            zhu.CreationTime = DateTime.Now;
            zhu.DataState = true;
            return Json(BLL.XBY.StockRemovalManager.AddChuKu(zhu), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        ///添加出库详表
        /// </summary>
        /// <param name="xiang"></param>
        /// <returns></returns>
        public ActionResult AddChuKuXiang(StockRemovalDetailed xiang)
        {
            xiang.Batch = 0;
            return Json(BLL.XBY.StockRemovalManager.AddChuKuXiang(xiang), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 查询所有客户信息
        /// </summary>
        /// <returns></returns>
        public ActionResult KeHuList()
        {
            return Json(BLL.XBY.CangKuCaoZuoManager.KeHu(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 通过id 查询对应客户
        /// </summary>
        /// <returns></returns>
        public ActionResult KeHuID(int id)
        {
            return Json(BLL.XBY.CangKuCaoZuoManager.IdKh(id), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        ///  通过地址id找到地电话
        /// </summary>
        /// <returns></returns>
        public ActionResult IdDz(int id)
        {
            return Json(BLL.XBY.CangKuCaoZuoManager.IdDz(id), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 删除出库单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ShanChuChuKu(string id)
        {
            return Json(BLL.XBY.StockRemovalManager.ShanChuChuKu(id), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 通过单号查详情
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="Danhao"></param>
        /// <returns></returns>
        public ActionResult IDChuku(string Danhao)
        {
            return Json(BLL.XBY.StockRemovalManager.ChuKuList(Danhao), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 查地址
        /// </summary>
        /// <param name="Danhao"></param>
        /// <returns></returns>
        public ActionResult chadizhi(int id)
        {
            return Json(BLL.XBY.StockRemovalManager.chadizhi(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult ChuKuList(int PageIndex, int PageSize, int State)
        {
            return Json(BLL.XBY.StockRemovalManager.ChuKuList(PageIndex, PageSize, State), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SuoYouChuKuList(int PageIndex, int PageSize)
        {
            return Json(BLL.XBY.StockRemovalManager.ChuKuList(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }


        public ActionResult MoHuChuKuList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            return Json(BLL.XBY.StockRemovalManager.MoHuChuKuList(PageSize, PageIndex, Danhao, time1, time2), JsonRequestBehavior.AllowGet);
        }

        public ActionResult ChuKuXF1()
        {
            return View();
        }


        public ActionResult BaoSunList(int PageIndex, int PageSize, int State)
        {
            return Json(BLL.XBY.BreakageManager.BaoSunList(PageIndex, PageSize, State), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SuoYouBaoSunList(int PageIndex, int PageSize)
        {
            return Json(BLL.XBY.BreakageManager.BaoSunList(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }

        public ActionResult MoHuBaoSunList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            return Json(BLL.XBY.BreakageManager.MoHuBaoSunList(PageSize, PageIndex, Danhao, time1, time2), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Baoxuncha(string id)
        {
            return Json(BLL.XBY.BreakageManager.Baoxuncha(id), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 报损管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaoSunGuanli()
        {
            return View();
        }

        /// <summary>
        /// 报损管理新增单子的页面
        /// </summary>
        /// <returns></returns>
        public ActionResult BaoSunGuanliAdd()
        {
            return View();
        }

        /// <summary>
        /// 报损审核
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult BaoSunShenHe(string danhao, int state)
        {
            return Json(BLL.XBY.BreakageManager.BaoSunShenHe(danhao, state), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 通过审核后修改相应库存数量
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult BaoSunSHHou(int cpid, int Count)
        {
            return Json(BLL.XBY.BreakageManager.BaoSunSHHou(cpid, Count), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        ///添加报损主表
        /// </summary>
        /// <param name="zhu"></param>
        /// <returns></returns>
        public ActionResult AddBaoSun(Breakage zhu)
        {
            zhu.State = 2;
            zhu.CreationTime = DateTime.Now;
            zhu.DataState = true;
            zhu.operationType = "电脑";
            return Json(BLL.XBY.BreakageManager.AddBaoSun(zhu), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 添加报损详表
        /// </summary>
        /// <param name="xiang"></param>
        /// <returns></returns>
        public ActionResult AddBaoSuniang(BreakageDetailed xiang)
        {
            return Json(BLL.XBY.BreakageManager.AddBaoSuniang(xiang), JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 删除报损单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ShanChuBaoSun(string id)
        {
            return Json(BLL.XBY.BreakageManager.ShanChuBaoSun(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult YiKuList(int PageIndex, int PageSize, int State)
        {
            return Json(BLL.XBY.MovementManager.YiKuList(PageIndex, PageSize, State), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SuoYouYiKuList(int PageIndex, int PageSize)
        {
            return Json(BLL.XBY.MovementManager.YiKuList(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult MoHuYiKuList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            return Json(BLL.XBY.MovementManager.MoHuYiKuList(PageSize, PageIndex, Danhao, time1, time2), JsonRequestBehavior.AllowGet);
        }


        public ActionResult YiKucha(string id)
        {
            return Json(BLL.XBY.MovementManager.YiKucha(id), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 移库管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult YiKuGuanli()
        {
            return View();
        }

        /// <summary>
        /// 移库管理新增单子页面
        /// </summary>
        /// <returns></returns>
        public ActionResult YiKuGuanliAdd()
        {
            return View();
        }


        /// <summary>
        /// 移库审核
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult YiKuShenHe(string danhao, int state)
        {
            return Json(BLL.XBY.MovementManager.YiKuShenHe(danhao, state), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        ///添加移库主表
        /// </summary>
        /// <param name="zhu"></param>
        /// <returns></returns>
        public ActionResult AddYiKu(Movement zhu)
        {
            zhu.State = 2;
            zhu.CreationTime = DateTime.Now;
            zhu.DataState = true;
            return Json(BLL.XBY.MovementManager.AddYiKu(zhu), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 添加移库详表
        /// </summary>
        /// <param name="xiang"></param>
        /// <returns></returns>
        public ActionResult AddYiKuxiang(MovementDetailed xiang)
        {
            return Json(BLL.XBY.MovementManager.AddYiKuxiang(xiang), JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 删除移库单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ShanChuYiKu(string id)
        {
            return Json(BLL.XBY.MovementManager.ShanChuYiKu(id), JsonRequestBehavior.AllowGet);
        }


        public ActionResult PanDianList(int PageIndex, int PageSize, int State)
        {
            return Json(BLL.XBY.CycleCountManager.PanDianList(PageIndex, PageSize, State), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SuoYouPanDianList(int PageIndex, int PageSize)
        {
            return Json(BLL.XBY.CycleCountManager.PanDianList(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }

        public ActionResult MoHuPanDianList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            return Json(BLL.XBY.CycleCountManager.MoHuPanDianList(PageSize, PageIndex, Danhao, time1, time2), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 盘点管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult PanDianGuanli()
        {
            return View();
        }

        /// <summary>
        /// 盘点管理新增单子页面
        /// </summary>
        /// <returns></returns>
        public ActionResult PanDianGuanliAdd()
        {
            return View();
        }

        /// <summary>
        /// 盘点审核
        /// </summary>
        /// <param name="danhao"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public ActionResult PanDianShenHe(string danhao, int state)
        {
            return Json(BLL.XBY.CycleCountManager.PanDianShenHe(danhao, state), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 删除盘点单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ShanChuPanDian(string id)
        {
            return Json(BLL.XBY.CycleCountManager.ShanChuPanDian(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult TuiHuoList(int PageIndex, int PageSize, int State)
        {
            return Json(BLL.XBY.ReturnsManager.TuiHuoList(PageIndex, PageSize, State), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SuoYouTuiHuoList(int PageIndex, int PageSize)
        {
            return Json(BLL.XBY.ReturnsManager.TuiHuoList(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }


        public ActionResult MoHuTuiHuoList(int PageSize, int PageIndex, string Danhao, string time1, string time2)
        {
            return Json(BLL.XBY.ReturnsManager.MoHuTuiHuoList(PageSize, PageIndex, Danhao, time1, time2), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 退货管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TuiHuoGuanli()
        {
            return View();
        }

        /// <summary>
        /// 退货管理新增单子页面
        /// </summary>
        /// <returns></returns>
        public ActionResult TuiHuoGuanliAdd()
        {
            return View();
        }




        /// <summary>
        /// 删除盘点单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ShanChuTuiHuo(string id)
        {
            return Json(BLL.XBY.ReturnsManager.ShanChuTuiHuo(id), JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 通过id查询对应产品信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult IDCanPin(int id)
        {
            return Json(BLL.XBY.CangKuCaoZuoManager.IDCanPin(id), JsonRequestBehavior.AllowGet);
        }


    }
}