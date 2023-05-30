namespace MZ_Notes.Views;

public partial class MZ_AboutPage : ContentPage
{
	public MZ_AboutPage()
	{
		InitializeComponent();
	}

    private async void MZ_LearnMore_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}