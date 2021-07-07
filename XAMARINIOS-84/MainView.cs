using System;
using UIKit;
using Syncfusion.SfDataGrid;
using CoreGraphics;

namespace Sample
{
	public class MainView : UIView
	{
		#region Field

		SfDataGrid sfGrid;
		ViewModel viewModel;

		#endregion

		public MainView ()
		{
			sfGrid = new SfDataGrid();
			sfGrid.DefaultColumnWidth = this.Frame.Width / 2;
			viewModel = new ViewModel ();
//			sfGrid.ItemsSource = viewModel.ProductDetails;
//			GridTextColumn productColumn = new GridTextColumn ();
//			productColumn.Width = 200;
//			sfGrid.Columns.Add (productColumn);
			this.AddSubview (sfGrid);
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();
			this.sfGrid.Frame = new CGRect (0, 20, Frame.Width, Frame.Height);
		}

		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			sfGrid.Dispose ();
			sfGrid = null;
		}
	}
}

