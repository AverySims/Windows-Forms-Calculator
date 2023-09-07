namespace SimpleCalculator
{
	public enum Operators
	{
		Add, Subtract, Multiply, Divide, Pow, Percent, None
	}

	public partial class Form : System.Windows.Forms.Form
	{
		private double valueA = 0;
		private double valueB = 0;
		private double valueResult = 0;

		private Operators operation = Operators.None;

		private string userNumber = " ";
		private string userOperation = " ";
		private bool initialInput = false;
		private bool decimalAdded = false;
		private bool negativeSign = false;

		public Form()
		{
			InitializeComponent();
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			// clearing all values upon initially loading the form
			buttonClear_Click(sender, e);
		}

		public void UpdateResultText()
		{
			// creating a string based on bool value
			string valueSign = negativeSign ? "-" : "";

			textResult.Text = valueSign + userNumber;
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			initialInput = false;
			decimalAdded = false;
			negativeSign = false;

			userNumber = "0";
			userOperation = " ";

			valueA = 0;
			valueB = 0;
			valueResult = 0;

			operation = Operators.None;

			UpdateResultText();
		}

		#region Buttons 1-9
		private void buttonNum0_Click(object sender, EventArgs e)
		{
			// making sure we avoid a situation where the 'textResult = 0000'
			if (userNumber != "0")
			{
				userNumber += "0";

				UpdateResultText();
			}
		}

		private void buttonNum1_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			userNumber += "1";

			UpdateResultText();
		}

		private void buttonNum2_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			userNumber += "2";

			UpdateResultText();
		}

		private void buttonNum3_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			userNumber += "3";

			UpdateResultText();
		}

		private void buttonNum4_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			userNumber += "4";

			UpdateResultText();
		}

		private void buttonNum5_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			userNumber += "5";

			UpdateResultText();
		}

		private void buttonNum6_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			userNumber += "6";

			UpdateResultText();
		}

		private void buttonNum7_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			userNumber += "7";

			UpdateResultText();
		}

		private void buttonNum8_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			userNumber += "8";

			UpdateResultText();
		}

		private void buttonNum9_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			userNumber += "9";

			UpdateResultText();
		}
		#endregion

		private void buttonDecimal_Click(object sender, EventArgs e)
		{
			IsInitialInput(false);

			if (!decimalAdded)
			{
				userNumber += ".";
				decimalAdded = true;

				UpdateResultText();
			}
		}

		private void buttonSign_Click(object sender, EventArgs e)
		{
			// flipping bool state
			negativeSign = !negativeSign;

			UpdateResultText();
		}

		private void IsInitialInput(bool eraseInput = true)
		{
			bool doOnce = !initialInput;
			if (doOnce)
			{
				if (eraseInput)
				{
					userNumber = "";
				}

				initialInput = true;
			}
		}

		// attempting to change text font size based on string length
		private void textResult_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox)sender;

			// Check if the text length is greater than or equal to the minimum length for font size change.
			if (textBox.Text.Length >= 13)
			{
				// Define the maximum font size that fits within the TextBox
				float maxFontSize = 100;

				// Create a graphics object to measure text size
				using (Graphics g = textBox.CreateGraphics())
				{
					string text = textBox.Text;
					Font currentFont = textBox.Font;

					// Measure the size of the current text with the current font
					SizeF textSize = g.MeasureString(text, currentFont);

					// Calculate the scaling factors for width and height
					float widthScale = textBox.Width / textSize.Width;
					float heightScale = textBox.Height / textSize.Height;

					// Use the smaller scaling factor to ensure the text fits within both width and height
					float minScale = Math.Min(widthScale, heightScale);

					// Calculate the new font size
					float newFontSize = currentFont.Size * minScale;

					// Ensure the font size does not exceed the maximum allowed size
					if (newFontSize > maxFontSize)
					{
						newFontSize = maxFontSize;
					}

					// Create a new font with the calculated size and set it to the TextBox
					textBox.Font = new Font(currentFont.FontFamily, newFontSize);
				}
			}
			else
			{
				// resetting font size when threshold hasn't been met
				textBox.Font = new Font(textBox.Font.FontFamily, 36);
			}
		}

		#region Operators
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (operation != Operators.Add)
			{
				operation = Operators.Add;
				userOperation = " + ";

				valueA = Convert.ToDouble(userNumber);
			}
		}

		private void buttonSubtract_Click(object sender, EventArgs e)
		{
			if (operation != Operators.Subtract)
			{
				operation = Operators.Subtract;
				userOperation = " - ";

				valueA = Convert.ToDouble(userNumber);
			}
		}

		private void buttonMultiply_Click(object sender, EventArgs e)
		{
			if (operation != Operators.Multiply)
			{
				operation = Operators.Multiply;
				userOperation = " * ";

				valueA = Convert.ToDouble(userNumber);
			}
		}

		private void buttonDivide_Click(object sender, EventArgs e)
		{
			if (operation != Operators.Divide)
			{
				operation = Operators.Divide;
				userOperation = " ÷ ";

				valueA = Convert.ToDouble(userNumber);
			}
		}
		#endregion

		private void buttonEquals_Click(object sender, EventArgs e)
		{
			switch (operation)
			{
				case Operators.Add:
					valueResult = CalculatorFunctions.SimpleAdd(valueA, valueB);
					break;

				case Operators.Subtract:
					valueResult = CalculatorFunctions.SimpleSubtract(valueA, valueB);
					break;

				case Operators.Multiply:
					valueResult = CalculatorFunctions.SimpleMultiply(valueA, valueB);
					break;

				case Operators.Divide:
					valueResult = CalculatorFunctions.SimpleDivide(valueA, valueB);
					break;
			}

			


		}
	}
}