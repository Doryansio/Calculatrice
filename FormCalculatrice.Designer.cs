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
            lblInProgress = new Label();
            lblMemory = new Label();
            SuspendLayout();
            // 
            // txbCalcul
            // 
            txbCalcul.BorderStyle = BorderStyle.None;
            txbCalcul.Font = new Font("Segoe UI", 20F);
            txbCalcul.Location = new Point(10, 37);
            txbCalcul.Name = "txbCalcul";
            txbCalcul.ReadOnly = true;
            txbCalcul.RightToLeft = RightToLeft.No;
            txbCalcul.Size = new Size(253, 36);
            txbCalcul.TabIndex = 0;
            txbCalcul.TextAlign = HorizontalAlignment.Right;
            txbCalcul.WordWrap = false;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 19F);
            btnBack.Location = new Point(203, 105);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(62, 48);
            btnBack.TabIndex = 1;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Segoe UI", 19F);
            btnClearAll.ForeColor = Color.Red;
            btnClearAll.Location = new Point(139, 105);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(62, 48);
            btnClearAll.TabIndex = 2;
            btnClearAll.Text = "C";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnClearOperand
            // 
            btnClearOperand.Font = new Font("Segoe UI", 19F);
            btnClearOperand.ForeColor = Color.Red;
            btnClearOperand.Location = new Point(75, 105);
            btnClearOperand.Name = "btnClearOperand";
            btnClearOperand.Size = new Size(62, 48);
            btnClearOperand.TabIndex = 3;
            btnClearOperand.Text = "CE";
            btnClearOperand.UseVisualStyleBackColor = true;
            btnClearOperand.Click += btnClearOperand_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 19F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(12, 213);
            button4.Name = "button4";
            button4.Size = new Size(62, 48);
            button4.TabIndex = 4;
            button4.Text = "7";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 19F);
            btn4.ForeColor = SystemColors.Desktop;
            btn4.Location = new Point(11, 265);
            btn4.Name = "btn4";
            btn4.Size = new Size(62, 48);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 19F);
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(11, 319);
            btn1.Name = "btn1";
            btn1.Size = new Size(62, 48);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // BtnPlusMinus
            // 
            BtnPlusMinus.Font = new Font("Segoe UI", 19F);
            BtnPlusMinus.ForeColor = SystemColors.Desktop;
            BtnPlusMinus.Location = new Point(11, 373);
            BtnPlusMinus.Name = "BtnPlusMinus";
            BtnPlusMinus.Size = new Size(62, 48);
            BtnPlusMinus.TabIndex = 7;
            BtnPlusMinus.Text = "+/_";
            BtnPlusMinus.UseVisualStyleBackColor = true;
            BtnPlusMinus.Click += BtnPlusMinus_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 19F);
            btnDivide.ForeColor = SystemColors.Desktop;
            btnDivide.Location = new Point(203, 159);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(62, 48);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnOperand_click;
            // 
            // btnSqr
            // 
            btnSqr.Font = new Font("Segoe UI", 19F);
            btnSqr.ForeColor = SystemColors.Desktop;
            btnSqr.Location = new Point(139, 159);
            btnSqr.Name = "btnSqr";
            btnSqr.Size = new Size(62, 48);
            btnSqr.TabIndex = 9;
            btnSqr.Text = "x²";
            btnSqr.UseVisualStyleBackColor = true;
            btnSqr.Click += btnSqr_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Segoe UI", 19F);
            btnSqrt.ForeColor = SystemColors.Desktop;
            btnSqrt.Location = new Point(75, 159);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(62, 48);
            btnSqrt.TabIndex = 10;
            btnSqrt.Text = "¹√x";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 19F);
            btnMultiply.ForeColor = SystemColors.Desktop;
            btnMultiply.Location = new Point(203, 213);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(62, 48);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnOperand_click;
            // 
            // btnSubstract
            // 
            btnSubstract.Font = new Font("Segoe UI", 19F);
            btnSubstract.ForeColor = SystemColors.Desktop;
            btnSubstract.Location = new Point(203, 267);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(62, 48);
            btnSubstract.TabIndex = 12;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = true;
            btnSubstract.Click += btnOperand_click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 19F);
            btnAdd.ForeColor = SystemColors.Desktop;
            btnAdd.Location = new Point(203, 321);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(62, 48);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnOperand_click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 19F);
            button14.ForeColor = SystemColors.Desktop;
            button14.Location = new Point(139, 213);
            button14.Name = "button14";
            button14.Size = new Size(62, 48);
            button14.TabIndex = 14;
            button14.Text = "9";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btnNumber_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 19F);
            button15.ForeColor = SystemColors.Desktop;
            button15.Location = new Point(139, 265);
            button15.Name = "button15";
            button15.Size = new Size(62, 48);
            button15.TabIndex = 15;
            button15.Text = "6";
            button15.UseVisualStyleBackColor = true;
            button15.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 19F);
            btn3.ForeColor = SystemColors.Desktop;
            btn3.Location = new Point(139, 319);
            btn3.Name = "btn3";
            btn3.Size = new Size(62, 48);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 19F);
            button17.ForeColor = SystemColors.Desktop;
            button17.Location = new Point(75, 213);
            button17.Name = "button17";
            button17.Size = new Size(62, 48);
            button17.TabIndex = 17;
            button17.Text = "8";
            button17.UseVisualStyleBackColor = true;
            button17.Click += btnNumber_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 19F);
            btn6.ForeColor = SystemColors.Desktop;
            btn6.Location = new Point(75, 265);
            btn6.Name = "btn6";
            btn6.Size = new Size(62, 48);
            btn6.TabIndex = 18;
            btn6.Text = "5";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 19F);
            btn2.ForeColor = SystemColors.Desktop;
            btn2.Location = new Point(75, 319);
            btn2.Name = "btn2";
            btn2.Size = new Size(62, 48);
            btn2.TabIndex = 19;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // BtnEquals
            // 
            BtnEquals.Font = new Font("Segoe UI", 19F);
            BtnEquals.ForeColor = SystemColors.Desktop;
            BtnEquals.Location = new Point(203, 373);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(62, 48);
            BtnEquals.TabIndex = 20;
            BtnEquals.Text = "=";
            BtnEquals.UseVisualStyleBackColor = true;
            BtnEquals.Click += BtnEquals_Click;
            // 
            // btnComma
            // 
            btnComma.Font = new Font("Segoe UI", 19F);
            btnComma.ForeColor = SystemColors.Desktop;
            btnComma.Location = new Point(139, 373);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(62, 48);
            btnComma.TabIndex = 21;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            btnComma.Click += btnComma_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 19F);
            btn0.ForeColor = SystemColors.Desktop;
            btn0.Location = new Point(75, 373);
            btn0.Name = "btn0";
            btn0.Size = new Size(62, 48);
            btn0.TabIndex = 22;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // btnDividedbyX
            // 
            btnDividedbyX.Font = new Font("Segoe UI", 19F);
            btnDividedbyX.ForeColor = SystemColors.Desktop;
            btnDividedbyX.Location = new Point(11, 159);
            btnDividedbyX.Name = "btnDividedbyX";
            btnDividedbyX.Size = new Size(62, 48);
            btnDividedbyX.TabIndex = 23;
            btnDividedbyX.Text = "¹/x";
            btnDividedbyX.UseVisualStyleBackColor = true;
            btnDividedbyX.Click += btnDividedbyX_Click;
            // 
            // btnPercent
            // 
            btnPercent.Font = new Font("Segoe UI", 19F);
            btnPercent.ForeColor = SystemColors.Desktop;
            btnPercent.Location = new Point(11, 105);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(62, 48);
            btnPercent.TabIndex = 24;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.Location = new Point(203, 80);
            btnMemoryClear.Margin = new Padding(2);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(60, 20);
            btnMemoryClear.TabIndex = 25;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            btnMemoryClear.Click += btnMemoryClear_Click;
            // 
            // btnMemoryRead
            // 
            btnMemoryRead.Location = new Point(141, 80);
            btnMemoryRead.Margin = new Padding(2);
            btnMemoryRead.Name = "btnMemoryRead";
            btnMemoryRead.Size = new Size(60, 20);
            btnMemoryRead.TabIndex = 26;
            btnMemoryRead.Text = "MR";
            btnMemoryRead.UseVisualStyleBackColor = true;
            btnMemoryRead.Click += btnMemoryRead_Click;
            // 
            // btnMemorySave
            // 
            btnMemorySave.Location = new Point(77, 80);
            btnMemorySave.Margin = new Padding(2);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(60, 20);
            btnMemorySave.TabIndex = 27;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = true;
            btnMemorySave.Click += btnMemorySave_Click;
            // 
            // btnMemoryAdd
            // 
            btnMemoryAdd.Location = new Point(14, 80);
            btnMemoryAdd.Margin = new Padding(2);
            btnMemoryAdd.Name = "btnMemoryAdd";
            btnMemoryAdd.Size = new Size(60, 20);
            btnMemoryAdd.TabIndex = 28;
            btnMemoryAdd.Text = "M+";
            btnMemoryAdd.UseVisualStyleBackColor = true;
            btnMemoryAdd.Click += btnMemoryAdd_Click;
            // 
            // lblInProgress
            // 
            lblInProgress.AutoSize = true;
            lblInProgress.Location = new Point(225, 19);
            lblInProgress.Name = "lblInProgress";
            lblInProgress.Size = new Size(0, 15);
            lblInProgress.TabIndex = 29;
            // 
            // lblMemory
            // 
            lblMemory.AutoSize = true;
            lblMemory.Location = new Point(14, 19);
            lblMemory.Name = "lblMemory";
            lblMemory.Size = new Size(0, 15);
            lblMemory.TabIndex = 30;
            // 
            // FormCalculatrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 421);
            Controls.Add(lblMemory);
            Controls.Add(lblInProgress);
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
        private Label lblInProgress;
        private Label lblMemory;
    }
}
