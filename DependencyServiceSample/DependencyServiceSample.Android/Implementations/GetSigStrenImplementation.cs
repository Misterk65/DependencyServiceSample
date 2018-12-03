using System;
using DependencyServiceSample.Droid.Implementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetSigStrenImplementation))]
namespace DependencyServiceSample.Droid.Implementations
{
    public class GetSigStrenImplementation: Interfaces.IGetSigStren
    {
         public string GetSignalStrength()
        {
            throw new NotImplementedException();
        }
    }
}
