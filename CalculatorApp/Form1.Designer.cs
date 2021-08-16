namespace CalculatorApp
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
            this.calculatorDisplay = new System.Windows.Forms.Label();
            this.sevenButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.perButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorDisplay.ForeColor = System.Drawing.Color.Snow;
            this.calculatorDisplay.Location = new System.Drawing.Point(14, 11);
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(358, 88);
            this.calculatorDisplay.TabIndex = 0;
            this.calculatorDisplay.Text = "0";
            // 
            // sevenButton
            // 
            this.sevenButton.AutoEllipsis = true;
            this.sevenButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sevenButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sevenButton.Location = new System.Drawing.Point(10, 205);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(86, 75);
            this.sevenButton.TabIndex = 1;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // mulButton
            // 
            this.mulButton.AutoEllipsis = true;
            this.mulButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mulButton.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mulButton.Location = new System.Drawing.Point(286, 205);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(86, 75);
            this.mulButton.TabIndex = 12;
            this.mulButton.Text = "X";
            this.mulButton.UseVisualStyleBackColor = false;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.AutoEllipsis = true;
            this.minusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minusButton.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minusButton.Location = new System.Drawing.Point(286, 284);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(86, 75);
            this.minusButton.TabIndex = 13;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.AutoEllipsis = true;
            this.plusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.plusButton.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plusButton.Location = new System.Drawing.Point(286, 365);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(86, 75);
            this.plusButton.TabIndex = 14;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.AutoEllipsis = true;
            this.equalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.equalButton.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equalButton.Location = new System.Drawing.Point(286, 446);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(86, 75);
            this.equalButton.TabIndex = 15;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.AutoEllipsis = true;
            this.eightButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.eightButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eightButton.Location = new System.Drawing.Point(102, 205);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(86, 75);
            this.eightButton.TabIndex = 16;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.AutoEllipsis = true;
            this.nineButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nineButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nineButton.Location = new System.Drawing.Point(194, 205);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(86, 75);
            this.nineButton.TabIndex = 17;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.AutoEllipsis = true;
            this.fourButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fourButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fourButton.Location = new System.Drawing.Point(10, 284);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(86, 75);
            this.fourButton.TabIndex = 18;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.AutoEllipsis = true;
            this.fiveButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fiveButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fiveButton.Location = new System.Drawing.Point(102, 284);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(86, 75);
            this.fiveButton.TabIndex = 19;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.AutoEllipsis = true;
            this.sixButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sixButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sixButton.Location = new System.Drawing.Point(194, 284);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(86, 75);
            this.sixButton.TabIndex = 20;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.AutoEllipsis = true;
            this.decimalButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.decimalButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decimalButton.Location = new System.Drawing.Point(194, 446);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(86, 75);
            this.decimalButton.TabIndex = 26;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = false;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.AutoEllipsis = true;
            this.zeroButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.zeroButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zeroButton.Location = new System.Drawing.Point(10, 446);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(178, 75);
            this.zeroButton.TabIndex = 24;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.AutoEllipsis = true;
            this.threeButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.threeButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.threeButton.Location = new System.Drawing.Point(194, 367);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(86, 75);
            this.threeButton.TabIndex = 23;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.AutoEllipsis = true;
            this.twoButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.twoButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.twoButton.Location = new System.Drawing.Point(102, 367);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(86, 75);
            this.twoButton.TabIndex = 22;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.AutoEllipsis = true;
            this.oneButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.oneButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oneButton.Location = new System.Drawing.Point(10, 367);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(86, 75);
            this.oneButton.TabIndex = 21;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // divButton
            // 
            this.divButton.AutoEllipsis = true;
            this.divButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.divButton.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.divButton.Location = new System.Drawing.Point(286, 124);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(86, 75);
            this.divButton.TabIndex = 27;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoEllipsis = true;
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clearButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.Location = new System.Drawing.Point(10, 124);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(178, 75);
            this.clearButton.TabIndex = 28;
            this.clearButton.Text = "AC";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // perButton
            // 
            this.perButton.AutoEllipsis = true;
            this.perButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.perButton.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.perButton.Location = new System.Drawing.Point(194, 124);
            this.perButton.Name = "perButton";
            this.perButton.Size = new System.Drawing.Size(86, 75);
            this.perButton.TabIndex = 29;
            this.perButton.Text = "%";
            this.perButton.UseVisualStyleBackColor = false;
            this.perButton.Click += new System.EventHandler(this.perButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 532);
            this.Controls.Add(this.perButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.calculatorDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label calculatorDisplay;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button perButton;
    }
}

