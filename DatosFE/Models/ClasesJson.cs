using Newtonsoft.Json;

namespace DatosFE.FE
{ 


    public class ClasesJson
{
}

public class RespuestaHacienda
{
    [JsonProperty("clave")]
    public string clave { get; set; }

    [JsonProperty("fecha")]
    public string fecha { get; set; }

    [JsonProperty("ind-estado")]
    public string ind_estado { get; set; }

    [JsonProperty("respuesta-xml")]
    public string respuesta_xml { get; set; }
}

public class Token
{
    [JsonProperty("access_token")]
    public string access_token { get; set; }

    [JsonProperty("refresh_token")]
    public string refresh_token { get; set; }
}

public class Recepcion
{
    [JsonProperty("clave")]
    public string clave { get; set; }

    [JsonProperty("fecha")]
    public string fecha { get; set; }

    [JsonProperty("emisor")]
    public Emisor emisor { get; set; }

    [JsonProperty("receptor")]
    public Receptor receptor { get; set; }

    [JsonProperty("comprobanteXml")]
    public string comprobanteXml { get; set; }

    [JsonProperty("consecutivoReceptor")]
    public string consecutivoReceptor { get; set; }
}

public class Emisor
{
    [JsonProperty("TipoIdentificacion")]
    public string TipoIdentificacion { get; set; }
    [JsonProperty("numeroIdentificacion")]
    public string numeroIdentificacion { get; set; }
}

public class Receptor
{
    [JsonProperty("TipoIdentificacion")]
    public string TipoIdentificacion { get; set; }
    [JsonProperty("numeroIdentificacion")]
    public string numeroIdentificacion { get; set; }
    public bool sinReceptor { get; set; } = false;
}
}