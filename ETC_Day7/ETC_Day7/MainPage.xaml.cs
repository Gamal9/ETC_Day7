using ETC_Day7.Models;
using ETC_Day7.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ETC_Day7
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        UserServices ser;
        public MainPage()
        {
            InitializeComponent();
            ser = new UserServices();
            DataGetter();
        }
        public async void DataGetter()
        {
            List<User> list = await ser.UsersGetter();
            Mylist.ItemsSource = list;
        }
    }
}
