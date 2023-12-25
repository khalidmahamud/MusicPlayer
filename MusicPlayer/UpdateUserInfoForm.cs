using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class UpdateUserInfoForm : Form
    {
        public readonly MainForm mainForm;

        public string name;
        public string email;
        public string gender;
        public DateTime birthdate;
        public UpdateUserInfoForm(string name, string email, string gender, DateTime birthdate)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
            this.birthdate = birthdate;
            InitializeComponent();
        }

        private void UpdateUserInfoForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = name;
            emailTextBox.Text = email;
            genderComboBox.Text = gender;
            dobDateTimePicker.Value = birthdate;
            emailTextBox.ReadOnly = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlDatabase.UpdateData(nameTextBox.Text, emailTextBox.Text, genderComboBox.Text, dobDateTimePicker.Value);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            HomeForm homeFormInstance = HomeForm.GetInstance(mainForm, email);
            homeFormInstance.LoadUserName();
        }
    }
}
