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
    public partial class ElectionStartup : Form
    {
        public bool openNextForm;
        //public static string electionID = null;
        public ElectionStartup()
        {
            InitializeComponent();
            openNextForm = false;
            FillLoadElectionBox();
            lblElectionStatus.Visible = false;
        }

        private void FillLoadElectionBox()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "SELECT * FROM evotingapplication.election; ";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                myReader = cmddb.ExecuteReader();

                while (myReader.Read())
                {
                    string stringName = myReader.GetString("elecYear");
                    cbxLoadElection.Items.Add(stringName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void ElectionStartup_Load(object sender, EventArgs e)
        {

        }

        private void cbxLoadElection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "select * from evotingapplication.election where elecYear='" + cbxLoadElection.Text + "' ; ";
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
                    lblElectionStatus.Text = sStatus;
                    string sElectionID = myReader.GetInt32("electionID").ToString();
                    lblElectionID.Text = sElectionID;                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadElection_Click(object sender, EventArgs e)
        {
            if (lblElectionStatus.Text == "Incomplete")
            {
                openNextForm = true;
                int electionID = Convert.ToInt32(lblElectionID.Text);
                Add_Candidates ad = new Add_Candidates(electionID);
                ad.Show();
                this.Hide();
            }
            else if (lblElectionStatus.Text == "Complete")
            {
                openNextForm = true;
                VoterLogin vl = new VoterLogin();
                vl.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something is wrong with the file. Please try another election year");
            }
        }

        private void ElectionStartup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (openNextForm == false)
            {
                Application.ExitThread();
            }
            else if (openNextForm == true)
            {
                this.Hide();
            }
        }

        private void btnNewElection_Click(object sender, EventArgs e)
        {
            openNextForm = true;
            int newSetup = 1;
            ElectionSetup es = new ElectionSetup(newSetup);
            es.ShowDialog();
            this.Hide();
        }
    }
}
