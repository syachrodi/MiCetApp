namespace MiCetApp.View;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        NavigationPage.SetHasBackButton(this, false);
    }

    private void PlayAnimation(object sender, EventArgs e)
    {
        gifAnimation.IsAnimationPlaying = true;
    }

    private void PauseAnimation(object sender, EventArgs e)
    {
        gifAnimation.IsAnimationPlaying = false;
    }
}