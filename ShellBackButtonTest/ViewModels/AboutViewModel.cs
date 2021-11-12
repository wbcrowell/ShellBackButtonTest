using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ShellBackButtonTest.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command ShowHidden { get; set; }

        public AboutViewModel()
        {
            Title = "About";
            ShowHidden = new Command(() => ExecuteShowHidden());
        }

        public ICommand OpenInvisibleCommand { get; }

        public void ExecuteShowHidden()
        {
            ((AppShell)Shell.Current).ShowHiddenAboutPage();
        }

    }
}