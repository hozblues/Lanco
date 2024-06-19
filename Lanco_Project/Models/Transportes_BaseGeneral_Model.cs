using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc.Routing.Constraints;

namespace Lanco_Project.Models
{
    public class Transportes_BaseGeneral_Model
    {
        public int Item { get; set; }

        [Required(ErrorMessage = "Por favor ingresa la placa")] 
        public string Placa { get; set; }

        public string Flotilla { get; set; }
        public string ClaveInterna { get; set; }
        public string Marca { get; set; }
        public string Submarca { get; set; }
        public int Modelo { get; set; }
        public string NoSerie { get; set; }
        public string Iave { get; set; }
        public string EstatusIave { get; set; }
        public float? Rendimiento { get; set; }
        public string Estatus { get; set; }
        public string UbicacionInterna { get; set; }
        public DateTime? FechaEntregaCasanovaLanco { get; set; }
        public int? KilometrajeEntrada { get; set; }
        public string GasolinaEntrada { get; set; }
        public string Estado { get; set; }
        public string CoordinadorForaneoEncargado { get; set; }
        public string Chofer { get; set; }
        public string ClaveObra { get; set; }
        public string Obra { get; set; }
        public string ImporteCobranzaMayo2022 { get; set; }
        public string ImporteCobranzaJunio2022 { get; set; }
        public string ImporteCobranzaJulio2022 { get; set; }
        public string ImporteCobranzaAgosto2022 { get; set; }
        public string ImporteCobranzaSeptiembre2022 { get; set; }
        public string ImporteCobranzaOctubre2022 { get; set; }
        public string ImporteCobranzaNoviembre2022 { get; set; }
        public string ImporteCobranzaDiciembre2022 { get; set; }
        public string ImporteCobranzaEnero2023 { get; set; }
        public string ImporteCobranzaFebrero2023 { get; set; }
        public string ImporteCobranzaMarzo2023 { get; set; }
        public string ImporteCobranzaAbril2023 { get; set; }
        public string ImporteCobranzaMayo2023 { get; set; }
        public string ImporteCobranzaJunio2023 { get; set; }
        public string ImporteCobranzaJulio2023 { get; set; }
        public string ImporteCobranzaAgosto2023 { get; set; }
        public string ImporteCobranzaSeptiembre2023 { get; set; }
        public string ImporteCobranzaOctubre2023 { get; set; }
        public string ImporteCobranzaNoviembre2023 { get; set; }
        public string ImporteCobranzaDiciembre2023 { get; set; }
        public string ImporteCobranzaEnero2024 { get; set; }
        public string ImporteCobranzaFebrero2024 { get; set; }
        public string ImporteCobranzaMarzo2024 { get; set; }
        public string ImporteCobranzaAbril2024 { get; set; }
        public string ImporteCobranzaMayo2024 { get; set; }
        public string ImporteCobranzaJunio2024 { get; set; }
        public string ImporteCobranzaJulio2024 { get; set; }
        public string ImporteCobranzaAgosto2024 { get; set; }
        public string ImporteCobranzaSeptiembre2024 { get; set; }
        public string ImporteCobranzaOctubre2024 { get; set; }
        public string ImporteCobranzaNoviembre2024 { get; set; }
        public string ImporteCobranzaDiciembre2024 { get; set; }
        public string Factura { get; set; }
        public string Observaciones { get; set; }
        public int? Terminacion { get; set; }
        public string PrimerSemestre { get; set; }
        public string SegundoSemestre { get; set; }
        public string Seguro { get; set; }
        public string NumeroPoliza { get; set; }
        public float? CostoPoliza { get; set; }
        public DateTime? Vigencia { get; set; }
        public string Entidad { get; set; }
        public DateTime? Vigencia2 { get; set; }
        public string Refrendo { get; set; }
        public float? Tenencia2022 { get; set; }
        public float? Tenencia2023 { get; set; }
        public float? Tenencia2024 { get; set; }
        public float? Tenencia2025 { get; set; }
        public string LicenciaDensimetroNuclear { get; set; }
        public DateTime? EntregaUnidadCasanova { get; set; }
        public int? KmSalida { get; set; }
        public int? TotalKmRecorridos { get; set; }
        public string CombustibleRetorno { get; set; }
        public string Observaciones3 { get; set; }


    }
}