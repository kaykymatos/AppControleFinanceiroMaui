﻿using AppControleFinanceiroMaui.Views;

namespace AppControleFinanceiroMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TransactionList();
        }
    }
}
