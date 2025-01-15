namespace MauiApp1.Views;

public partial class GraphicsPage : ContentPage
{
	public GraphicsPage()
	{
		InitializeComponent();
	}

	private async void OnOpenUrlClicked(object sender, EventArgs e)
	{
		var url = "https://learn.microsoft.com/en-us/dotnet/maui/user-interface/graphics/draw?view=net-maui-9.0";
		if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
		{
			await Launcher.Default.OpenAsync(uri);
		}
		else
		{
			await DisplayAlert("Error", "Invalid URL", "OK");
		}
	}
}