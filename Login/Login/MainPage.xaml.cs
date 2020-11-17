using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		async void LoginClicked(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(User.Text) | string.IsNullOrEmpty(Pass.Text))
			{
				await DisplayAlert("Error", "Something is missing", "Ok");
			}
			else
			{
				await Navigation.PushModalAsync(new HomePage());
				await DisplayAlert("Welcome", $"Welcome again {User.Text}", "Ok");
			}

			
		}

		async void SingupClicked(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Name.Text) |
				string.IsNullOrEmpty(Email.Text) |
				string.IsNullOrEmpty(Pass1.Text) |
				string.IsNullOrEmpty(Pass2.Text))
			{
				await DisplayAlert("Error", "Something is missing", "Ok");
			}
			else if (Pass1.Text != Pass2.Text)
			{
				await DisplayAlert("Error", "The Passwords are not the same", "Ok");
			}
			else
			{
				await Navigation.PushModalAsync(new HomePage());
				await DisplayAlert("Welcome", $"Welcome again {Name.Text}", "Ok");
			}
		}

		private void GoSign(object sender, EventArgs e)
		{
			CurrentPage = SignUpView;
		}
	}
}
