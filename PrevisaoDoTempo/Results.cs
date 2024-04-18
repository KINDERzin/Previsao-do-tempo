namespace PrevisaoDoTempo;

public partial class Results
{

    

    public int Temp {get; set;} // Temperatura
    public int Sunrise {get; set;} // Amanhecer
    public int Sunset {get; set;} //Anoitecer
    public int Date {get; set;} // Data
    public int Time {get; set;} // Hora
    public string Description {get; set;} //
    public string Currently {get; set;} //
    public string City {get; set;} // Cidade
    public int Humidity {get; set;} // Humidade
    public double Cloudness {get; set;} // Nublado
    public double Rain {get; set;} // Chuva
    public double WindSpeedy {get; set;} // Velocidade do vento
    public string WindCardinal {get; set;} // Direção do vento
    public int Condition_code {get; set;} //
    public string MoonPhase {get; set;} // Fase da lua
    public int Image_id {get; set;} // Id da imagem

	public Results()
	{
		
	}
}