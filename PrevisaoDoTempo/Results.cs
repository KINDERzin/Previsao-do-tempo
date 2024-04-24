namespace PrevisaoDoTempo;

public partial class Results
{

    

    public int temp {get; set;} // Temperatura
    
    public int humidity {get; set;} // Humidade
    
    public string date {get; set;} // Data
    public string time {get; set;} // Hora
    public string description {get; set;} // Descrição do tempo
    public string currently {get; set;} // Dia ou Noite
    public string city {get; set;} // Cidade
    public string wind_cardinal {get; set;} // Direção do vento
    public string moon_phase {get; set;} // Fase da lua
    public string wind_speedy {get; set;} // Velocidade do vento  
    public string sunrise {get; set;} // Amanhecer
    public string sunset {get; set;} //Anoitecer

    public double cloudiness {get; set;} // Nublado
    public double rain {get; set;} // Chuva
      

	public Results()
	{
		
	}
}