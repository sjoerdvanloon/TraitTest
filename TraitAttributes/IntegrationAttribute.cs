using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace TraitTest.TraitAttributes
{
    [TraitDiscoverer(IntegrationDiscoverer.DiscovererTypeName, DiscovererUtil.AssemblyName)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class IntegrationAttribute : Attribute, ITraitAttribute
    {
        public IntegrationAttribute()
        {

        }
    }

    internal class IntegrationDiscoverer : ITraitDiscoverer
    {
        internal const string DiscovererTypeName = DiscovererUtil.TraitAttributesFullyQualifiedName + "." + nameof(IntegrationDiscoverer);

        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            yield return new KeyValuePair<string, string>("Category", "Integration");
        }
    }
}
