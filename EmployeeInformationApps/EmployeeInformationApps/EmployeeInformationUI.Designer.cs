namespace EmployeeInformationApps
{
    partial class EmployeeInformationUI
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
            this.showButton = new System.Windows.Forms.Button();
            this.retrieveButton = new System.Windows.Forms.Button();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.nameInputTextBox = new System.Windows.Forms.TextBox();
            this.salaryInputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(50, 151);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // retrieveButton
            // 
            this.retrieveButton.Location = new System.Drawing.Point(146, 151);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(75, 23);
            this.retrieveButton.TabIndex = 4;
            this.retrieveButton.Text = "Retrieve";
            this.retrieveButton.UseVisualStyleBackColor = true;
            this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(66, 17);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(137, 20);
            this.employeeIdTextBox.TabIndex = 5;
            // 
            // nameInputTextBox
            // 
            this.nameInputTextBox.Location = new System.Drawing.Point(66, 49);
            this.nameInputTextBox.Name = "nameInputTextBox";
            this.nameInputTextBox.Size = new System.Drawing.Size(137, 20);
            this.nameInputTextBox.TabIndex = 6;
            // 
            // salaryInputTextBox
            // 
            this.salaryInputTextBox.Location = new System.Drawing.Point(66, 88);
            this.salaryInputTextBox.Name = "salaryInputTextBox";
            this.salaryInputTextBox.Size = new System.Drawing.Size(137, 20);
            this.salaryInputTextBox.TabIndex = 7;
            // 
            // EmployeeInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.salaryInputTextBox);
            this.Controls.Add(this.nameInputTextBox);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeInformationUI";
            this.Text = "EmployeeInformationUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button retrieveButton;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.TextBox nameInputTextBox;
        private System.Windows.Forms.TextBox salaryInputTextBox;
    }
}

