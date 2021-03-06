﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP.MDI.Samples.GettingStarted
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ExitMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void CustomersMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var frm = new CustomerForm();
            frm.Show();
        }

        private void InvoicesMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var frm = new InvoiceForm();
            frm.Show();
        }
    }
}
