using Lanco_Project.Data;
using Lanco_Project.Models;
using Lanco_Project.Models.Permision;
using Lanco_Project.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Lanco_Project.Controllers
{
    public class AdminController : Controller
    {
        UsersData oUserData = new UsersData();
        RolesData oRolesData = new RolesData();

        [SessionValidate]

        public ActionResult Users()
        {
            var oUsers = oUserData.GetUsersList();
            var oRoles = oRolesData.GetRolesList().Where(p => p.IsActive == true);

            ViewBag.RolesList = new SelectList(oRoles, "RoleID", "RoleName");

            return View(oUsers);
        }

        [HttpPost]
        public ActionResult Add(Users addUser)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int _iResponse = oUserData.AddUser(addUser);

            if (_iResponse > 0)
            {
                int _iResponseRole = oUserData.AddUserRole(_iResponse, addUser.RoleID);
                if(_iResponseRole > 0)
                {
                    Session["MessageStatus"] = "Success";
                    Session["Message"] = "Se agrego correctamente la información";
                }
                else
                {
                    Session["MessageStatus"] = "Danger";
                    Session["Message"] = "Hubo un problema en la asignación del Rol";
                }                
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la alta del usuario";
            }

            return RedirectToAction("Users");

        }

        public ActionResult Edit(int Id)
        {
            Users oUser = oUserData.GetUsersList().Where(p => p.UserID == Id).FirstOrDefault();
            return PartialView("_EditUserPartialView", oUser);
        }

        [HttpPost]
        public ActionResult Edit(Users editUser)
        {
            int _iResponse = oUserData.EditUser(editUser);

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

            return RedirectToAction("Users");
        }

        public ActionResult Cancel(int Id)
        {
            Users oUser = oUserData.GetUsersList().Where(p => p.UserID == Id).FirstOrDefault();
            return PartialView("_CancelUserPartialView", oUser);
        }

        [HttpPost]
        public ActionResult Cancel(Users cancelUser)
        {
            int _iResponse = oUserData.CancelUser(cancelUser);
            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se desactivo el usuario correctamente";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la desactualización";
            }

            return RedirectToAction("Users");
        }

        public ActionResult Change(int Id)
        {
            Users oUser = oUserData.GetUsersList().Where(p => p.UserID == Id).FirstOrDefault();
            return PartialView("_ChangeUserPartialView", oUser);
        }

        [HttpPost]
        public ActionResult Change(Users changeUser)
        {
            int _iResponse = oUserData.ChangePasswordlUser(changeUser);
            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se actualizo la contraseña correctamente";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la actualización de la contraseña";
            }

            return RedirectToAction("Users");
        }

        [HttpPost]
        public ActionResult ClearSession()
        {
            Session["MessageStatus"] = null;
            Session["Message"] = null;
            return RedirectToAction("Users");
        }


        [SessionValidate]
        public ActionResult Roles()
        {
            var oRoles = oRolesData.GetRolesList();

            return View(oRoles);
        }

        [HttpPost]
        public ActionResult AddRole(Roles addRole)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int _iResponse = oRolesData.AddRole(addRole);

            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se agrego correctamente la información";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la alta del rol";
            }

            return RedirectToAction("Roles");

        }

        public ActionResult EditRole(int Id)
        {
            Roles oRoles = oRolesData.GetRolesList().Where(p => p.RoleID == Id).FirstOrDefault();
            return PartialView("_EditRolePartialView", oRoles);
        }

        [HttpPost]
        public ActionResult EditRole(Roles editRole)
        {
            int _iResponse = oRolesData.EditRole(editRole);

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

            return RedirectToAction("Roles");
        }

        public ActionResult CancelRole(int Id)
        {
            Roles oRole = oRolesData.GetRolesList().Where(p => p.RoleID == Id).FirstOrDefault();
            return PartialView("_CancelRolePartialView", oRole);
        }

        [HttpPost]
        public ActionResult CancelRole(Roles cancelRole)
        {
            int _iResponse = oRolesData.CancelRole(cancelRole);
            if (_iResponse > 0)
            {
                Session["MessageStatus"] = "Success";
                Session["Message"] = "Se desactivo el rol correctamente";
            }
            else
            {
                Session["MessageStatus"] = "Danger";
                Session["Message"] = "Hubo un problema en la desactualización";
            }

            return RedirectToAction("Roles");
        }
    }
}