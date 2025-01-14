using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Constants
{
	// requires nuget package - sqlite-net-pcl
	public static class ToDoDbConstants
    {
		public const string DatabaseFilename = "TodoSQLite.db3";

		public const SQLite.SQLiteOpenFlags Flags =
			// open the database in read/write mode
			SQLite.SQLiteOpenFlags.ReadWrite |
			// create the database if it doesn't exist
			SQLite.SQLiteOpenFlags.Create |
			// enable multi-threaded database access
			SQLite.SQLiteOpenFlags.SharedCache;

		public static string DatabasePath =>
			Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
	}


	/*
	The SQLiteOpenFlag enum supports these values:

	Create: The connection will automatically create the database file if it doesn't exist.
	FullMutex: The connection is opened in serialized threading mode.
	NoMutex: The connection is opened in multi-threading mode.
	PrivateCache: The connection will not participate in the shared cache, even if it's enabled.
	ReadWrite: The connection can read and write data.
	SharedCache: The connection will participate in the shared cache, if it's enabled.
	ProtectionComplete: The file is encrypted and inaccessible while the device is locked.
	ProtectionCompleteUnlessOpen: The file is encrypted until it's opened but is then accessible even if the user locks the device.
	ProtectionCompleteUntilFirstUserAuthentication: The file is encrypted until after the user has booted and unlocked the device.
	ProtectionNone: The database file isn't encrypted.
	*/
}
