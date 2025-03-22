using System;
using System.IO;
using Microsoft.Maui.Storage;

namespace PanfilovPR3
{
    public static class DatabaseHelper
    {
        public static string GetDatabasePath()
        {
            var folderPath = FileSystem.AppDataDirectory;
            return Path.Combine(folderPath, "expenses.db3");
        }
    }
}
