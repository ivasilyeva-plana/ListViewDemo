using System;
using System.Collections.Generic;
using ListViewDemo.Models;
using ListViewDemo.ViewModels;
using Xamarin.Forms;

namespace ListViewDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {


            InitializeComponent();

            this.BindingContext = new MainPageViewModel()
            {
                Phones = new List<Phone>
                    {
                        new Phone {Title="Galaxy S8", Company="Samsung", Price=48000, ImagePath="ic_email.png", ImageName = "ic_email"},
                        new Phone {Title="Huawei P10", Company="Huawei", Price=35000, ImagePath="ic_leads.png", ImageName = "ic_leads"},
                        new Phone {Title="HP Elite z3", Company="HP", Price=42000, ImagePath="ic_opportunities.png", ImageName = "ic_opportunities"},
                        new Phone {Title="LG G 6", Company="LG", Price=42000, ImagePath="ic_target_list.png", ImageName = "ic_target_list"},
                        new Phone {Title="iPhone 7", Company="Apple", Price=52000, ImagePath="ic_target.png", ImageName = "ic_target"}
                    }
            };
        }


    private void myListSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (((ListView)sender).SelectedItem == null) return;

            //Get the item we have tapped on in the list. Because our ItemsSource is bound to a list of BoundObject, this is possible.
            var selection = (Phone)e.SelectedItem;
            var PhoneList = (List<Phone>)myList.ItemsSource;
            //Loop through our List<BoundObject> - if the item is our selected item (checking on ID) - change the color. Else - set it back to blue 
            foreach (var item in PhoneList)
            {
                if (item.Title == selection.Title)
                    item.ImagePath = String.Concat(item.ImageName, "_blue.png");
                else
                    item.ImagePath = String.Concat(item.ImageName, ".png");
            }

            //ItemsSource must be set to null before it is re-assigned, otherwise it will not re-generate with the updated values. 
            myList.ItemsSource = null;
            //     myList.SelectedItem = null;
            myList.ItemsSource = PhoneList;
            //  myList.SelectedItem = SelectedPhone;
        }
    }


}

