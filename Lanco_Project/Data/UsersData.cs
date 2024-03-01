using Lanco_Project.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using System.Net;
using Lanco_Project.Utilities;

namespace Lanco_Project.Data
{
    public class UsersData
    {
        string connStr = ConfigurationManager.ConnectionStrings["conndb"].ConnectionString;

        public List<Users> GetUsersList() {
            List<Users> oUsersList = new List<Users>();

            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                SqlCommand oCmd = new SqlCommand("SP_GetAllUsers", oConn);
                oCmd.CommandType = CommandType.StoredProcedure;
                oConn.Open();

                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        oUsersList.Add(new Users()
                        {
                            UserID = Convert.ToInt32(oDr["UserID"]),
                            UserFirstName = oDr["UserFirstName"].ToString(),
                            UserLastName = oDr["UserLastName"].ToString(),
                            UserEmail = oDr["UserEmail"].ToString(),
                            IsActive = Convert.ToBoolean(oDr["IsActive"]),
                            RoleID = Convert.ToInt32(oDr["RoleID"].ToString()),
                            RoleName = oDr["RoleName"].ToString(),
                            RelationshipID = Convert.ToInt32(oDr["Relationship_ID"].ToString()),
                        });
                    }
                }
            }

            return oUsersList;
        }

        public int AddUser(Users oUser)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_User", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("UserFirstName", oUser.UserFirstName);
                    oCmd.Parameters.AddWithValue("UserLastName", oUser.UserLastName);
                    oCmd.Parameters.AddWithValue("UserEmail", oUser.UserEmail);
                    oCmd.Parameters.AddWithValue("UserPassword", CommonServices.ConvertSha256(oUser.UserPassword));
                    oCmd.Parameters.AddWithValue("CreatedDate", DateTime.Now);
                    oCmd.Parameters.AddWithValue("IsActive", oUser.IsActive);

                    SqlParameter oIncID = new SqlParameter("@Response", SqlDbType.Int);
                    oIncID.Direction = ParameterDirection.Output;
                    oCmd.Parameters.Add(oIncID);
                    oCmd.ExecuteNonQuery();

                    _iResponse = (int)oCmd.Parameters["@Response"].Value;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                _iResponse = 0;
            }

            return _iResponse;
        }
        
        public int AddUserRole(int User_ID, int Role_ID)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_Role", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("RoleID ", Role_ID);
                    oCmd.Parameters.AddWithValue("UserID", User_ID);
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

        public int EditUser(Users oUser)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Edit_User", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("UserID", oUser.UserID);
                    oCmd.Parameters.AddWithValue("UserFirstName", oUser.UserFirstName);
                    oCmd.Parameters.AddWithValue("UserLastName", oUser.UserLastName);
                    oCmd.Parameters.AddWithValue("UserEmail", oUser.UserEmail);
                    oCmd.Parameters.AddWithValue("CreatedDate", DateTime.Now);
                    oCmd.Parameters.AddWithValue("IsActive", oUser.IsActive);
                    oCmd.Parameters.AddWithValue("RoleID", oUser.RoleID);
                    oCmd.Parameters.AddWithValue("RelationshipID", oUser.RelationshipID);
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

        public int CancelUser(Users oUser)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Cancel_User", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("UserID", oUser.UserID);
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

        public int ChangePasswordlUser(Users oUser)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_ChangePass_User", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("UserID", oUser.UserID);
                    oCmd.Parameters.AddWithValue("Password", CommonServices.ConvertSha256(oUser.UserPassword));
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