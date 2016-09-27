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
    public partial class VoterLogin : Form
    {
        public VoterLogin(string id)
        {
            InitializeComponent();
            lblElecID.Text = id;
            dtpCurrentDate.Value = DateTime.Now;
            LoadVotingPeriod();
            string startDate = lblStartDate.Text;
            string endDate = lblEndDate.Text;
            DateTime sd = Convert.ToDateTime(startDate);
            DateTime ed = Convert.ToDateTime(endDate);
            if (sd > dtpCurrentDate.Value || ed < dtpCurrentDate.Value)
            {
                btnNext.Visible = false;
            }
            
            LoadElectionStatus();
            if (lblStatus.Text == "Incomplete")
            {
                ChangeElectionStatus();
                LoadElectionStatus();
            }
        }

        private void LoadVotingPeriod()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "select * from evotingapplication.election where electionID='" + lblElecID.Text + "' ; ";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                myReader = cmddb.ExecuteReader();

                while (myReader.Read())
                {
                    string sStartDate = myReader.GetString("startDate");
                    lblStartDate.Text = sStartDate;
                    string sEndDate = myReader.GetString("endDate");
                    lblEndDate.Text = sEndDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeElectionStatus()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "update evotingapplication.election set status='Complete' where electionID='" + lblElecID.Text + "'; ";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                myReader = cmddb.ExecuteReader();
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadElectionStatus()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "select * from evotingapplication.election where electionID='" + lblElecID.Text + "' ; ";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                myReader = cmddb.ExecuteReader();

                while (myReader.Read())
                {
                    string sStatus = myReader.GetString("status");
                    lblStatus.Text = sStatus;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM evotingapplication.approvedstudents where studentNumber='" + this.tbxStudentNum.Text + "' and electionID='"+lblElecID.Text+"' and voted = 'no';", myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();


                int count = 0;
                //This while condition checks if there is a duplicate user
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Approved! You can register to vote", "Voting Validation");
                    this.Hide();
                    VoterRegistration vr = new VoterRegistration(tbxStudentNum.Text, lblElecID.Text);
                    vr.ShowDialog();
                    this.Controls.Clear();
                }
                else if (count > 1)
                {
                    MessageBox.Show("There is more than one record of that student number...Contact SRC Office!", "Voting Validation");
                }
                else
                {
                    MessageBox.Show("You've already voted or you aren't approved to vote. Contact SRC Office!", "Voting Validation");
                    myConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpCurrentDate_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
