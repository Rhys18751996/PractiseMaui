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
		await Toast.Make("Data has been added!",
				  ToastDuration.Short,
				  14)
			.Show(cancellationTokenSource.Token);
	}

	private async void ShowSnackBar_Clicked(object sender, EventArgs e)
	{
	}
	
}