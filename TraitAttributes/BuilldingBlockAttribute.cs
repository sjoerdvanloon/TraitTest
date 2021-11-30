using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace TraitTest.TraitAttributes
{
    [TraitDiscoverer(BuildingBlockDiscoverer.DiscovererTypeName, DiscovererUtil.AssemblyName)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class BuildingBlockAttribute : Attribute, ITraitAttribute
    {
        public BuildingBlockAttribute()
        {

        }
    }

    internal class BuildingBlockDiscoverer : ITraitDiscoverer
    {
        internal const string DiscovererTypeName = DiscovererUtil.TraitAttributesFullyQualifiedName + "." + nameof(BuildingBlockDiscoverer);

        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {


            yield return new KeyValuePair<string, string>("Category", "BuildingBlock");

        }
    }
}
