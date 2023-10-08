using System;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {
        private readonly StudentInfoClass.DelegateNumber _delStudNo;
        private readonly StudentInfoClass.DelegateText _delProgram;
        private readonly StudentInfoClass.DelegateText _delLastName;
        private readonly StudentInfoClass.DelegateText _delFirstName;
        private readonly StudentInfoClass.DelegateText _delMiddleName;
        private readonly StudentInfoClass.DelegateNumber _delAge;
        private readonly StudentInfoClass.DelegateNumber _delContactNo;
        private readonly StudentInfoClass.DelegateText _delAddress;

        public FrmConfirm()
        {
            InitializeComponent();
            _delStudNo = StudentInfoClass.GetStudentNo;
            _delProgram = StudentInfoClass.GetProgram;
            _delLastName = StudentInfoClass.GetLastName;
            _delFirstName = StudentInfoClass.GetFirstName;
            _delMiddleName = StudentInfoClass.GetMiddleName;
            _delAge = StudentInfoClass.GetAge;
            _delContactNo = StudentInfoClass.GetContactNo;
            _delAddress = StudentInfoClass.GetAddress;
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            StudentNumber.Text = _delStudNo(StudentInfoClass.StudentNo).ToString();
            Program.Text = _delProgram(StudentInfoClass.Program);
            LastName.Text = _delLastName(StudentInfoClass.LastName);
            FirstName.Text = _delFirstName(StudentInfoClass.Firstname);
            MiddleName.Text = StudentInfoClass.MiddleName == "" ? "N/A" : _delMiddleName(StudentInfoClass.MiddleName);
            Age.Text = _delAge(StudentInfoClass.Age).ToString();
            ContactNumber.Text = _delContactNo(StudentInfoClass.ContactNo).ToString();
            Address.Text = _delAddress(StudentInfoClass.Address);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

    }
}