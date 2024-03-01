using Lanco_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Lanco_Project.Data
{
    public class FactsData
    {
        string connStr = ConfigurationManager.ConnectionStrings["conndb"].ConnectionString;
        
        // Fact Routes
        public List<FRoutes> GetRoutesList()
        {
            List<FRoutes> oRoutesList = new List<FRoutes>();

            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                SqlCommand oCmd = new SqlCommand("SP_Get_FRoutes", oConn);
                oCmd.CommandType = CommandType.StoredProcedure;
                oConn.Open();

                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        oRoutesList.Add(new FRoutes()
                        {
                            RouteFact_ID = Convert.ToInt32(oDr["RouteFact_ID"]),
                            RouteID = Convert.ToInt32(oDr["RouteID"].ToString()),
                            RouteName = oDr["RouteName"].ToString(),
                            ResponsibleID = Convert.ToInt32(oDr["ResponsibleID"]),
                            ResponsibleName = oDr["ResponsibleName"].ToString(),
                            AdmissionDate = Convert.ToDateTime(oDr["AdmissionDate"].ToString()),
                            DepartureDate = Convert.ToDateTime(oDr["DepartureDate"].ToString())
                        });
                    }
                }
            }

            return oRoutesList;
        }
        public int AddRoute(FRoutes oRoute)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_FRoutes", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("RouteID ", oRoute.RouteID);
                    oCmd.Parameters.AddWithValue("ResponsibleID", oRoute.ResponsibleID);
                    oCmd.Parameters.AddWithValue("AdmissionDate", oRoute.AdmissionDate);
                    oCmd.Parameters.AddWithValue("DepartureDate", oRoute.DepartureDate);

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
        public int EditRoute(FRoutes oRoute)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Edit_FRoutes", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("RouteFact_ID ", oRoute.RouteFact_ID);
                    oCmd.Parameters.AddWithValue("RouteID ", oRoute.RouteID);
                    oCmd.Parameters.AddWithValue("ResponsibleID", oRoute.ResponsibleID);
                    oCmd.Parameters.AddWithValue("AdmissionDate", oRoute.AdmissionDate);
                    oCmd.Parameters.AddWithValue("DepartureDate", oRoute.DepartureDate);

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

        // Fact Payment SAE
        public List<FPaymentsSAE> GetPaymentSAEList()
        {
            List<FPaymentsSAE> oPaymentList = new List<FPaymentsSAE>();

            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                SqlCommand oCmd = new SqlCommand("SP_Get_FPaymentsSAE", oConn);
                oCmd.CommandType = CommandType.StoredProcedure;
                oConn.Open();

                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        oPaymentList.Add(new FPaymentsSAE()
                        {
                            PaymentSAE_ID = Convert.ToInt32(oDr["PaymentSAE_ID"]),
                            CustomerID = Convert.ToInt32(oDr["CustomerID"].ToString()),
                            CustomerName = oDr["CustomerName"].ToString(),
                            BankID = Convert.ToInt32(oDr["BankID"]),
                            BankName = oDr["BankName"].ToString(),
                            PaymentDate = Convert.ToDateTime(oDr["PaymentDate"].ToString()),
                            PaymentAmount = Convert.ToDecimal(oDr["PaymentAmount"].ToString()),
                            CurrencyID = Convert.ToInt32(oDr["CurrencyID"].ToString()),
                            CurrencyCode = oDr["CurrencyCode"].ToString(),
                            CurrencyName = oDr["CurrencyName"].ToString(),
                            RouteID = Convert.ToInt32(oDr["RouteID"].ToString()),
                            RouteName = oDr["RouteName"].ToString(),
                            ResponsibleID = Convert.ToInt32(oDr["ResponsibleID"].ToString()),
                            ResponsibleName = oDr["ResponsibleName"].ToString()
                        });
                    }
                }
            }

            return oPaymentList;
        }
        public int AddPaymentSAE(FPaymentsSAE oPayment)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_FPaymentsSAE", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("CustomerID ", oPayment.CustomerID);
                    oCmd.Parameters.AddWithValue("BankID", oPayment.BankID);
                    oCmd.Parameters.AddWithValue("PaymentDate", oPayment.PaymentDate);
                    oCmd.Parameters.AddWithValue("PaymentAmount", oPayment.PaymentAmount);
                    oCmd.Parameters.AddWithValue("CurrencyID", oPayment.CurrencyID);
                    oCmd.Parameters.AddWithValue("RouteID", oPayment.RouteID);
                    oCmd.Parameters.AddWithValue("ResponsibleID", oPayment.ResponsibleID);
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
        public int EditPaymentsSAE(FPaymentsSAE oPayment)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Edit_FPaymentsSAE", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("PaymentSAE_ID ", oPayment.PaymentSAE_ID);
                    oCmd.Parameters.AddWithValue("CustomerID ", oPayment.CustomerID);
                    oCmd.Parameters.AddWithValue("BankID", oPayment.BankID);
                    oCmd.Parameters.AddWithValue("PaymentDate", oPayment.PaymentDate);
                    oCmd.Parameters.AddWithValue("PaymentAmount", oPayment.PaymentAmount);
                    oCmd.Parameters.AddWithValue("CurrencyID", oPayment.CurrencyID);
                    oCmd.Parameters.AddWithValue("RouteID", oPayment.RouteID);
                    oCmd.Parameters.AddWithValue("ResponsibleID", oPayment.ResponsibleID);
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

        // Fact Forecasts
        public List<FForecast> GetForecastsList()
        {
            List<FForecast> oForecastsList = new List<FForecast>();

            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                SqlCommand oCmd = new SqlCommand("SP_Get_FForecasts", oConn);
                oCmd.CommandType = CommandType.StoredProcedure;
                oConn.Open();

                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        oForecastsList.Add(new FForecast()
                        {
                            Forecasts_ID = Convert.ToInt32(oDr["Forecasts_ID"]),
                            Invoice = oDr["Invoice"].ToString(),
                            AgreedPaymentDate = Convert.ToDateTime(oDr["AgreedPaymentDate"].ToString()),
                            AgreedAmount = Convert.ToDecimal(oDr["AgreedAmount"].ToString()),
                            ConstructionSiteID = Convert.ToInt32(oDr["ConstructionSiteID"].ToString()),
                            ConstructionSiteName = oDr["ConstructionSiteName"].ToString(),
                            RouteID = Convert.ToInt32(oDr["RouteID"].ToString()),
                            RouteName = oDr["RouteName"].ToString(),
                            ResponsibleID = Convert.ToInt32(oDr["ResponsibleID"].ToString()),
                            ResponsibleName = oDr["ResponsibleName"].ToString()
                        });
                    }
                }
            }

            return oForecastsList;
        }
        public int AddForecasts(FForecast oForcast)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_FForecasts", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("Invoice ", oForcast.Invoice);
                    oCmd.Parameters.AddWithValue("AgreedPaymentDate", oForcast.AgreedPaymentDate);
                    oCmd.Parameters.AddWithValue("AgreedAmount", oForcast.AgreedAmount);
                    oCmd.Parameters.AddWithValue("ConstructionSiteID", oForcast.ConstructionSiteID);
                    oCmd.Parameters.AddWithValue("RouteID", oForcast.RouteID);
                    oCmd.Parameters.AddWithValue("ResponsibleID", oForcast.ResponsibleID);
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
        public int EditForecasts(FForecast oForcast)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Edit_FForecasts", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("Forecasts_ID", oForcast.Forecasts_ID);
                    oCmd.Parameters.AddWithValue("Invoice ", oForcast.Invoice);
                    oCmd.Parameters.AddWithValue("AgreedPaymentDate ", oForcast.AgreedPaymentDate);
                    oCmd.Parameters.AddWithValue("AgreedAmount", oForcast.AgreedAmount);
                    oCmd.Parameters.AddWithValue("ConstructionSiteID", oForcast.ConstructionSiteID);
                    oCmd.Parameters.AddWithValue("RouteID", oForcast.RouteID);
                    oCmd.Parameters.AddWithValue("ResponsibleID", oForcast.ResponsibleID);
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

        // Fact Files
        public List<FFiles> GetFilesList()
        {
            List<FFiles> oFilesList = new List<FFiles>();

            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                SqlCommand oCmd = new SqlCommand("SP_Get_FFiles", oConn);
                oCmd.CommandType = CommandType.StoredProcedure;
                oConn.Open();

                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        oFilesList.Add(new FFiles()
                        {
                            Files_ID = Convert.ToInt32(oDr["Files_ID"]),
                            CustomerID = Convert.ToInt32(oDr["CustomerID"]),
                            CustomerName = oDr["CustomerName"].ToString(),
                            NumberFile = oDr["NumberFile"].ToString(),
                            ConstructionSiteID = Convert.ToInt32(oDr["ConstructionSiteID"]),
                            ConstructionSiteName = oDr["ConstructionSiteName"].ToString()
                        });
                    }
                }
            }

            return oFilesList;
        }
        public int AddFiles(FFiles oFIles)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Add_FFiles", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("CustomerID", oFIles.CustomerID);
                    oCmd.Parameters.AddWithValue("NumberFile", oFIles.NumberFile);
                    oCmd.Parameters.AddWithValue("ConstructionSiteID", oFIles.ConstructionSiteID);
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
        public int EditFiles(FFiles oFIles)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Edit_FFiles", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("Files_ID", oFIles.Files_ID);
                    oCmd.Parameters.AddWithValue("CustomerID ", oFIles.CustomerID);
                    oCmd.Parameters.AddWithValue("NumberFile ", oFIles.NumberFile);
                    oCmd.Parameters.AddWithValue("ConstructionSiteID", oFIles.ConstructionSiteID);
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