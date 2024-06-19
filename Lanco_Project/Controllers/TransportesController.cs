using Lanco_Project.Data;
using Lanco_Project.Models.Permision;
using Lanco_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lanco_Project.Data;
using Lanco_Project.Models;
using Microsoft.Ajax.Utilities;

namespace Lanco_Project.Controllers
{
    public class TransportesController : Controller
    {
        _Transportes_BaseGeneral_Data oTransportesBaseGeneralData = new _Transportes_BaseGeneral_Data();

        [SessionValidate]
        public ActionResult List_Transporte_BaseGeneral()
        {
            var oLista = oTransportesBaseGeneralData._Transportes_BaseGeneral_List();
            ViewBag.Lista = new SelectList(oLista, "Item", "Placa");
            return View(oLista);
        }

        [HttpPost]
        public ActionResult _Transportes_BaseGeneral_Add(Transportes_BaseGeneral_Model oTransporteBaseGeneral)
        {
            oTransporteBaseGeneral.Iave = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Iave) ? "" : oTransporteBaseGeneral.Iave;
            oTransporteBaseGeneral.EstatusIave = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.EstatusIave) ? "" : oTransporteBaseGeneral.EstatusIave;
            oTransporteBaseGeneral.Estatus = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Estatus) ? "" : oTransporteBaseGeneral.Estatus;
            oTransporteBaseGeneral.UbicacionInterna = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.UbicacionInterna) ? "" : oTransporteBaseGeneral.UbicacionInterna;
            oTransporteBaseGeneral.GasolinaEntrada = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.GasolinaEntrada) ? "" : oTransporteBaseGeneral.GasolinaEntrada;
            oTransporteBaseGeneral.Estado = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Estado) ? "" : oTransporteBaseGeneral.Estado;
            oTransporteBaseGeneral.CoordinadorForaneoEncargado = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.CoordinadorForaneoEncargado) ? "" : oTransporteBaseGeneral.CoordinadorForaneoEncargado;
            oTransporteBaseGeneral.Chofer = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Chofer) ? "" : oTransporteBaseGeneral.Chofer;
            oTransporteBaseGeneral.ClaveObra = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ClaveObra) ? "" : oTransporteBaseGeneral.ClaveObra;
            oTransporteBaseGeneral.Obra = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Obra) ? "" : oTransporteBaseGeneral.Obra;
            oTransporteBaseGeneral.ImporteCobranzaMayo2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaMayo2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaMayo2022;
            oTransporteBaseGeneral.ImporteCobranzaJunio2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaJunio2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaJunio2022;
            oTransporteBaseGeneral.ImporteCobranzaJulio2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaJulio2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaJulio2022;
            oTransporteBaseGeneral.ImporteCobranzaAgosto2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaAgosto2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaAgosto2022;
            oTransporteBaseGeneral.ImporteCobranzaSeptiembre2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaSeptiembre2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaSeptiembre2022;
            oTransporteBaseGeneral.ImporteCobranzaOctubre2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaOctubre2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaOctubre2022;
            oTransporteBaseGeneral.ImporteCobranzaNoviembre2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaNoviembre2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaNoviembre2022;
            oTransporteBaseGeneral.ImporteCobranzaDiciembre2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaDiciembre2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaDiciembre2022;
            oTransporteBaseGeneral.ImporteCobranzaEnero2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaEnero2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaEnero2023;
            oTransporteBaseGeneral.ImporteCobranzaFebrero2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaFebrero2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaFebrero2023;
            oTransporteBaseGeneral.ImporteCobranzaMarzo2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaMarzo2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaMarzo2023;
            oTransporteBaseGeneral.ImporteCobranzaAbril2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaAbril2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaAbril2023;
            oTransporteBaseGeneral.ImporteCobranzaMayo2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaMayo2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaMayo2023;
            oTransporteBaseGeneral.ImporteCobranzaJunio2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaJunio2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaJunio2023;
            oTransporteBaseGeneral.ImporteCobranzaJulio2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaJulio2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaJulio2023;
            oTransporteBaseGeneral.ImporteCobranzaAgosto2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaAgosto2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaAgosto2023;
            oTransporteBaseGeneral.ImporteCobranzaSeptiembre2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaSeptiembre2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaSeptiembre2023;
            oTransporteBaseGeneral.ImporteCobranzaOctubre2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaOctubre2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaOctubre2023;
            oTransporteBaseGeneral.ImporteCobranzaNoviembre2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaNoviembre2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaNoviembre2023;
            oTransporteBaseGeneral.ImporteCobranzaDiciembre2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaDiciembre2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaDiciembre2023;
            oTransporteBaseGeneral.ImporteCobranzaEnero2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaEnero2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaEnero2024;
            oTransporteBaseGeneral.ImporteCobranzaFebrero2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaFebrero2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaFebrero2024;
            oTransporteBaseGeneral.ImporteCobranzaMarzo2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaMarzo2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaMarzo2024;
            oTransporteBaseGeneral.ImporteCobranzaAbril2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaAbril2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaAbril2024;
            oTransporteBaseGeneral.ImporteCobranzaMayo2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaMayo2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaMayo2024;
            oTransporteBaseGeneral.ImporteCobranzaJunio2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaJunio2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaJunio2024;
            oTransporteBaseGeneral.ImporteCobranzaJulio2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaJulio2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaJulio2024;
            oTransporteBaseGeneral.ImporteCobranzaAgosto2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaAgosto2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaAgosto2024;
            oTransporteBaseGeneral.ImporteCobranzaSeptiembre2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaSeptiembre2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaSeptiembre2024;
            oTransporteBaseGeneral.ImporteCobranzaOctubre2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaOctubre2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaOctubre2024;
            oTransporteBaseGeneral.ImporteCobranzaNoviembre2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaNoviembre2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaNoviembre2024;
            oTransporteBaseGeneral.ImporteCobranzaDiciembre2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaDiciembre2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaDiciembre2024;
            oTransporteBaseGeneral.Factura = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Factura) ? "" : oTransporteBaseGeneral.Factura;
            oTransporteBaseGeneral.Observaciones = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Observaciones) ? "" : oTransporteBaseGeneral.Observaciones;
            oTransporteBaseGeneral.PrimerSemestre = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.PrimerSemestre) ? "" : oTransporteBaseGeneral.PrimerSemestre;
            oTransporteBaseGeneral.SegundoSemestre = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.SegundoSemestre) ? "" : oTransporteBaseGeneral.SegundoSemestre;
            oTransporteBaseGeneral.Seguro = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Seguro) ? "" : oTransporteBaseGeneral.Seguro;
            oTransporteBaseGeneral.NumeroPoliza = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.NumeroPoliza) ? "" : oTransporteBaseGeneral.NumeroPoliza;
            oTransporteBaseGeneral.Entidad = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Entidad) ? "" : oTransporteBaseGeneral.Entidad;
            oTransporteBaseGeneral.Refrendo = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Refrendo) ? "" : oTransporteBaseGeneral.Refrendo;
            oTransporteBaseGeneral.LicenciaDensimetroNuclear = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.LicenciaDensimetroNuclear) ? "" : oTransporteBaseGeneral.LicenciaDensimetroNuclear;
            oTransporteBaseGeneral.CombustibleRetorno = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.CombustibleRetorno) ? "" : oTransporteBaseGeneral.CombustibleRetorno;
            oTransporteBaseGeneral.Observaciones3 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Observaciones3) ? "" : oTransporteBaseGeneral.Observaciones3;
            // Verificar si el modelo es válido después de la modificación
            if (!ModelState.IsValid)
            {
                
                return PartialView("Add_Transporte_BaseGeneral", oTransporteBaseGeneral);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Modelo Valido");
                int _iResponse = oTransportesBaseGeneralData.AddTransportesBaseGeneral(oTransporteBaseGeneral);
                oTransporteBaseGeneral.Iave = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Iave) ? "" : oTransporteBaseGeneral.Iave;
                oTransporteBaseGeneral.EstatusIave = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.EstatusIave) ? "" : oTransporteBaseGeneral.EstatusIave;
                oTransporteBaseGeneral.Estatus = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Estatus) ? "" : oTransporteBaseGeneral.Estatus;
                oTransporteBaseGeneral.UbicacionInterna = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.UbicacionInterna) ? "" : oTransporteBaseGeneral.UbicacionInterna;
                oTransporteBaseGeneral.GasolinaEntrada = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.GasolinaEntrada) ? "" : oTransporteBaseGeneral.GasolinaEntrada;
                oTransporteBaseGeneral.Estado = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Estado) ? "" : oTransporteBaseGeneral.Estado;
                oTransporteBaseGeneral.CoordinadorForaneoEncargado = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.CoordinadorForaneoEncargado) ? "" : oTransporteBaseGeneral.CoordinadorForaneoEncargado;
                oTransporteBaseGeneral.Chofer = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Chofer) ? "" : oTransporteBaseGeneral.Chofer;
                oTransporteBaseGeneral.ClaveObra = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ClaveObra) ? "" : oTransporteBaseGeneral.ClaveObra;
                oTransporteBaseGeneral.Obra = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Obra) ? "" : oTransporteBaseGeneral.Obra;
                oTransporteBaseGeneral.ImporteCobranzaMayo2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaMayo2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaMayo2022;
                oTransporteBaseGeneral.ImporteCobranzaJunio2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaJunio2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaJunio2022;
                oTransporteBaseGeneral.ImporteCobranzaJulio2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaJulio2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaJulio2022;
                oTransporteBaseGeneral.ImporteCobranzaAgosto2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaAgosto2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaAgosto2022;
                oTransporteBaseGeneral.ImporteCobranzaSeptiembre2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaSeptiembre2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaSeptiembre2022;
                oTransporteBaseGeneral.ImporteCobranzaOctubre2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaOctubre2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaOctubre2022;
                oTransporteBaseGeneral.ImporteCobranzaNoviembre2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaNoviembre2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaNoviembre2022;
                oTransporteBaseGeneral.ImporteCobranzaDiciembre2022 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaDiciembre2022) ? "" : oTransporteBaseGeneral.ImporteCobranzaDiciembre2022;
                oTransporteBaseGeneral.ImporteCobranzaEnero2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaEnero2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaEnero2023;
                oTransporteBaseGeneral.ImporteCobranzaFebrero2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaFebrero2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaFebrero2023;
                oTransporteBaseGeneral.ImporteCobranzaMarzo2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaMarzo2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaMarzo2023;
                oTransporteBaseGeneral.ImporteCobranzaAbril2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaAbril2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaAbril2023;
                oTransporteBaseGeneral.ImporteCobranzaMayo2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaMayo2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaMayo2023;
                oTransporteBaseGeneral.ImporteCobranzaJunio2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaJunio2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaJunio2023;
                oTransporteBaseGeneral.ImporteCobranzaJulio2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaJulio2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaJulio2023;
                oTransporteBaseGeneral.ImporteCobranzaAgosto2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaAgosto2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaAgosto2023;
                oTransporteBaseGeneral.ImporteCobranzaSeptiembre2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaSeptiembre2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaSeptiembre2023;
                oTransporteBaseGeneral.ImporteCobranzaOctubre2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaOctubre2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaOctubre2023;
                oTransporteBaseGeneral.ImporteCobranzaNoviembre2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaNoviembre2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaNoviembre2023;
                oTransporteBaseGeneral.ImporteCobranzaDiciembre2023 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaDiciembre2023) ? "" : oTransporteBaseGeneral.ImporteCobranzaDiciembre2023;
                oTransporteBaseGeneral.ImporteCobranzaEnero2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaEnero2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaEnero2024;
                oTransporteBaseGeneral.ImporteCobranzaFebrero2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaFebrero2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaFebrero2024;
                oTransporteBaseGeneral.ImporteCobranzaMarzo2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaMarzo2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaMarzo2024;
                oTransporteBaseGeneral.ImporteCobranzaAbril2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaAbril2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaAbril2024;
                oTransporteBaseGeneral.ImporteCobranzaMayo2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaMayo2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaMayo2024;
                oTransporteBaseGeneral.ImporteCobranzaJunio2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaJunio2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaJunio2024;
                oTransporteBaseGeneral.ImporteCobranzaJulio2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaJulio2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaJulio2024;
                oTransporteBaseGeneral.ImporteCobranzaAgosto2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaAgosto2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaAgosto2024;
                oTransporteBaseGeneral.ImporteCobranzaSeptiembre2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaSeptiembre2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaSeptiembre2024;
                oTransporteBaseGeneral.ImporteCobranzaOctubre2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaOctubre2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaOctubre2024;
                oTransporteBaseGeneral.ImporteCobranzaNoviembre2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaNoviembre2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaNoviembre2024;
                oTransporteBaseGeneral.ImporteCobranzaDiciembre2024 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.ImporteCobranzaDiciembre2024) ? "" : oTransporteBaseGeneral.ImporteCobranzaDiciembre2024;
                oTransporteBaseGeneral.Factura = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Factura) ? "" : oTransporteBaseGeneral.Factura;
                oTransporteBaseGeneral.Observaciones = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Observaciones) ? "" : oTransporteBaseGeneral.Observaciones;
                oTransporteBaseGeneral.PrimerSemestre = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.PrimerSemestre) ? "" : oTransporteBaseGeneral.PrimerSemestre;
                oTransporteBaseGeneral.SegundoSemestre = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.SegundoSemestre) ? "" : oTransporteBaseGeneral.SegundoSemestre;
                oTransporteBaseGeneral.Seguro = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Seguro) ? "" : oTransporteBaseGeneral.Seguro;
                oTransporteBaseGeneral.NumeroPoliza = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.NumeroPoliza) ? "" : oTransporteBaseGeneral.NumeroPoliza;
                oTransporteBaseGeneral.Entidad = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Entidad) ? "" : oTransporteBaseGeneral.Entidad;
                oTransporteBaseGeneral.Refrendo = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Refrendo) ? "" : oTransporteBaseGeneral.Refrendo;
                oTransporteBaseGeneral.LicenciaDensimetroNuclear = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.LicenciaDensimetroNuclear) ? "" : oTransporteBaseGeneral.LicenciaDensimetroNuclear;
                oTransporteBaseGeneral.CombustibleRetorno = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.CombustibleRetorno) ? "" : oTransporteBaseGeneral.CombustibleRetorno;
                oTransporteBaseGeneral.Observaciones3 = string.IsNullOrWhiteSpace(oTransporteBaseGeneral.Observaciones3) ? "" : oTransporteBaseGeneral.Observaciones3;
                if (_iResponse > 0)
                {
                    Session["MessageStatus"] = "Success";
                    Session["Message"] = "Se agregó correctamente la información";
                }
                else
                {
                    Session["MessageStatus"] = "Danger";
                    Session["Message"] = "Hubo un problema en la alta del transporte";
                }

                return RedirectToAction("List_Transporte_BaseGeneral");
            }
        }

        public ActionResult _Transportes_BaseGeneral_Edit(string Placa)
        {
            Transportes_BaseGeneral_Model oTransporteBaseGeneral = oTransportesBaseGeneralData._Transportes_BaseGeneral_List().Where(p => p.Placa == Placa).FirstOrDefault();
            return PartialView("Edit_Transporte_BaseGeneral", oTransporteBaseGeneral);
        }

        [HttpPost]
        public ActionResult _Transportes_BaseGeneral_Edit(Transportes_BaseGeneral_Model editTransport)
        {
            int _iResponse = oTransportesBaseGeneralData.EditTransportesBaseGeneral(editTransport);

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

            return RedirectToAction("List_Transporte_BaseGeneral");
        }

        [HttpPost]
        public ActionResult ClearSession()
        {
            Session["MessageStatus"] = null;
            Session["Message"] = null;
            return RedirectToAction("List_Transporte_BaseGeneral");
        }
        public ActionResult _Transportes_BaseGeneral_Delete(string Placa)
        {
            Transportes_BaseGeneral_Model oTransport = oTransportesBaseGeneralData._Transportes_BaseGeneral_List().Where(p => p.Placa == Placa).FirstOrDefault();
            return View(oTransport);
        }

        [HttpPost]
        public ActionResult _Transportes_BaseGeneral_Delete(Transportes_BaseGeneral_Model deleteTransport)
        {
            int _iResponse = oTransportesBaseGeneralData.DeleteTransportesBaseGeneral(deleteTransport.Placa);

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

            return RedirectToAction("List_Transporte_BaseGeneral");
        }

    }
}
