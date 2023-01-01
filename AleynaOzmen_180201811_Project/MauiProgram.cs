using AleynaOzmen_180201811_Project.DBTrans;

namespace AleynaOzmen_180201811_Project;

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
        string dbtrans = Path.Combine(FileSystem.AppDataDirectory, "company.db");
        //string _db_Crs_Path = Path.Combine(FileSystem.AppDataDirectory, "Student.db");
        builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<dBTransFixed>(s, dbtrans));
        return builder.Build();
	}
}
