using MauiApp1.Views.ControlsDemo;
using MauiApp1.Views.LayoutsDemo;
using MauiApp1.Views.Todo;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


			LayoutsDemoBtn.Clicked += (sender, args) =>
			{
				// Navigate to the next page when the button is clicked
				Navigation.PushAsync(new LayoutsDemo());
			};
		}


        private async void PagesDemo_Clicked(object sender, EventArgs e)
        {
			await Shell.Current.GoToAsync("//PagesDemo");

			// Pass parameters while navigating
			//await Shell.Current.GoToAsync("//second?id=123");


			//var navPage = new NavigationPage(new PagesDemo());
			//await Navigation.PushAsync(navPage);
		}

		//private async void LayoutsDemo_Clicked(object sender, EventArgs e)
		//{
		//	var navPage = new NavigationPage(new LayoutsDemo());
		//	await Navigation.PushAsync(navPage);
		//}

		private async void ControlsDemo_Clicked(object sender, EventArgs e)
		{
			var navPage = new NavigationPage(new ControlsPage());
			await Navigation.PushAsync(navPage);
		}

		private async void TodoDbCommands_Clicked(object sender, EventArgs e)
		{
			var navPage = new NavigationPage(new TodoDbCommandsPage());
			await Navigation.PushAsync(navPage);
		}
		
	}
}
