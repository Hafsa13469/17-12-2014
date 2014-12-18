using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace ViewDailyExpenseApps
{
    public partial class DailyExpenceUI : Form
    {
        private string path = @"E:\DailyExpenseKeeping.CSV";

        public DailyExpenceUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            FileStream aStream = new FileStream(path, FileMode.Append);
            CSVLib.CsvFileWriter aWriter = new CSVLib.CsvFileWriter(aStream);

            List<string> aDailyExpenseRecord = new List<string>();

            aDailyExpenseRecord.Add(amountTextBox.Text);
            if (categoryEntryComboBox.Text == "House Rent")
            {
                aDailyExpenseRecord.Add(categoryEntryComboBox.Text);
                aDailyExpenseRecord.Add(particularEntryTextBox.Text);

            }
            else if (categoryEntryComboBox.Text == "Utility Bill")
            {
                aDailyExpenseRecord.Add(categoryEntryComboBox.Text);
                aDailyExpenseRecord.Add(particularEntryTextBox.Text);
            }
            else if (categoryEntryComboBox.Text == "Conveyance")
            {
                aDailyExpenseRecord.Add(categoryEntryComboBox.Text);
                aDailyExpenseRecord.Add(particularEntryTextBox.Text);

            }
            else if (categoryEntryComboBox.Text == "Grocery")
            {
                aDailyExpenseRecord.Add(categoryEntryComboBox.Text);
                aDailyExpenseRecord.Add(particularEntryTextBox.Text);
            }
            else if (categoryEntryComboBox.Text == "Misc")
            {
                aDailyExpenseRecord.Add(categoryEntryComboBox.Text);
                aDailyExpenseRecord.Add(particularEntryTextBox.Text);
            }
            aWriter.WriteRow(aDailyExpenseRecord);
            amountTextBox.Text = string.Empty;
            categoryEntryComboBox.Text = string.Empty;
            particularEntryTextBox.Text = string.Empty;

            aStream.Close();
        }
        private void viewSummeryShowButton_Click(object sender, EventArgs e)
        {

            FileStream bStream = new FileStream(path, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(bStream);
            List<string> aDailyExpenseRecord = new List<string>();
            showListBox.Items.Clear();
            double totalAmount = 0;
            List<int> aAmount = new List<int>();
            while (aReader.ReadRow(aDailyExpenseRecord))
            {
                string amount = aDailyExpenseRecord[0];
                aAmount.Add(Convert.ToInt32(amount));

                totalAmount += Convert.ToDouble(amount);

            }
            totalExpenceViewTextBox.Text = totalAmount.ToString();
            

            string amount1 = Convert.ToString(aAmount.Max());
            maximumExpenceViewTextBox.Text = amount1;



            bStream.Close();
        }

        private void categorywiseExpenseShowButton_Click(object sender, EventArgs e)
        {
             FileStream cStream = new FileStream(path, FileMode.Open);
             CsvFileReader aReader = new CsvFileReader(cStream);
             List<string> cRecord = new List<string>();
             showListBox.Items.Clear();
            double totalamount = 0;

            while (aReader.ReadRow(cRecord))
            {


                if (cRecord[1]==viewCategorywiseExpenseComboBox.Text)
                {
                    string amount = cRecord[0];
                    string category = cRecord[1];

                    string particular = cRecord[2];

                   showListBox.Items.Add(amount + " " +category+" "+ particular);

                    //string viewAmount = cRecord[0];
                    totalamount += Convert.ToDouble(cRecord[0]);
                }
                showTotalTextBox.Text = totalamount.ToString();
            }
             cStream.Close();
        }


    }
}
