namespace PrevisaoDoTempo;

public partial class Results
{

    Results Resultado;

    public int Tempo {get; set;}
    public int Date {get; set;}
    public int Time {get; set;}
    public string Description {get; set;}
    public string Curently {get; set;}
    public string City {get; set;}
    public int Humidity {get; set;}
    public double Cloudness {get; set;}
    public double Rain {get; set;}
    public double Wind_speedy {get; set;}
    public int Condition_code {get; set;}
    public int Image_id {get; set;}

	public Results()
	{
		var Resultado = new Results();
	}
}