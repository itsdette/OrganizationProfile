using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {

        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfPrograms = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information System",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfPrograms[i].ToString());
            }
        }

        /////return methods 
        public long StudentNumber(string studNum)
        {

            if (!(studNum.Equals("")))
            {
                _StudentNo = long.Parse(studNum);
            }
            else
            {
                throw new ArgumentNullException("\nStudent Number cannot be null. \nPlease try again!");
                
            }
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);

            }
            else
            {
                throw new OverflowException("\nWrong input for Contact Number. \nPlease try again!");
            }
            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new FormatException("\nWrong input for name. \nPlease try again!");
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);

            }
            else
            {
                throw new IndexOutOfRangeException("\nWrong input for age. Please try again!");
            }

            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
                StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");

                frmConfirm frm = new frmConfirm();
                frm.ShowDialog();
            }

            catch (FormatException ex)
            {
                MessageBox.Show("FormatException: " + ex.Message);
            }

            catch (ArgumentNullException ex)
            {
                MessageBox.Show("ArgumentNullException: " + ex.Message);
                
            }

            catch (OverflowException ex)
            {
                MessageBox.Show("OverflowException: " + ex.Message);
            }

            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("IndexOutOfRangeException: " + ex.Message);
            }


        }
    }
}




