using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eVoting_Application
{
    public partial class VoterRegistration : Form
    {
        public VoterRegistration(string studentNum, string electionID)
        {
            InitializeComponent();
            lblElecID.Text = electionID;
            lblStudentNum.Text = studentNum;
        }

        private void btnNewElection_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "insert into evotingapplication.students (studentNumber, initials, lastName, faculty, age, gender, yearOfStudy)"
            + "values('"+lblStudentNum.Text+"', '"+tbxInitials.Text+"', '"+tbxLastName.Text+"', '"+cbxFaculty.Text+"', '"+tbxAge.Text+"', '"+cbxGender.Text+"', '"+cbxYearOfStudy.Text+"'); ";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                if (Convert.ToInt32(tbxAge.Text) < 18 || Convert.ToInt32(tbxAge.Text) > 100)
                {
                    MessageBox.Show("Please enter an age between 18 and 100", "Age Range Error");
                }
                else
                {
                    condb.Open();
                    myReader = cmddb.ExecuteReader();
                    MessageBox.Show("Data Saved", "Voter Registration");
                    while (myReader.Read())
                    {

                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxInitials.Clear();
            tbxLastName.Clear();
            tbxAge.Clear();
        }
    }
}
