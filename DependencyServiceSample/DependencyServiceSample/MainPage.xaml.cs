using System;
using DependencyServiceSample.Interfaces;
using Xamarin.Forms;

namespace DependencyServiceSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            RefreshUiData();
        }

        void BtnPoi_OnClicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Information", "Not yet Implemented", "Confirm");
        }

        void BtnPoi_OnPressed(object sender, System.EventArgs e)
        {
            DisplayAlert("Information", "Not yet Implemented", "Confirm");
        }

        void Btn1_OnClicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Information", "Not yet Implemented", "Confirm");
        }

        void Btn2_OnClicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Information", "Not yet Implemented", "Confirm");
        }

        void Btn3_OnClicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Information", "Not yet Implemented", "Confirm");
        }

        public void RefreshUiData()
        {
            var bat = DependencyService.Get<IUiRefresh>();
            if (bat.GetProviderName() != null)
            {
                LblLiveNwData.Text = "Live Network Data - "
                + bat.GetProviderName();
            }
            else
            {
                LblLiveNwData.Text = "Live Network Data";
            }
        }
    }
}
