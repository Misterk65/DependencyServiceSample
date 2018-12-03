using System;
using DependencyServiceSample.Droid.Implementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetLocationImplementation))]
namespace DependencyServiceSample.Droid.Implementations
{
    public class GetLocationImplementation: Interfaces.IGetLocation
    {
         public string GetLocation()
        {
            throw new NotImplementedException();
        }
    }
}
