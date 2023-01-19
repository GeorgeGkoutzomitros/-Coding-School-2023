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

		private void btnOne_Click(object sender, EventArgs e)
		{

			if (_result != null)
			{

				ctrlDisplay.Text = string.Empty;
				_value1 = null;
				_value2 = null;
				_result = null;
			}

			ctrlDisplay.Text += "1";

			if (_value1 == null)
			{
				_value1 = 1;
			}
			else
			{
				_value2 = 1;
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
					break;
			}

			ctrlDisplay.Text += _result;
		}
	}
}