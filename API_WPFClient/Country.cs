using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_WPFClient
{
	public class Country
	{
		public string Countryname { get; set; }
		public string Capital { get; set; }
		public string Continent { get; set; }
		public Int32 Population { get; set; }
		public string Currency { get; set; }
		public string[] Common_languages { get; set; }
		public string Imagesource { get; set; }
	}
}
