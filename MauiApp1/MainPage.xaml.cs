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
			await Shell.Current.GoToAsync("//pagesdemo_link");
		}

		private async void ControlsDemo_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//controlspage_link");
		}

		private async void LayoutsDemoBtn_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//layoutsdemo_link");
		}

		private async void TodoDbCommands_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//todo_link");
		}

		private async void ExternalApisPage_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//externalapis_link");
		}
	}
}
