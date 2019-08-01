using System;
using System.Collections.ObjectModel;

namespace Sample
{
	public class ProductRepository
	{
		#region Constructor

		public ProductRepository ()
		{
			
		}

		#endregion 

		#region private variables 

		private  ObservableCollection<ProductDetails> productDetails;

		#endregion


		#region GetProdctDetails

		public ObservableCollection<ProductDetails> GetProdctDetails(int count)
		{
			productDetails = new ObservableCollection<ProductDetails> ();

			Random random = new Random ();
			for (int i = 0; i < count; i++) 
			{
				var product = new ProductDetails () {
					ProductName = this.ProductName [random.Next (1, 7)],
					Price = random.Next(5000,15000)
				};
				productDetails.Add (product);
			}
			return productDetails;
		}

		string[] ProductName = new string[]
		{
			"Dell", 
			"HP",
			"Asus",
			"Sony",
			"Apple",
			"Lenovo" ,
			"Nokia", 
			"Samsung",
			"SonyMobile",
			"HTC",
			"IPhone" ,
			"FastTrack",
			"ROLEX", 
			"Casio",
			"Geneva",
			"Seiko"
		};

		#endregion


	}
}

