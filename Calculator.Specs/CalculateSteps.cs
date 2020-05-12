using TechTalk.SpecFlow;
using Xunit;

namespace Calculator.Specs
{
	[Binding]
	public class CalculateSteps
	{
		private Calculator calc = new Calculator();
		private int result;

		[Given(@"I have entered number (.*) into the calculator")]
		public void GivenIHaveEnteredNumberIntoTheCalculator(int p0)
		{
			calc.FirstNumber = p0;
		}

		[Given(@"I have also entered number (.*) into the calculator")]
		public void GivenIHaveAlsoEnteredNumberIntoTheCalculator(int p0)
		{
			calc.SecondNumber = p0;
		}

		//[When(@"I select calc type Add and press calc")]
		//public void WhenISelectCalcTypeAddAndPressCalc()
		//{
		//	ScenarioContext.Current.Pending();
		//}

		[When(@"I select calc type (.*) and press calc")]
		public void WhenISelectCalcTypeAndPressCalc(CalcType calcType)
		{
			result = calc.Calc(calcType);
		}

		[Then(@"the calculated result should be (.*) on the screen")]
		public void ThenTheCalculatedResultShouldBeOnTheScreen(int p0)
		{
			Assert.Equal(p0, result);
		}
	}
}
