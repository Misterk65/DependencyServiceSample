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
            return FileOperations.InformationElementDistance.ToString();
        }
    }
}
