using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace API_WPFClient
{
	public partial class DeleteWindow : Window
	{
		private const string ApiUrl = "http://localhost:3001";
		public DeleteWindow()
		{
			InitializeComponent();
		}
		private async void SendDataButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				string countryName = CountrynameTextBox.Text;

				using (HttpClient client = new HttpClient())
				{
					HttpResponseMessage response = await client.DeleteAsync(ApiUrl + "/deleteCountry/" + countryName);
					response.EnsureSuccessStatusCode();

					MessageBox.Show("Country name sent successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
	}
}
