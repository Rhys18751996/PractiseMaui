using SQLite;
using MauiApp1.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Models.TodoDbModels;

namespace MauiApp1.Data
{
	// https://learn.microsoft.com/en-us/dotnet/maui/data-cloud/database-sqlite?view=net-maui-9.0
	public class TodoItemDatabase
    {
		SQLiteAsyncConnection Database;

		public TodoItemDatabase()
		{
		}

		async Task Init()
		{
			if (Database is not null)
				return;

			Database = new SQLiteAsyncConnection(ToDoDbConstants.DatabasePath, ToDoDbConstants.Flags);
			var result = await Database.CreateTableAsync<TodoItem>();
		}


		#region Data manipulation methods
		public async Task<IEnumerable<TodoItem>> GetItemsAsync()
		{
			await Init();
			var result = await Database.Table<TodoItem>().ToListAsync();
			return result;
		}


		/// <summary>
		/// 
		/// </summary>
		public async Task<List<TodoItem>> GetItemsNotDoneAsync()
		{
			await Init();
			return await Database.Table<TodoItem>().Where(t => t.IsCompleted).ToListAsync();

			// SQL queries are also possible
			//return await Database.QueryAsync<TodoItem>("SELECT * FROM [TodoItem] WHERE [IsCompleted] = 0");
		}

		//public User GetByUsername(string username)
		//{
		//	var user = from u in conn.Table<User>()
		//			   where u.Username == username
		//			   select u;
		//	return user.FirstOrDefault();
		//}

		/// <summary>
		/// 
		/// </summary>
		public async Task<TodoItem> GetItemAsync(int id)
		{
			await Init();
			return await Database.Table<TodoItem>().Where(i => i.Id == id).FirstOrDefaultAsync();
		}


		/// <summary>
		/// 
		/// </summary>
		public async Task<int> SaveItemAsync(TodoItem item)
		{
			await Init();
			if (item.Id != 0)
				return await Database.UpdateAsync(item);
			else
				return await Database.InsertAsync(item);
		}


		/// <summary>
		/// 
		/// </summary>
		public async Task<int> DeleteItemAsync(TodoItem item)
		{
			await Init();
			return await Database.DeleteAsync(item);
		}


		/// <summary>
		/// 
		/// </summary>
		public async Task DropDatabaseAsync()
		{
			if (Database != null)
			{
				await Database.CloseAsync(); // Ensure the database connection is closed
				Database = null;
			}

			try
			{
				if (File.Exists(ToDoDbConstants.DatabasePath))
					File.Delete(ToDoDbConstants.DatabasePath);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error deleting database: {ex.Message}");
			}
		}


		/// <summary>
		/// usage
		/// var database = new TodoItemDatabase()
		/// Delete all data from the TodoItem table
		/// await database.DeleteAllDataAsync(TodoItem)()
		/// </summary>
		public async Task<int> DeleteAllDataAsync<T>() where T : new()
		{
			await Init();
			return await Database.DeleteAllAsync<T>();
		}

		#endregion
	}
}
