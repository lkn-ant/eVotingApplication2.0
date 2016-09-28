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
    public partial class ElectionSetup : Form
    {
        public int numCand = 0;
        public int numSRC = 0;
        public static int started = 0;
        
        
        public ElectionSetup(int newSetup)
        {
            InitializeComponent();
            started = newSetup;
            if (started == 0)
            {
                Application.Run(new ElectionStartup());
                this.Hide();
            }
            else if (started == 1)
            {

            }
            
        }

        public ElectionSetup()
        {
            Application.Run(new Ballot());
            //string elecID = "2";
            //Application.Run(new VoterLogin(elecID));
            //Application.Run(new ElectionStartup());
            this.Hide();
        }

        private void ElectionSetup_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numCand = Convert.ToInt32(cbxNumOfCandidates.Text);
            numSRC = Convert.ToInt32(cbxNumOfSRCMembers.Text);

            if (numCand <= numSRC)
            {
                MessageBox.Show("Number of candidates must be more than number of SRC Members");
            }
            else
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                string Query = "insert into evotingapplication.election (elecYear, numCand, numSRC, startDate, endDate, status) values ('" + cbxElectionYear.Text + "', '" + cbxNumOfCandidates.Text + "', '" + cbxNumOfSRCMembers.Text + "', '" + dtpStartDate.Text + "', '" + dtpEndDate.Text + "', 'Incomplete'); ";
                MySqlConnection condb = new MySqlConnection(myConnection);
                MySqlCommand cmddb = new MySqlCommand(Query, condb);
                MySqlDataReader myReader;
                try
                {
                    condb.Open();
                    myReader = cmddb.ExecuteReader();
                    MessageBox.Show("Election Created");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            
            
        }

        private void ElectionSetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
