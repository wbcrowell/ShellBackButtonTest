using ShellBackButtonTest.Models;
using ShellBackButtonTest.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellBackButtonTest.Views
{
    public partial class HiddenItemPage : ContentPage
    {
        public Item Item { get; set; }

        public HiddenItemPage()
        {
            InitializeComponent();
        }
    }
}