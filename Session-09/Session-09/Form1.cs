namespace Session_09
{
	public partial class Form1 : Form
	{

		private decimal? _value1 = null;
		private decimal? _value2 = null;
		private decimal? _result = null;

		private CalcOperation _calcOperation;

		enum CalcOperation
		{
			Addition,
			Subtraction,
			Multiplication,
			Division,
			RaiseToPower,
			SquareRoot

		}


		public Form1()
		{
			InitializeComponent();
		}

		//button14 equal to Division
		private void button14_Click(object sender, EventArgs e)
		{
			ctrlDisplay.Text += " / ";
			_calcOperation = CalcOperation.Division;
		}

		private void ctrlAddition_Click(object sender, EventArgs e)
		{
			ctrlDisplay.Text += " + ";
			_calcOperation = CalcOperation.Addition;
		}

		private void ctrlSubtraction_Click(object sender, EventArgs e)
		{
			ctrlDisplay.Text += " - ";
			_calcOperation = CalcOperation.Subtraction;
		}

		private void ctrlMultiplication_Click(object sender, EventArgs e)
		{
			ctrlDisplay.Text += " * ";
			_calcOperation = CalcOperation.Multiplication;
		}

		private void ctrlRaiseToPower_Click(object sender, EventArgs e)
		{
			ctrlDisplay.Text += " ^ ";
			_calcOperation = CalcOperation.RaiseToPower;
		}

		private void ctrlSquareRoot_Click(object sender, EventArgs e)
		{
			ctrlDisplay.Text += " sqrt ";
			_calcOperation = CalcOperation.SquareRoot;
		}

		private void ChooseNumber(decimal number)
		{

			if (_result != null)
			{

				ctrlDisplay.Text = string.Empty;
				_value1 = null;
				_value2 = null;
				_result = null;
			}


			if (_value1 == null)
			{
				_value1 = number;
			}
			else
			{
				_value2 = number;
			}

		}
		

		private void ctrlEqual_Click(object sender, EventArgs e)
		{
			ctrlDisplay.Text += " = ";

			switch (_calcOperation)
			{
				case CalcOperation.Addition:

					_result = _value1 + _value2;
					break;

				case CalcOperation.Subtraction:

					_result = _value1 - _value2;
					break;

				case CalcOperation.Multiplication:

					_result = _value1 * _value2;
					break;

				case CalcOperation.Division:

					_result = _value1 / _value2;
					break;

				case CalcOperation.RaiseToPower:

					_result = _value1 * _value2;
					break;

				case CalcOperation.SquareRoot:
					//object SingleValue;
					//object DoubleValue;

					//SingleValue = decimal.ToSingle(_value1);
					//DoubleValue = decimal.ToDouble(_value1);
					//_result = Math.Sqrt(_va);
					break;

				default:
					Console.WriteLine("Wrong input");
					break;
			}

			ctrlDisplay.Text += _result;
		}

		private void btnOne_Click(object sender, EventArgs e)
		{

			ChooseNumber(1);
			ctrlDisplay.Text += "1";
		}

		private void btnTwo_Click(object sender, EventArgs e)
		{

			ChooseNumber(2);
			ctrlDisplay.Text += "2";
		}

		private void btnThree_Click(object sender, EventArgs e)
		{

			ChooseNumber(3);
			ctrlDisplay.Text += "3";
		}

		private void btnFour_Click(object sender, EventArgs e)
		{

			ChooseNumber(4);
			ctrlDisplay.Text += "4";
		}

		private void btnFive_Click(object sender, EventArgs e)
		{

			ChooseNumber(5);
			ctrlDisplay.Text += "5";
		}

		private void btnSix_Click(object sender, EventArgs e)
		{

			ChooseNumber(6);
			ctrlDisplay.Text += "6";
		}

		private void btnSeven_Click(object sender, EventArgs e)
		{

			ChooseNumber(7);
			ctrlDisplay.Text += "7";
		}

		private void btnEight_Click(object sender, EventArgs e)
		{

			ChooseNumber(8);
			ctrlDisplay.Text += "8";
		}

		private void btnNine_Click(object sender, EventArgs e)
		{

			ChooseNumber(9);
			ctrlDisplay.Text += "9";
		}
	}
}