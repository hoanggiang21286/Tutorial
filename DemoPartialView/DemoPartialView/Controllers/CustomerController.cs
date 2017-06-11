using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoPartialView.Models;
namespace DemoPartialView.Controllers
{
    public class CustomerController : Controller
    {       
        public ActionResult GetKhachHang(string id, string name)
        {
            var listKH = new List<KhachHang>();
            var cmDo = new CommonDO();
            var listRaw = cmDo.GetListCustomer(id, name);
            foreach (var itemKh in listRaw)
            {
                var itemKhachHang = new KhachHang
                {
                    id = itemKh.CustomerID,
                    name = itemKh.CustomerName,
                    address = itemKh.Address
                };
                listKH.Add((itemKhachHang));
            }
            //ViewData["DsKh"] = listKH;
            return PartialView(listKH);
        }
        // GET: Customer
        public ActionResult Index()
        {
            //List<Customer> listCustomer = _cmDo.GetListCustomer();
            //ViewData["DanhSachKH"] = listCustomer;

            return View();
        }
    }
}