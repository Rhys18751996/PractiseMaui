namespace MauiApp1.Views.ControlsDemo;

public partial class ControlsPage : ContentPage
{
	public ControlsPage()
	{
		InitializeComponent();
	}

	
	private async void ListViewControlDemo_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ListViewPageDemo());
	}
}