using System;

namespace SimpleCalculator
{
	public partial class Form : System.Windows.Forms.Form
	{
		private Font defaultResultFont;

		private bool operationPerformed = false;
		private bool isDecimal = false;

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

		/// <summary>
		/// Runs when a number button is clicked. Adds the number to the resultTextBox as the value to be calculated.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnNumber_Click(object sender, EventArgs e)
		{
			// Saving the sender as a button to access the button's text
			Button button = (Button)sender;

			// Clearing the resultTextBox when the text is 0 or an operation has been performed.
			if ((resultTextBox.Text == "0" || operationPerformed) && !isDecimal)
			{
				resultTextBox.Clear();
			}

			// Adding the button's text to the resultTextBox regardless of the current text
			resultTextBox.Text += button.Text;
			operationPerformed = false;
		}

		/// <summary>
		/// Runs when the current value in the resultTextBox is to be change from positive to negative or vice versa.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SignChange_Click(object sender, EventArgs e)
		{
			// Change the sign of the number in the resultTextBox
			double currentValue = double.Parse(resultTextBox.Text);
			double newValue = -currentValue;
			resultTextBox.Text = newValue.ToString();

		}

		/// <summary>
		/// Adds a decimal to the current value in the resultTextBox. Only one decimal can be added per value.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDecimal_Click(object sender, EventArgs e)
		{
			if (operationPerformed)
			{
				resultTextBox.Text = "0";
			}

			if (!isDecimal)
			{
				resultTextBox.Text += ".";
				isDecimal = true;
			}
		}

		/// <summary>
		/// Runs when an operation button is clicked. Saves the operation to be performed and the current value in the resultTextBox.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnOperand_Click(object sender, EventArgs e)
		{
			operationPerformed = true;

			// Saving the sender as a button to access the button's text
			Button button = (Button)sender;

			if (selectedOperator != button.Tag.ToString())
			{
				// The button's operation is saved within its tag, so we convert it to a string to determine the proper operation.
				string tempOperationVisual = button.Text;
				selectedOperator = button.Tag.ToString() ?? "null";

				resultLabel.Text = $" {resultTextBox.Text} {tempOperationVisual}";

				SwitchOnOperand();

				result = double.Parse(resultTextBox.Text);
			}

			isDecimal = false;

		}

		/// <summary>
		/// Clears the resultTextBox and resets the result, isDecimal, operationFunctional, and selectedOperator variables to their default values.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Clear_Click(object sender, EventArgs e)
		{
			resultTextBox.Text = "0";
			resultLabel.Text = "";

			result = 0;
			isDecimal = false;
			operationFunctional = "";
			selectedOperator = "";
		}

		/// <summary>
		/// Exectues the operation selected by the user and displays the result in the resultTextBox. The result is also saved to the result variable for future operations.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
				isDecimal = false;
				operationFunctional = "";
				selectedOperator = "";
			}
		}

		/// <summary>
		/// Switch statement to determine which operation to perform based on the operationFunctional variable.
		/// </summary>
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

		/// <summary>
		/// Runs when the resultTextBox text is changed. Adjusts the font size of the resultTextBox based on the length of the text.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Result_TextChanged(object sender, EventArgs e)
		{
			resultTextBox.Font = AdjustFontBasedOnLength(resultTextBox.Text, defaultResultFont, 12);
		}

		/// <summary>
		/// Adjusts the font size of the resultTextBox based on the length of the text.
		/// </summary>
		/// <param name="inputText">The string of text to check the length of</param>
		/// <param name="originalFont">Font reference when string should be default size</param>
		/// <param name="maxLength">The maximum length of the string before resizing occurs</param>
		/// <returns></returns>
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