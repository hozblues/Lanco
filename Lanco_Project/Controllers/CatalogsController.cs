using Lanco_Project.Data;
using Lanco_Project.Models;
using Lanco_Project.Models.Permision;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lanco_Project.Controllers
{
    public class CatalogsController : Controller
    {
        CatalogsData oCatalogsData = new CatalogsData();
        // GET: Catalogs

        [SessionValidate]

        // Route
        public ActionResult Route()
        {
            var oRoute = oCatalogsData.GetRoutesList();

            return View(oRoute);
        }


        [HttpPost]
        public ActionResult AddRoute(CRoutes addRoute)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int _iResponse = oCatalogsData.AddRoute(addRoute);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se agrego correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la alta de la ruta";
            }

            return RedirectToAction("Route");

        }

        public ActionResult EditRoute(int Id)
        {
            CRoutes oRoutes = oCatalogsData.GetRoutesList().Where(p => p.RouteId == Id).FirstOrDefault();
            return PartialView("_EditRoutePartialView", oRoutes);
        }

        [HttpPost]
        public ActionResult EditRoute(CRoutes editRoute)
        {
            int _iResponse = oCatalogsData.EditRoute(editRoute);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se actualizó correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la actualización";
            }

            return RedirectToAction("Route");
        }

        [HttpPost]
        public ActionResult ClearSession()
        {
            Session["MessageStatus"] = null;
            Session["Message"] = null;
            return RedirectToAction("Route");
        }

        [SessionValidate]
        // Responsible
        public ActionResult Responsible()
        {
            var oResponsible = oCatalogsData.GetResponsibleList();

            return View(oResponsible);
        }

        [HttpPost]
        public ActionResult AddResponsible(CResponsible addResponsible)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int _iResponse = oCatalogsData.AddResponsible(addResponsible);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se agrego correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la alta de la ruta";
            }

            return RedirectToAction("Responsible");

        }

        public ActionResult EditResponsible(int Id)
        {
            CResponsible oResponsibles = oCatalogsData.GetResponsibleList().Where(p => p.ResponsibleID == Id).FirstOrDefault();
            return PartialView("_EditResponsiblePartialView", oResponsibles);
        }

        [HttpPost]
        public ActionResult EditResponsible(CResponsible editResponsible)
        {
            int _iResponse = oCatalogsData.EditResponsible(editResponsible);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se actualizó correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la actualización";
            }

            return RedirectToAction("Responsible");
        }

        [SessionValidate]
        // Customers
        public ActionResult Customers()
        {
            var oCustomers = oCatalogsData.GetCustomersList();

            return View(oCustomers);
        }

        [HttpPost]
        public ActionResult AddCustomers(CCustomers addCustomers)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int _iResponse = oCatalogsData.AddCustomers(addCustomers);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se agrego correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la alta de la ruta";
            }

            return RedirectToAction("Customers");

        }

        public ActionResult EditCustomers(int Id)
        {
            CCustomers oCustomerss = oCatalogsData.GetCustomersList().Where(p => p.CustomerID == Id).FirstOrDefault();
            return PartialView("_EditCustomersPartialView", oCustomerss);
        }

        [HttpPost]
        public ActionResult EditCustomers(CCustomers editCustomers)
        {
            int _iResponse = oCatalogsData.EditCustomers(editCustomers);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se actualizó correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la actualización";
            }

            return RedirectToAction("Customers");
        }

        [SessionValidate]
        // Banks
        public ActionResult Banks()
        {
            var oBanks = oCatalogsData.GetBanksList();

            return View(oBanks);
        }

        [HttpPost]
        public ActionResult AddBanks(CBanks addBanks)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int _iResponse = oCatalogsData.AddBanks(addBanks);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se agrego correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la alta de la ruta";
            }

            return RedirectToAction("Banks");

        }

        public ActionResult EditBanks(int Id)
        {
            CBanks oBanks = oCatalogsData.GetBanksList().Where(p => p.BankID == Id).FirstOrDefault();
            return PartialView("_EditBanksPartialView", oBanks);
        }

        [HttpPost]
        public ActionResult EditBanks(CBanks editBanks)
        {
            int _iResponse = oCatalogsData.EditBanks(editBanks);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se actualizó correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la actualización";
            }

            return RedirectToAction("Banks");
        }

        [SessionValidate]
        // Currency
        public ActionResult Currency()
        {
            var oCurrency = oCatalogsData.GetCurrencyList();

            return View(oCurrency);
        }

        [HttpPost]
        public ActionResult AddCurrency(CCurrency addCurrency)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int _iResponse = oCatalogsData.AddCurrency(addCurrency);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se agrego correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la alta de la ruta";
            }

            return RedirectToAction("Currency");

        }

        public ActionResult EditCurrency(int Id)
        {
            CCurrency oCurrency = oCatalogsData.GetCurrencyList().Where(p => p.CurrencyID == Id).FirstOrDefault();
            return PartialView("_EditCurrencyPartialView", oCurrency);
        }

        [HttpPost]
        public ActionResult EditCurrency(CCurrency editCurrency)
        {
            int _iResponse = oCatalogsData.EditCurrency(editCurrency);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se actualizó correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la actualización";
            }

            return RedirectToAction("Currency");
        }

        [SessionValidate]
        // ConstructionSite
        public ActionResult ConstructionSite()
        {
            var oConstructionSite = oCatalogsData.GetConstructionSiteList();

            return View(oConstructionSite);
        }

        [HttpPost]
        public ActionResult AddConstructionSite(CConstructionSite addConstructionSite)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int _iResponse = oCatalogsData.AddConstructionSite(addConstructionSite);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se agrego correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la alta de la ruta";
            }

            return RedirectToAction("ConstructionSite");

        }

        public ActionResult EditConstructionSite(int Id)
        {
            CConstructionSite oConstructionSite = oCatalogsData.GetConstructionSiteList().Where(p => p.ConstructionSiteID == Id).FirstOrDefault();
            return PartialView("_EditConstructionSitePartialView", oConstructionSite);
        }

        [HttpPost]
        public ActionResult EditConstructionSite(CConstructionSite editConstructionSite)
        {
            int _iResponse = oCatalogsData.EditConstructionSite(editConstructionSite);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se actualizó correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la actualización";
            }

            return RedirectToAction("ConstructionSite");
        }
    }
}