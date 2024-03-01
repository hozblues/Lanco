using Lanco_Project.Data;
using Lanco_Project.Models.Permision;
using Lanco_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lanco_Project.Controllers
{
    public class FactsController : Controller
    {
        FactsData oFactsData = new FactsData();
        CatalogsData oCatalogsData = new CatalogsData();

        [SessionValidate]
        public ActionResult FRoutes()
        {
            var oFRoutes = oFactsData.GetRoutesList();
            var oLuRoutes = oCatalogsData.GetRoutesList().Where(p => p.IsActive == true);
            var oLuResponsible = oCatalogsData.GetResponsibleList().Where(p => p.IsActive == true);

            ViewBag.FRutesList = new SelectList(oLuRoutes, "RouteId", "RouteName");
            ViewBag.FResponsibleList = new SelectList(oLuResponsible, "ResponsibleID", "ResponsibleName");

            return View(oFRoutes);
        }

        [HttpPost]
        public ActionResult AddFRoute(FRoutes addRoute)
        {
            if (!ModelState.IsValid)
            {
                var oLuRoutes = oCatalogsData.GetRoutesList().Where(p => p.IsActive == true);
                var oLuResponsible = oCatalogsData.GetResponsibleList().Where(p => p.IsActive == true);

                ViewBag.FRutesList = new SelectList(oLuRoutes, "RouteId", "RouteName");
                ViewBag.FResponsibleList = new SelectList(oLuResponsible, "ResponsibleID", "ResponsibleName");

                return PartialView("_AddFRoutesPartialView", addRoute);
            }
            else
            {
                int _iResponse = oFactsData.AddRoute(addRoute);

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

                return RedirectToAction("FRoutes");
            }
        }

        public ActionResult EditFRoute(int Id)
        {
            FRoutes oFRoute = oFactsData.GetRoutesList().Where(p => p.RouteFact_ID == Id).FirstOrDefault();
            return PartialView("_EditFRoutePartialView", oFRoute);
        }

        [HttpPost]
        public ActionResult EditFRoute(FRoutes editRoute)
        {
            int _iResponse = oFactsData.EditRoute(editRoute);

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

            return RedirectToAction("FRoutes");
        }

        [HttpPost]
        public ActionResult ClearSession()
        {
            Session["MessageStatus"] = null;
            Session["Message"] = null;
            return RedirectToAction("FRoutes");
        }

        [SessionValidate]
        public ActionResult FPaymentsSAE()
        {
            var oFPaymentSAE = oFactsData.GetPaymentSAEList();
            var oLuCustomers = oCatalogsData.GetCustomersList().Where(p => p.IsActive == true);
            var oLuBanks = oCatalogsData.GetBanksList().Where(p => p.IsActive == true);
            var oCurrency = oCatalogsData.GetCurrencyList().Where(p => p.IsActive == true);
            var oLuRoutes = oCatalogsData.GetRoutesList().Where(p => p.IsActive == true);
            var oLuResponsible = oCatalogsData.GetResponsibleList().Where(p => p.IsActive == true);

            ViewBag.FCustomersList = new SelectList(oLuCustomers, "CustomerID", "CustomerName");
            ViewBag.FBanksList = new SelectList(oLuBanks, "BankID", "BankName");
            ViewBag.FCurrencyList = new SelectList(oCurrency, "CurrencyID", "CurrencyCode");
            ViewBag.FRutesList = new SelectList(oLuRoutes, "RouteId", "RouteName");
            ViewBag.FResponsibleList = new SelectList(oLuResponsible, "ResponsibleID", "ResponsibleName");

            return View(oFPaymentSAE);
        }

        [HttpPost]
        public ActionResult AddFPaymentsSAE(FPaymentsSAE addPayment)
        {
            if (!ModelState.IsValid)
            {
                var oLuCustomers = oCatalogsData.GetCustomersList().Where(p => p.IsActive == true);
                var oLuBanks = oCatalogsData.GetBanksList().Where(p => p.IsActive == true);
                var oCurrency = oCatalogsData.GetCurrencyList().Where(p => p.IsActive == true);
                var oLuRoutes = oCatalogsData.GetRoutesList().Where(p => p.IsActive == true);
                var oLuResponsible = oCatalogsData.GetResponsibleList().Where(p => p.IsActive == true);

                ViewBag.FCustomersList = new SelectList(oLuCustomers, "CustomerID", "CustomerName");
                ViewBag.FBanksList = new SelectList(oLuBanks, "BankID", "BankName");
                ViewBag.FCurrencyList = new SelectList(oCurrency, "CurrencyID", "CurrencyCode");
                ViewBag.FRutesList = new SelectList(oLuRoutes, "RouteId", "RouteName");
                ViewBag.FResponsibleList = new SelectList(oLuResponsible, "ResponsibleID", "ResponsibleName");

                return PartialView("_AddFPaymentSAEPartialView", addPayment);
            }
            else
            {
                int _iResponse = oFactsData.AddPaymentSAE(addPayment);

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

                return RedirectToAction("FPaymentsSAE");
            }
        }

        public ActionResult EditFPaymentsSAE(int Id)
        {
            FPaymentsSAE oFPaymentsSAE = oFactsData.GetPaymentSAEList().Where(p => p.PaymentSAE_ID == Id).FirstOrDefault();
            return PartialView("_EditFPaymentSAEPartialView", oFPaymentsSAE);
        }

        [HttpPost]
        public ActionResult EditFPaymentsSAE(FPaymentsSAE editPayment)
        {
            int _iResponse = oFactsData.EditPaymentsSAE(editPayment);

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

            return RedirectToAction("FPaymentsSAE");
        }

        [SessionValidate]
        public ActionResult FForcast()
        {
            var oFForcast = oFactsData.GetForecastsList();
            var oLuConstructionSite = oCatalogsData.GetConstructionSiteList().Where(p => p.IsActive == true);
            var oLuRoutes = oCatalogsData.GetRoutesList().Where(p => p.IsActive == true);
            var oLuResponsible = oCatalogsData.GetResponsibleList().Where(p => p.IsActive == true);

            ViewBag.FConstructionSiteList = new SelectList(oLuConstructionSite, "ConstructionSiteID", "ConstructionSiteName");
            ViewBag.FRutesList = new SelectList(oLuRoutes, "RouteId", "RouteName");
            ViewBag.FResponsibleList = new SelectList(oLuResponsible, "ResponsibleID", "ResponsibleName");

            return View(oFForcast);
        }

        [HttpPost]
        public ActionResult AddFForcast(FForecast addForecast)
        {
            if (!ModelState.IsValid)
            {
                var oLuConstructionSite = oCatalogsData.GetConstructionSiteList().Where(p => p.IsActive == true);
                var oLuRoutes = oCatalogsData.GetRoutesList().Where(p => p.IsActive == true);
                var oLuResponsible = oCatalogsData.GetResponsibleList().Where(p => p.IsActive == true);

                ViewBag.FConstructionSiteList = new SelectList(oLuConstructionSite, "ConstructionSiteID", "ConstructionSiteName");
                ViewBag.FRutesList = new SelectList(oLuRoutes, "RouteId", "RouteName");
                ViewBag.FResponsibleList = new SelectList(oLuResponsible, "ResponsibleID", "ResponsibleName");

                return PartialView("_AddFForcastPartialView", addForecast);
            }
            else
            {
                int _iResponse = oFactsData.AddForecasts(addForecast);

                if (_iResponse > 0)
                {
                    Session["MessageStatus"] = "Success";
                    Session["Message"] = "Se agrego correctamente la información";
                }
                else
                {
                    Session["MessageStatus"] = "Danger";
                    Session["Message"] = "Hubo un problema en la alta del Forcast";
                }

                return RedirectToAction("FForcast");
            }
        }

        public ActionResult EditFForcast(int Id)
        {
            FPaymentsSAE oFPaymentsSAE = oFactsData.GetPaymentSAEList().Where(p => p.PaymentSAE_ID == Id).FirstOrDefault();
            return PartialView("_EditFForcastPartialView", oFPaymentsSAE);
        }

        [HttpPost]
        public ActionResult EditFForcast(FForecast editForcast)
        {
            int _iResponse = oFactsData.EditForecasts(editForcast);

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

            return RedirectToAction("FForcast");
        }

        [SessionValidate]
        public ActionResult FFiles()
        {
            var oFFiles = oFactsData.GetFilesList();
            var oLuCustomer = oCatalogsData.GetCustomersList().Where(p => p.IsActive == true);
            var oLuConstructionSite = oCatalogsData.GetConstructionSiteList().Where(p => p.IsActive == true);

            ViewBag.FCustomerList = new SelectList(oLuCustomer, "CustomerID", "CustomerName");
            ViewBag.FConstructionSiteList = new SelectList(oLuConstructionSite, "ConstructionSiteID", "ConstructionSiteName");

            return View(oFFiles);
        }

        [HttpPost]
        public ActionResult AddFFiles(FFiles addFiles)
        {
            if (!ModelState.IsValid)
            {
                var oLuCustomer = oCatalogsData.GetCustomersList().Where(p => p.IsActive == true);
                var oLuConstructionSite = oCatalogsData.GetConstructionSiteList().Where(p => p.IsActive == true);

                ViewBag.FCustomerList = new SelectList(oLuCustomer, "CustomerID", "CustomerName");
                ViewBag.FConstructionSiteList = new SelectList(oLuConstructionSite, "ConstructionSiteID", "ConstructionSiteName");

                return PartialView("_AddFFilesPartialView", addFiles);
            }
            else
            {
                int _iResponse = oFactsData.AddFiles(addFiles);

                if (_iResponse > 0)
                {
                    Session["MessageStatus"] = "Success";
                    Session["Message"] = "Se agrego correctamente la información";
                }
                else
                {
                    Session["MessageStatus"] = "Danger";
                    Session["Message"] = "Hubo un problema en la alta del expediente";
                }

                return RedirectToAction("FFiles");
            }
        }

        public ActionResult EditFFiles(int Id)
        {
            FFiles oFFiles = oFactsData.GetFilesList().Where(p => p.Files_ID == Id).FirstOrDefault();
            return PartialView("_EditFFilesPartialView", oFFiles);
        }

        [HttpPost]
        public ActionResult EditFFiles(FFiles editFiles)
        {
            int _iResponse = oFactsData.EditFiles(editFiles);

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

            return RedirectToAction("FFiles");
        }
    }
}