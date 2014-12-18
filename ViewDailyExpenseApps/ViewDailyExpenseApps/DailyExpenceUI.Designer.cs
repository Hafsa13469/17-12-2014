namespace ViewDailyExpenseApps
{
    partial class DailyExpenceUI
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
            this.expenseEntryLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.categoryLevel = new System.Windows.Forms.Label();
            this.particularLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.categoryEntryComboBox = new System.Windows.Forms.ComboBox();
            this.particularEntryTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.viewSummeryLabel = new System.Windows.Forms.Label();
            this.totalExpenseLabel = new System.Windows.Forms.Label();
            this.maxExpenseLabel = new System.Windows.Forms.Label();
            this.totalExpenceViewTextBox = new System.Windows.Forms.TextBox();
            this.maximumExpenceViewTextBox = new System.Windows.Forms.TextBox();
            this.catagorywiseExpenseViewLabel = new System.Windows.Forms.Label();
            this.viewCategorywiseExpenseLabel = new System.Windows.Forms.Label();
            this.viewCategorywiseExpenseComboBox = new System.Windows.Forms.ComboBox();
            this.categorywiseExpenseShowButton = new System.Windows.Forms.Button();
            this.showListBox = new System.Windows.Forms.ListBox();
            this.showTotalLabel = new System.Windows.Forms.Label();
            this.showTotalTextBox = new System.Windows.Forms.TextBox();
            this.viewSummeryShowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // expenseEntryLabel
            // 
            this.expenseEntryLabel.AutoSize = true;
            this.expenseEntryLabel.Location = new System.Drawing.Point(28, 20);
            this.expenseEntryLabel.Name = "expenseEntryLabel";
            this.expenseEntryLabel.Size = new System.Drawing.Size(101, 13);
            this.expenseEntryLabel.TabIndex = 0;
            this.expenseEntryLabel.Text = "Daily Expense Entry";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(36, 67);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Amount";
            // 
            // categoryLevel
            // 
            this.categoryLevel.AutoSize = true;
            this.categoryLevel.Location = new System.Drawing.Point(36, 109);
            this.categoryLevel.Name = "categoryLevel";
            this.categoryLevel.Size = new System.Drawing.Size(49, 13);
            this.categoryLevel.TabIndex = 2;
            this.categoryLevel.Text = "Category";
            // 
            // particularLabel
            // 
            this.particularLabel.AutoSize = true;
            this.particularLabel.Location = new System.Drawing.Point(34, 156);
            this.particularLabel.Name = "particularLabel";
            this.particularLabel.Size = new System.Drawing.Size(51, 13);
            this.particularLabel.TabIndex = 3;
            this.particularLabel.Text = "Particular";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(99, 71);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(170, 20);
            this.amountTextBox.TabIndex = 4;
            // 
            // categoryEntryComboBox
            // 
            this.categoryEntryComboBox.FormattingEnabled = true;
            this.categoryEntryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryEntryComboBox.Location = new System.Drawing.Point(99, 109);
            this.categoryEntryComboBox.Name = "categoryEntryComboBox";
            this.categoryEntryComboBox.Size = new System.Drawing.Size(170, 21);
            this.categoryEntryComboBox.TabIndex = 5;
            // 
            // particularEntryTextBox
            // 
            this.particularEntryTextBox.Location = new System.Drawing.Point(99, 153);
            this.particularEntryTextBox.Multiline = true;
            this.particularEntryTextBox.Name = "particularEntryTextBox";
            this.particularEntryTextBox.Size = new System.Drawing.Size(170, 68);
            this.particularEntryTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(241, 240);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // viewSummeryLabel
            // 
            this.viewSummeryLabel.AutoSize = true;
            this.viewSummeryLabel.Location = new System.Drawing.Point(31, 289);
            this.viewSummeryLabel.Name = "viewSummeryLabel";
            this.viewSummeryLabel.Size = new System.Drawing.Size(76, 13);
            this.viewSummeryLabel.TabIndex = 9;
            this.viewSummeryLabel.Text = "View Summery";
            // 
            // totalExpenseLabel
            // 
            this.totalExpenseLabel.AutoSize = true;
            this.totalExpenseLabel.Location = new System.Drawing.Point(25, 363);
            this.totalExpenseLabel.Name = "totalExpenseLabel";
            this.totalExpenseLabel.Size = new System.Drawing.Size(76, 13);
            this.totalExpenseLabel.TabIndex = 10;
            this.totalExpenseLabel.Text = "Total Expence";
            // 
            // maxExpenseLabel
            // 
            this.maxExpenseLabel.AutoSize = true;
            this.maxExpenseLabel.Location = new System.Drawing.Point(12, 407);
            this.maxExpenseLabel.Name = "maxExpenseLabel";
            this.maxExpenseLabel.Size = new System.Drawing.Size(95, 13);
            this.maxExpenseLabel.TabIndex = 11;
            this.maxExpenseLabel.Text = "Maximum Expense";
            // 
            // totalExpenceViewTextBox
            // 
            this.totalExpenceViewTextBox.Location = new System.Drawing.Point(113, 363);
            this.totalExpenceViewTextBox.Name = "totalExpenceViewTextBox";
            this.totalExpenceViewTextBox.Size = new System.Drawing.Size(164, 20);
            this.totalExpenceViewTextBox.TabIndex = 12;
            // 
            // maximumExpenceViewTextBox
            // 
            this.maximumExpenceViewTextBox.Location = new System.Drawing.Point(113, 403);
            this.maximumExpenceViewTextBox.Name = "maximumExpenceViewTextBox";
            this.maximumExpenceViewTextBox.Size = new System.Drawing.Size(161, 20);
            this.maximumExpenceViewTextBox.TabIndex = 13;
            // 
            // catagorywiseExpenseViewLabel
            // 
            this.catagorywiseExpenseViewLabel.AutoSize = true;
            this.catagorywiseExpenseViewLabel.Location = new System.Drawing.Point(383, 27);
            this.catagorywiseExpenseViewLabel.Name = "catagorywiseExpenseViewLabel";
            this.catagorywiseExpenseViewLabel.Size = new System.Drawing.Size(141, 13);
            this.catagorywiseExpenseViewLabel.TabIndex = 14;
            this.catagorywiseExpenseViewLabel.Text = "View Categorywise Expence";
            // 
            // viewCategorywiseExpenseLabel
            // 
            this.viewCategorywiseExpenseLabel.AutoSize = true;
            this.viewCategorywiseExpenseLabel.Location = new System.Drawing.Point(383, 70);
            this.viewCategorywiseExpenseLabel.Name = "viewCategorywiseExpenseLabel";
            this.viewCategorywiseExpenseLabel.Size = new System.Drawing.Size(49, 13);
            this.viewCategorywiseExpenseLabel.TabIndex = 15;
            this.viewCategorywiseExpenseLabel.Text = "Category";
            // 
            // viewCategorywiseExpenseComboBox
            // 
            this.viewCategorywiseExpenseComboBox.FormattingEnabled = true;
            this.viewCategorywiseExpenseComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.viewCategorywiseExpenseComboBox.Location = new System.Drawing.Point(448, 67);
            this.viewCategorywiseExpenseComboBox.Name = "viewCategorywiseExpenseComboBox";
            this.viewCategorywiseExpenseComboBox.Size = new System.Drawing.Size(180, 21);
            this.viewCategorywiseExpenseComboBox.TabIndex = 16;
            // 
            // categorywiseExpenseShowButton
            // 
            this.categorywiseExpenseShowButton.Location = new System.Drawing.Point(553, 109);
            this.categorywiseExpenseShowButton.Name = "categorywiseExpenseShowButton";
            this.categorywiseExpenseShowButton.Size = new System.Drawing.Size(75, 23);
            this.categorywiseExpenseShowButton.TabIndex = 17;
            this.categorywiseExpenseShowButton.Text = "Show";
            this.categorywiseExpenseShowButton.UseVisualStyleBackColor = true;
            this.categorywiseExpenseShowButton.Click += new System.EventHandler(this.categorywiseExpenseShowButton_Click);
            // 
            // showListBox
            // 
            this.showListBox.FormattingEnabled = true;
            this.showListBox.Location = new System.Drawing.Point(448, 153);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(180, 147);
            this.showListBox.TabIndex = 18;
            // 
            // showTotalLabel
            // 
            this.showTotalLabel.AutoSize = true;
            this.showTotalLabel.Location = new System.Drawing.Point(400, 363);
            this.showTotalLabel.Name = "showTotalLabel";
            this.showTotalLabel.Size = new System.Drawing.Size(31, 13);
            this.showTotalLabel.TabIndex = 19;
            this.showTotalLabel.Text = "Total";
            // 
            // showTotalTextBox
            // 
            this.showTotalTextBox.Location = new System.Drawing.Point(448, 360);
            this.showTotalTextBox.Name = "showTotalTextBox";
            this.showTotalTextBox.Size = new System.Drawing.Size(180, 20);
            this.showTotalTextBox.TabIndex = 20;
            // 
            // viewSummeryShowButton
            // 
            this.viewSummeryShowButton.Location = new System.Drawing.Point(241, 321);
            this.viewSummeryShowButton.Name = "viewSummeryShowButton";
            this.viewSummeryShowButton.Size = new System.Drawing.Size(75, 23);
            this.viewSummeryShowButton.TabIndex = 21;
            this.viewSummeryShowButton.Text = "Show";
            this.viewSummeryShowButton.UseVisualStyleBackColor = true;
            this.viewSummeryShowButton.Click += new System.EventHandler(this.viewSummeryShowButton_Click);
            // 
            // DailyExpenceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 575);
            this.Controls.Add(this.viewSummeryShowButton);
            this.Controls.Add(this.showTotalTextBox);
            this.Controls.Add(this.showTotalLabel);
            this.Controls.Add(this.showListBox);
            this.Controls.Add(this.categorywiseExpenseShowButton);
            this.Controls.Add(this.viewCategorywiseExpenseComboBox);
            this.Controls.Add(this.viewCategorywiseExpenseLabel);
            this.Controls.Add(this.catagorywiseExpenseViewLabel);
            this.Controls.Add(this.maximumExpenceViewTextBox);
            this.Controls.Add(this.totalExpenceViewTextBox);
            this.Controls.Add(this.maxExpenseLabel);
            this.Controls.Add(this.totalExpenseLabel);
            this.Controls.Add(this.viewSummeryLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.particularEntryTextBox);
            this.Controls.Add(this.categoryEntryComboBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.particularLabel);
            this.Controls.Add(this.categoryLevel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.expenseEntryLabel);
            this.Name = "DailyExpenceUI";
            this.Text = "DailyExpenceUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label expenseEntryLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label categoryLevel;
        private System.Windows.Forms.Label particularLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox categoryEntryComboBox;
        private System.Windows.Forms.TextBox particularEntryTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label viewSummeryLabel;
        private System.Windows.Forms.Label totalExpenseLabel;
        private System.Windows.Forms.Label maxExpenseLabel;
        private System.Windows.Forms.TextBox totalExpenceViewTextBox;
        private System.Windows.Forms.TextBox maximumExpenceViewTextBox;
        private System.Windows.Forms.Label catagorywiseExpenseViewLabel;
        private System.Windows.Forms.Label viewCategorywiseExpenseLabel;
        private System.Windows.Forms.ComboBox viewCategorywiseExpenseComboBox;
        private System.Windows.Forms.Button categorywiseExpenseShowButton;
        private System.Windows.Forms.ListBox showListBox;
        private System.Windows.Forms.Label showTotalLabel;
        private System.Windows.Forms.TextBox showTotalTextBox;
        private System.Windows.Forms.Button viewSummeryShowButton;
    }
}

