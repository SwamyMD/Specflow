using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace Calculator.Specs
{
	[Binding]
	public class MultiplicationSteps
	{
		private Calculator calc = new Calculator();
		private int result;

		[Given(@"I have entered following attributes into calc and using weakly typed data")]
		public void GivenWeeklyTypedDataExample(Table table)
		{
			//Weakly Typed
			var firstNumber = table.Rows.First(row => row["attribute"] == "firstNumber")["value"];
			var secondNumber = table.Rows.First(row => row["attribute"] == "secondNumber")["value"];

			calc.FirstNumber = int.Parse(firstNumber);
			calc.SecondNumber = int.Parse(secondNumber);
		}

		[Given(@"I have entered following attributes into cal and using strongly typed data")]
		public void GivenStronglyTypedDataExample(Table table)
		{
			//Strongly Typed
			var calcAttribute = table.CreateInstance<CalcAttribute>();

			calc.FirstNumber = calcAttribute.FirstNumber;
			calc.SecondNumber = calcAttribute.SecondNumber;
		}

		[Given(@"I have entered following attributes into cal and using dynamic typed data")]
		public void GivenDynamicTypedDataExample(Table table)
		{
			//dynamic Typed
			dynamic calcAttribute = table.CreateDynamicInstance();

			calc.FirstNumber = calcAttribute.firstNumber;
			calc.SecondNumber = calcAttribute.secondNumber;
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
