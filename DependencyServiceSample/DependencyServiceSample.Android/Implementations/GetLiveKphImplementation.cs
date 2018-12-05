using System;
using DependencyServiceSample.Droid.Implementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetLiveKphImplementation))]
namespace DependencyServiceSample.Droid.Implementations
{
    public class GetLiveKphImplementation: Interfaces.IGetLiveKph
    {
       public string GetLiveKph()
        {
            return FileOperations.PositionElementSpeed.ToString();
        }
    }
}
