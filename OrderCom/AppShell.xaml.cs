﻿using OrderCom.Views;

namespace OrderCom;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(NarudzbaDetailPage), typeof(NarudzbaDetailPage));
	}
}
