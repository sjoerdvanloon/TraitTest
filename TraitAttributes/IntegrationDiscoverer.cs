using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace TraitTest.TraitAttributes
{
    internal class IntegrationDiscoverer : ITraitDiscoverer
    {
        internal const string DiscovererTypeName = DiscovererUtil.AssemblyName + ".TraitAttributes." + nameof(IntegrationDiscoverer);

        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
           // var bugId = traitAttribute.GetNamedArgument<string>("Id");


            yield return new KeyValuePair<string, string>("Category", "Integration");

            //if (!string.IsNullOrWhiteSpace(bugId))
            //    yield return new KeyValuePair<string, string>("Bug", bugId);

        }
    }
}
