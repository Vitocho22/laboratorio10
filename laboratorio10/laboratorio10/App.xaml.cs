﻿using laboratorio10.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace laboratorio10
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Operaciones();
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
