using System;
using Xamarin.Forms;

namespace ListViewDemo.Controls
{
    public class CustomListCell : ViewCell
    {
        Label titleLabel, detailLabel;
        Image image;

        public CustomListCell()
        {
            titleLabel = new Label { FontSize = 18 };
            detailLabel = new Label();
            image = new Image();

            StackLayout cell = new StackLayout();
            cell.Orientation = StackOrientation.Horizontal;

            StackLayout titleDetailLayout = new StackLayout();
            titleDetailLayout.Children.Add(titleLabel);
            titleDetailLayout.Children.Add(detailLabel);

            cell.Children.Add(image);
            cell.Children.Add(titleDetailLayout);
            View = cell;
        }

        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create("Title", typeof(string), typeof(CustomListCell), "");

        public static readonly BindableProperty ImagePathProperty =
            BindableProperty.Create("ImagePath", typeof(ImageSource), typeof(CustomListCell), null);

        public static readonly BindableProperty ImageWidthProperty =
            BindableProperty.Create("ImageWidth", typeof(int), typeof(CustomListCell), 100);

        public static readonly BindableProperty ImageHeightProperty =
            BindableProperty.Create("ImageHeight", typeof(int), typeof(CustomListCell), 100);

        public static readonly BindableProperty DetailProperty =
            BindableProperty.Create("Detail", typeof(string), typeof(CustomListCell), "");

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public int ImageWidth
        {
            get { return (int)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }
        public int ImageHeight
        {
            get { return (int)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        public ImageSource ImagePath
        {
            get { return (ImageSource)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }

        public string Detail
        {
            get { return (string)GetValue(DetailProperty); }
            set { SetValue(DetailProperty, value); }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext != null)
            {
                titleLabel.Text = Title;
                detailLabel.Text = Detail;
                image.Source = ImagePath;
                image.WidthRequest = ImageWidth;
                image.HeightRequest = ImageHeight;
            }
        }
    }
}





