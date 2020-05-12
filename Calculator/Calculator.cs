namespace Calculator
{
	public class Calculator
	{
		public int FirstNumber { get; set; }
		public int SecondNumber { get; set; }
		public int Add()
		{
			return FirstNumber + SecondNumber;
		}

		public int Subtract()
		{
			return FirstNumber - SecondNumber;
		}

		public int Multiply()
		{
			return FirstNumber * SecondNumber;
		}

		public int Divide()
		{
			return FirstNumber / SecondNumber;
		}

		public int Calc(CalcType calcType)
		{
			switch (calcType)
			{
				case CalcType.Add: return Add();
				case CalcType.Subtract: return Subtract();
				default: return 0;
			}
		}
	}
}
