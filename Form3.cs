using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_login
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            nationality.Items.Add("Indonesia");
            nationality.Items.Add("Foreign");

            gender_.Items.Add("Male");
            gender_.Items.Add("Female");

            status_.Items.Add("Single");
            status_.Items.Add("Married");
            status_.Items.Add("Divorced");

            blood_.Items.Add("A");
            blood_.Items.Add("B");
            blood_.Items.Add("AB");
            blood_.Items.Add("O");

            faculty_.Items.Add("Computer Science");
            faculty_.Items.Add("Economic and Business");
            faculty_.Items.Add("Phylosophy");
            faculty_.Items.Add("Engineering");
        }

        private void Output_Click(object sender, EventArgs e)
        {
            String firstname = first_name.Text;
            String lastname = last_name.Text;
            String nickname = nicknamee.Text;
            String fathersname = fathers_name.Text;
            String mothersname = mothers_name.Text;
            String phonenumber = phone_number.Text;
            String email = email_.Text;
            String university = university_.Text;
            String faculty = faculty_.SelectedItem?.ToString();
            String major = major_.Text;
            String gradyear = graduate_.Text;
            String age = age_.Value.ToString();
            String dateofbirth = birth_date.Value.ToString("dd mm yy");
            String nationalitys =nationality.SelectedItem?.ToString();
            String address = address_.Text;
            String religion = religion_.Text;
            String hobbies = hobbies_.Text;
            String gender = gender_.SelectedItem?.ToString();
            String maritalStatus = status_.SelectedItem?.ToString();
            String bloodType = blood_.SelectedItem?.ToString();


            
            string output =
                $"First Name: {firstname}" + "\r\n" +
                $"Last Name: {lastname}" + "\r\n" +
                $"Nickname: {nickname}" + "\r\n" +
                $"Father's Name: {fathersname}" + "\r\n" +
                $"Mother's Name: {mothersname}" + "\r\n" +
                $"Phone Number: {phonenumber}" + "\r\n" +
                $"Email: {email}" + "\r\n" +
                $"University: {university}" + "\r\n" +
                $"Faculty: {faculty}" + "\r\n" +
                $"Major: {major}" + "\r\n" +
                $"Year of Graduate: {gradyear}" + "\r\n" +
                $"Age: {age}" + "\r\n" +
                $"Date of Birth: {dateofbirth}" + "\r\n" +
                $"Nationality: {nationalitys}" + "\r\n" +
                $"Address: {address}" + "\r\n" +
                $"Religion: {religion}" + "\r\n" +
                $"Hobbies: {hobbies}" + "\r\n" +
                $"Gender: {gender}" + "\r\n" +
                $"Marital Status: {maritalStatus}" + "\r\n" +
                $"Blood Type: {bloodType}";

            
            Form4 outputForm = new Form4 (output);
            outputForm.Show(); 
            this.Hide(); 

        }

        private void nationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gender__SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void blood__SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void faculty__SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int year;
            if (!int.TryParse(graduate_.Text, out year) || year < 1900 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid year between 1900 and " + DateTime.Now.Year.ToString());
                graduate_.Focus();
            }
        }
    }
}