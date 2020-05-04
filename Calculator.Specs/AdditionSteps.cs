using TechTalk.SpecFlow;
using Xunit;

namespace Calculator.Specs
{
	[Binding]
	public class AdditionSteps
	{
		private Calculator calc = new Calculator();
		private int result;

		[Given]
		public void Given_I_have_entered_firstnumber_P0_into_the_calculator(int p0)
		{
			calc.FirstNumber = p0;
		}

		[Given]
		public void GivenIHaveEnteredSecondnumber_P0_IntoTheCalculator(int p0)
		{
			calc.SecondNumber = p0;
		}

		[When(@"I press add")]
		public void WhenIPressAdd()
		{
			result = calc.Add();
		}

		[Then(@"the addition result should be (.*) on the screen")]
		public void ThenTheAdditionResultShouldBeOnTheScreen(int p0)
		{
			Assert.Equal(p0, result);
		}

	}
}
