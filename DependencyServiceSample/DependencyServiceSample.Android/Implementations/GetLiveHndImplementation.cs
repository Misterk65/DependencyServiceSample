using System;
using DependencyServiceSample.Droid.Implementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetLiveHndImplementation))]

namespace DependencyServiceSample.Droid.Implementations
{
    public class GetLiveHndImplementation: Interfaces.IGetLiveHnd
    {
       public string GetLiveHeading()
        {
            return FileOperations.PositionElementHead.ToString();
        }
    }
}
