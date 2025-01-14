using SQLite;
using System.ComponentModel;

namespace MauiApp1.Models.TodoDbModels
{
	[Table("todoitem")]
	public class TodoItem
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[SQLite.MaxLength(255)]
		public string Title { get; set; }

		public bool IsCompleted { get; set; }

		public DateTime CreatedAt { get; set; }

		public DateTime? CompletedAt { get; set; }
	}
}
