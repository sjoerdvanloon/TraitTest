using TraitTest.TraitAttributes;
using Xunit;
using Xunit.Categories;

namespace TraitTest
{
    public class UnitTest1
    {
        [IntegrationTest]
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
        [Bug(12321)]
        [Fact]
        public void Test2()
        {

        }
    }
}