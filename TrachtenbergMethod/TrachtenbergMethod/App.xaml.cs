﻿using System;
using TrachtenbergMethod.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrachtenbergMethod
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new TabbedPages();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
