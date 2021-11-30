using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit.Sdk;


namespace TraitTest
{
    public enum Feature { Flow, Document, Risk} 
}

namespace TraitTest.TraitAttributes
{
    [TraitDiscoverer(FeatureDiscoverer.DiscovererTypeName, DiscovererUtil.AssemblyName)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class FeatureAttribute : Attribute, ITraitAttribute
    {
        public Feature Feature { get; set; }
        public FeatureAttribute(Feature feature)
        {
            Feature = feature;
        }
    }

    internal class FeatureDiscoverer : ITraitDiscoverer
    {
        internal const string DiscovererTypeName = DiscovererUtil.TraitAttributesFullyQualifiedName + "." + nameof(FeatureDiscoverer);

        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            yield return new KeyValuePair<string, string>("Category", "Feature");
            var feature = traitAttribute.GetNamedArgument<Feature>("Feature");
            yield return new KeyValuePair<string, string>("Feature", feature.ToString()); // You could to lower this

        }
    }
}
