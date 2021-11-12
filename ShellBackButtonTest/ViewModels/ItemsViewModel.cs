using ShellBackButtonTest.Models;
using ShellBackButtonTest.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShellBackButtonTest.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public Command ShowItemPage { get; set; }

        public Command ShowHiddenItemPage { get; set; }

        public ItemsViewModel()
        {
            ShowItemPage = new Command(ExecuteShowItemPage);
            ShowHiddenItemPage = new Command(ExecuteShowHiddenItemPage);
        }

        public void OnAppearing()
        {
        }

        public void ExecuteShowItemPage()
        {
            ((AppShell)Shell.Current).ShowItemPage();
        }

        public void ExecuteShowHiddenItemPage()
        {
            ((AppShell)Shell.Current).ShowHiddenItemPage();
        }

    }
}