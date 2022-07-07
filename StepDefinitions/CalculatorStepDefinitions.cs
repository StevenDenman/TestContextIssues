using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace TestContextIssues.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly TestContext _testContext;

        private int _first;
        private int _second;
        private int _total;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext, TestContext testContext)
        {
            _scenarioContext = scenarioContext;
            _testContext = testContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _testContext.WriteLine($"{_scenarioContext.ScenarioInfo.Title} first number {number}");
            _first = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _testContext.WriteLine($"{_scenarioContext.ScenarioInfo.Title} second number {number}");
            _second = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _total = _first + _second;
            _testContext.WriteLine($"{_scenarioContext.ScenarioInfo.Title} actual total {_total}");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _testContext.WriteLine($"{_scenarioContext.ScenarioInfo.Title} expected total {result}");
            Assert.AreEqual(result, _total);
        }
    }
}