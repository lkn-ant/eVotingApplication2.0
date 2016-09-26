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
            LoadElectionStatus();
            if (lblStatus.Text == "Incomplete")
            {
                ChangeElectionStatus();
                LoadElectionStatus();

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
    }
}
