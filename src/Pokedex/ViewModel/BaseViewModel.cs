using CommunityToolkit.Mvvm.ComponentModel;

namespace Pokedex.ViewModel;

public partial class BaseViewModel : ObservableObject {

	[ObservableProperty]
	[NotifyPropertyChangedFor(nameof(IsNotBusy))]
	bool isBusy;
	
	[ObservableProperty]
	string title;

	public bool IsNotBusy => !IsBusy;

	protected IConnectivity connectivity;

}