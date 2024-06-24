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
                            Item = Convert.ToInt32(oDr["Item"]),
                            Placa = oDr["Placa"].ToString(),
                            Flotilla = oDr["Flotilla"].ToString(),
                            ClaveInterna = oDr["ClaveInterna"].ToString(),
                            Marca = oDr["Marca"].ToString(),
                            Submarca = oDr["SubMarca"].ToString(),
                            Modelo = Convert.ToInt32(oDr["Modelo"]),
                            NoSerie = oDr["NoSerie"].ToString(),
                            Iave = oDr["Iave"] != DBNull.Value ? Convert.ToString(oDr["Iave"]) : (string)null,
                            EstatusIave = oDr["EstatusIave"] != DBNull.Value ? Convert.ToString(oDr["EstatusIave"]) : (string)null,
                            Rendimiento = oDr["Rendimiento"] != DBNull.Value ? Convert.ToSingle(oDr["Rendimiento"]) : (float?)null,
                            Estatus = oDr["Estatus"] != DBNull.Value ? Convert.ToString(oDr["Estatus"]) : (string)null,
                            UbicacionInterna = oDr["UbicacionInterna"] != DBNull.Value ? Convert.ToString(oDr["UbicacionInterna"]) : (string)null,
                            FechaEntregaCasanovaLanco = oDr["FechaEntregaCasanovaLanco"] != DBNull.Value ? (DateTime)oDr["FechaEntregaCasanovaLanco"] : (DateTime?)null,
                            KilometrajeEntrada = oDr["KilometrajeEntrada"] != DBNull.Value ? Convert.ToInt32(oDr["KilometrajeEntrada"]) : (int?)null,
                            GasolinaEntrada = oDr["GasolinaEntrada"] != DBNull.Value ? Convert.ToString(oDr["GasolinaEntrada"]) : (string)null,
                            Estado = oDr["Estado"] != DBNull.Value ? Convert.ToString(oDr["Estado"]) : (string)null,
                            CoordinadorForaneoEncargado = oDr["CoordinadorForaneoEncargado"] != DBNull.Value ? Convert.ToString(oDr["CoordinadorForaneoEncargado"]) : (string)null,
                            Chofer = oDr["Chofer"] != DBNull.Value ? Convert.ToString(oDr["Chofer"]) : (string)null,
                            ClaveObra = oDr["ClaveObra"] != DBNull.Value ? Convert.ToString(oDr["ClaveObra"]) : (string)null,
                            Obra = oDr["Obra"] != DBNull.Value ? Convert.ToString(oDr["Obra"]) : (string)null,
                            ImporteCobranzaMayo2022 = oDr["ImporteCobranzaMayo2022"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaMayo2022"]) : (string)null,
                            ImporteCobranzaJunio2022 = oDr["ImporteCobranzaJunio2022"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaJunio2022"]) : (string)null,
                            ImporteCobranzaJulio2022 = oDr["ImporteCobranzaJulio2022"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaJulio2022"]) : (string)null,
                            ImporteCobranzaAgosto2022 = oDr["ImporteCobranzaAgosto2022"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaAgosto2022"]) : (string)null,
                            ImporteCobranzaSeptiembre2022 = oDr["ImporteCobranzaSeptiembre2022"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaSeptiembre2022"]) : (string)null,
                            ImporteCobranzaOctubre2022 = oDr["ImporteCobranzaOctubre2022"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaOctubre2022"]) : (string)null,
                            ImporteCobranzaNoviembre2022 = oDr["ImporteCobranzaNoviembre2022"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaNoviembre2022"]) : (string)null,
                            ImporteCobranzaDiciembre2022 = oDr["ImporteCobranzaDiciembre2022"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaDiciembre2022"]) : (string)null,
                            ImporteCobranzaEnero2023 = oDr["ImporteCobranzaEnero2023"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaEnero2023"]) : (string)null,
                            ImporteCobranzaFebrero2023 = oDr["ImporteCobranzaFebrero2023"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaFebrero2023"]) : (string)null,
                            ImporteCobranzaMarzo2023 = oDr["ImporteCobranzaMarzo2023"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaMarzo2023"]) : (string)null,
                            ImporteCobranzaAbril2023 = oDr["ImporteCobranzaAbril2023"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaAbril2023"]) : (string)null,
                            ImporteCobranzaMayo2023 = oDr["ImporteCobranzaMayo2023"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaMayo2023"]) : (string)null,
                            ImporteCobranzaJunio2023 = oDr["ImporteCobranzaJunio2023"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaJunio2023"]) : (string)null,
                            ImporteCobranzaJulio2023 = oDr["ImporteCobranzaJulio2023"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaJulio2023"]) : (string)null,
                            ImporteCobranzaAgosto2023 = oDr["ImporteCobranzaAgosto2023"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaAgosto2023"]) : (string)null,
                            ImporteCobranzaSeptiembre2023 = oDr["ImporteCobranzaSeptiembre2023"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaSeptiembre2023"]) : (string)null,
                            ImporteCobranzaOctubre2023 = oDr["ImporteCobranzaOctubre2023"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaOctubre2023"]) : (string)null,
                            ImporteCobranzaNoviembre2023 = oDr["ImporteCobranzaNoviembre2023"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaNoviembre2023"]) : (string)null,
                            ImporteCobranzaDiciembre2023 = oDr["ImporteCobranzaDiciembre2023"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaDiciembre2023"]) : (string)null,
                            ImporteCobranzaEnero2024 = oDr["ImporteCobranzaEnero2024"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaEnero2024"]) : (string)null,
                            ImporteCobranzaFebrero2024 = oDr["ImporteCobranzaFebrero2024"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaFebrero2024"]) : (string)null,
                            ImporteCobranzaMarzo2024 = oDr["ImporteCobranzaMarzo2024"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaMarzo2024"]) : (string)null,
                            ImporteCobranzaAbril2024 = oDr["ImporteCobranzaAbril2024"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaAbril2024"]) : (string)null,
                            ImporteCobranzaMayo2024 = oDr["ImporteCobranzaMayo2024"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaMayo2024"]) : (string)null,
                            ImporteCobranzaJunio2024 = oDr["ImporteCobranzaJunio2024"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaJunio2024"]) : (string)null,
                            ImporteCobranzaJulio2024 = oDr["ImporteCobranzaJulio2024"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaJulio2024"]) : (string)null,
                            ImporteCobranzaAgosto2024 = oDr["ImporteCobranzaAgosto2024"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaAgosto2024"]) : (string)null,
                            ImporteCobranzaSeptiembre2024 = oDr["ImporteCobranzaSeptiembre2024"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaSeptiembre2024"]) : (string)null,
                            ImporteCobranzaOctubre2024 = oDr["ImporteCobranzaOctubre2024"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaOctubre2024"]) : (string)null,
                            ImporteCobranzaNoviembre2024 = oDr["ImporteCobranzaNoviembre2024"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaNoviembre2024"]) : (string)null,
                            ImporteCobranzaDiciembre2024 = oDr["ImporteCobranzaDiciembre2024"] != DBNull.Value ? Convert.ToString(oDr["ImporteCobranzaDiciembre2024"]) : (string)null,
                            Factura = oDr["Factura"] != DBNull.Value ? Convert.ToString(oDr["Factura"]) : (string)null,
                            Observaciones = oDr["Observaciones"] != DBNull.Value ? Convert.ToString(oDr["Observaciones"]) : (string)null,
                            Terminacion = oDr["Terminacion"] != DBNull.Value ? Convert.ToInt32(oDr["Terminacion"]) : (int?)null,
                            PrimerSemestre = oDr["PrimerSemestre"] != DBNull.Value ? Convert.ToString(oDr["PrimerSemestre"]) : (string)null,
                            SegundoSemestre = oDr["SegundoSemestre"] != DBNull.Value ? Convert.ToString(oDr["SegundoSemestre"]) : (string)null,
                            Seguro = oDr["Seguro"] != DBNull.Value ? Convert.ToString(oDr["Seguro"]) : (string)null,
                            NumeroPoliza = oDr["NumeroPoliza"] != DBNull.Value ? Convert.ToString(oDr["NumeroPoliza"]) : (string)null,
                            CostoPoliza = oDr["CostoPoliza"] != DBNull.Value ? Convert.ToSingle(oDr["CostoPoliza"]) : (float?)null,
                            Vigencia = oDr["Vigencia"] != DBNull.Value ? (DateTime)oDr["Vigencia"] : (DateTime?)null,
                            Entidad = oDr["Entidad"] != DBNull.Value ? Convert.ToString(oDr["Entidad"]) : (string)null,
                            Vigencia2 = oDr["Vigencia2"] != DBNull.Value ? (DateTime)oDr["Vigencia2"] : (DateTime?)null,
                            Refrendo = oDr["Refrendo"] != DBNull.Value ? Convert.ToString(oDr["Refrendo"]) : (string)null,
                            Tenencia2022 = oDr["Tenencia2022"] != DBNull.Value ? Convert.ToSingle(oDr["Tenencia2022"]) : (float?)null,
                            Tenencia2023 = oDr["Tenencia2023"] != DBNull.Value ? Convert.ToSingle(oDr["Tenencia2023"]) : (float?)null,
                            Tenencia2024 = oDr["Tenencia2024"] != DBNull.Value ? Convert.ToSingle(oDr["Tenencia2024"]) : (float?)null,
                            Tenencia2025 = oDr["Tenencia2025"] != DBNull.Value ? Convert.ToSingle(oDr["Tenencia2025"]) : (float?)null,
                            LicenciaDensimetroNuclear = oDr["LicenciaDensimetroNuclear"] != DBNull.Value ? Convert.ToString(oDr["LicenciaDensimetroNuclear"]) : (string)null,
                            EntregaUnidadCasanova = oDr["EntregaUnidadCasanova"] != DBNull.Value ? (DateTime)oDr["EntregaUnidadCasanova"] : (DateTime?)null,
                            KmSalida = oDr["KmSalida"] != DBNull.Value ? Convert.ToInt32(oDr["KmSalida"]) : (int?)null,
                            TotalKmRecorridos = oDr["TotalKmRecorridos"] != DBNull.Value ? Convert.ToInt32(oDr["TotalKmRecorridos"]) : (int?)null,
                            CombustibleRetorno = oDr["CombustibleRetorno"] != DBNull.Value ? Convert.ToString(oDr["CombustibleRetorno"]) : (string)null,
                            Observaciones3 = oDr["Observaciones3"] != DBNull.Value ? Convert.ToString(oDr["Observaciones3"]) : (string)null,



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
                    SqlCommand oCmd = new SqlCommand("SP_TransportesEdit", oConn);
                    oConn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.AddWithValue("Placa", oRoute.Placa);
                    oCmd.Parameters.AddWithValue("Flotilla", oRoute.Flotilla);
                    oCmd.Parameters.AddWithValue("ClaveInterna", oRoute.ClaveInterna);
                    oCmd.Parameters.AddWithValue("Marca", oRoute.Marca);
                    oCmd.Parameters.AddWithValue("Submarca", oRoute.Submarca);
                    oCmd.Parameters.AddWithValue("Modelo", oRoute.Modelo);
                    oCmd.Parameters.AddWithValue("NoSerie", oRoute.NoSerie);
                    oCmd.Parameters.AddWithValue("Iave", oRoute.Iave != null ? (object)oRoute.Iave : DBNull.Value);
                    oCmd.Parameters.AddWithValue("EstatusIave", oRoute.EstatusIave != null ? (object)oRoute.EstatusIave : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Rendimiento", oRoute.Rendimiento.HasValue ? (object)oRoute.Rendimiento.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Estatus", oRoute.Estatus != null ? (object)oRoute.Estatus : DBNull.Value);
                    oCmd.Parameters.AddWithValue("UbicacionInterna", oRoute.UbicacionInterna != null ? (object)oRoute.UbicacionInterna : DBNull.Value);
                    oCmd.Parameters.AddWithValue("FechaEntregaCasanovaLanco", oRoute.FechaEntregaCasanovaLanco.HasValue ? (object)oRoute.FechaEntregaCasanovaLanco.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("KilometrajeEntrada", oRoute.KilometrajeEntrada.HasValue ? (object)oRoute.KilometrajeEntrada.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("GasolinaEntrada", oRoute.GasolinaEntrada != null ? (object)oRoute.GasolinaEntrada : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Estado", oRoute.Estado != null ? (object)oRoute.Estado : DBNull.Value);
                    oCmd.Parameters.AddWithValue("CoordinadorForaneoEncargado", oRoute.CoordinadorForaneoEncargado != null ? (object)oRoute.CoordinadorForaneoEncargado : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Chofer", oRoute.Chofer != null ? (object)oRoute.Chofer : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ClaveObra", oRoute.ClaveObra != null ? (object)oRoute.ClaveObra : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Obra", oRoute.Obra != null ? (object)oRoute.Obra : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMayo2022", oRoute.ImporteCobranzaMayo2022 != null ? (object)oRoute.ImporteCobranzaMayo2022 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJunio2022", oRoute.ImporteCobranzaJunio2022 != null ? (object)oRoute.ImporteCobranzaJunio2022 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJulio2022", oRoute.ImporteCobranzaJulio2022 != null ? (object)oRoute.ImporteCobranzaJulio2022 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAgosto2022", oRoute.ImporteCobranzaAgosto2022 != null ? (object)oRoute.ImporteCobranzaAgosto2022 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaSeptiembre2022", oRoute.ImporteCobranzaSeptiembre2022 != null ? (object)oRoute.ImporteCobranzaSeptiembre2022 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaOctubre2022", oRoute.ImporteCobranzaOctubre2022 != null ? (object)oRoute.ImporteCobranzaOctubre2022 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaNoviembre2022", oRoute.ImporteCobranzaNoviembre2022 != null ? (object)oRoute.ImporteCobranzaNoviembre2022 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaDiciembre2022", oRoute.ImporteCobranzaDiciembre2022 != null ? (object)oRoute.ImporteCobranzaDiciembre2022 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaEnero2023", oRoute.ImporteCobranzaEnero2023 != null ? (object)oRoute.ImporteCobranzaEnero2023 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaFebrero2023", oRoute.ImporteCobranzaFebrero2023 != null ? (object)oRoute.ImporteCobranzaFebrero2023 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMarzo2023", oRoute.ImporteCobranzaMarzo2023 != null ? (object)oRoute.ImporteCobranzaMarzo2023 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAbril2023", oRoute.ImporteCobranzaAbril2023 != null ? (object)oRoute.ImporteCobranzaAbril2023 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMayo2023", oRoute.ImporteCobranzaMayo2023 != null ? (object)oRoute.ImporteCobranzaMayo2023 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJunio2023", oRoute.ImporteCobranzaJunio2023 != null ? (object)oRoute.ImporteCobranzaJunio2023 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJulio2023", oRoute.ImporteCobranzaJulio2023 != null ? (object)oRoute.ImporteCobranzaJulio2023 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAgosto2023", oRoute.ImporteCobranzaAgosto2023 != null ? (object)oRoute.ImporteCobranzaAgosto2023 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaSeptiembre2023", oRoute.ImporteCobranzaSeptiembre2023 != null ? (object)oRoute.ImporteCobranzaSeptiembre2023 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaOctubre2023", oRoute.ImporteCobranzaOctubre2023 != null ? (object)oRoute.ImporteCobranzaOctubre2023 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaNoviembre2023", oRoute.ImporteCobranzaNoviembre2023 != null ? (object)oRoute.ImporteCobranzaNoviembre2023 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaDiciembre2023", oRoute.ImporteCobranzaDiciembre2023 != null ? (object)oRoute.ImporteCobranzaDiciembre2023 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaEnero2024", oRoute.ImporteCobranzaEnero2024 != null ? (object)oRoute.ImporteCobranzaEnero2024 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaFebrero2024", oRoute.ImporteCobranzaFebrero2024 != null ? (object)oRoute.ImporteCobranzaFebrero2024 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMarzo2024", oRoute.ImporteCobranzaMarzo2024 != null ? (object)oRoute.ImporteCobranzaMarzo2024 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAbril2024", oRoute.ImporteCobranzaAbril2024 != null ? (object)oRoute.ImporteCobranzaAbril2024 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaMayo2024", oRoute.ImporteCobranzaMayo2024 != null ? (object)oRoute.ImporteCobranzaMayo2024 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJunio2024", oRoute.ImporteCobranzaJunio2024 != null ? (object)oRoute.ImporteCobranzaJunio2024 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaJulio2024", oRoute.ImporteCobranzaJulio2024 != null ? (object)oRoute.ImporteCobranzaJulio2024 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaAgosto2024", oRoute.ImporteCobranzaAgosto2024 != null ? (object)oRoute.ImporteCobranzaAgosto2024 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaSeptiembre2024", oRoute.ImporteCobranzaSeptiembre2024 != null ? (object)oRoute.ImporteCobranzaSeptiembre2024 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaOctubre2024", oRoute.ImporteCobranzaOctubre2024 != null ? (object)oRoute.ImporteCobranzaOctubre2024 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaNoviembre2024", oRoute.ImporteCobranzaNoviembre2024 != null ? (object)oRoute.ImporteCobranzaNoviembre2024 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("ImporteCobranzaDiciembre2024", oRoute.ImporteCobranzaDiciembre2024 != null ? (object)oRoute.ImporteCobranzaDiciembre2024 : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Factura", oRoute.Factura != null ? (object)oRoute.Factura : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Observaciones", oRoute.Observaciones != null ? (object)oRoute.Observaciones : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Terminacion", oRoute.Terminacion.HasValue ? (object)oRoute.Terminacion.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("PrimerSemestre", oRoute.PrimerSemestre != null ? (object)oRoute.PrimerSemestre : DBNull.Value);
                    oCmd.Parameters.AddWithValue("SegundoSemestre", oRoute.SegundoSemestre != null ? (object)oRoute.SegundoSemestre : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Seguro", oRoute.Seguro != null ? (object)oRoute.Seguro : DBNull.Value);
                    oCmd.Parameters.AddWithValue("NumeroPoliza", oRoute.NumeroPoliza != null ? (object)oRoute.NumeroPoliza : DBNull.Value);
                    oCmd.Parameters.AddWithValue("CostoPoliza", oRoute.CostoPoliza.HasValue ? (object)oRoute.CostoPoliza.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Vigencia", oRoute.Vigencia.HasValue ? (object)oRoute.Vigencia.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Entidad", oRoute.Entidad != null ? (object)oRoute.Entidad : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Vigencia2", oRoute.Vigencia2.HasValue ? (object)oRoute.Vigencia2.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Refrendo", oRoute.Refrendo != null ? (object)oRoute.Refrendo : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Tenencia2022", oRoute.Tenencia2022.HasValue ? (object)oRoute.Tenencia2022.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Tenencia2023", oRoute.Tenencia2023.HasValue ? (object)oRoute.Tenencia2023.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Tenencia2024", oRoute.Tenencia2024.HasValue ? (object)oRoute.Tenencia2024.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Tenencia2025", oRoute.Tenencia2025.HasValue ? (object)oRoute.Tenencia2025.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("LicenciaDensimetroNuclear", oRoute.LicenciaDensimetroNuclear != null ? (object)oRoute.LicenciaDensimetroNuclear : DBNull.Value);
                    oCmd.Parameters.AddWithValue("EntregaUnidadCasanova", oRoute.EntregaUnidadCasanova.HasValue ? (object)oRoute.EntregaUnidadCasanova.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("KmSalida", oRoute.KmSalida.HasValue ? (object)oRoute.KmSalida.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("TotalKmRecorridos", oRoute.TotalKmRecorridos.HasValue ? (object)oRoute.TotalKmRecorridos.Value : DBNull.Value);
                    oCmd.Parameters.AddWithValue("CombustibleRetorno", oRoute.CombustibleRetorno != null ? (object)oRoute.CombustibleRetorno : DBNull.Value);
                    oCmd.Parameters.AddWithValue("Observaciones3", oRoute.Observaciones3 != null ? (object)oRoute.Observaciones3 : DBNull.Value);
                    Debug.WriteLine(oRoute.Placa);
                    Debug.WriteLine(oRoute.Flotilla);
                    Debug.WriteLine(oRoute.ClaveInterna);
                    Debug.WriteLine(oRoute.Marca);
                    Debug.WriteLine(oRoute.Submarca);
                    Debug.WriteLine(oRoute.Modelo);
                    Debug.WriteLine(oRoute.NoSerie);
                    Debug.WriteLine(oRoute.Iave);
                    Debug.WriteLine(oRoute.EstatusIave);
                    Debug.WriteLine(oRoute.Rendimiento);
                    Debug.WriteLine(oRoute.Estatus);
                    Debug.WriteLine(oRoute.UbicacionInterna);
                    Debug.WriteLine(oRoute.FechaEntregaCasanovaLanco);
                    Debug.WriteLine(oRoute.KilometrajeEntrada);
                    Debug.WriteLine(oRoute.GasolinaEntrada);
                    Debug.WriteLine(oRoute.Estado);
                    Debug.WriteLine(oRoute.CoordinadorForaneoEncargado);
                    Debug.WriteLine(oRoute.Chofer);
                    Debug.WriteLine(oRoute.ClaveObra);
                    Debug.WriteLine(oRoute.Obra);
                    Debug.WriteLine(oRoute.ImporteCobranzaMayo2022);
                    Debug.WriteLine(oRoute.ImporteCobranzaJunio2022);
                    Debug.WriteLine(oRoute.ImporteCobranzaJulio2022);
                    Debug.WriteLine(oRoute.ImporteCobranzaAgosto2022);
                    Debug.WriteLine(oRoute.ImporteCobranzaSeptiembre2022);
                    Debug.WriteLine(oRoute.ImporteCobranzaOctubre2022);
                    Debug.WriteLine(oRoute.ImporteCobranzaNoviembre2022);
                    Debug.WriteLine(oRoute.ImporteCobranzaDiciembre2022);
                    Debug.WriteLine(oRoute.ImporteCobranzaEnero2023);
                    Debug.WriteLine(oRoute.ImporteCobranzaFebrero2023);
                    Debug.WriteLine(oRoute.ImporteCobranzaMarzo2023);
                    Debug.WriteLine(oRoute.ImporteCobranzaAbril2023);
                    Debug.WriteLine(oRoute.ImporteCobranzaMayo2023);
                    Debug.WriteLine(oRoute.ImporteCobranzaJunio2023);
                    Debug.WriteLine(oRoute.ImporteCobranzaJulio2023);
                    Debug.WriteLine(oRoute.ImporteCobranzaAgosto2023);
                    Debug.WriteLine(oRoute.ImporteCobranzaSeptiembre2023);
                    Debug.WriteLine(oRoute.ImporteCobranzaOctubre2023);
                    Debug.WriteLine(oRoute.ImporteCobranzaNoviembre2023);
                    Debug.WriteLine(oRoute.ImporteCobranzaDiciembre2023);
                    Debug.WriteLine(oRoute.ImporteCobranzaEnero2024);
                    Debug.WriteLine(oRoute.ImporteCobranzaFebrero2024);
                    Debug.WriteLine(oRoute.ImporteCobranzaMarzo2024);
                    Debug.WriteLine(oRoute.ImporteCobranzaAbril2024);
                    Debug.WriteLine(oRoute.ImporteCobranzaMayo2024);
                    Debug.WriteLine(oRoute.ImporteCobranzaJunio2024);
                    Debug.WriteLine(oRoute.ImporteCobranzaJulio2024);
                    Debug.WriteLine(oRoute.ImporteCobranzaAgosto2024);
                    Debug.WriteLine(oRoute.ImporteCobranzaSeptiembre2024);
                    Debug.WriteLine(oRoute.ImporteCobranzaOctubre2024);
                    Debug.WriteLine(oRoute.ImporteCobranzaNoviembre2024);
                    Debug.WriteLine(oRoute.ImporteCobranzaDiciembre2024);
                    Debug.WriteLine(oRoute.Factura);
                    Debug.WriteLine(oRoute.Observaciones);
                    Debug.WriteLine(oRoute.Terminacion);
                    Debug.WriteLine(oRoute.PrimerSemestre);
                    Debug.WriteLine(oRoute.SegundoSemestre);
                    Debug.WriteLine(oRoute.Seguro);
                    Debug.WriteLine(oRoute.NumeroPoliza);
                    Debug.WriteLine(oRoute.CostoPoliza);
                    Debug.WriteLine(oRoute.Vigencia);
                    Debug.WriteLine(oRoute.Entidad);
                    Debug.WriteLine(oRoute.Vigencia2);
                    Debug.WriteLine(oRoute.Refrendo);
                    Debug.WriteLine(oRoute.Tenencia2022);
                    Debug.WriteLine(oRoute.Tenencia2023);
                    Debug.WriteLine(oRoute.Tenencia2024);
                    Debug.WriteLine(oRoute.Tenencia2025);
                    Debug.WriteLine(oRoute.LicenciaDensimetroNuclear);
                    Debug.WriteLine(oRoute.EntregaUnidadCasanova);
                    Debug.WriteLine(oRoute.KmSalida);
                    Debug.WriteLine(oRoute.TotalKmRecorridos);
                    Debug.WriteLine(oRoute.CombustibleRetorno);
                    Debug.WriteLine(oRoute.Observaciones3);


                    oCmd.ExecuteNonQuery();

                    _iResponse = 1;
                    Debug.WriteLine(_iResponse);
                }
            }
            catch (SqlException sqlEx)
            {
                // Captura de excepciones de SQL Server
                Debug.WriteLine("Error SQL al ejecutar el procedimiento almacenado:");
                Debug.WriteLine(sqlEx.Message);
                _iResponse = 0;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                _iResponse = 0;
                Debug.WriteLine(ex.Message);
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
                    SqlCommand oCmd = new SqlCommand("SP_TransportesDelete", oConn);
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