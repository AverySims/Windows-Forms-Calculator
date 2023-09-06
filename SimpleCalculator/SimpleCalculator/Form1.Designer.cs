namespace SimpleCalculator
{
	partial class Form
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			FlowLayoutPanel flowLayoutPanel1;
			textResult = new TextBox();
			buttonClear = new Button();
			buttonSquareRoot = new Button();
			buttonPercentage = new Button();
			buttonDivide = new Button();
			buttonNum7 = new Button();
			buttonNum8 = new Button();
			buttonNum9 = new Button();
			buttonMultiply = new Button();
			buttonNum4 = new Button();
			buttonNum5 = new Button();
			buttonNum6 = new Button();
			buttonSubtract = new Button();
			buttonNum1 = new Button();
			buttonNum2 = new Button();
			buttonNum3 = new Button();
			buttonAdd = new Button();
			buttonSign = new Button();
			buttonNum0 = new Button();
			buttonDecimal = new Button();
			buttonEquals = new Button();
			flowLayoutPanel1 = new FlowLayoutPanel();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// textResult
			// 
			textResult.Anchor = AnchorStyles.Top;
			textResult.BorderStyle = BorderStyle.None;
			textResult.Enabled = false;
			textResult.Font = new Font("Segoe UI", 27F, FontStyle.Regular, GraphicsUnit.Point);
			textResult.Location = new Point(12, 70);
			textResult.Name = "textResult";
			textResult.Size = new Size(325, 48);
			textResult.TabIndex = 12;
			textResult.TabStop = false;
			textResult.Text = "0";
			textResult.TextAlign = HorizontalAlignment.Right;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(buttonClear);
			flowLayoutPanel1.Controls.Add(buttonSquareRoot);
			flowLayoutPanel1.Controls.Add(buttonPercentage);
			flowLayoutPanel1.Controls.Add(buttonDivide);
			flowLayoutPanel1.Controls.Add(buttonNum7);
			flowLayoutPanel1.Controls.Add(buttonNum8);
			flowLayoutPanel1.Controls.Add(buttonNum9);
			flowLayoutPanel1.Controls.Add(buttonMultiply);
			flowLayoutPanel1.Controls.Add(buttonNum4);
			flowLayoutPanel1.Controls.Add(buttonNum5);
			flowLayoutPanel1.Controls.Add(buttonNum6);
			flowLayoutPanel1.Controls.Add(buttonSubtract);
			flowLayoutPanel1.Controls.Add(buttonNum1);
			flowLayoutPanel1.Controls.Add(buttonNum2);
			flowLayoutPanel1.Controls.Add(buttonNum3);
			flowLayoutPanel1.Controls.Add(buttonAdd);
			flowLayoutPanel1.Controls.Add(buttonSign);
			flowLayoutPanel1.Controls.Add(buttonNum0);
			flowLayoutPanel1.Controls.Add(buttonDecimal);
			flowLayoutPanel1.Controls.Add(buttonEquals);
			flowLayoutPanel1.Location = new Point(12, 177);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(325, 412);
			flowLayoutPanel1.TabIndex = 13;
			// 
			// buttonClear
			// 
			buttonClear.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			buttonClear.Location = new Point(3, 3);
			buttonClear.MaximumSize = new Size(100, 100);
			buttonClear.MinimumSize = new Size(75, 75);
			buttonClear.Name = "buttonClear";
			buttonClear.Size = new Size(75, 75);
			buttonClear.TabIndex = 24;
			buttonClear.TabStop = false;
			buttonClear.Text = "Clear";
			buttonClear.UseVisualStyleBackColor = true;
			// 
			// buttonSquareRoot
			// 
			buttonSquareRoot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonSquareRoot.Location = new Point(84, 3);
			buttonSquareRoot.MaximumSize = new Size(100, 100);
			buttonSquareRoot.MinimumSize = new Size(75, 75);
			buttonSquareRoot.Name = "buttonSquareRoot";
			buttonSquareRoot.Size = new Size(75, 75);
			buttonSquareRoot.TabIndex = 22;
			buttonSquareRoot.TabStop = false;
			buttonSquareRoot.Text = "√x";
			buttonSquareRoot.UseVisualStyleBackColor = true;
			// 
			// buttonPercentage
			// 
			buttonPercentage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonPercentage.Location = new Point(165, 3);
			buttonPercentage.MaximumSize = new Size(100, 100);
			buttonPercentage.MinimumSize = new Size(75, 75);
			buttonPercentage.Name = "buttonPercentage";
			buttonPercentage.Size = new Size(75, 75);
			buttonPercentage.TabIndex = 23;
			buttonPercentage.TabStop = false;
			buttonPercentage.Text = "%";
			buttonPercentage.UseVisualStyleBackColor = true;
			// 
			// buttonDivide
			// 
			buttonDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonDivide.Location = new Point(246, 3);
			buttonDivide.MaximumSize = new Size(100, 100);
			buttonDivide.MinimumSize = new Size(75, 75);
			buttonDivide.Name = "buttonDivide";
			buttonDivide.Size = new Size(75, 75);
			buttonDivide.TabIndex = 25;
			buttonDivide.TabStop = false;
			buttonDivide.Text = "÷";
			buttonDivide.UseVisualStyleBackColor = true;
			// 
			// buttonNum7
			// 
			buttonNum7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonNum7.Location = new Point(3, 84);
			buttonNum7.MaximumSize = new Size(100, 100);
			buttonNum7.MinimumSize = new Size(75, 75);
			buttonNum7.Name = "buttonNum7";
			buttonNum7.Size = new Size(75, 75);
			buttonNum7.TabIndex = 6;
			buttonNum7.TabStop = false;
			buttonNum7.Text = "7";
			buttonNum7.UseVisualStyleBackColor = true;
			buttonNum7.Click += buttonNum7_Click;
			// 
			// buttonNum8
			// 
			buttonNum8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonNum8.Location = new Point(84, 84);
			buttonNum8.MaximumSize = new Size(100, 100);
			buttonNum8.MinimumSize = new Size(75, 75);
			buttonNum8.Name = "buttonNum8";
			buttonNum8.Size = new Size(75, 75);
			buttonNum8.TabIndex = 7;
			buttonNum8.TabStop = false;
			buttonNum8.Text = "8";
			buttonNum8.UseVisualStyleBackColor = true;
			buttonNum8.Click += buttonNum8_Click;
			// 
			// buttonNum9
			// 
			buttonNum9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonNum9.Location = new Point(165, 84);
			buttonNum9.MaximumSize = new Size(100, 100);
			buttonNum9.MinimumSize = new Size(75, 75);
			buttonNum9.Name = "buttonNum9";
			buttonNum9.Size = new Size(75, 75);
			buttonNum9.TabIndex = 8;
			buttonNum9.TabStop = false;
			buttonNum9.Text = "9";
			buttonNum9.UseVisualStyleBackColor = true;
			buttonNum9.Click += buttonNum9_Click;
			// 
			// buttonMultiply
			// 
			buttonMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonMultiply.Location = new Point(246, 84);
			buttonMultiply.MaximumSize = new Size(100, 100);
			buttonMultiply.MinimumSize = new Size(75, 75);
			buttonMultiply.Name = "buttonMultiply";
			buttonMultiply.Size = new Size(75, 75);
			buttonMultiply.TabIndex = 9;
			buttonMultiply.TabStop = false;
			buttonMultiply.Text = "*";
			buttonMultiply.UseVisualStyleBackColor = true;
			// 
			// buttonNum4
			// 
			buttonNum4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonNum4.Location = new Point(3, 165);
			buttonNum4.MaximumSize = new Size(100, 100);
			buttonNum4.MinimumSize = new Size(75, 75);
			buttonNum4.Name = "buttonNum4";
			buttonNum4.Size = new Size(75, 75);
			buttonNum4.TabIndex = 10;
			buttonNum4.TabStop = false;
			buttonNum4.Text = "4";
			buttonNum4.UseVisualStyleBackColor = true;
			buttonNum4.Click += buttonNum4_Click;
			// 
			// buttonNum5
			// 
			buttonNum5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonNum5.Location = new Point(84, 165);
			buttonNum5.MaximumSize = new Size(100, 100);
			buttonNum5.MinimumSize = new Size(75, 75);
			buttonNum5.Name = "buttonNum5";
			buttonNum5.Size = new Size(75, 75);
			buttonNum5.TabIndex = 11;
			buttonNum5.TabStop = false;
			buttonNum5.Text = "5";
			buttonNum5.UseVisualStyleBackColor = true;
			buttonNum5.Click += buttonNum5_Click;
			// 
			// buttonNum6
			// 
			buttonNum6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonNum6.Location = new Point(165, 165);
			buttonNum6.MaximumSize = new Size(100, 100);
			buttonNum6.MinimumSize = new Size(75, 75);
			buttonNum6.Name = "buttonNum6";
			buttonNum6.Size = new Size(75, 75);
			buttonNum6.TabIndex = 12;
			buttonNum6.TabStop = false;
			buttonNum6.Text = "6";
			buttonNum6.UseVisualStyleBackColor = true;
			buttonNum6.Click += buttonNum6_Click;
			// 
			// buttonSubtract
			// 
			buttonSubtract.Font = new Font("Segoe UI", 27F, FontStyle.Regular, GraphicsUnit.Point);
			buttonSubtract.Location = new Point(246, 165);
			buttonSubtract.MaximumSize = new Size(100, 100);
			buttonSubtract.MinimumSize = new Size(75, 75);
			buttonSubtract.Name = "buttonSubtract";
			buttonSubtract.Size = new Size(75, 75);
			buttonSubtract.TabIndex = 13;
			buttonSubtract.TabStop = false;
			buttonSubtract.Text = "-";
			buttonSubtract.UseVisualStyleBackColor = true;
			// 
			// buttonNum1
			// 
			buttonNum1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonNum1.Location = new Point(3, 246);
			buttonNum1.MaximumSize = new Size(100, 100);
			buttonNum1.MinimumSize = new Size(75, 75);
			buttonNum1.Name = "buttonNum1";
			buttonNum1.Size = new Size(75, 75);
			buttonNum1.TabIndex = 14;
			buttonNum1.TabStop = false;
			buttonNum1.Text = "1";
			buttonNum1.UseVisualStyleBackColor = true;
			buttonNum1.Click += buttonNum1_Click;
			// 
			// buttonNum2
			// 
			buttonNum2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonNum2.Location = new Point(84, 246);
			buttonNum2.MaximumSize = new Size(100, 100);
			buttonNum2.MinimumSize = new Size(75, 75);
			buttonNum2.Name = "buttonNum2";
			buttonNum2.Size = new Size(75, 75);
			buttonNum2.TabIndex = 15;
			buttonNum2.TabStop = false;
			buttonNum2.Text = "2";
			buttonNum2.UseVisualStyleBackColor = true;
			buttonNum2.Click += buttonNum2_Click;
			// 
			// buttonNum3
			// 
			buttonNum3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonNum3.Location = new Point(165, 246);
			buttonNum3.MaximumSize = new Size(100, 100);
			buttonNum3.MinimumSize = new Size(75, 75);
			buttonNum3.Name = "buttonNum3";
			buttonNum3.Size = new Size(75, 75);
			buttonNum3.TabIndex = 16;
			buttonNum3.TabStop = false;
			buttonNum3.Text = "3";
			buttonNum3.UseVisualStyleBackColor = true;
			buttonNum3.Click += buttonNum3_Click;
			// 
			// buttonAdd
			// 
			buttonAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonAdd.Location = new Point(246, 246);
			buttonAdd.MaximumSize = new Size(100, 100);
			buttonAdd.MinimumSize = new Size(75, 75);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(75, 75);
			buttonAdd.TabIndex = 17;
			buttonAdd.TabStop = false;
			buttonAdd.Text = "+";
			buttonAdd.UseVisualStyleBackColor = true;
			// 
			// buttonSign
			// 
			buttonSign.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonSign.Location = new Point(3, 327);
			buttonSign.MaximumSize = new Size(100, 100);
			buttonSign.MinimumSize = new Size(75, 75);
			buttonSign.Name = "buttonSign";
			buttonSign.Size = new Size(75, 75);
			buttonSign.TabIndex = 18;
			buttonSign.TabStop = false;
			buttonSign.Text = "+/-";
			buttonSign.UseVisualStyleBackColor = true;
			// 
			// buttonNum0
			// 
			buttonNum0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonNum0.Location = new Point(84, 327);
			buttonNum0.MaximumSize = new Size(100, 100);
			buttonNum0.MinimumSize = new Size(75, 75);
			buttonNum0.Name = "buttonNum0";
			buttonNum0.Size = new Size(75, 75);
			buttonNum0.TabIndex = 19;
			buttonNum0.TabStop = false;
			buttonNum0.Text = "0";
			buttonNum0.UseVisualStyleBackColor = true;
			buttonNum0.Click += buttonNum0_Click;
			// 
			// buttonDecimal
			// 
			buttonDecimal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonDecimal.Location = new Point(165, 327);
			buttonDecimal.MaximumSize = new Size(100, 100);
			buttonDecimal.MinimumSize = new Size(75, 75);
			buttonDecimal.Name = "buttonDecimal";
			buttonDecimal.Size = new Size(75, 75);
			buttonDecimal.TabIndex = 20;
			buttonDecimal.TabStop = false;
			buttonDecimal.Text = ".";
			buttonDecimal.UseVisualStyleBackColor = true;
			// 
			// buttonEquals
			// 
			buttonEquals.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			buttonEquals.Location = new Point(246, 327);
			buttonEquals.MaximumSize = new Size(100, 100);
			buttonEquals.MinimumSize = new Size(75, 75);
			buttonEquals.Name = "buttonEquals";
			buttonEquals.Size = new Size(75, 75);
			buttonEquals.TabIndex = 21;
			buttonEquals.TabStop = false;
			buttonEquals.Text = "=";
			buttonEquals.UseVisualStyleBackColor = true;
			// 
			// Form
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(349, 601);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(textResult);
			Name = "Form";
			Text = "Calculator";
			Load += Form1_Load;
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox textResult;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button buttonNum7;
		private Button buttonNum8;
		private Button buttonNum9;
		private Button buttonMultiply;
		private Button buttonNum4;
		private Button buttonNum5;
		private Button buttonNum6;
		private Button buttonSubtract;
		private Button buttonNum1;
		private Button buttonNum2;
		private Button buttonNum3;
		private Button buttonAdd;
		private Button buttonSign;
		private Button buttonNum0;
		private Button buttonDecimal;
		private Button buttonEquals;
		private Button buttonSquareRoot;
		private Button buttonPercentage;
		private Button buttonClear;
		private Button buttonDivide;
	}
}