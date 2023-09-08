using System;

namespace SimpleCalculator
{
	public enum Operators
	{
		Add, Subtract, Multiply, Divide, Pow, Percent, None
	}

	public partial class Form : System.Windows.Forms.Form
	{
		private Font defaultResultFont;

		private bool operationPerformed = false;

		private string operationFunctional = "";
		private string selectedOperator = "";
		private double result = 0;

		public Form()
		{
			InitializeComponent();
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			resultLabel.Text = "";
			resultTextBox.Text = "0";

			defaultResultFont = resultTextBox.Font;
		}

		private void OnNumber_Click(object sender, EventArgs e)
		{
			// Saving the sender as a button to access the button's text
			Button button = (Button)sender;

			// Clearing the resultTextBox when the text is 0 or an operation has been performed.
			if ((resultTextBox.Text == "0" || operationPerformed) && !resultTextBox.Text.Contains("."))
			{
				resultTextBox.Clear();
			}

			// Adding the button's text to the resultTextBox regardless of the current text
			resultTextBox.Text += button.Text;
			operationPerformed = false;
		}

		private void OnDecimal_Click(object sender, EventArgs e)
		{
			if (operationPerformed)
			{
				resultTextBox.Text = "0";
			}

			if (!resultTextBox.Text.Contains("."))
			{
				resultTextBox.Text += ".";
			}
		}

		private void OnOperand_Click(object sender, EventArgs e)
		{
			operationPerformed = true;

			// Saving the sender as a button to access the button's text
			Button button = (Button)sender;

			// The button's operation is saved within its tag, so we convert it to a string to determine the proper operation.
			string tempOperationVisual = button.Text;
			selectedOperator = button.Tag.ToString() ?? "null";

			resultLabel.Text += $" {resultTextBox.Text} {tempOperationVisual}";

			SwitchOnOperand();

			result = double.Parse(resultTextBox.Text);

		}

		private void Clear_Click(object sender, EventArgs e)
		{
			resultTextBox.Text = "0";
			resultLabel.Text = "";

			result = 0;
			operationFunctional = "";
			selectedOperator = "";
		}

		private void Equals_Click(object sender, EventArgs e)
		{
			operationPerformed = true;
			{
				operationFunctional = selectedOperator;
				resultLabel.Text = "";

				SwitchOnOperand();

				result = double.Parse(resultTextBox.Text);
				resultTextBox.Text = result.ToString();

				result = 0;
				operationFunctional = "";
				selectedOperator = "";
			}
		}

		private void SwitchOnOperand()
		{
			switch (operationFunctional.ToLower())
			{
				case "add":
					resultTextBox.Text = CalculatorFunctions.SimpleAdd(result, double.Parse(resultTextBox.Text)).ToString();
					break;
				case "subtract":
					resultTextBox.Text = CalculatorFunctions.SimpleSubtract(result, double.Parse(resultTextBox.Text)).ToString();
					break;
				case "multiply":
					resultTextBox.Text = CalculatorFunctions.SimpleMultiply(result, double.Parse(resultTextBox.Text)).ToString();
					break;
				case "divide":
					resultTextBox.Text = CalculatorFunctions.SimpleDivide(result, double.Parse(resultTextBox.Text)).ToString();
					break;

				default:
					break;
			}
		}

		// attempting to change text font size based on string length
		private void Result_TextChanged(object sender, EventArgs e)
		{
			resultTextBox.Font = AdjustFontBasedOnLength(resultTextBox.Text, defaultResultFont, 12);
		}

		public static Font AdjustFontBasedOnLength(string inputText, Font originalFont, int maxLength)
		{
			if (inputText.Length > maxLength)
			{
				// Calculate the scaling factor based on the length of the text and maxLength.
				double scaleFactor = (double)maxLength / inputText.Length;

				// Calculate the new font size by applying the scaling factor.
				float newSize = originalFont.Size * (float)scaleFactor;

				// Create and return a new font with the adjusted size.
				return new Font(originalFont.FontFamily, newSize);
			}
			else
			{
				// If the length is less than or equal to maxLength, return the original font.
				return originalFont;
			}
		}

	}
}