using OrderCom.Contracts;
using OrderCom.Services;
using OrderCom.ViewModels;
using OrderCom.Views;

namespace OrderCom;

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
			});

		RegisterServices(builder.Services);
		RegisterViewModels(builder.Services);
		RegisterPages(builder.Services);

		return builder.Build();
	}

	static void RegisterServices(in IServiceCollection services)
	{
        services.AddSingleton<ILoginService, LoginService>();
		services.AddSingleton<IDatabaseService, DatabaseService>();
		services.AddSingleton<INarudzbeniceService, NarudzbeniceService>();
    }

    static void RegisterPages(in IServiceCollection services)
	{
        services.AddSingleton<LoginPage>();
		services.AddSingleton<KnjiznaObavijestPage>();
		services.AddSingleton<KupacPage>();
		services.AddSingleton<ProizvodPage>();
		services.AddSingleton<NarudzbaPage>();
		services.AddTransient<NarudzbaDetailPage>();
    }

    static void RegisterViewModels(in IServiceCollection services)
	{
		services.AddSingleton<LoginViewModel>();
		services.AddSingleton<ProizvodViewModel>();
		services.AddSingleton<KupacViewModel>();
		services.AddSingleton<NarudzbaViewModel>();
		services.AddSingleton<KnjiznaObavijestViewModel>();
		services.AddTransient<NarudzbaDetailViewModel>();
	}
}
