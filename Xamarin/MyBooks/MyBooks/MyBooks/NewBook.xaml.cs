using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyBooks
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewBook : ContentPage
	{
		public NewBook ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "We have handled the click event", "Great!");
        }
    }
}