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
			var navigationPage = new NavigationPage(new PagesDemo());
			await Navigation.PushAsync(navigationPage);
		}

		private async void LayoutsDemo_Clicked(object sender, EventArgs e)
		{
			var navigationPage = new NavigationPage(new PagesDemo());
			await Navigation.PushAsync(navigationPage);
		}
	}
}
