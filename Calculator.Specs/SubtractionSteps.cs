using TechTalk.SpecFlow;
using Xunit;

namespace Calculator.Specs
{
	[Binding]
	public class SubtractionSteps
	{
		private Calculator calc;
		private int result;

		[Given(@"Calculator is resetted")]
		public void GivenCalculatorIsResetted()
		{
			calc = new Calculator();
			result = 0;
		}


		[Given(@"I have entered first number (.*) into the calculator")]
		public void GivenIHaveEnteredFirstNumberIntoTheCalculator(int p0)
		{
			calc.FirstNumber = p0;
		}

		[Given(@"I have entered second number (.*) into the calculator")]
		public void GivenIHaveEnteredSecondNumberIntoTheCalculator(int p0)
		{
			calc.SecondNumber = p0;
		}

		[When(@"I press subtract")]
		public void WhenIPressSubtract()
		{
			result = calc.Subtract();
		}

		[Then(@"the result should be (.*) on the screen")]
		public void ThenTheResultShouldBeOnTheScreen(int p0)
		{
			Assert.Equal(p0, result);
		}
	}
}
