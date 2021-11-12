using ShellBackButtonTest.Models;
using ShellBackButtonTest.ViewModels;
using ShellBackButtonTest.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellBackButtonTest.Views
{
    public partial class HiddenItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public HiddenItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}