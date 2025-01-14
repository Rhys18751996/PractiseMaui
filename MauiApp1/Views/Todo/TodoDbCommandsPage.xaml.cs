using MauiApp1.Data;
using MauiApp1.Models.TodoDbModels;
using System.Collections.ObjectModel;

namespace MauiApp1.Views.Todo;

public partial class TodoDbCommandsPage : ContentPage
{
	public TodoDbCommandsPage()
	{
		InitializeComponent();
	}

	private async void CreateSeedData_Clicked(object sender, EventArgs e)
	{
		var todoItems = new List<TodoItem>
			{
				new TodoItem { Title = "Buy groceries", IsCompleted = false, CreatedAt = DateTime.Now },
				new TodoItem { Title = "Complete MAUI project", IsCompleted = true, CreatedAt = DateTime.Now },
				new TodoItem { Title = "Plan the weekend", IsCompleted = false, CreatedAt = DateTime.Now },
				new TodoItem { Title = "Go for a run", IsCompleted = false, CreatedAt = DateTime.Now },
				new TodoItem { Title = "Read a book", IsCompleted = false, CreatedAt = DateTime.Now },
				new TodoItem { Title = "Write a blog post", IsCompleted = false, CreatedAt = DateTime.Now },
				new TodoItem { Title = "Clean the house", IsCompleted = false, CreatedAt = DateTime.Now },
				new TodoItem { Title = "Call a friend", IsCompleted = true, CreatedAt = DateTime.Now },
				new TodoItem { Title = "Prepare for the meeting", IsCompleted = false, CreatedAt = DateTime.Now },
				new TodoItem { Title = "Update resume", IsCompleted = false, CreatedAt = DateTime.Now },
				new TodoItem { Title = "Learn a new recipe", IsCompleted = false, CreatedAt = DateTime.Now },
				new TodoItem { Title = "Organize the desk", IsCompleted = false, CreatedAt = DateTime.Now },
				new TodoItem { Title = "Plan next vacation", IsCompleted = false, CreatedAt = DateTime.Now }
			};

		foreach (var item in todoItems)
		{
			await new TodoItemDatabase().SaveItemAsync(item);
		}
	}

	private async void DeleteTodoItemTableData_Clicked(object sender, EventArgs e)
	{
		new TodoItemDatabase().DeleteAllDataAsync<TodoItem>();
	}

	private async void DeleteEntireTodoDatabase_Clicked(object sender, EventArgs e)
	{
		new TodoItemDatabase().DropDatabaseAsync();
	}

	private async void ShowTodoData_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TodoListPage());
	}
	
}