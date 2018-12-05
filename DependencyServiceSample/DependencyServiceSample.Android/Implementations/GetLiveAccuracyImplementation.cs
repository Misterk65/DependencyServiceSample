using System;
using DependencyServiceSample.Droid.Implementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetLiveAccuracyImplementation))]

namespace DependencyServiceSample.Droid.Implementations
{
    public class GetLiveAccuracyImplementation: Interfaces.IGetLiveAccuracy
    {

        public string GetLiveAccuracy()
        {
            return FileOperations.InformationElementAccuracy.ToString();
        }
    }
}
