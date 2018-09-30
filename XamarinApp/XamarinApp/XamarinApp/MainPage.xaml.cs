using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void SayHelloButton_OnClicked(object sender, EventArgs e)
        {
            var name = NameEntry.Text;
            await DisplayAlert("Hello World!", HelloWorldLibrary.HelloWorldClass.SayHello(name), "Bye.");
        } 
	}
}
