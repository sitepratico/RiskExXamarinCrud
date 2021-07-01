using RiskExXamarinCrud.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RiskExXamarinCrud.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        public string Id { get; set; }

        //public Command SaveItemCommand { get; }
        //public Command CancelItemCommand { get; }

        public ItemDetailViewModel()
        {
            //SaveItemCommand = new Command(OnSaveItem);
            //CancelItemCommand = new Command(OnCancelItem);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        //private async void OnSaveItem(object obj)
        //{
        //    //await Shell.Current.GoToAsync(nameof(NewItemPage));
        //    DisplayAlert("save option", "save was selected", "b1", "b2");
        //}

        //private async void OnCancelItem(object obj)
        //{
        //    //await Shell.Current.GoToAsync(nameof(NewItemPage));
        //    DisplayAlert("cancel option", "cancel was selected", "b1", "b2");
        //}
    }
}
