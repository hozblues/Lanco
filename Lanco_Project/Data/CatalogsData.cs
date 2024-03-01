using Lanco_Project.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Lanco_Project.Data
{
    public class CatalogsData
    {
        string connStr = ConfigurationManager.ConnectionStrings["conndb"].ConnectionString;

        // Routes
        public List<CRoutes> GetRoutesList()
        {
            List<CRoutes> oRoutesList = new List<CRoutes>();

            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                SqlCommand oCmd = new SqlCommand("SP_Get_Routes", oConn);
                oCmd.CommandType = CommandType.StoredProcedure;
                oConn.Open();

                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        oRoutesList.Add(new CRoutes()
                        {
                            RouteId = Convert.ToInt32(oDr["RouteID"]),
                            RouteName = oDr["RouteName"].ToString(),
                            IsActive = Convert.ToBoolean(oDr["IsActive"])
                        });
                    }
                }
            }

            return oRoutesList;
        }

        public int AddRoute(CRoutes oRoute)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_Routes", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("RouteName ", oRoute.RouteName);
                    oCmd.Parameters.AddWithValue("IsActive", oRoute.IsActive);
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

        public int EditRoute(CRoutes oRoute)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Edit_Routes", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("RouteID", oRoute.RouteId);
                    oCmd.Parameters.AddWithValue("RouteName", oRoute.RouteName);
                    oCmd.Parameters.AddWithValue("IsActive", oRoute.IsActive);

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

        // Responsible
        public List<CResponsible> GetResponsibleList()
        {
            List<CResponsible> oResponsibleList = new List<CResponsible>();

            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                SqlCommand oCmd = new SqlCommand("SP_Get_Responsible", oConn);
                oCmd.CommandType = CommandType.StoredProcedure;
                oConn.Open();

                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        oResponsibleList.Add(new CResponsible()
                        {
                            ResponsibleID = Convert.ToInt32(oDr["ResponsibleID"]),
                            ResponsibleName = oDr["ResponsibleName"].ToString(),
                            IsActive = Convert.ToBoolean(oDr["IsActive"])
                        });
                    }
                }
            }

            return oResponsibleList;
        }

        public int AddResponsible(CResponsible oResponsible)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_Responsible", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("ResponsibleName ", oResponsible.ResponsibleName);
                    oCmd.Parameters.AddWithValue("IsActive", oResponsible.IsActive);
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

        public int EditResponsible(CResponsible oResponsible)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Edit_Responsible", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("ResponsibleID", oResponsible.ResponsibleID);
                    oCmd.Parameters.AddWithValue("ResponsibleName", oResponsible.ResponsibleName);
                    oCmd.Parameters.AddWithValue("IsActive", oResponsible.IsActive);

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

        // Customers
        public List<CCustomers> GetCustomersList()
        {
            List<CCustomers> oCustomersList = new List<CCustomers>();

            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                SqlCommand oCmd = new SqlCommand("SP_Get_Customers", oConn);
                oCmd.CommandType = CommandType.StoredProcedure;
                oConn.Open();

                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        oCustomersList.Add(new CCustomers()
                        {
                            CustomerID = Convert.ToInt32(oDr["CustomerID"]),
                            CustomerName = oDr["CustomerName"].ToString(),
                            IsActive = Convert.ToBoolean(oDr["IsActive"])
                        });
                    }
                }
            }

            return oCustomersList;
        }

        public int AddCustomers(CCustomers oCustomers)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_Customers", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("CustomerName ", oCustomers.CustomerName);
                    oCmd.Parameters.AddWithValue("IsActive", oCustomers.IsActive);
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

        public int EditCustomers(CCustomers oCustomers)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Edit_Customers", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("CustomerID", oCustomers.CustomerID);
                    oCmd.Parameters.AddWithValue("CustomerName", oCustomers.CustomerName);
                    oCmd.Parameters.AddWithValue("IsActive", oCustomers.IsActive);

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

        // Banks
        public List<CBanks> GetBanksList()
        {
            List<CBanks> oBanksList = new List<CBanks>();

            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                SqlCommand oCmd = new SqlCommand("SP_Get_Banks", oConn);
                oCmd.CommandType = CommandType.StoredProcedure;
                oConn.Open();

                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        oBanksList.Add(new CBanks()
                        {
                            BankID = Convert.ToInt32(oDr["BankID"]),
                            BankName = oDr["BankName"].ToString(),
                            IsActive = Convert.ToBoolean(oDr["IsActive"])
                        });
                    }
                }
            }

            return oBanksList;
        }

        public int AddBanks(CBanks oBanks)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_Banks", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("BankName ", oBanks.BankName);
                    oCmd.Parameters.AddWithValue("IsActive", oBanks.IsActive);
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

        public int EditBanks(CBanks oBanks)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Edit_Banks", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("BankID", oBanks.BankID);
                    oCmd.Parameters.AddWithValue("BankName", oBanks.BankName);
                    oCmd.Parameters.AddWithValue("IsActive", oBanks.IsActive);

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

        // Currency
        public List<CCurrency> GetCurrencyList()
        {
            List<CCurrency> oCurrencyList = new List<CCurrency>();

            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                SqlCommand oCmd = new SqlCommand("SP_Get_Currency", oConn);
                oCmd.CommandType = CommandType.StoredProcedure;
                oConn.Open();

                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        oCurrencyList.Add(new CCurrency()
                        {
                            CurrencyID = Convert.ToInt32(oDr["CurrencyID"]),
                            CurrencyCode = oDr["CurrencyCode"].ToString(),
                            CurrencyName = oDr["CurrencyName"].ToString(),
                            IsActive = Convert.ToBoolean(oDr["IsActive"])
                        });
                    }
                }
            }

            return oCurrencyList;
        }

        public int AddCurrency(CCurrency oCurrency)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_Currency", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("CurrencyCode ", oCurrency.CurrencyCode);
                    oCmd.Parameters.AddWithValue("CurrencyName ", oCurrency.CurrencyName);
                    oCmd.Parameters.AddWithValue("IsActive", oCurrency.IsActive);
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

        public int EditCurrency(CCurrency oCurrency)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Edit_Currency", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("CurrencyID", oCurrency.CurrencyID);
                    oCmd.Parameters.AddWithValue("CurrencyCode", oCurrency.CurrencyCode);
                    oCmd.Parameters.AddWithValue("CurrencyName", oCurrency.CurrencyName);
                    oCmd.Parameters.AddWithValue("IsActive", oCurrency.IsActive);

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

        // ConstructionSite
        public List<CConstructionSite> GetConstructionSiteList()
        {
            List<CConstructionSite> oConstructionSiteList = new List<CConstructionSite>();

            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                SqlCommand oCmd = new SqlCommand("SP_Get_ConstructionSite", oConn);
                oCmd.CommandType = CommandType.StoredProcedure;
                oConn.Open();

                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        oConstructionSiteList.Add(new CConstructionSite()
                        {
                            ConstructionSiteID = Convert.ToInt32(oDr["ConstructionSiteID"]),
                            ConstructionSiteName = oDr["ConstructionSiteName"].ToString(),
                            IsActive = Convert.ToBoolean(oDr["IsActive"])
                        });
                    }
                }
            }

            return oConstructionSiteList;
        }

        public int AddConstructionSite(CConstructionSite oConstructionSite)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_ConstructionSite", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("ConstructionSiteName ", oConstructionSite.ConstructionSiteName);
                    oCmd.Parameters.AddWithValue("IsActive", oConstructionSite.IsActive);
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

        public int EditConstructionSite(CConstructionSite oConstructionSite)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Edit_ConstructionSite", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("ConstructionSiteID", oConstructionSite.ConstructionSiteID);
                    oCmd.Parameters.AddWithValue("ConstructionSiteName", oConstructionSite.ConstructionSiteName);
                    oCmd.Parameters.AddWithValue("IsActive", oConstructionSite.IsActive);

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