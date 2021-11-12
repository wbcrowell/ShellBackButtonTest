using ShellBackButtonTest.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ShellBackButtonTest.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}