using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace eVoting_Application
{
    public partial class Add_Candidates : Form
    {
        public static string electID;
        public static bool imageLoaded = false;
        public Add_Candidates(int electionID)
        {
            InitializeComponent();
            //electionID = electID;
            lblElecID.Text = Convert.ToString(electionID);
            ElecYearLabel();
            CandCountLabel();

        }

        private void CandCountLabel()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "SELECT count(*) as numCand FROM evotingapplication.candidate where electionID = '"+lblElecID.Text+"';";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                myReader = cmddb.ExecuteReader();

                while (myReader.Read())
                {
                    int iNumCand = myReader.GetInt32("numCand") + 1;

                    lblX.Text = iNumCand.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ElecYearLabel()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "SELECT * FROM evotingapplication.election where electionID='"+lblElecID.Text+"' ;";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                myReader = cmddb.ExecuteReader();

                while (myReader.Read())
                {
                    string sElecYear = myReader.GetInt32("elecYear").ToString();
                    lblElecYear.Text = sElecYear;
                    string sNumCand = myReader.GetInt32("NumCand").ToString();
                    lblY.Text = sNumCand;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveCandidate_Click(object sender, EventArgs e)
        {
            if (imageLoaded == false)
            {
                MessageBox.Show("Please upload an image!", "Upload Image",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                byte[] imageBT = null;
                FileStream fStream = new FileStream(this.tbxImagePath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader bReader = new BinaryReader(fStream);
                imageBT = bReader.ReadBytes((int)fStream.Length);

                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                string Query = "insert into evotingapplication.candidate (studentNum, initials, lastName, faculty, age, gender, yearOfStudy, electionID, image)" +
                    "values ('" + tbxStudentNum.Text + "', '" + tbxInitials.Text + "', '" + tbxLastName.Text + "', '" + cbxFaculty.Text + "', '" + tbxAge.Text + "', '" + cbxGender.Text + "', '" + cbxYearOfStudy.Text + "', '" + lblElecID.Text + "', @IMG); ";
                MySqlConnection condb = new MySqlConnection(myConnection);
                MySqlCommand cmddb = new MySqlCommand(Query, condb);
                MySqlDataReader myReader;
                try
                {

                    if (Convert.ToInt32(tbxAge.Text) < 18 || Convert.ToInt32(tbxAge.Text) > 100)
                    {
                        MessageBox.Show("Please enter an age between 18 and 100");
                    }
                    else
                    {
                        condb.Open();
                        cmddb.Parameters.Add(new MySqlParameter("@IMG", imageBT));
                        myReader = cmddb.ExecuteReader();
                        DialogResult result = MessageBox.Show("Candidate Added", "Candidate", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            if (Convert.ToInt32(lblX.Text) == Convert.ToInt32(lblY.Text))
                            {
                                string id = lblElecID.Text;
                                VoterLogin vl = new VoterLogin(id);
                                vl.ShowDialog();
                                this.Hide();
                            }
                            
                            electID = lblElecID.Text;
                            imageLoaded = false;
                            this.Controls.Clear();
                            this.InitializeComponent();
                            lblElecID.Text = electID;
                            ElecYearLabel();
                            CandCountLabel();

                        }


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
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            dlg.Title = "Select Candidate Photo (300x300px).";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picLoc = dlg.FileName.ToString();
                tbxImagePath.Text = picLoc;
                pbxCandidatePhoto.ImageLocation = picLoc;
                imageLoaded = true;
            }
        }
    }
}
