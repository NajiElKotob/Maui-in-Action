﻿using MauiApp1;

namespace Maui_in_Action;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new AppShell();

        //MainPage = new Tabbed_Page();
        //MainPage = new NavigationPage(new Tabbed_Page());

        MainPage = new DataBindingBasicsPage();
    }
}
