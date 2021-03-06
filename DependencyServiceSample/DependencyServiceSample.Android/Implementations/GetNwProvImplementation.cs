﻿using Android.Telephony;
using DependencyServiceSample.Droid.Implementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetNwProvImplementation))]

namespace DependencyServiceSample.Droid.Implementations
{
    public class GetNwProvImplementation : Interfaces.IGetNwProv
    {
        private static TelephonyManager _tm;
        public static TelephonyManager Tm { get => _tm; set => _tm = value; }

        public string GetProviderName()
        {
            return FileOperations.ProviderString;
        }
    }
}