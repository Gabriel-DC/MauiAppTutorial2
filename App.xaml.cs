﻿using MauiAppTutorial2.Pages;

namespace MauiAppTutorial2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ResourcesPage());
        }
    }
}
