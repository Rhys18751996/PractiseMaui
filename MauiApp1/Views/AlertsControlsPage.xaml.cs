using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace MauiApp1.Views;

public partial class AlertsControlsPage : ContentPage
{
	public AlertsControlsPage()
	{
		InitializeComponent();
	}

	private async void ShowToastMessage_Clicked(object sender, EventArgs e)
	{
		CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
		//await Toast.Make("Data has been added!", ToastDuration.Long, 16).Show(cancellationTokenSource.Token);
		await Toast.Make("Data has been added!").Show(cancellationTokenSource.Token);
	}

	private async void ShowSnackBar_Clicked(object sender, EventArgs e)
	{
	}

	private async void DisplayAlert_Clicked(object sender, EventArgs e)
	{
		await DisplayAlert("Title", "A message goes here", "Close box");
	}

	private async void YesOrNoDisplayAlert_Clicked(object sender, EventArgs e)
	{
		bool answer = await DisplayAlert("Pick One", "Yes or No?", "Yes", "No");
		if (answer)
		{
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			await Toast.Make("You tapped yes").Show(cancellationTokenSource.Token);
		}
		else
		{
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			await Toast.Make("You tapped no").Show(cancellationTokenSource.Token);
		}
	}

}