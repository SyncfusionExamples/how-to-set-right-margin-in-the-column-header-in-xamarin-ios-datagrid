
using System;

using Foundation;
using UIKit;
using Syncfusion.SfDataGrid;
using CoreGraphics;

namespace Sample
{
	public partial class SampleViewController : UIViewController
	{
		#region Field

		SfDataGrid sfGrid;
		ViewModel viewModel;
		GridTextColumn productNameColumn;
		GridTextColumn priceColumn;

		#endregion

		public SampleViewController () : base ("SampleViewController", null)
		{
			sfGrid = new SfDataGrid();
			sfGrid.AutoGenerateColumns = false;
			viewModel = new ViewModel ();
			sfGrid.ItemsSource = viewModel.ProductDetails;

			productNameColumn= new GridTextColumn ();
			productNameColumn.MappingName = "ProductName";
			productNameColumn.HeaderText = "Product Name Column Header";
			productNameColumn.HeaderTextAlignment = UITextAlignment.Left;
			productNameColumn.TextAlignment = UITextAlignment.Left;
			productNameColumn.TextMargin = 10;
			sfGrid.Columns.Add (productNameColumn);

			priceColumn = new GridTextColumn ();
			priceColumn.MappingName = "Price";
			priceColumn.HeaderText = "Price";
			priceColumn.HeaderTextAlignment = UITextAlignment.Right;
			priceColumn.TextAlignment = UITextAlignment.Right;
			priceColumn.TextMargin = 10;
			sfGrid.Columns.Add (priceColumn);

			sfGrid.HeaderRowHeight = 60;

			sfGrid.CellRenderers.Remove ("HeaderView");
			sfGrid.CellRenderers.Add ("HeaderView", new CustomGridHeaderCellRenderer ());
		}

		public override void ViewDidLayoutSubviews ()
		{
			base.ViewDidLayoutSubviews ();
			this.sfGrid.Frame = new CGRect (0, 20, View.Frame.Width, View.Frame.Height - 20);
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			View.AddSubview (sfGrid);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
			this.sfGrid.Dispose ();
			this.sfGrid = null;
		}
	}
}

