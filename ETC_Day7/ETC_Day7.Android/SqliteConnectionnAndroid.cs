using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ETC_Day7.Droid;
using ETC_Day7.Models;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqliteConnectionnAndroid))]
namespace ETC_Day7.Droid
{
    public class SqliteConnectionnAndroid : ISqliteInterface
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var dbpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbpath, "Mydatabase");
            return new SQLiteAsyncConnection(path);
        }
    }
}