using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lanco_Project.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Diagnostics;
namespace Lanco_Project.Data
{
    public class _Transportes_BaseGeneral_Data
    {
        string connStr = ConfigurationManager.ConnectionStrings["conndb"].ConnectionString;
        public List<Transportes_BaseGeneral_Model> _Transportes_BaseGeneral_List()
        {
            //Se crea una variable lista oContactoList a partir del modelo ContactoModel y se guadan los valores obtenidos del Modelo
            List<Transportes_BaseGeneral_Model> oTransportesBaseGeneralList = new List<Transportes_BaseGeneral_Model>();
            //Se hace uso de la cadena de conexion para establecer la conexion
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                //Se define el procedimiento almacenado a ejecutar y como segundo parametro la conexion
                SqlCommand oCmd = new SqlCommand("SP_TransportesList", oConn);
                //Define el tipo de comando Cmd
                oCmd.CommandType = CommandType.StoredProcedure;
                //Se abre la cadena de conexion
                oConn.Open();

                //se ejecuta el comando con el procedimiento almacenado y se leen los valores
                using (SqlDataReader oDr = oCmd.ExecuteReader())
                {   //lee uno a uno los registros
                    while (oDr.Read())
                    {   //con el metodo add añadimos a la variable oContactoList los registros con el modelo ContactoModel
                        oTransportesBaseGeneralList.Add(new Transportes_BaseGeneral_Model()
                        {   //Se llaman las propiedades a utilizar y se convierten al tipo de dato creado en la DB
                            Item = oDr["Item"] != DBNull.Value ? Convert.ToInt32(oDr["Item"]) : 0,
                            Placa = oDr["Placa"] != DBNull.Value ? oDr["Placa"].ToString() : "-",
                            Flotilla = oDr["Flotilla"] != DBNull.Value ? oDr["Flotilla"].ToString() : "-",
                            ClaveInterna = oDr["ClaveInterna"] != DBNull.Value ? oDr["ClaveInterna"].ToString() : "-",
                            Marca = oDr["Marca"] != DBNull.Value ? oDr["Marca"].ToString() : "-",
                            Submarca = oDr["SubMarca"] != DBNull.Value ? oDr["SubMarca"].ToString() : "-",
                            Modelo = oDr["Modelo"] != DBNull.Value ? Convert.ToInt32(oDr["Modelo"]) : 0,
                            NoSerie = oDr["NoSerie"] != DBNull.Value ? oDr["NoSerie"].ToString() : "-"

                        });
                    }
                }
            }
            //Me retorna la lista de contacto con todos los registros obtenidos del procedimiento almacenado el cual es un SELECT
            return oTransportesBaseGeneralList;
        }
        //Definir metodo para guardar un Contacto en la tabla SQL
        //Case publica que retornara un entero y va a recibir un objeto del ContactModel y se nombra como oRute(se debia cambiar la nomenclatura)
        public int AddTransportesBaseGeneral(Transportes_BaseGeneral_Model oRoute)
        {   //Se declara una variable de respuesta
            int _iResponse = 0;
            //intenta el codigo
            try
            {   //usar la cadena para crear la conexion
                using (SqlConnection oConn = new SqlConnection(connStr))
                {   //se define el comando cmd a ejecutar con el procedimiento almacenado "sp_Guardar" como segundo parametro la cadena de conexion a usar
                    SqlCommand oCmd = new SqlCommand("SP_TransportesSave", oConn);
                    //se abre la conexion
                    oConn.Open();
                    //Define el tipo de comando Cmd (Procedimiento Almacenado)
                    oCmd.CommandType = CommandType.StoredProcedure;
                    //Define los parametros a usar del procedimiento almacenado y se envian los valores de oRoute
                    Debug.WriteLine(oRoute.Modelo);
                    oCmd.Parameters.AddWithValue("Placa", oRoute.Placa);
                    oCmd.Parameters.AddWithValue("Flotilla", oRoute.Flotilla);
                    oCmd.Parameters.AddWithValue("ClaveInterna", oRoute.ClaveInterna);
                    oCmd.Parameters.AddWithValue("Marca", oRoute.Marca);
                    oCmd.Parameters.AddWithValue("Submarca", oRoute.Submarca);
                    oCmd.Parameters.AddWithValue("Modelo", oRoute.Modelo);
                    oCmd.Parameters.AddWithValue("NoSerie", oRoute.NoSerie);
                    oCmd.Parameters.AddWithValue("Iave", oRoute.Iave);
                    oCmd.Parameters.AddWithValue("EstatusIave", oRoute.EstatusIave);
                    oCmd.Parameters.AddWithValue("Rendimiento", oRoute.Rendimiento);
                    oCmd.Parameters.AddWithValue("Estatus", oRoute.Estatus);
                    oCmd.Parameters.AddWithValue("UbicacionInterna", oRoute.UbicacionInterna);
                    oCmd.Parameters.AddWithValue("FechaEntregaCasanovaLanco", oRoute.FechaEntregaCasanovaLanco);
                    oCmd.Parameters.AddWithValue("KilometrajeEntrada", oRoute.KilometrajeEntrada);
                    oCmd.Parameters.AddWithValue("GasolinaEntrada", oRoute.GasolinaEntrada);
                    oCmd.Parameters.AddWithValue("Estado", oRoute.Estado);
                    oCmd.Parameters.AddWithValue("CoordinadorForaneoEncargado", oRoute.CoordinadorForaneoEncargado);
                    oCmd.Parameters.AddWithValue("Chofer", oRoute.Chofer);
                    oCmd.Parameters.AddWithValue("ClaveObra", oRoute.ClaveObra);
                    oCmd.Parameters.AddWithValue("Obra", oRoute.Obra);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMayo2022", oRoute.ImporteCobranzaMayo2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJunio2022", oRoute.ImporteCobranzaJunio2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJulio2022", oRoute.ImporteCobranzaJulio2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAgosto2022", oRoute.ImporteCobranzaAgosto2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaSeptiembre2022", oRoute.ImporteCobranzaSeptiembre2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaOctubre2022", oRoute.ImporteCobranzaOctubre2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaNoviembre2022", oRoute.ImporteCobranzaNoviembre2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaDiciembre2022", oRoute.ImporteCobranzaDiciembre2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaEnero2023", oRoute.ImporteCobranzaEnero2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaFebrero2023", oRoute.ImporteCobranzaFebrero2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMarzo2023", oRoute.ImporteCobranzaMarzo2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAbril2023", oRoute.ImporteCobranzaAbril2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMayo2023", oRoute.ImporteCobranzaMayo2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJunio2023", oRoute.ImporteCobranzaJunio2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJulio2023", oRoute.ImporteCobranzaJulio2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAgosto2023", oRoute.ImporteCobranzaAgosto2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaSeptiembre2023", oRoute.ImporteCobranzaSeptiembre2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaOctubre2023", oRoute.ImporteCobranzaOctubre2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaNoviembre2023", oRoute.ImporteCobranzaNoviembre2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaDiciembre2023", oRoute.ImporteCobranzaDiciembre2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaEnero2024", oRoute.ImporteCobranzaEnero2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaFebrero2024", oRoute.ImporteCobranzaFebrero2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMarzo2024", oRoute.ImporteCobranzaMarzo2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAbril2024", oRoute.ImporteCobranzaAbril2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMayo2024", oRoute.ImporteCobranzaMayo2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJunio2024", oRoute.ImporteCobranzaJunio2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJulio2024", oRoute.ImporteCobranzaJulio2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAgosto2024", oRoute.ImporteCobranzaAgosto2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaSeptiembre2024", oRoute.ImporteCobranzaSeptiembre2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaOctubre2024", oRoute.ImporteCobranzaOctubre2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaNoviembre2024", oRoute.ImporteCobranzaNoviembre2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaDiciembre2024", oRoute.ImporteCobranzaDiciembre2024);
                    oCmd.Parameters.AddWithValue("Factura", oRoute.Factura);
                    oCmd.Parameters.AddWithValue("Observaciones", oRoute.Observaciones);
                    oCmd.Parameters.AddWithValue("Terminacion", oRoute.Terminacion);
                    oCmd.Parameters.AddWithValue("PrimerSemestre", oRoute.PrimerSemestre);
                    oCmd.Parameters.AddWithValue("SegundoSemestre", oRoute.SegundoSemestre);
                    oCmd.Parameters.AddWithValue("Seguro", oRoute.Seguro);
                    oCmd.Parameters.AddWithValue("NumeroPoliza", oRoute.NumeroPoliza);
                    oCmd.Parameters.AddWithValue("CostoPoliza", oRoute.CostoPoliza);
                    oCmd.Parameters.AddWithValue("Vigencia", oRoute.Vigencia);
                    oCmd.Parameters.AddWithValue("Entidad", oRoute.Entidad);
                    oCmd.Parameters.AddWithValue("Vigencia2", oRoute.Vigencia2);
                    oCmd.Parameters.AddWithValue("Refrendo", oRoute.Refrendo);
                    oCmd.Parameters.AddWithValue("Tenencia2022", oRoute.Tenencia2022);
                    oCmd.Parameters.AddWithValue("Tenencia2023", oRoute.Tenencia2023);
                    oCmd.Parameters.AddWithValue("Tenencia2024", oRoute.Tenencia2024);
                    oCmd.Parameters.AddWithValue("Tenencia2025", oRoute.Tenencia2025);
                    oCmd.Parameters.AddWithValue("LicenciaDensimetroNuclear", oRoute.LicenciaDensimetroNuclear);
                    oCmd.Parameters.AddWithValue("EntregaUnidadCasanova", oRoute.EntregaUnidadCasanova);
                    oCmd.Parameters.AddWithValue("KmSalida", oRoute.KmSalida);
                    oCmd.Parameters.AddWithValue("TotalKmRecorridos", oRoute.TotalKmRecorridos);
                    oCmd.Parameters.AddWithValue("CombustibleRetorno", oRoute.CombustibleRetorno);
                    oCmd.Parameters.AddWithValue("Observaciones3", oRoute.Observaciones3);


                    //Ejecutar el procedimiento almacenado sin devolver valores
                    oCmd.ExecuteNonQuery();

                    _iResponse = 1;
                }
            }
            //captura el error
            catch (Exception ex)
            {
                
                Debug.WriteLine(ex.Message);
                
                

                _iResponse = 0;
            }
            //Retorna la variable de respuesta
            return _iResponse;
        }
        public int EditTransportesBaseGeneral(Transportes_BaseGeneral_Model oRoute)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Transportes_BaseGeneral_Edit", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("Placa", oRoute.Placa);
                    oCmd.Parameters.AddWithValue("Flotilla", oRoute.Flotilla);
                    oCmd.Parameters.AddWithValue("ClaveInterna", oRoute.ClaveInterna);
                    oCmd.Parameters.AddWithValue("Marca", oRoute.Marca);
                    oCmd.Parameters.AddWithValue("Submarca", oRoute.Submarca);
                    oCmd.Parameters.AddWithValue("Modelo", oRoute.Modelo);
                    oCmd.Parameters.AddWithValue("NoSerie", oRoute.NoSerie);
                    oCmd.Parameters.AddWithValue("Iave", oRoute.Iave);
                    oCmd.Parameters.AddWithValue("EstatusIave", oRoute.EstatusIave);
                    oCmd.Parameters.AddWithValue("Rendimiento", oRoute.Rendimiento);
                    oCmd.Parameters.AddWithValue("Estatus", oRoute.Estatus);
                    oCmd.Parameters.AddWithValue("UbicacionInterna", oRoute.UbicacionInterna);
                    oCmd.Parameters.AddWithValue("FechaEntregaCasanovaLanco", oRoute.FechaEntregaCasanovaLanco);
                    oCmd.Parameters.AddWithValue("KilometrajeEntrada", oRoute.KilometrajeEntrada);
                    oCmd.Parameters.AddWithValue("GasolinaEntrada", oRoute.GasolinaEntrada);
                    oCmd.Parameters.AddWithValue("Estado", oRoute.Estado);
                    oCmd.Parameters.AddWithValue("CoordinadorForaneoEncargado", oRoute.CoordinadorForaneoEncargado);
                    oCmd.Parameters.AddWithValue("Chofer", oRoute.Chofer);
                    oCmd.Parameters.AddWithValue("ClaveObra", oRoute.ClaveObra);
                    oCmd.Parameters.AddWithValue("Obra", oRoute.Obra);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMayo2022", oRoute.ImporteCobranzaMayo2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJunio2022", oRoute.ImporteCobranzaJunio2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJulio2022", oRoute.ImporteCobranzaJulio2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAgosto2022", oRoute.ImporteCobranzaAgosto2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaSeptiembre2022", oRoute.ImporteCobranzaSeptiembre2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaOctubre2022", oRoute.ImporteCobranzaOctubre2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaNoviembre2022", oRoute.ImporteCobranzaNoviembre2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaDiciembre2022", oRoute.ImporteCobranzaDiciembre2022);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaEnero2023", oRoute.ImporteCobranzaEnero2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaFebrero2023", oRoute.ImporteCobranzaFebrero2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMarzo2023", oRoute.ImporteCobranzaMarzo2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAbril2023", oRoute.ImporteCobranzaAbril2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMayo2023", oRoute.ImporteCobranzaMayo2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJunio2023", oRoute.ImporteCobranzaJunio2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJulio2023", oRoute.ImporteCobranzaJulio2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAgosto2023", oRoute.ImporteCobranzaAgosto2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaSeptiembre2023", oRoute.ImporteCobranzaSeptiembre2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaOctubre2023", oRoute.ImporteCobranzaOctubre2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaNoviembre2023", oRoute.ImporteCobranzaNoviembre2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaDiciembre2023", oRoute.ImporteCobranzaDiciembre2023);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaEnero2024", oRoute.ImporteCobranzaEnero2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaFebrero2024", oRoute.ImporteCobranzaFebrero2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMarzo2024", oRoute.ImporteCobranzaMarzo2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAbril2024", oRoute.ImporteCobranzaAbril2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMayo2024", oRoute.ImporteCobranzaMayo2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJunio2024", oRoute.ImporteCobranzaJunio2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJulio2024", oRoute.ImporteCobranzaJulio2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAgosto2024", oRoute.ImporteCobranzaAgosto2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaSeptiembre2024", oRoute.ImporteCobranzaSeptiembre2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaOctubre2024", oRoute.ImporteCobranzaOctubre2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaNoviembre2024", oRoute.ImporteCobranzaNoviembre2024);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaDiciembre2024", oRoute.ImporteCobranzaDiciembre2024);
                    oCmd.Parameters.AddWithValue("Factura", oRoute.Factura);
                    oCmd.Parameters.AddWithValue("Observaciones", oRoute.Observaciones);
                    oCmd.Parameters.AddWithValue("Terminacion", oRoute.Terminacion);
                    oCmd.Parameters.AddWithValue("PrimerSemestre", oRoute.PrimerSemestre);
                    oCmd.Parameters.AddWithValue("SegundoSemestre", oRoute.SegundoSemestre);
                    oCmd.Parameters.AddWithValue("Seguro", oRoute.Seguro);
                    oCmd.Parameters.AddWithValue("NumeroPoliza", oRoute.NumeroPoliza);
                    oCmd.Parameters.AddWithValue("CostoPoliza", oRoute.CostoPoliza);
                    oCmd.Parameters.AddWithValue("Vigencia", oRoute.Vigencia);
                    oCmd.Parameters.AddWithValue("Entidad", oRoute.Entidad);
                    oCmd.Parameters.AddWithValue("Vigencia2", oRoute.Vigencia2);
                    oCmd.Parameters.AddWithValue("Refrendo", oRoute.Refrendo);
                    oCmd.Parameters.AddWithValue("Tenencia2022", oRoute.Tenencia2022);
                    oCmd.Parameters.AddWithValue("Tenencia2023", oRoute.Tenencia2023);
                    oCmd.Parameters.AddWithValue("Tenencia2024", oRoute.Tenencia2024);
                    oCmd.Parameters.AddWithValue("Tenencia2025", oRoute.Tenencia2025);
                    oCmd.Parameters.AddWithValue("LicenciaDensimetroNuclear", oRoute.LicenciaDensimetroNuclear);
                    oCmd.Parameters.AddWithValue("EntregaUnidadCasanova", oRoute.EntregaUnidadCasanova);
                    oCmd.Parameters.AddWithValue("KmSalida", oRoute.KmSalida);
                    oCmd.Parameters.AddWithValue("TotalKmRecorridos", oRoute.TotalKmRecorridos);
                    oCmd.Parameters.AddWithValue("CombustibleRetorno", oRoute.CombustibleRetorno);
                    oCmd.Parameters.AddWithValue("Observaciones3", oRoute.Observaciones3);

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
        public int DeleteTransportesBaseGeneral(string Placa)
        {
            int _iResponse = 0;

            try
            {
                using (SqlConnection oConn = new SqlConnection(connStr))
                {
                    SqlCommand oCmd = new SqlCommand("SP_Transportes_BaseGeneral_Delete", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("@Placa", Placa);

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