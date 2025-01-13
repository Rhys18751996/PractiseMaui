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
			var navigationPage = new NavigationPage(new PagesDemo());
			await Navigation.PushAsync(navigationPage);
		}
	}
}
