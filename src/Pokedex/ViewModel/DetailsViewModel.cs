using Pokedex.Model;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Pokedex.ViewModel;

[QueryProperty("Pokemon", "Pokemon")]
public partial class DetailsViewModel : BaseViewModel {

	[ObservableProperty]
	Pokemon pokemon;

	public DetailsViewModel() {
		
	}

	[RelayCommand]
	async Task GoBackAsync() {
		await Shell.Current.GoToAsync("..");
	}

}