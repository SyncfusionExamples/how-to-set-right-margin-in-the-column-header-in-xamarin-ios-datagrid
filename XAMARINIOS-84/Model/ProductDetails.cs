using System;
using System.ComponentModel;

namespace Sample
{
	public class ProductDetails :INotifyPropertyChanged
	{
		public ProductDetails ()
		{
		}

		#region Private Variables 

		private string productName;
		private int price;

		#endregion

		#region Public Properties

		public string ProductName
		{
			get{return productName; }
			set{ 
				productName = value;
				RaisePropertyChanged ("ProductName");
			}
		}

		public int Price
		{
			get{return price; }
			set{ 
				price = value;
				RaisePropertyChanged ("Price");
			}
		}

		#endregion

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		private void RaisePropertyChanged (String Name)
		{
			if (PropertyChanged != null)
				this.PropertyChanged (this, new PropertyChangedEventArgs (Name));
		}

		#endregion
	}
}

