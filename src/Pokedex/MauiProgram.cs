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

		return builder.Build();
	}
}