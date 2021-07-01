using RiskExXamarinCrud.ViewModels;
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
    }
}