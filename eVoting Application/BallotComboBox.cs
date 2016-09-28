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
    public partial class BallotComboBox : Form
    {
        public BallotComboBox()
        {
            InitializeComponent();
            FillVotingComboBoxes();
            int x = 7;

            if (x < 12)
            {
                cbxVote12.Visible = false;
                lblVote12.Visible = false;
                if (x < 11)
                {
                    cbxVote11.Visible = false;
                    lblVote11.Visible = false;
                    if (x < 10)
                    {
                        cbxVote10.Visible = false;
                        lblVote10.Visible = false;
                        if (x < 9)
                        {
                            cbxVote9.Visible = false;
                            lblVote9.Visible = false;
                            if (x < 8)
                            {
                                cbxVote8.Visible = false;
                                lblVote8.Visible = false;
                                if (x < 7)
                                {
                                    cbxVote7.Visible = false;
                                    lblVote7.Visible = false;
                                    if (x < 6)
                                    {
                                        cbxVote6.Visible = false;
                                        lblVote6.Visible = false;
                                        if (x < 5)
                                        {
                                            cbxVote5.Visible = false;
                                            lblVote5.Visible = false;
                                            if (x < 4)
                                            {
                                                cbxVote4.Visible = false;
                                                lblVote4.Visible = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void FillVotingComboBoxes()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "select * from evotingApplication.candidate where electionID = 2; ";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                myReader = cmddb.ExecuteReader();

                while (myReader.Read())
                {
                    string sInitials = myReader.GetString("initials");
                    string sLastName = myReader.GetString("lastName");
                    cbxVote1.Items.Add(sInitials + " " + sLastName);
                    cbxVote2.Items.Add(sInitials + " " + sLastName);
                    cbxVote3.Items.Add(sInitials + " " + sLastName);
                    cbxVote4.Items.Add(sInitials + " " + sLastName);
                    cbxVote5.Items.Add(sInitials + " " + sLastName);
                    cbxVote6.Items.Add(sInitials + " " + sLastName);
                    cbxVote7.Items.Add(sInitials + " " + sLastName);
                    cbxVote8.Items.Add(sInitials + " " + sLastName);
                    cbxVote9.Items.Add(sInitials + " " + sLastName);
                    cbxVote10.Items.Add(sInitials + " " + sLastName);
                    cbxVote11.Items.Add(sInitials + " " + sLastName);
                    cbxVote12.Items.Add(sInitials + " " + sLastName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
