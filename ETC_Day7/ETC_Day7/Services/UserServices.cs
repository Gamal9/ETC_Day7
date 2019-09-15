using ETC_Day7.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ETC_Day7.Services
{
    public class UserServices
    {
        private SQLiteAsyncConnection Connection;
        public UserServices()
        {
            DataGetter();
        }

        private async void DataGetter()
        {
            Connection = DependencyService.Get<ISqliteInterface>().GetConnection();
            await Connection.CreateTableAsync<User>();
        }

        public async Task<int> InsertNewUser(User user)
        {
            return await Connection.InsertAsync(user);
        }
        public async Task<int> DeleteUser(User user)
        {
            return await Connection.DeleteAsync(user);
        }
    }
}
