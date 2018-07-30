using System;
using System.Collections.Generic;
using System.ComponentModel;
using ListViewDemo.Models;

namespace ListViewDemo.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        private Phone selectedItem;
        public Phone SelectedItem
        {
            get { return selectedItem; }
            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;

             /*       var newPhones = new List<Phone>(Phones);

                    foreach (var item in newPhones)
                    {
                        if (item.Title == selectedItem.Title)
                            item.ImagePath = String.Concat(item.ImageName, "_blue.png");
                        else
                            item.ImagePath = String.Concat(item.ImageName, ".png");
                    }
                    Phones = null;
                    phones = newPhones;*/

                    OnPropertyChanged("SelectedItem");

                }
            }
        }


        private List<Phone> phones;
        public List<Phone> Phones
        {
            get { return phones; }
            set
            {
                if (phones != value)
                {
                    phones = value;
                    OnPropertyChanged("Phones");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));


        }
    }
}
