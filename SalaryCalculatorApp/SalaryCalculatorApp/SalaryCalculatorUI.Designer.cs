namespace SalaryCalculatorApp
{
    partial class SalaryCalculatorUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.basicAmountTextBox = new System.Windows.Forms.TextBox();
            this.rentTextBox = new System.Windows.Forms.TextBox();
            this.medicalAllowanceeTextBox = new System.Windows.Forms.TextBox();
            this.showSalaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medical Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "% of Basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "% of Basic";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(114, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // basicAmountTextBox
            // 
            this.basicAmountTextBox.Location = new System.Drawing.Point(114, 74);
            this.basicAmountTextBox.Name = "basicAmountTextBox";
            this.basicAmountTextBox.Size = new System.Drawing.Size(170, 20);
            this.basicAmountTextBox.TabIndex = 7;
            // 
            // rentTextBox
            // 
            this.rentTextBox.Location = new System.Drawing.Point(114, 131);
            this.rentTextBox.Name = "rentTextBox";
            this.rentTextBox.Size = new System.Drawing.Size(170, 20);
            this.rentTextBox.TabIndex = 8;
            // 
            // medicalAllowanceeTextBox
            // 
            this.medicalAllowanceeTextBox.Location = new System.Drawing.Point(114, 182);
            this.medicalAllowanceeTextBox.Name = "medicalAllowanceeTextBox";
            this.medicalAllowanceeTextBox.Size = new System.Drawing.Size(170, 20);
            this.medicalAllowanceeTextBox.TabIndex = 9;
            // 
            // showSalaryButton
            // 
            this.showSalaryButton.Location = new System.Drawing.Point(153, 240);
            this.showSalaryButton.Name = "showSalaryButton";
            this.showSalaryButton.Size = new System.Drawing.Size(75, 23);
            this.showSalaryButton.TabIndex = 10;
            this.showSalaryButton.Text = "Salary";
            this.showSalaryButton.UseVisualStyleBackColor = true;
            this.showSalaryButton.Click += new System.EventHandler(this.showSalaryButton_Click);
            // 
            // SalaryCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 296);
            this.Controls.Add(this.showSalaryButton);
            this.Controls.Add(this.medicalAllowanceeTextBox);
            this.Controls.Add(this.rentTextBox);
            this.Controls.Add(this.basicAmountTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryCalculatorUI";
            this.Text = "SalaryCalculatorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox basicAmountTextBox;
        private System.Windows.Forms.TextBox rentTextBox;
        private System.Windows.Forms.TextBox medicalAllowanceeTextBox;
        private System.Windows.Forms.Button showSalaryButton;
    }
}

