using System.ComponentModel.DataAnnotations;

public class Vuelta
{

    public String id { get; set;} = Guid.NewGuid().ToString();
    [Required]
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string RutaRecorrida { get; set; } = "";
    public string Capitan { get; set; } = "";
    public string NumeroDeAutobus { get; set; } = "";
    public List<Detenido> Detenidos { get; set;} = new List<Detenido>();
}

public class Detenido{
    public string? Nombre {get; set;}
    public string? Apellido {get; set;}
    public string Sexo {get; set;} = "";
    public string? Documento {get; set;}
    public string Latitud {get; set;} ="0";
    public string Longitud {get; set;} ="0";
    public double Dinero {get; set;}
    
}