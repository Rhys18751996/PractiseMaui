namespace MauiApp1.Views;

public partial class PagesDemo : ContentPage
{
	public PagesDemo()
	{
		InitializeComponent();
	}


	//protected override void OnNavigatedFrom()
	//{
		// Cleanup actions
	//}

	//protected override void OnNavigatedTo(NavigationEventArgs args)
	//{
		// Load data or perform actions on arrival

		//	var id = args.Parameters["id"];
		//	// Use the parameter as needed
	//}

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