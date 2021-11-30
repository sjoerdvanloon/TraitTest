using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace TraitTest.TraitAttributes
{
    [TraitDiscoverer(BuilderDiscoverer.DiscovererTypeName, DiscovererUtil.AssemblyName)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class BuilderAttribute : Attribute, ITraitAttribute
    {
        public BuilderAttribute()
        {

        }
    }

    internal class BuilderDiscoverer : ITraitDiscoverer
    {
        internal const string DiscovererTypeName = DiscovererUtil.TraitAttributesFullyQualifiedName + "." + nameof(BuilderDiscoverer);

        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {


            yield return new KeyValuePair<string, string>("Category", "Builder");

        }
    }
}
