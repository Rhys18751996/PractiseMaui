using MauiApp1.Views;
using System.Windows.Input;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
		public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();

		public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));



		public AppShell()
        {
            InitializeComponent();
			RegisterRoutes();
		}

		void RegisterRoutes()
		{
			Routes.Add("home", typeof(MainPage));
			Routes.Add("pagesdemo", typeof(PagesDemo));
			Routes.Add("layoutsdemo", typeof(LayoutsDemo));
			Routes.Add("controlspage", typeof(ControlsPage));

			foreach (var item in Routes)
				Routing.RegisterRoute(item.Key, item.Value);
		}
	}
}
