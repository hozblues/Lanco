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
using System.Diagnostics;
using System.Reflection;

namespace Lanco_Project.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos oContactoData = new ContactoDatos();

        [SessionValidate]
        public ActionResult Contact()
        {
            var oLista = oContactoData.GetContactoList();
            ViewBag.Lista = new SelectList(oLista, "ID", "ContactName");
            /* ViewBag.FRutesList = new SelectList(oLuRoutes, "RouteId", "RouteName");
               ViewBag.FResponsibleList = new SelectList(oLuResponsible, "ResponsibleID", "ResponsibleName");
            */
            return View(oLista);
        }

        [HttpPost]
        public ActionResult AddContact(ContactoModel oContacto)
        {
            
            oContacto.Email = string.IsNullOrWhiteSpace(oContacto.Email) ? "" : oContacto.Email;
            if (string.IsNullOrWhiteSpace(oContacto.Email))
            {
                 
                oContacto.Email = "";
            }
            oContacto.Phone = string.IsNullOrWhiteSpace(oContacto.Phone) ? "" : oContacto.Phone;
            oContacto.Name = string.IsNullOrWhiteSpace(oContacto.Name) ? "" : oContacto.Name;
            
            
            //01010001

            // Verificar si el modelo es válido después de la modificación
            if (!ModelState.IsValid)
            {   
                return PartialView("_AddContactPartialView", oContacto);
            }
            else
            {
                int _iResponse = oContactoData.AddContact(oContacto);

                if (_iResponse > 0)
                {
                    Session["MessageStatus"] = "Success";
                    Session["Message"] = "Se agregó correctamente la información";
                }
                else
                {
                    Session["MessageStatus"] = "Danger";
                    Session["Message"] = "Hubo un problema en la alta del contacto";
                }

                return RedirectToAction("Contact");
            }
        }


        public ActionResult EditContact(int Id)
        {
            ContactoModel oContacto = oContactoData.GetContactoList().Where(p => p.IdContact == Id).FirstOrDefault();
            return PartialView("_EditContactPartialView", oContacto);
        }

        [HttpPost]
        public ActionResult EditContact(ContactoModel editContact)
        {
            int _iResponse = oContactoData.EditContact(editContact);
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

            return RedirectToAction("Contact");
        }

        [HttpPost]
        public ActionResult ClearSession()
        {
            Session["MessageStatus"] = null;
            Session["Message"] = null;
            return RedirectToAction("Contact");
        }

        public ActionResult DeleteContact(int Id)
        {
            ContactoModel oContacto = oContactoData.GetContactoList().Where(p => p.IdContact == Id).FirstOrDefault();
            return View(oContacto);
        }

        [HttpPost]
        public ActionResult DeleteContact(ContactoModel deleteContacto)
        {

            int _iResponse = oContactoData.DeleteContact(deleteContacto.IdContact);

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

            return RedirectToAction("Contact");
        }
    }
}
