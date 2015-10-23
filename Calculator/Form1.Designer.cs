namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonRemainder = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSQRT = new System.Windows.Forms.Button();
            this.buttonSecondPower = new System.Windows.Forms.Button();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(54, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(96, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 33);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 122);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 33);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(54, 122);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 33);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(96, 122);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 33);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 161);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(78, 33);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Location = new System.Drawing.Point(96, 161);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(36, 33);
            this.buttonDecimal.TabIndex = 11;
            this.buttonDecimal.Text = ",";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(264, 44);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(36, 33);
            this.buttonPlus.TabIndex = 12;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(222, 44);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(36, 33);
            this.buttonMinus.TabIndex = 13;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Location = new System.Drawing.Point(222, 83);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(36, 33);
            this.buttonMultiplication.TabIndex = 14;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(264, 83);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(36, 33);
            this.buttonDivision.TabIndex = 15;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonRemainder
            // 
            this.buttonRemainder.Location = new System.Drawing.Point(222, 122);
            this.buttonRemainder.Name = "buttonRemainder";
            this.buttonRemainder.Size = new System.Drawing.Size(36, 33);
            this.buttonRemainder.TabIndex = 16;
            this.buttonRemainder.Text = "%";
            this.buttonRemainder.UseVisualStyleBackColor = true;
            this.buttonRemainder.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(222, 161);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(78, 33);
            this.buttonResult.TabIndex = 17;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(264, 122);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(36, 33);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 19;
            // 
            // buttonSQRT
            // 
            this.buttonSQRT.Location = new System.Drawing.Point(174, 44);
            this.buttonSQRT.Name = "buttonSQRT";
            this.buttonSQRT.Size = new System.Drawing.Size(42, 33);
            this.buttonSQRT.TabIndex = 20;
            this.buttonSQRT.Text = "sqrt";
            this.buttonSQRT.UseVisualStyleBackColor = true;
            this.buttonSQRT.Click += new System.EventHandler(this.buttonSpecialOperation_Click);
            // 
            // buttonSecondPower
            // 
            this.buttonSecondPower.Location = new System.Drawing.Point(174, 83);
            this.buttonSecondPower.Name = "buttonSecondPower";
            this.buttonSecondPower.Size = new System.Drawing.Size(42, 33);
            this.buttonSecondPower.TabIndex = 21;
            this.buttonSecondPower.Text = "^2";
            this.buttonSecondPower.UseVisualStyleBackColor = true;
            this.buttonSecondPower.Click += new System.EventHandler(this.buttonSpecialOperation_Click);
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(12, 200);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(120, 23);
            this.buttonSwitch.TabIndex = 24;
            this.buttonSwitch.Text = "Switch to advanced";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 232);
            this.Controls.Add(this.buttonSwitch);
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
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonRemainder;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSQRT;
        private System.Windows.Forms.Button buttonSecondPower;
        private System.Windows.Forms.Button buttonSwitch;
    }
}

