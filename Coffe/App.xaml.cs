using Coffe.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coffe
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
