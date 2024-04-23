
using System.Diagnostics.Tracing;
using System.Text.Json;

namespace PrevisaoDoTempo;

public partial class MainPage : ContentPage
{
	Resposta resposta;
	const string URL = "https://api.hgbrasil.com/weather?woeid&key=eeb4ae8c";
	public MainPage()
	{
		InitializeComponent();
	
		
		AtualizaTempo();
		
	}

	async void AtualizaTempo(){
		try{
			var HttpClient = new HttpClient();
			var Response = await HttpClient.GetAsync(URL);

			if(Response.IsSuccessStatusCode){
				var Content = await Response.Content.ReadAsStringAsync();
				resposta = JsonSerializer.Deserialize<Resposta>(Content);
			}
		}

		catch(Exception e){
			//ERRO
		}

		PreencherTela();
	}
	

	void PreencherTela(){
		LabelTemperatura.Text = Convert.ToString(resposta.results.temp + "ºC");
		LabelTempo.Text = resposta.results.description;
		LabelChuva.Text = Convert.ToString(resposta.results.rain);
		LabelHumidade.Text = Convert.ToString(resposta.results.humidity);
		LabelAmanhecer.Text = Convert.ToString(resposta.results.sunrise);
		LabelAnoitecer.Text = Convert.ToString(resposta.results.sunset);
		LabelForca.Text = Convert.ToString(resposta.results.wind_speedy);
		LabelDirecao.Text = resposta.results.wind_cardinal;
		LabelFase.Text = resposta.results.moon_phase;
		LabelHora.Text = resposta.results.time;

		int temp = 31;
		string description = "Tempo nublado";
		int rain = 11;
		int humidity = 25;
		int sunrise = 0620;
		int sunset = 1850;
		int cloudiness = 30;
		int wind_speedy = 5;
		string wind_cardinal = "NE";
		string moon_phase = "Minguante";
		string time = "00:00";

		if(resposta.results.currently == "dia"){
			if(resposta.results.rain > 10)
			TelaDeFundo.Source = "dia_chuvoso.png";
		
		else if(resposta.results.cloudiness > 20)
			TelaDeFundo.Source = "dia_nublado.png";

		else
			TelaDeFundo.Source = "dia_claro.png";
		}
		
		else {
			
			if(resposta.results.rain > 10)
			TelaDeFundo.Source = "noite_chuvosa.png";
		
			else if(resposta.results.cloudiness > 20)
				TelaDeFundo.Source = "noite_nublada.png";

			else
				TelaDeFundo.Source = "noite_clara.png";
		}
		
	}

}

