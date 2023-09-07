namespace SimpleCalculator
{
	public partial class Form : System.Windows.Forms.Form
	{
		private bool initialInput = false;

		private bool decimalAdded = false;

		private int resultFontSize = 36;

		public Form()
		{
			InitializeComponent();
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			initialInput = false;
			decimalAdded = false;

			textResult.Text = "0";
		}

		#region Buttons 1-9
		private void buttonNum0_Click(object sender, EventArgs e)
		{
			// making sure we avoid a situation where the 'textResult = 0000'
			if (textResult.Text != "0")
			{
				textResult.Text += "0";
			}
		}

		private void buttonNum1_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			textResult.Text += "1";
		}

		private void buttonNum2_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			textResult.Text += "2";
		}

		private void buttonNum3_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			textResult.Text += "3";
		}

		private void buttonNum4_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			textResult.Text += "4";
		}

		private void buttonNum5_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			textResult.Text += "5";
		}

		private void buttonNum6_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			textResult.Text += "6";
		}

		private void buttonNum7_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			textResult.Text += "7";
		}

		private void buttonNum8_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			textResult.Text += "8";
		}

		private void buttonNum9_Click(object sender, EventArgs e)
		{
			IsInitialInput();
			textResult.Text += "9";
		}
		#endregion

		private void buttonClear_Click(object sender, EventArgs e)
		{
			initialInput = false;
			decimalAdded = false;

			textResult.Text = "0";
		}

		private void buttonDecimal_Click(object sender, EventArgs e)
		{
			IsInitialInput(false);

			if (!decimalAdded)
			{
				textResult.Text += ".";
				decimalAdded = true;
			}
		}

		private void IsInitialInput(bool eraseInput = true)
		{
			bool doOnce = !initialInput;
			if (doOnce)
			{
				if (eraseInput)
				{
					textResult.Text = "";
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
		}
	}
}