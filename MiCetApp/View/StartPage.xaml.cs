namespace MiCetApp.View;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        NavigationPage.SetHasBackButton(this, false);
    }
}