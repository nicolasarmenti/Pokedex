using Pokedex.ViewModel;

namespace Pokedex.View;

public partial class MainPage : ContentPage {
	
	public MainPage(MainPageViewModel vm) {
		InitializeComponent();
		BindingContext = vm;
	}

}