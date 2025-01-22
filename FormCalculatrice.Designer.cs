namespace Calculatrice
{
    partial class FormCalculatrice
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
            txbCalcul = new TextBox();
            btnBack = new Button();
            btnClearAll = new Button();
            btnClearOperand = new Button();
            button4 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            BtnPlusMinus = new Button();
            btnDivide = new Button();
            btnSqr = new Button();
            btnSqrt = new Button();
            btnMultiply = new Button();
            btnSubstract = new Button();
            btnAdd = new Button();
            button14 = new Button();
            button15 = new Button();
            btn3 = new Button();
            button17 = new Button();
            btn6 = new Button();
            btn2 = new Button();
            BtnEquals = new Button();
            btnComma = new Button();
            btn0 = new Button();
            btnDividedbyX = new Button();
            btnPercent = new Button();
            btnMemoryClear = new Button();
            btnMemoryRead = new Button();
            btnMemorySave = new Button();
            btnMemoryAdd = new Button();
            SuspendLayout();
            // 
            // txbCalcul
            // 
            txbCalcul.Font = new Font("Segoe UI", 15F);
            txbCalcul.Location = new Point(16, 20);
            txbCalcul.Margin = new Padding(4, 5, 4, 5);
            txbCalcul.Name = "txbCalcul";
            txbCalcul.RightToLeft = RightToLeft.Yes;
            txbCalcul.Size = new Size(360, 47);
            txbCalcul.TabIndex = 0;
            txbCalcul.WordWrap = false;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 19F);
            btnBack.Location = new Point(290, 175);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(89, 80);
            btnBack.TabIndex = 1;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Segoe UI", 19F);
            btnClearAll.ForeColor = Color.Red;
            btnClearAll.Location = new Point(199, 175);
            btnClearAll.Margin = new Padding(4, 5, 4, 5);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(89, 80);
            btnClearAll.TabIndex = 2;
            btnClearAll.Text = "C";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnClearOperand
            // 
            btnClearOperand.Font = new Font("Segoe UI", 19F);
            btnClearOperand.ForeColor = Color.Red;
            btnClearOperand.Location = new Point(107, 175);
            btnClearOperand.Margin = new Padding(4, 5, 4, 5);
            btnClearOperand.Name = "btnClearOperand";
            btnClearOperand.Size = new Size(89, 80);
            btnClearOperand.TabIndex = 3;
            btnClearOperand.Text = "CE";
            btnClearOperand.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 19F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(17, 355);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(89, 80);
            button4.TabIndex = 4;
            button4.Text = "7";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 19F);
            btn4.ForeColor = SystemColors.Desktop;
            btn4.Location = new Point(16, 442);
            btn4.Margin = new Padding(4, 5, 4, 5);
            btn4.Name = "btn4";
            btn4.Size = new Size(89, 80);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 19F);
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(16, 532);
            btn1.Margin = new Padding(4, 5, 4, 5);
            btn1.Name = "btn1";
            btn1.Size = new Size(89, 80);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // BtnPlusMinus
            // 
            BtnPlusMinus.Font = new Font("Segoe UI", 19F);
            BtnPlusMinus.ForeColor = SystemColors.Desktop;
            BtnPlusMinus.Location = new Point(16, 622);
            BtnPlusMinus.Margin = new Padding(4, 5, 4, 5);
            BtnPlusMinus.Name = "BtnPlusMinus";
            BtnPlusMinus.Size = new Size(89, 80);
            BtnPlusMinus.TabIndex = 7;
            BtnPlusMinus.Text = "+/_";
            BtnPlusMinus.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 19F);
            btnDivide.ForeColor = SystemColors.Desktop;
            btnDivide.Location = new Point(290, 265);
            btnDivide.Margin = new Padding(4, 5, 4, 5);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(89, 80);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnSqr
            // 
            btnSqr.Font = new Font("Segoe UI", 19F);
            btnSqr.ForeColor = SystemColors.Desktop;
            btnSqr.Location = new Point(199, 265);
            btnSqr.Margin = new Padding(4, 5, 4, 5);
            btnSqr.Name = "btnSqr";
            btnSqr.Size = new Size(89, 80);
            btnSqr.TabIndex = 9;
            btnSqr.Text = "x²";
            btnSqr.UseVisualStyleBackColor = true;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Segoe UI", 19F);
            btnSqrt.ForeColor = SystemColors.Desktop;
            btnSqrt.Location = new Point(107, 265);
            btnSqrt.Margin = new Padding(4, 5, 4, 5);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(89, 80);
            btnSqrt.TabIndex = 10;
            btnSqrt.Text = "¹√x";
            btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 19F);
            btnMultiply.ForeColor = SystemColors.Desktop;
            btnMultiply.Location = new Point(290, 355);
            btnMultiply.Margin = new Padding(4, 5, 4, 5);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(89, 80);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnSubstract
            // 
            btnSubstract.Font = new Font("Segoe UI", 19F);
            btnSubstract.ForeColor = SystemColors.Desktop;
            btnSubstract.Location = new Point(290, 445);
            btnSubstract.Margin = new Padding(4, 5, 4, 5);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(89, 80);
            btnSubstract.TabIndex = 12;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 19F);
            btnAdd.ForeColor = SystemColors.Desktop;
            btnAdd.Location = new Point(290, 535);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 80);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 19F);
            button14.ForeColor = SystemColors.Desktop;
            button14.Location = new Point(199, 355);
            button14.Margin = new Padding(4, 5, 4, 5);
            button14.Name = "button14";
            button14.Size = new Size(89, 80);
            button14.TabIndex = 14;
            button14.Text = "9";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btnNumber_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 19F);
            button15.ForeColor = SystemColors.Desktop;
            button15.Location = new Point(199, 442);
            button15.Margin = new Padding(4, 5, 4, 5);
            button15.Name = "button15";
            button15.Size = new Size(89, 80);
            button15.TabIndex = 15;
            button15.Text = "6";
            button15.UseVisualStyleBackColor = true;
            button15.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 19F);
            btn3.ForeColor = SystemColors.Desktop;
            btn3.Location = new Point(199, 532);
            btn3.Margin = new Padding(4, 5, 4, 5);
            btn3.Name = "btn3";
            btn3.Size = new Size(89, 80);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 19F);
            button17.ForeColor = SystemColors.Desktop;
            button17.Location = new Point(107, 355);
            button17.Margin = new Padding(4, 5, 4, 5);
            button17.Name = "button17";
            button17.Size = new Size(89, 80);
            button17.TabIndex = 17;
            button17.Text = "8";
            button17.UseVisualStyleBackColor = true;
            button17.Click += btnNumber_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 19F);
            btn6.ForeColor = SystemColors.Desktop;
            btn6.Location = new Point(107, 442);
            btn6.Margin = new Padding(4, 5, 4, 5);
            btn6.Name = "btn6";
            btn6.Size = new Size(89, 80);
            btn6.TabIndex = 18;
            btn6.Text = "5";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 19F);
            btn2.ForeColor = SystemColors.Desktop;
            btn2.Location = new Point(107, 532);
            btn2.Margin = new Padding(4, 5, 4, 5);
            btn2.Name = "btn2";
            btn2.Size = new Size(89, 80);
            btn2.TabIndex = 19;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // BtnEquals
            // 
            BtnEquals.Font = new Font("Segoe UI", 19F);
            BtnEquals.ForeColor = SystemColors.Desktop;
            BtnEquals.Location = new Point(290, 622);
            BtnEquals.Margin = new Padding(4, 5, 4, 5);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(89, 80);
            BtnEquals.TabIndex = 20;
            BtnEquals.Text = "=";
            BtnEquals.UseVisualStyleBackColor = true;
            // 
            // btnComma
            // 
            btnComma.Font = new Font("Segoe UI", 19F);
            btnComma.ForeColor = SystemColors.Desktop;
            btnComma.Location = new Point(199, 622);
            btnComma.Margin = new Padding(4, 5, 4, 5);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(89, 80);
            btnComma.TabIndex = 21;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 19F);
            btn0.ForeColor = SystemColors.Desktop;
            btn0.Location = new Point(107, 622);
            btn0.Margin = new Padding(4, 5, 4, 5);
            btn0.Name = "btn0";
            btn0.Size = new Size(89, 80);
            btn0.TabIndex = 22;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // btnDividedbyX
            // 
            btnDividedbyX.Font = new Font("Segoe UI", 19F);
            btnDividedbyX.ForeColor = SystemColors.Desktop;
            btnDividedbyX.Location = new Point(16, 265);
            btnDividedbyX.Margin = new Padding(4, 5, 4, 5);
            btnDividedbyX.Name = "btnDividedbyX";
            btnDividedbyX.Size = new Size(89, 80);
            btnDividedbyX.TabIndex = 23;
            btnDividedbyX.Text = "¹/x";
            btnDividedbyX.UseVisualStyleBackColor = true;
            // 
            // btnPercent
            // 
            btnPercent.Font = new Font("Segoe UI", 19F);
            btnPercent.ForeColor = SystemColors.Desktop;
            btnPercent.Location = new Point(16, 175);
            btnPercent.Margin = new Padding(4, 5, 4, 5);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(89, 80);
            btnPercent.TabIndex = 24;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.Location = new Point(290, 133);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(86, 34);
            btnMemoryClear.TabIndex = 25;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            // 
            // btnMemoryRead
            // 
            btnMemoryRead.Location = new Point(202, 133);
            btnMemoryRead.Name = "btnMemoryRead";
            btnMemoryRead.Size = new Size(86, 34);
            btnMemoryRead.TabIndex = 26;
            btnMemoryRead.Text = "MR";
            btnMemoryRead.UseVisualStyleBackColor = true;
            // 
            // btnMemorySave
            // 
            btnMemorySave.Location = new Point(110, 133);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(86, 34);
            btnMemorySave.TabIndex = 27;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = true;
            // 
            // btnMemoryAdd
            // 
            btnMemoryAdd.Location = new Point(20, 133);
            btnMemoryAdd.Name = "btnMemoryAdd";
            btnMemoryAdd.Size = new Size(86, 34);
            btnMemoryAdd.TabIndex = 28;
            btnMemoryAdd.Text = "M+";
            btnMemoryAdd.UseVisualStyleBackColor = true;
            // 
            // FormCalculatrice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 720);
            Controls.Add(btnMemoryAdd);
            Controls.Add(btnMemorySave);
            Controls.Add(btnMemoryRead);
            Controls.Add(btnMemoryClear);
            Controls.Add(btnPercent);
            Controls.Add(btnDividedbyX);
            Controls.Add(btn0);
            Controls.Add(btnComma);
            Controls.Add(BtnEquals);
            Controls.Add(btn2);
            Controls.Add(btn6);
            Controls.Add(button17);
            Controls.Add(btn3);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(btnAdd);
            Controls.Add(btnSubstract);
            Controls.Add(btnMultiply);
            Controls.Add(btnSqrt);
            Controls.Add(btnSqr);
            Controls.Add(btnDivide);
            Controls.Add(BtnPlusMinus);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(button4);
            Controls.Add(btnClearOperand);
            Controls.Add(btnClearAll);
            Controls.Add(btnBack);
            Controls.Add(txbCalcul);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCalculatrice";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calculatrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbCalcul;
        private Button btnBack;
        private Button btnClearAll;
        private Button btnClearOperand;
        private Button button4;
        private Button btn4;
        private Button btn1;
        private Button BtnPlusMinus;
        private Button btnDivide;
        private Button btnSqr;
        private Button btnSqrt;
        private Button btnMultiply;
        private Button btnSubstract;
        private Button btnAdd;
        private Button button14;
        private Button button15;
        private Button btn3;
        private Button button17;
        private Button btn6;
        private Button btn2;
        private Button BtnEquals;
        private Button btnComma;
        private Button btn0;
        private Button btnDividedbyX;
        private Button btnPercent;
        private Button btnMemoryClear;
        private Button btnMemoryRead;
        private Button btnMemorySave;
        private Button btnMemoryAdd;
    }
}
