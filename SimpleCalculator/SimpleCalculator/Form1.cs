namespace SimpleCalculator
{
	public enum Operators
	{
		Add, Subtract, Multiply, Divide, Pow, Percent, None
	}

	public partial class Form : System.Windows.Forms.Form
	{
		public Form()
		{
			InitializeComponent();
		}

		public void Form1_Load(object sender, EventArgs e)
		{

		}

		public void UpdateResultText()
		{

		}

		private void IsInitialInput(bool eraseInput = true)
		{

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

	}
}