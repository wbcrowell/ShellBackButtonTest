using ShellBackButtonTest.ViewModels;
using ShellBackButtonTest.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ShellBackButtonTest
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        public void ShowHiddenAboutPage()
        {
            Shell.Current.CurrentItem = HiddenAboutPage;
        }

        public void ShowItemPage()
        {
            Shell.Current.Navigation.PushAsync(new ItemPage());
        }

        public void ShowHiddenItemPage()
        {
            Shell.Current.Navigation.PushAsync(new HiddenItemPage());
        }

    }
}
