namespace Calculator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonPowerRoot = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonSecondPower = new System.Windows.Forms.Button();
            this.buttonSQRT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonRemainder = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNaturalLog = new System.Windows.Forms.Button();
            this.buttonEPower = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPowerRoot
            // 
            this.buttonPowerRoot.Location = new System.Drawing.Point(232, 164);
            this.buttonPowerRoot.Name = "buttonPowerRoot";
            this.buttonPowerRoot.Size = new System.Drawing.Size(42, 33);
            this.buttonPowerRoot.TabIndex = 47;
            this.buttonPowerRoot.Text = "y rt(x)";
            this.buttonPowerRoot.UseVisualStyleBackColor = true;
            this.buttonPowerRoot.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonPower
            // 
            this.buttonPower.Location = new System.Drawing.Point(232, 125);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(42, 33);
            this.buttonPower.TabIndex = 46;
            this.buttonPower.Text = "^";
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonSecondPower
            // 
            this.buttonSecondPower.Location = new System.Drawing.Point(232, 86);
            this.buttonSecondPower.Name = "buttonSecondPower";
            this.buttonSecondPower.Size = new System.Drawing.Size(42, 33);
            this.buttonSecondPower.TabIndex = 45;
            this.buttonSecondPower.Text = "^2";
            this.buttonSecondPower.UseVisualStyleBackColor = true;
            this.buttonSecondPower.Click += new System.EventHandler(this.buttonSpecialOperation_Click);
            // 
            // buttonSQRT
            // 
            this.buttonSQRT.Location = new System.Drawing.Point(232, 47);
            this.buttonSQRT.Name = "buttonSQRT";
            this.buttonSQRT.Size = new System.Drawing.Size(42, 33);
            this.buttonSQRT.TabIndex = 44;
            this.buttonSQRT.Text = "sqrt";
            this.buttonSQRT.UseVisualStyleBackColor = true;
            this.buttonSQRT.Click += new System.EventHandler(this.buttonSpecialOperation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 43;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(322, 125);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(36, 33);
            this.buttonClear.TabIndex = 42;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(280, 203);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(78, 33);
            this.buttonResult.TabIndex = 41;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonRemainder
            // 
            this.buttonRemainder.Location = new System.Drawing.Point(280, 125);
            this.buttonRemainder.Name = "buttonRemainder";
            this.buttonRemainder.Size = new System.Drawing.Size(36, 33);
            this.buttonRemainder.TabIndex = 40;
            this.buttonRemainder.Text = "%";
            this.buttonRemainder.UseVisualStyleBackColor = true;
            this.buttonRemainder.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(322, 86);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(36, 33);
            this.buttonDivision.TabIndex = 39;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Location = new System.Drawing.Point(280, 86);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(36, 33);
            this.buttonMultiplication.TabIndex = 38;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(280, 47);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(36, 33);
            this.buttonMinus.TabIndex = 37;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(322, 47);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(36, 33);
            this.buttonPlus.TabIndex = 36;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Location = new System.Drawing.Point(96, 164);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(36, 33);
            this.buttonDecimal.TabIndex = 35;
            this.buttonDecimal.Text = ",";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 164);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(78, 33);
            this.button0.TabIndex = 34;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(96, 125);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 33);
            this.button9.TabIndex = 33;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(54, 125);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 33);
            this.button8.TabIndex = 32;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 125);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 33);
            this.button7.TabIndex = 31;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(96, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 33);
            this.button6.TabIndex = 30;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(54, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 33);
            this.button5.TabIndex = 29;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 33);
            this.button4.TabIndex = 28;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 33);
            this.button3.TabIndex = 27;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 33);
            this.button2.TabIndex = 26;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonNaturalLog
            // 
            this.buttonNaturalLog.Location = new System.Drawing.Point(280, 164);
            this.buttonNaturalLog.Name = "buttonNaturalLog";
            this.buttonNaturalLog.Size = new System.Drawing.Size(36, 33);
            this.buttonNaturalLog.TabIndex = 49;
            this.buttonNaturalLog.Text = "ln";
            this.buttonNaturalLog.UseVisualStyleBackColor = true;
            this.buttonNaturalLog.Click += new System.EventHandler(this.buttonSpecialOperation_Click);
            // 
            // buttonEPower
            // 
            this.buttonEPower.Location = new System.Drawing.Point(322, 164);
            this.buttonEPower.Name = "buttonEPower";
            this.buttonEPower.Size = new System.Drawing.Size(36, 33);
            this.buttonEPower.TabIndex = 50;
            this.buttonEPower.Text = "e^";
            this.buttonEPower.UseVisualStyleBackColor = true;
            this.buttonEPower.Click += new System.EventHandler(this.buttonSpecialOperation_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.Location = new System.Drawing.Point(12, 203);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(36, 33);
            this.buttonPi.TabIndex = 51;
            this.buttonPi.Text = "π";
            this.buttonPi.UseVisualStyleBackColor = true;
            this.buttonPi.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(54, 203);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(36, 33);
            this.buttonE.TabIndex = 52;
            this.buttonE.Text = "e";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(176, 47);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 33);
            this.button10.TabIndex = 53;
            this.button10.Text = "log";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttonSpecialOperation_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(176, 86);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 33);
            this.button11.TabIndex = 54;
            this.button11.Text = "b log x";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(176, 125);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 33);
            this.button12.TabIndex = 55;
            this.button12.Text = "sin";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buttonSpecialOperation_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(176, 203);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 33);
            this.button13.TabIndex = 56;
            this.button13.Text = "asin";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttonSpecialOperation_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(232, 203);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(42, 33);
            this.button14.TabIndex = 57;
            this.button14.Text = "acos";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.buttonSpecialOperation_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(176, 164);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 33);
            this.button15.TabIndex = 58;
            this.button15.Text = "cos";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.buttonSpecialOperation_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 244);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonEPower);
            this.Controls.Add(this.buttonNaturalLog);
            this.Controls.Add(this.buttonPowerRoot);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.buttonSecondPower);
            this.Controls.Add(this.buttonSQRT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonRemainder);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPowerRoot;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonSecondPower;
        private System.Windows.Forms.Button buttonSQRT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonRemainder;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNaturalLog;
        private System.Windows.Forms.Button buttonEPower;
        private System.Windows.Forms.Button buttonPi;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
    }
}