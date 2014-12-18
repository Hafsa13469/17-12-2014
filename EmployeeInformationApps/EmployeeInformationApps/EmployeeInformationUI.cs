using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationApps
{
    public partial class EmployeeInformationUI : Form
    {
        EmployeeInformation info1 = new EmployeeInformation();
        public EmployeeInformationUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            info1.id = employeeIdTextBox.Text;
            info1.name = nameInputTextBox.Text;
            info1.salary = Convert.ToDouble(salaryInputTextBox.Text);

            MessageBox.Show(info1.id + " " + info1.name + " " + info1.salary);
            employeeIdTextBox.Text = string.Empty;
            nameInputTextBox.Text = string.Empty;
            salaryInputTextBox.Text = string.Empty;
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
             employeeIdTextBox.Text= info1.id ;
             nameInputTextBox.Text=info1.name;
             salaryInputTextBox.Text =info1.salary.ToString();



        }
    }
}
