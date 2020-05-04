using System.Linq;
using TechTalk.SpecFlow;
using Xunit;

namespace Calculator.Specs
{
	[Binding]
	public class MultiplicationSteps
	{
		private Calculator calc = new Calculator();
		private int result;

		[Given(@"I have entered following attributes into the calculator")]
		public void GivenIHaveEnteredFollowingAttributesIntoTheCalculator(Table table)
		{
			var firstNumber = table.Rows.First(row => row["attribute"] == "firstNumber")["value"];
			var secondNumber = table.Rows.First(row => row["attribute"] == "secondNumber")["value"];

			calc.FirstNumber = int.Parse(firstNumber);
			calc.SecondNumber = int.Parse(secondNumber);
		}

		[When(@"I press multiply")]
		public void WhenIPressMultiply()
		{
			result = calc.Multiply();
		}

		[Then(@"the multiplication result should be (.*) on the screen")]
		public void ThenTheMultiplicationResultShouldBeOnTheScreen(int p0)
		{
			Assert.Equal(p0, result);
		}
	}
}
