using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using OfficeConnexion;
using Xamarin.Forms;

namespace EpitechMobileApp
{
    public partial class MainPage : ContentPage
    {
        public static string clientId = "761cb158-4f3d-4ca5-8690-cd0244513b78";
        public static string authority = "https://login.windows.net/common";
        public static string returnUri = "http://EpitechMobileApp";
        private const string graphResourceUri = "https://graph.windows.net";
        public static string graphApiVersion = "2013-11-08";
        private AuthenticationResult authResult = null;    

        public MainPage()
        {
            InitializeComponent();
        }
        public class User
        {
            public string autologin;
        }

        void az(string token)
        {
            User user = new User();
            var url = "https://intra.epitech.eu/" + token + "/&format=json";
            var req = (HttpWebRequest)WebRequest.Create(url);
            char[] delimiterChars = { ',' };

            req.Accept = "application/json";
            req.ContentType = "application/json";
            req.Method = "GET";

            var response = req.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var json = reader.ReadToEnd();
                user = JsonConvert.DeserializeObject<User>(json);
            }
        }
        private async void Button_OnClicked(object sender, EventArgs e)
        {
            /*var data = await DependencyService.Get<IAuthenticator>()
                .Authenticate(authority, graphResourceUri, clientId, returnUri);
            var userName = data.UserInfo.GivenName + " " + data.UserInfo.FamilyName;
            await DisplayAlert("Token", userName, "Ok", "Cancel");
            az(data.AccessToken);*/
        }
    }
}