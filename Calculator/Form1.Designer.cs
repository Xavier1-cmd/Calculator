namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonDivision = new Button();
            buttonClearEntry = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonMultiply = new Button();
            buttonClear = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonMinus = new Button();
            buttonZero = new Button();
            buttonDot = new Button();
            buttonAddition = new Button();
            buttonEqual = new Button();
            textBoxResult = new TextBox();
            labelCurrentOperation = new Label();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(33, 123);
            button7.Name = "button7";
            button7.Size = new Size(45, 45);
            button7.TabIndex = 0;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button_click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(84, 123);
            button8.Name = "button8";
            button8.Size = new Size(45, 45);
            button8.TabIndex = 0;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button_click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(135, 123);
            button9.Name = "button9";
            button9.Size = new Size(45, 45);
            button9.TabIndex = 0;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button_click;
            // 
            // buttonDivision
            // 
            buttonDivision.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDivision.Location = new Point(186, 123);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(45, 45);
            buttonDivision.TabIndex = 0;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += Operator_click;
            // 
            // buttonClearEntry
            // 
            buttonClearEntry.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClearEntry.Location = new Point(237, 123);
            buttonClearEntry.Name = "buttonClearEntry";
            buttonClearEntry.Size = new Size(45, 45);
            buttonClearEntry.TabIndex = 0;
            buttonClearEntry.Text = "CE";
            buttonClearEntry.UseVisualStyleBackColor = true;
            buttonClearEntry.Click += ButtonCE;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(33, 174);
            button4.Name = "button4";
            button4.Size = new Size(45, 45);
            button4.TabIndex = 0;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(84, 174);
            button5.Name = "button5";
            button5.Size = new Size(45, 45);
            button5.TabIndex = 0;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(135, 174);
            button6.Name = "button6";
            button6.Size = new Size(45, 45);
            button6.TabIndex = 0;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMultiply.Location = new Point(186, 174);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(45, 45);
            buttonMultiply.TabIndex = 0;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += Operator_click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(237, 174);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(45, 45);
            buttonClear.TabIndex = 0;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ButtonC;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(33, 225);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(84, 225);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 0;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(135, 225);
            button3.Name = "button3";
            button3.Size = new Size(45, 45);
            button3.TabIndex = 0;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMinus.Location = new Point(186, 225);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(45, 45);
            buttonMinus.TabIndex = 0;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += Operator_click;
            // 
            // buttonZero
            // 
            buttonZero.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonZero.Location = new Point(33, 276);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(96, 45);
            buttonZero.TabIndex = 0;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += Button_click;
            // 
            // buttonDot
            // 
            buttonDot.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDot.Location = new Point(135, 276);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(45, 45);
            buttonDot.TabIndex = 0;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += Button_click;
            // 
            // buttonAddition
            // 
            buttonAddition.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddition.Location = new Point(186, 276);
            buttonAddition.Name = "buttonAddition";
            buttonAddition.Size = new Size(45, 45);
            buttonAddition.TabIndex = 0;
            buttonAddition.Text = "+";
            buttonAddition.UseVisualStyleBackColor = true;
            buttonAddition.Click += Operator_click;
            // 
            // buttonEqual
            // 
            buttonEqual.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEqual.Location = new Point(237, 225);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(45, 96);
            buttonEqual.TabIndex = 0;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += ButtonEqual_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI", 14.25F);
            textBoxResult.Location = new Point(33, 84);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(249, 33);
            textBoxResult.TabIndex = 1;
            textBoxResult.Text = "0";
            textBoxResult.TextAlign = HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentOperation.ForeColor = SystemColors.ControlDark;
            labelCurrentOperation.Location = new Point(33, 56);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 25);
            labelCurrentOperation.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 351);
            Controls.Add(labelCurrentOperation);
            Controls.Add(textBoxResult);
            Controls.Add(buttonEqual);
            Controls.Add(buttonAddition);
            Controls.Add(buttonMinus);
            Controls.Add(buttonClear);
            Controls.Add(buttonDot);
            Controls.Add(buttonMultiply);
            Controls.Add(button3);
            Controls.Add(buttonClearEntry);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(buttonDivision);
            Controls.Add(buttonZero);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button8);
            Controls.Add(button7);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonDivision;
        private Button buttonClearEntry;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonMultiply;
        private Button buttonClear;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonMinus;
        private Button buttonZero;
        private Button buttonDot;
        private Button buttonAddition;
        private Button buttonEqual;
        private TextBox textBoxResult;
        private Label labelCurrentOperation;
    }
}
