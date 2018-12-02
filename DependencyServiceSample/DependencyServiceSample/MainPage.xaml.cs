using System;
using DependencyServiceSample.Interfaces;
using Xamarin.Forms;

namespace DependencyServiceSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();


        private void Button_OnClicked(object sender, EventArgs e)
        {
            var bat = DependencyService.Get<IGetNwProv>();
            lblProvider.Text = bat.GetProviderName();
        }
    }
}
