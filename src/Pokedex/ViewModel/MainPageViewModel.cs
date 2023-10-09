using Pokedex.Model;
using Pokedex.Services;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Pokedex.View;

namespace Pokedex.ViewModel;

public partial class MainPageViewModel : BaseViewModel {

	public ObservableCollection<Pokemon> pokemonList { get; } = new();

	HttpClient httpClient = new();

	public MainPageViewModel(IConnectivity connectivity) {
		this.connectivity = connectivity;

		LoadAsync();
	}

	public async void LoadAsync() {
		await GetPokemonsAsync();
	}

	[RelayCommand]
	public async Task GetPokemonsAsync() {
		if(IsBusy) return;

		if(connectivity.NetworkAccess != NetworkAccess.Internet) {
			await Shell.Current.DisplayAlert("Internet issue!", "Check yourn internet connection and try again", "OK");
			return;
		}

		IsBusy = true;
		
		PokeAPIService service = new(httpClient);

		try {
			PokemonResponse response = await service.GetAllPokemonsAsync();

			foreach(Result res in response.results) {
				Pokemon pkm = await service.GetPokemonFromUrlAsync(res.url);
				pokemonList.Add(pkm);
			}
		} catch(Exception ex) {
			Debug.WriteLine(ex);
			await Shell.Current.DisplayAlert("Error!", $"Unable to get pokemons: {ex.Message}", "OK");
		} finally {
			IsBusy = false;
		}
	}

	[RelayCommand]
	public async Task GoToDetailsAsync(Pokemon pkm) {
		if(pkm is null) return;

		try {
			if(pkm.specie is null) {
				PokeAPIService service = new(httpClient);
				pkm.specie = await service.GetSpecieFromUrlAsync(pkm.species.url);
			}

			Application.Current.Resources.TryGetValue("Type" + pkm.types[0].type.FullName, out var actual);
			if(actual != null) {
				Application.Current.Resources["Wireframe"] = actual;
			} else {
				Application.Current.Resources["Wireframe"] = new Microsoft.Maui.Graphics.Color(184, 184, 184);
			}

			await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object> { { "Pokemon", pkm} });
		} catch(Exception ex) {
			Debug.WriteLine(ex);
			await Shell.Current.DisplayAlert("Error!", $"Unable to get pokemons: {ex.Message}", "OK");
		}
	}
}