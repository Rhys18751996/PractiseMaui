using MauiApp1.Views.ControlsDemo;
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
				Navigation.PushAsync(new ContentPageDemo());
			};
		}


        private async void PagesDemo_Clicked(object sender, EventArgs e)
        {
			await Shell.Current.GoToAsync("//LayoutDemoPages");

			// Pass parameters while navigating
			//await Shell.Current.GoToAsync("//second?id=123");


			//var navigationPage = new NavigationPage(new PagesDemo());
			//await Navigation.PushAsync(navigationPage);
		}

		private async void LayoutsDemo_Clicked(object sender, EventArgs e)
		{
			var navigationPage = new NavigationPage(new PagesDemo());
			await Navigation.PushAsync(navigationPage);
		}

		private async void ControlsDemo_Clicked(object sender, EventArgs e)
		{
			var navigationPage = new NavigationPage(new ControlsPage());
			await Navigation.PushAsync(navigationPage);
		}

		private async void TodoDbCommands_Clicked(object sender, EventArgs e)
		{
			var navigationPage = new NavigationPage(new TodoDbCommandsPage());
			await Navigation.PushAsync(navigationPage);
		}
		
	}
}
