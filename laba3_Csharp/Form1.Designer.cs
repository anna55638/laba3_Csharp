namespace laba3_Csharp
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
            cmbOperation = new ComboBox();
            txtNumerator1 = new TextBox();
            txtDenominator1 = new TextBox();
            txtNumerator2 = new TextBox();
            txtDenominator2 = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cmbOperation
            // 
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperation.Location = new Point(70, 29);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(50, 28);
            cmbOperation.TabIndex = 0;
            // 
            // txtNumerator1
            // 
            txtNumerator1.Location = new Point(12, 12);
            txtNumerator1.Name = "txtNumerator1";
            txtNumerator1.Size = new Size(40, 27);
            txtNumerator1.TabIndex = 1;
            // 
            // txtDenominator1
            // 
            txtDenominator1.Location = new Point(12, 54);
            txtDenominator1.Name = "txtDenominator1";
            txtDenominator1.Size = new Size(40, 27);
            txtDenominator1.TabIndex = 2;
            txtDenominator1.TextChanged += textBox2_TextChanged;
            // 
            // txtNumerator2
            // 
            txtNumerator2.Location = new Point(134, 12);
            txtNumerator2.Name = "txtNumerator2";
            txtNumerator2.Size = new Size(40, 27);
            txtNumerator2.TabIndex = 3;
            // 
            // txtDenominator2
            // 
            txtDenominator2.Location = new Point(134, 54);
            txtDenominator2.Name = "txtDenominator2";
            txtDenominator2.Size = new Size(40, 27);
            txtDenominator2.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 110);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(146, 34);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Тык";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(42, 187);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 29);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 7;
            label1.Text = "________";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 29);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 8;
            label2.Text = "________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 295);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtDenominator2);
            Controls.Add(txtNumerator2);
            Controls.Add(txtDenominator1);
            Controls.Add(txtNumerator1);
            Controls.Add(cmbOperation);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperation;
        private TextBox txtNumerator1;
        private TextBox txtDenominator1;
        private TextBox txtNumerator2;
        private TextBox txtDenominator2;
        private Button btnCalculate;
        private Label lblResult;
        private Label label1;
        private Label label2;
    }
}
