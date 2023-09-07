using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
	public partial class Form
	{
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
	}
}
