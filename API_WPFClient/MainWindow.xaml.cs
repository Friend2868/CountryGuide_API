using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace API_WPFClient
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void OpenAddpageButton_Click(object sender, RoutedEventArgs e)
		{
			AddWindow addWindow = new AddWindow();

			addWindow.Show();
		}
		private void OpenDeletepageButton_Click(object sender, RoutedEventArgs e)
		{
			DeleteWindow deleteWindow = new DeleteWindow();

			deleteWindow.Show();
		}
		private void OpenUpdatepageButton_Click(object sender, RoutedEventArgs e)
		{
			UpdateWindow updateWindow = new UpdateWindow();

			updateWindow.Show();
		}
	}
}
