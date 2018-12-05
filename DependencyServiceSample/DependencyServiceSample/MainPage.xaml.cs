using System;
using System.Timers;
using DependencyServiceSample.Interfaces;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace DependencyServiceSample
{
    public partial class MainPage : ContentPage
    {
        private static Timer aTimer;


        public MainPage()
        {
            InitializeComponent();
            SetTimer();
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
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
            var nwProv = DependencyService.Get<IGetNwProv>();
            var distTrav = DependencyService.Get<IGetDistTrav>();
            var nwProvInf = DependencyService.Get<IGetProvInf>();
            var sigStren = DependencyService.Get<IGetSigStren>();
            var curLoc = DependencyService.Get<IGetLocation>();
            var curAcc = DependencyService.Get<IGetLiveAccuracy>();
            var curHnd = DependencyService.Get<IGetLiveHnd>();
            var curSpeed = DependencyService.Get<IGetLiveKph>();

            if (curSpeed.GetLiveKph() != null)
            {
                LbLKph.Text = curSpeed.GetLiveKph() + " Kph";
            }
            else
            {
                LbLKph.Text = "0.0 Kph";
            }

            if (curHnd.GetLiveHeading() != null)
            {
                LbLHnd.Text = curHnd.GetLiveHeading() + " deg";
            }
            else
            {
                LbLHnd.Text = "0.0 deg";
            }

            if (curAcc.GetLiveAccuracy() != null)
            {
                LblOperation.Text = "Operation - Accuracy -> " + 
                curAcc.GetLiveAccuracy() + " m";
            }
            else
            {
                LblOperation.Text = "Operation";
            }

            if (curLoc.GetLocation() !=null)
            {
                LblLocation.Text = "Current Location: " + curLoc.GetLocation();
            }
            else
            {
                LblLocation.Text = "Current Location";
            }

            if (nwProv.GetProviderName() != null)
            {
                LblLiveNwData.Text = "Live Network Data - "
                + nwProv.GetProviderName();
            }
            else
            {
                LblLiveNwData.Text = "Live Network Data";
            }

            if(distTrav.GetDistanceTRavelled() !=null)
            {
                LbLKm.Text = distTrav.GetDistanceTRavelled() + " Km";
            }
            else
            {
                LbLKm.Text = "0.0 Km";
            }

            if (nwProvInf.GetProviderInfo() !=null ) 
            {
                LblProvider.Text =  "Provider Info: " +
                 nwProvInf.GetProviderInfo();
            }
            else
            {
                LblProvider.Text = "Provider Info";
            }

            if(sigStren.GetSignalStrength() != null)
            {
                LblSigStrength.Text = "Signal Strength: " + 
                sigStren.GetSignalStrength();
            }
            else
            {
                LblSigStrength.Text = "Signal Strength";
            }

        }
    }
}
