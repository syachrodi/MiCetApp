using Microsoft.Maui.LifecycleEvents;
using Syncfusion.Maui.Core.Hosting;

namespace MiCetApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureSyncfusionCore()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Aureola-Italic.ttf", "AureolaItalic");
				fonts.AddFont("Aureola-Regular.ttf", "AureolaRegular");
            })
			.ConfigureLifecycleEvents(events =>
		    {
			#if ANDROID
             events.AddAndroid(android => android.OnCreate((activity, bundle) => MakeStatusBarTranslucent(activity)));

             static void MakeStatusBarTranslucent(Android.App.Activity activity)
             {
                 activity.Window.SetFlags(Android.Views.WindowManagerFlags.LayoutNoLimits, Android.Views.WindowManagerFlags.LayoutNoLimits);

                 activity.Window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);

                 activity.Window.SetStatusBarColor(Android.Graphics.Color.Transparent);
             }
			#endif
			});


        return builder.Build();
	}
}
