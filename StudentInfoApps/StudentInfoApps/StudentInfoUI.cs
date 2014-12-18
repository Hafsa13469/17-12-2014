using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApps
{
    public partial class StudentInfoUI : Form
    {
        Student aStudent = new Student(); 
        public StudentInfoUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            ClearBox();

            string FullName = aStudent.GetFullName(aStudent.firstName, aStudent.lastName);

            MessageBox.Show(FullName +" your regNo id is: " + aStudent.regNo);

        }

        private void ClearBox()
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = aStudent.regNo;
            firstNameTextBox.Text = aStudent.firstName;
            lastNameTextBox.Text = aStudent.lastName;

        }
    }
}
