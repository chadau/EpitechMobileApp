﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EpitechMobileApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void OnConnect(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConnectionPage());
        }
	}
}
