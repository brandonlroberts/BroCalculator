﻿using BroCalculator.Services;

namespace BroCalculator;

public partial class App : Application
{
    public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
	}
}
