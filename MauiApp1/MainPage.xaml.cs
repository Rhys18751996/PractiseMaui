using MauiApp1;
using MauiApp1.Views;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
		}


        private async void PagesDemo_Clicked(object sender, EventArgs e)
        {
			//await Shell.Current.GoToAsync("//PagesDemo"); // clear navigation stack 
			await Shell.Current.GoToAsync("//pagesdemo");
		}

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

		private async void LayoutsDemoBtn_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//layoutsdemo");
		}
	}
}
