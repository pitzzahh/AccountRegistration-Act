using System;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            ProgramsList.Items.Add("Bachelor of Science in Information Technology");
            ProgramsList.Items.Add("Bachelor of Science in Computer Engineering");
            ProgramsList.Items.Add("Bachelor of Science in Hospitality Management");
            ProgramsList.Items.Add("Bachelor of Science in Business Administration");
            ProgramsList.Items.Add("Bachelor of Science in Accounting Information System");
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (FirstNameInput.Text == "" || LastNameInput.Text == "" || AddressInput.Text == "" ||
                ProgramsList.Text == "" || AgeInput.Text == "" ||
                ContactNumberInput.Text == "" || StudentNumberInput.Text == "")
            {
                MessageBox.Show(@"Please fill up all the fields.", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(StudentNumberInput.Text, out _))
            {
                MessageBox.Show(@"Student number must be a number.", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(AgeInput.Text, out _))
            {
                MessageBox.Show(@"Age must be a number.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(ContactNumberInput.Text, out _))
            {
                MessageBox.Show(@"Contact number must be a number.", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            StudentInfoClass.Firstname = FirstNameInput.Text;
            StudentInfoClass.LastName = LastNameInput.Text;
            StudentInfoClass.MiddleName = MiddleNameInput.Text;
            StudentInfoClass.Address = AddressInput.Text;
            StudentInfoClass.Program = ProgramsList.Text;
            StudentInfoClass.Age = long.Parse(AgeInput.Text);
            StudentInfoClass.ContactNo = long.Parse(ContactNumberInput.Text);
            StudentInfoClass.StudentNo = long.Parse(StudentNumberInput.Text);

            if (new FrmConfirm().ShowDialog() != DialogResult.OK) return;

            FirstNameInput.Text = "";
            LastNameInput.Text = "";
            MiddleNameInput.Text = "";
            AddressInput.Text = "";
            ProgramsList.Text = "";
            AgeInput.Text = "";
            ContactNumberInput.Text = "";
            StudentNumberInput.Text = "";
        }
    }

    public static class StudentInfoClass
    {
        public delegate long DelegateNumber(long number);

        public delegate string DelegateText(string txt);

        public static string Firstname = "";
        public static string LastName = "";
        public static string MiddleName = "";
        public static string Address = "";
        public static string Program = "";
        public static long Age;
        public static long ContactNo;
        public static long StudentNo;

        public static string GetFirstName(string firstName) => firstName;
        public static string GetLastName(string lastName) => lastName;
        public static string GetMiddleName(string middleName) => middleName;
        public static string GetAddress(string address) => address;
        public static string GetProgram(string program) => program;
        public static long GetAge(long age) => age;
        public static long GetContactNo(long contactNo) => contactNo;
        public static long GetStudentNo(long studentNo) => studentNo;
    }
}