using Lanco_Project.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Lanco_Project.Utilities;

namespace Lanco_Project.Data
{
    public class RolesData
    {
        string connStr = ConfigurationManager.ConnectionStrings["conndb"].ConnectionString;

        public List<Roles> GetRolesList()
        {
            List<Roles> oRolesList = new List<Roles>();

            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                SqlCommand oCmd = new SqlCommand("SP_GetRoles", oConn);
                oCmd.CommandType = CommandType.StoredProcedure;
                oConn.Open();

                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        oRolesList.Add(new Roles()
                        {
                            RoleID = Convert.ToInt32(oDr["RoleID"].ToString()),
                            RoleName = oDr["RoleName"].ToString(),
                            IsActive = Convert.ToBoolean(oDr["IsActive"])
                        });
                    }
                }
            }

            return oRolesList;
        }

        public int AddRole(Roles oRoles)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_Role", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("RoleName ", oRoles.RoleName);
                    oCmd.Parameters.AddWithValue("IsActive", oRoles.IsActive);
                    oCmd.Parameters.AddWithValue("CreatedDate", DateTime.Now);
                    
                    oCmd.ExecuteNonQuery();

                    _iResponse = 1;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                _iResponse = 0;
            }

            return _iResponse;
        }

        public int EditRole(Roles oRoles)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Edit_Role", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("RoleID", oRoles.RoleID);
                    oCmd.Parameters.AddWithValue("RoleName", oRoles.RoleName);
                    oCmd.Parameters.AddWithValue("IsActive", oRoles.IsActive);

                    oCmd.ExecuteNonQuery();

                    _iResponse = 1;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                _iResponse = 0;
            }

            return _iResponse;
        }

        public int CancelRole(Roles oRoles)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Cancel_Role", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("RoleID", oRoles.RoleID);
                    oCmd.Parameters.AddWithValue("IsActive", false);
                    oCmd.ExecuteNonQuery();

                    _iResponse = 1;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                _iResponse = 0;
            }

            return _iResponse;
        }
    }
}