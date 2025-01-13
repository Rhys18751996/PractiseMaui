namespace MauiApp1;

public partial class PagesDemo : ContentPage
{
	public PagesDemo()
	{
		InitializeComponent();
	}

	private async void NavigateToContentPageDemo_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ContentPageDemo());
		//await Shell.Current.GoToAsync("ContentPageDemo");
	}

	private async void NavigateToFlyoutPageDemo_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new FlyoutPageDemo());
	}

	private async void NavigateToTabbedPageDemo_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TabbedPageDemo());
	}
}