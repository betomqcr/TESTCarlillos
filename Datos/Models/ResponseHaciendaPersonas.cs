using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Datos.Models
{
    public partial class ResponseHaciendaPersonas
    {
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("tipoIdentificacion")]
        public string TipoIdentificacion { get; set; }

        //[JsonProperty("regimen")]
        //public Regimen Regimen { get; set; }

        //[JsonProperty("situacion")]
        //public Situacion Situacion { get; set; }

        //[JsonProperty("actividades")]
        //public Actividade[] Actividades { get; set; }

    }

    //public partial class Actividade
    //{
    //    [JsonProperty("estado")]
    //    public string Estado { get; set; }

    //    [JsonProperty("tipo")]
    //    public string Tipo { get; set; }

    //    [JsonProperty("codigo")]
    //    [JsonConverter(typeof(ParseStringConverter))]
    //    public long Codigo { get; set; }

    //    [JsonProperty("descripcion")]
    //    public string Descripcion { get; set; }
    //}

    //public partial class Regimen
    //{
    //    [JsonProperty("codigo")]
    //    public long Codigo { get; set; }

    //    [JsonProperty("descripcion")]
    //    public string Descripcion { get; set; }
    //}

    //public partial class Situacion
    //{
    //    [JsonProperty("moroso")]
    //    public string Moroso { get; set; }

    //    [JsonProperty("omiso")]
    //    public string Omiso { get; set; }

    //    [JsonProperty("estado")]
    //    public string Estado { get; set; }

    //    [JsonProperty("administracionTributaria")]
    //    public string AdministracionTributaria { get; set; }
    //}
}