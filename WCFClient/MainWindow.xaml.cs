using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WCFClient
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{

			try
			{
				WCFClient.ServiceReference1.Service1Client obj = new WCFClient.ServiceReference1.Service1Client();

				textBox.Text = obj.GetData(Convert.ToInt32(textBox.Text));
			}
			catch (Exception ex)
			{
				textBox.Text = ex.Message;
			}
		}
	}
}
