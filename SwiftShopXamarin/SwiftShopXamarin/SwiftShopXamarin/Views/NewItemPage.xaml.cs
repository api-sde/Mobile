using SwiftShopXamarin.Models;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace SwiftShopXamarin.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        public ShoppingItem Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new ShoppingItem
            {
                Text = "Item name",
                Description = "This is an item description.",
                Price = 1
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);

            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}