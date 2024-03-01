using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Lanco_Project.Models;
using Lanco_Project.Utilities;

namespace Lanco_Project.Controllers
{
    public class AccessController : Controller
    {
        string connStr = ConfigurationManager.ConnectionStrings["conndb"].ConnectionString;

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccessUser oUser)
        {
            if (oUser.UserEmail != null && oUser.UserPassword != null)
            {
                oUser.UserPassword = CommonServices.ConvertSha256(oUser.UserPassword);

                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_ValidateAccess", oConn);
                    oCmd.Parameters.AddWithValue("UserEmail", oUser.UserEmail);
                    oCmd.Parameters.AddWithValue("UserPassword", oUser.UserPassword);
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oConn.Open();

                    oUser.UserID = Convert.ToInt32(oCmd.ExecuteScalar().ToString());
                }

                if (oUser.UserID != 0)
                {
                    using (SqlConnection oConn = new SqlConnection(connStr))
                    {
                        SqlCommand oCmd = new SqlCommand("SP_UserLogin", oConn);
                        oCmd.Parameters.AddWithValue("UserID", oUser.UserID);
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oConn.Open();

                        SqlDataAdapter oAdapter = new SqlDataAdapter();
                        oAdapter.SelectCommand = oCmd;

                        DataSet oDs = new DataSet();
                        oAdapter.Fill(oDs);

                        List<int> oRolesID = new List<int>();
                        List<string> oRolesNames = new List<string>();

                        for (int i = 0; i < oDs.Tables[0].Rows.Count; i++)
                        {
                            oUser.UserFirstName = oDs.Tables[0].Rows[i]["UserFirstName"].ToString();
                            oUser.UserLastName = oDs.Tables[0].Rows[i]["UserLastName"].ToString();
                            oUser.UserEmail = oDs.Tables[0].Rows[i]["UserEmail"].ToString();
                            oUser.IsActive = Convert.ToBoolean(oDs.Tables[0].Rows[i]["IsActive"].ToString());

                            oRolesID.Add(Convert.ToInt32(oDs.Tables[0].Rows[i]["RoleID"].ToString()));
                            oRolesNames.Add(oDs.Tables[0].Rows[i]["RoleName"].ToString());
                        }

                        oUser.RoleID = oRolesID.ToArray();
                        oUser.RoleName = oRolesNames.ToArray();
                    }

                    Session["User"] = oUser;

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["Message"] = "Usuario no registrado";

                    return View();
                }
            }
            else
            {
                ViewData["Message"] = "Llenar el formulario para accesar";

                return View();
            }
        }
    }
}