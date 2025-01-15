namespace MauiApp1.Views;

public partial class ControlsPage : ContentPage
{
	public ControlsPage()
	{
		InitializeComponent();
	}

	
	private async void ListViewControlDemo_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ListViewControlPageDemo());
	}

	private async void AlertsDemo_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new AlertsControlsPage());
	}

	private async void GraphicsDemo_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new GraphicsPage());
	}
	
}