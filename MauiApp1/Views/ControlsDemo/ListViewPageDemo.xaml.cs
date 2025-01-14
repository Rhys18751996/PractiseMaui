using MauiApp1.Models.TodoDbModels;
using System.Collections.ObjectModel;

namespace MauiApp1.Views.ControlsDemo;

public partial class ListViewPageDemo : ContentPage
{

	public ObservableCollection<TodoItem> TodoItems { get; set; }

	public ListViewPageDemo()
	{
		InitializeComponent();

		TodoItems = new ObservableCollection<TodoItem>
			{
				new TodoItem { Id = 1, Title = "Buy groceries", IsCompleted = false, CreatedAt = DateTime.Now },
				new TodoItem { Id = 2, Title = "Complete MAUI project", IsCompleted = true, CreatedAt = DateTime.Now },
				new TodoItem { Id = 3, Title = "Plan the weekend", IsCompleted = false, CreatedAt = DateTime.Now }
			};

		BindingContext = this;
	}
}