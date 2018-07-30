using ListViewDemo.Controls;
using ListViewDemo.iOS.PlatformCode.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomListCell), typeof(MenuViewCellRenderer))]
namespace ListViewDemo.iOS.PlatformCode.Renderers
{
    public class MenuViewCellRenderer : ViewCellRenderer
    {

        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {

            var cell = base.GetCell(item, reusableCell, tv);
            if (cell != null)
            {

                cell.SelectedBackgroundView = new UIView()
                {
                    BackgroundColor = UIColor.Yellow
                };

            }


            tv.SeparatorStyle = UITableViewCellSeparatorStyle.None;
            return cell;
        }

    }
}
