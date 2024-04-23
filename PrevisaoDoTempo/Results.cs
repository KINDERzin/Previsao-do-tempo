namespace PrevisaoDoTempo;

public partial class Results
{

    

    public int temp {get; set;} // Temperatura
    public int sunrise {get; set;} // Amanhecer
    public int sunset {get; set;} //Anoitecer
    public string date {get; set;} // Data
    public string time {get; set;} // Hora
    public string description {get; set;} // Descrição do tempo
    public string currently {get; set;} // Dia ou Noite
    public string city {get; set;} // Cidade
    public int humidity {get; set;} // Humidade
    public double cloudiness {get; set;} // Nublado
    public double rain {get; set;} // Chuva
    public double wind_speedy {get; set;} // Velocidade do vento
    public string wind_cardinal {get; set;} // Direção do vento
    public string moon_phase {get; set;} // Fase da lua
    public int image_id {get; set;} // Id da imagem

	public Results()
	{
		
	}
}