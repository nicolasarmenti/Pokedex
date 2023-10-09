using Pokedex.Model;
using System.Net.Http.Json;
using System.Text.Json;

namespace Pokedex.Services;

internal class PokeAPIService {

	HttpClient httpClient;

	public PokeAPIService(HttpClient httpClient) {
		this.httpClient = httpClient;
	}

	public async Task<PokemonResponse> GetAllPokemonsAsync() {
		HttpResponseMessage response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon?limit=10&offset=0");

		if(response.IsSuccessStatusCode) 
			return await response.Content.ReadFromJsonAsync<PokemonResponse>();

		return null;
	}

	public async Task<Pokemon> GetPokemonFromUrlAsync(string url) {
		HttpResponseMessage response = await httpClient.GetAsync(url);

		if(response.IsSuccessStatusCode) {
			return await response.Content.ReadFromJsonAsync<Pokemon>();
		} else {
			return null;
		}
	}

	public async Task<Specie> GetSpecieFromUrlAsync(string url) {
		HttpResponseMessage response = await httpClient.GetAsync(url);

		if(response.IsSuccessStatusCode) {
			return await response.Content.ReadFromJsonAsync<Specie>();
		} else {
			return null;
		}
	}

}