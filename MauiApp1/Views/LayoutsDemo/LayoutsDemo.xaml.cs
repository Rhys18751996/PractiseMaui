namespace MauiApp1.Views.LayoutsDemo;

public partial class LayoutsDemo : ContentPage
{
	public LayoutsDemo()
	{
		InitializeComponent();
	}

	private async void VerticalStackLayoutBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new StackLayoutPageDemo());
	}

	private async void HorizontalStackLayoutBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new HorizontalStackLayoutDemo());
	}

	private async void GridStackLayoutBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new GridLayoutDemo());
	}

	private async void FlexLayoutBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new FlexLayoutDemo());
	}
}