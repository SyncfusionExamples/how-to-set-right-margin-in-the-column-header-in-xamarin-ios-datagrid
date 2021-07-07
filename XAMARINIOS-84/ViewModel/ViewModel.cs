using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Sample
{
	public class ViewModel : INotifyPropertyChanged
	{
		#region Fields

		private ObservableCollection<ProductDetails> productInfo;

		#endregion

		#region Constructor

		public ViewModel()
		{
			SetRowstoGenerate (20);
		}

		#endregion

		#region Property

		public ObservableCollection<ProductDetails> ProductDetails {
			get { return productInfo; }
			set { this.productInfo = value; }
		}

		public ProductRepository ProductRepository { get; set; }

		#endregion

		#region ItemSource Generator

		public void SetRowstoGenerate (int count)
		{
			ProductRepository = new ProductRepository ();
			productInfo = ProductRepository.GetProdctDetails (count);
		}

		#endregion

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		public void RaisePropertyChanged (string propertyName)
		{
			if (PropertyChanged != null)
				this.PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
		}

		#endregion
	}

}

