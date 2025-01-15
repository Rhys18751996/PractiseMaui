using MauiApp1.Data;
using MauiApp1.Models.TodoDbModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp1.Views;

public partial class TodoListPage : ContentPage
{
	TodoItemDatabase database;


	private ObservableCollection<TodoItem> _todoItems;
	public ObservableCollection<TodoItem> TodoItems
	{
		get => _todoItems;
		set
		{
			_todoItems = value;
			OnPropertyChanged();
		}
	}



	public TodoListPage()//TodoItemDatabase todoItemDatabase)
	{
		InitializeComponent();

		database = new TodoItemDatabase();// todoItemDatabase;

		InitializeTodoItemsAsync();

		BindingContext = this;
	}


	protected override async void OnAppearing()
	{
		base.OnAppearing();
	}


	// Use an async method to initialize TodoItems
	private async Task InitializeTodoItemsAsync()
	{
		var items = await database.GetItemsAsync();

		if (TodoItems == null)
			TodoItems = new ObservableCollection<TodoItem>(items);
		else
			TodoItems = new ObservableCollection<TodoItem>(items.ToList());
	}

	private async void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		// Get the CheckBox that raised the event
		var checkBox = sender as CheckBox;

		// Revert the change to match the bound value
		if (checkBox != null)
		{
			// Find the bound object and reset the value
			var toDoItem = checkBox.BindingContext as TodoItem;
			await new TodoItemDatabase().SaveItemAsync(toDoItem);
		}
	}
}