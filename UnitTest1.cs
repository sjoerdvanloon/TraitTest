using TraitTest.TraitAttributes;
using Xunit;

namespace TraitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        //[Integration]
        //[Category("Plumbing")]

        //[Category("Plumbing")]


        //[Category("Builder")]
        //[Feature("iTask")]

        //[IntegrationTest]
        //[Category("Activator")]
        //[Feature("iTask")]

        //[IntegrationTest]
        //[Category("BuildingBlock")]
        //[Feature("iTask")]

        //[IntegrationTest]
        //[Category("Scenario")]
        //[Feature("iTask")]

        [Integration]
        [Builder]
        [Fact]
        public void Test2()
        {

        }

        [Feature(Feature.Flow)]
        [Feature(Feature.Document)]
        [Fact]
        public void Test_IfFeatureTraitIsApplied()
        {

        }

        [Integration]
        [Activator]
        [Fact]
        public void Test3()
        {

        }
    }
}