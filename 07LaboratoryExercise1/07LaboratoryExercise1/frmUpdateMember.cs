using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _07LaboratoryExercise1
{
    public partial class frmUpdateMember : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, LastName, MiddleName, Gender, Program;
        private long StudentId;

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudent.SelectedItem != null)
            {
                long selectedStudentID = Convert.ToInt64(cbStudent.SelectedItem);
                // clubRegistrationQuery.GetStudentData(selectedStudentID); // This method should retrieve the data of the selected student ID from the database
                clubRegistrationQuery.GetStudentData(selectedStudentID);
                TextFill();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            StudentId = Convert.ToInt64(cbStudent.Text);
            Age = Convert.ToInt32(textBoxAge.Text);
            Program = comboBoxProgram.Text;
            FirstName = textBoxFirstname.Text;
            MiddleName = textBoxMIddleName.Text;
            LastName = textBoxLastName.Text;
            Gender = comboBoxGender.Text;
            clubRegistrationQuery.UpdateStudent(StudentId, Age, Program, FirstName, LastName, MiddleName, Gender);
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {

            this.clubMembersTableAdapter.Fill(this.clubDBDataSet.ClubMembers);
            this.clubMembersTableAdapter.Fill(this.clubDBDataSet.ClubMembers);
            clubRegistrationQuery = new ClubRegistrationQuery();
            clubRegistrationQuery.DisplayID(cbStudent);

        }

        public frmUpdateMember()
        {
            InitializeComponent();
        }

        public void Fill()
        {
            string ClubDBConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\deane\Downloads\Compressed\fgsfdsd-main\fgsfdsd-main\JUSTINE-main\07LaboratoryExercise1\07LaboratoryExercise1\ClubDB.mdf;Integrated Security=True";
            SqlConnection sqlConnect = new SqlConnection(ClubDBConnectionString);
            string getId = "SELECT * FROM ClubMembers";
            SqlCommand sqlCommand = new SqlCommand(getId, sqlConnect);
            sqlConnect.Open();
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            while (sqlReader.Read())
            {
                cbStudent.Items.Add(sqlReader["StudentId"]);
            }
            sqlConnect.Close();
        }
        public void TextFill()
        {
            textBoxLastName.Text = clubRegistrationQuery._LastName;
            textBoxFirstname.Text = clubRegistrationQuery._FirstName;
            textBoxMIddleName.Text = clubRegistrationQuery._MiddleName;
            textBoxAge.Text = clubRegistrationQuery._Age.ToString();
            comboBoxGender.Text = clubRegistrationQuery._Gender;
            comboBoxProgram.Text = clubRegistrationQuery._Program;
        }
        public void cbFill()
        {
            clubRegistrationQuery.DisplayID(cbStudent);
        }

       
    }
}
