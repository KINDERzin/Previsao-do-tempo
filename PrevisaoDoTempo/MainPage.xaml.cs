
using System.Diagnostics.Tracing;

namespace PrevisaoDoTempo;

public partial class MainPage : ContentPage
{
	Results resultado;
	public MainPage()
	{
		InitializeComponent();
	
		resultado = new Results();

		TestaLayout();
		PreencherTela();		
	}

	void TestaLayout(){
		resultado = new Results();

		resultado.Temp = 31;
		resultado.Currently = "Dia";
		resultado.Description = "Tempo nublado";
		resultado.Rain = 10;
		resultado.Humidity = 25;
		resultado.Sunrise = 0620;
		resultado.Cloudness = 10;
		resultado.Sunset = 1850;
		resultado.WindSpeedy = 5;
		resultado.WindCardinal = "NE";
		resultado.MoonPhase = "Minguante";
	}

	void PreencherTela(){
		LabelTemperatura.Text = Convert.ToString(resultado.Temp + "ºC");
		LabelTempo.Text = resultado.Description;
		LabelChuva.Text = Convert.ToString(resultado.Rain);
		LabelHumidade.Text = Convert.ToString(resultado.Humidity);
		LabelAmanhecer.Text = Convert.ToString(resultado.Sunrise);
		LabelAnoitecer.Text = Convert.ToString(resultado.Sunset);
		LabelForca.Text = Convert.ToString(resultado.WindSpeedy);
		LabelDirecao.Text = resultado.WindCardinal;
		LabelFase.Text = resultado.MoonPhase;

		int Temp = 31;
		string Description = "Tempo nublado";
		int Rain = 11;
		int Humidity = 25;
		int Sunrise = 0620;
		int Sunset = 1850;
		int Cloudness = 30;
		int WindSpeedy = 5;
		string WindCardinal = "NE";
		string MoonPhase = "Minguante";

		if(Rain > 10)
			TelaDeFundo.Source = "dia_chuvoso.png";
		
		else 
			TelaDeFundo.Source = "dia_claro.png";

		if(Cloudness > 20)
			TelaDeFundo.Source = "dia_nublado.png";
		
		else
			TelaDeFundo.Source = "dia_claro.png";
	}
	
}

