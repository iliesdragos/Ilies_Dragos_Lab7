namespace Ilies_Dragos_Lab7;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureEssentials(essentials =>
			{
				essentials.UseMapServiceToken("HEVvLcHhcSEwrOvLC8c7~581Iv88kFiHta5-xpDHTsg~AuWpNoojttQMag_JhHZzPkoU4W_o8YpVnyATfAnQHNNwVwNLK3nt4z3HVGIwIQyH");
			});

		return builder.Build();
	}
}
