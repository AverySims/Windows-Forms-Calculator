namespace SimpleCalculator
{
	public partial class Form : System.Windows.Forms.Form
	{
		public Form()
		{
			InitializeComponent();
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			textResult.Text = "";
		}

		#region Buttons 1-9
		private void buttonNum0_Click(object sender, EventArgs e)
		{
			textResult.Text += "0";
		}

		private void buttonNum1_Click(object sender, EventArgs e)
		{
			textResult.Text += "1";
		}

		private void buttonNum2_Click(object sender, EventArgs e)
		{
			textResult.Text += "2";
		}

		private void buttonNum3_Click(object sender, EventArgs e)
		{
			textResult.Text += "3";
		}

		private void buttonNum4_Click(object sender, EventArgs e)
		{
			textResult.Text += "4";
		}

		private void buttonNum5_Click(object sender, EventArgs e)
		{
			textResult.Text += "5";
		}

		private void buttonNum6_Click(object sender, EventArgs e)
		{
			textResult.Text += "6";
		}

		private void buttonNum7_Click(object sender, EventArgs e)
		{
			textResult.Text += "7";
		}

		private void buttonNum8_Click(object sender, EventArgs e)
		{
			textResult.Text += "8";
		}

		private void buttonNum9_Click(object sender, EventArgs e)
		{
			textResult.Text += "9";
		}
		#endregion
	}

}