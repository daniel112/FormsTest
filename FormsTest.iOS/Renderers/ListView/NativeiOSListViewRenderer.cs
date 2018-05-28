using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using CoreGraphics;
using FormsTest.iOS;
using FormsTest.Renderers;

[assembly: ExportRenderer(typeof(NativeListView), typeof(NativeiOSListViewRenderer))]

namespace FormsTest.iOS
{
	public class NativeiOSListViewRenderer : ListViewRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged(e);
            
			if (Control == null)
                return;

			UITableView tableView = Control;
			tableView.TableFooterView = new UIView(CGRect.Empty);
		}

        
	}
}
