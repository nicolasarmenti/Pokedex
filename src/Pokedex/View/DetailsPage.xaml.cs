using Pokedex.ViewModel;

namespace Pokedex.View;

public partial class DetailsPage : ContentPage {
	public DetailsPage(DetailsViewModel vm) {
		InitializeComponent();
		BindingContext = vm;
	}
	
}