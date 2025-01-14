using System;
using System.IO;
using Microsoft.Maui.Storage;

namespace MauiApp1.Services
{
	public class FileManager
	{
		private string rootDirectory;

		public FileManager()
		{
			// Get the path to the Documents folder
			string documentsPath = FileSystem.AppDataDirectory;

			// Create a folder within Documents (if it doesn't already exist)
			rootDirectory = Path.Combine(documentsPath, "MyAppRoot");
			if (!Directory.Exists(rootDirectory))
			{
				Directory.CreateDirectory(rootDirectory);
			}
		}

		public string GetRootDirectory()
		{
			return rootDirectory;
		}


		#region file action methods
		public void CreateFolder(string folderName)
		{
			string folderPath = Path.Combine(rootDirectory, folderName);
			if (!Directory.Exists(folderPath))
			{
				Directory.CreateDirectory(folderPath);
			}
		}

		public void CreateFile(string fileName, string content)
		{
			string filePath = Path.Combine(rootDirectory, fileName);
			File.WriteAllText(filePath, content);
		}

		public void DisplayFilesAndFolders()
		{
			var directories = Directory.GetDirectories(rootDirectory);
			var files = Directory.GetFiles(rootDirectory);

			Console.WriteLine("Folders:");
			foreach (var dir in directories)
			{
				Console.WriteLine(Path.GetFileName(dir));
			}

			Console.WriteLine("Files:");
			foreach (var file in files)
			{
				Console.WriteLine(Path.GetFileName(file));
			}
		}
		#endregion
	}
}
