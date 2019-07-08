using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftShopXamarin.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Welcome
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
