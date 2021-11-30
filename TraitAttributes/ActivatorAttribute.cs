using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace TraitTest.TraitAttributes
{
    [TraitDiscoverer(ActivatorDiscoverer.DiscovererTypeName, DiscovererUtil.AssemblyName)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class ActivatorAttribute : Attribute, ITraitAttribute
    {
        public ActivatorAttribute()
        {

        }
    }

    internal class ActivatorDiscoverer : ITraitDiscoverer
    {
        internal const string DiscovererTypeName = DiscovererUtil.TraitAttributesFullyQualifiedName + "." + nameof(ActivatorDiscoverer);

        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {


            yield return new KeyValuePair<string, string>("Category", "Activator");

        }
    }
}
