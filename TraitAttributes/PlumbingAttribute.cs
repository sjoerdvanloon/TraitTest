using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace TraitTest.TraitAttributes
{
    [TraitDiscoverer(PlumbingDiscoverer.DiscovererTypeName, DiscovererUtil.AssemblyName)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class PlumbingAttribute : Attribute, ITraitAttribute
    {
        public PlumbingAttribute()
        {

        }
    }

    internal class PlumbingDiscoverer : ITraitDiscoverer
    {
        internal const string DiscovererTypeName = DiscovererUtil.TraitAttributesFullyQualifiedName +  "." + nameof(PlumbingDiscoverer);

        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {


            yield return new KeyValuePair<string, string>("Category", "Plumbing");

        }
    }
}
