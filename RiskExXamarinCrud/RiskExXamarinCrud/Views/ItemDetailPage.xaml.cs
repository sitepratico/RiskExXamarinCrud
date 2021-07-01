using RiskExXamarinCrud.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace RiskExXamarinCrud.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();


            BindingContext = new ItemDetailViewModel();
        }

        private void SaveClicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("save option", "save was selected", "b1", "b2");
        }

        private void CancelClicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("cancel option", "cancel was selected", "b1", "b2");
        }
    }
}