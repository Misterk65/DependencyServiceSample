using System;
using DependencyServiceSample.Droid.Implementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetProvInfImplementation))]
namespace DependencyServiceSample.Droid.Implementations
{
    public class GetProvInfImplementation:Interfaces.IGetProvInf
    {
         public string GetProviderInfo()
        {
            string ProvInf = "MCC " + FileOperations.InformationElementMcc 
            + " MNC " + FileOperations.InformationElementMnc + " - " + 
                FileOperations.InformationElementNwType;

            return ProvInf;
        }
    }
}
