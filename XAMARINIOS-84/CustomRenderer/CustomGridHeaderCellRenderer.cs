using System;
using Syncfusion.SfDataGrid;
using UIKit;
using Foundation;

namespace Sample
{
    public class CustomGridHeaderCellRenderer : GridHeaderCellRenderer
    {
        public override void OnInitializeDisplayView(DataColumnBase dataColumn, UIView view)
        {
            base.OnInitializeDisplayView(dataColumn, view);

            UILabel label = view as UILabel;

            if (label == null)
                return;

            label.LineBreakMode = UILineBreakMode.WordWrap;
            label.Lines = 2;
            if (dataColumn.GridColumn.HeaderTextAlignment == UITextAlignment.Right)
            {
                label.Text += "  .";
                var textAttributed = new NSMutableAttributedString(label.Text);
                var colorAttribute = new UIStringAttributes()
                {
                    ForegroundColor = UIColor.Clear
                };
                textAttributed.SetAttributes(colorAttribute, new NSRange(label.Text.Length - 1, 1));
                label.AttributedText = textAttributed;
            }
        }
    }
}

