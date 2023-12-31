﻿using Pokedex.View;
using Pokedex.Services;
using Pokedex.ViewModel;

namespace Pokedex;

public static class MauiProgram {
	public static MauiApp CreateMauiApp() {
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts => {
				fonts.AddFont("Poppins-Black.ttf", "PoppinsBlack");
				fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
				fonts.AddFont("Poppins-ExtraBold.ttf", "PoppinsExtraBold");
				fonts.AddFont("Poppins-ExtraLight.ttf", "PoppinsExtraLight");
				fonts.AddFont("Poppins-Light.ttf", "PoppinsLight");
				fonts.AddFont("Poppins-Medium.ttf", "PoppinsMedium");
				fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
				fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsSemiBold");
				fonts.AddFont("Poppins-Thin.ttf", "PoppinsThin");
			});

		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

		builder.Services.AddSingleton<PokeAPIService>();

		builder.Services.AddSingleton<MainPageViewModel>();
		builder.Services.AddTransient<DetailsViewModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<DetailsPage>();

		return builder.Build();
	}
}