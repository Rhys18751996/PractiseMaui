using CommunityToolkit.Maui.Alerts;
using System.Threading;

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
		try
		{
			await Navigation.PushAsync(new ContentPageDemo());
		}
		catch (Exception ex)
		{
			// Content page should work no matter the app shell type
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			await Toast.Make("An error occured").Show(cancellationTokenSource.Token);
		}
	}

	private async void NavigateToFlyoutPageDemo_Clicked(object sender, EventArgs e)
	{
		try
		{
			await Navigation.PushAsync(new FlyoutPageDemo());
		}
		catch (Exception ex) 
		{
			// because the app shell has a flyout built into it, flyout and tab pages cannot be added.
			// the app shell must be a simple ShellContent type for these to work
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			await Toast.Make("An error occured, check AppShell type").Show(cancellationTokenSource.Token);
		}
	}

	private async void NavigateToTabbedPageDemo_Clicked(object sender, EventArgs e)
	{
		try
		{
			await Navigation.PushAsync(new TabbedPageDemo());
		}
		catch (Exception ex) 
		{
			// because the app shell has a flyout built into it, flyout and tab pages cannot be added.
			// the app shell must be a simple ShellContent type for these to work
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			await Toast.Make("An error occured").Show(cancellationTokenSource.Token);
		}
	}
}