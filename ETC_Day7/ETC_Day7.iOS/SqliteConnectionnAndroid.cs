using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ETC_Day7.iOS;
using ETC_Day7.Models;
using Foundation;
using SQLite;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqliteConnectionnIOS))]
namespace ETC_Day7.iOS
{
    public class SqliteConnectionnIOS : ISqliteInterface
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var dbpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbpath, "ETC.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}