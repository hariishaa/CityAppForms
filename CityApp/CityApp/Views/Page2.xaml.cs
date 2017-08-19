using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CityApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //string client_id = "5994190";
            //string redirect_uri = "https://oauth.vk.com/blank.html";
            //Uri authorization_url = new Uri($"https://oauth.vk.com/authorize?client_id={client_id}&redirect_uri={redirect_uri}");
            //Device.OpenUri(authorization_url);

            var auth = new OAuth2Authenticator
            (
                clientId: "5994190",
                scope: "",
                authorizeUrl: new Uri("https://oauth.vk.com/authorize"),
                redirectUrl: new Uri("https://oauth.vk.com/blank.html"),
                clientSecret: null,
                accessTokenUrl: new Uri("https://oauth.vk.com/blank.html")
            )
            {
                Title = "Авторизация",
            };
            auth.Completed += Auth_Completed;

            var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
            presenter.Login(auth);
        }

        private void Auth_Completed(object sender, AuthenticatorCompletedEventArgs e)
        {
        }
    }
}