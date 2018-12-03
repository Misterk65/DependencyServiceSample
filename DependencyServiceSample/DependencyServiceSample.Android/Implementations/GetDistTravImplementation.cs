using System;
using DependencyServiceSample.Droid.Implementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetDistTravImplementation))]

namespace DependencyServiceSample.Droid.Implementations
{
    public class GetDistTravImplementation: Interfaces.IGetDistTrav
    {

        public string GetDistanceTRavelled()
        {
            throw new NotImplementedException();
        }
    }
}
