namespace MZ_Notes;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.NotePage), typeof(Views.NotePage));
    }

	private void InitializeComponent()
	{
		throw new NotImplementedException();
	}
}
