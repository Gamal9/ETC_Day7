using ETC_Day7.Models;
using ETC_Day7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ETC_Day7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        UserServices ser;
        public Login()
        {
            InitializeComponent();
            ser = new UserServices();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (EntryPass.Text == EntryCon.Text)
            {
                User user = new User
                {
                    Name = EntryName.Text,
                    Email = EntryEmail.Text,
                    Password = EntryPass.Text
                };
                int x = await ser.InsertNewUser(user);
            }
            else DisplayAlert("", "الباسورد مش متوافق", "OK");
        }

        private void EntryEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}