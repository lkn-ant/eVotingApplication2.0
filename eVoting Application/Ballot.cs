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
    public partial class Ballot : Form
    {
        public static int voteCount;
        public Ballot(string studentNumber, string electionID)
        {
            InitializeComponent();
            
            string studNum = studentNumber;
            string elecID = electionID;

            tbxStudentNum.Text = studNum;
            tbxElecId.Text = elecID;
            
            FillStudentData();
            FillNumSRC();

            btnVote.Visible = false;
            btnFinished.Visible = false;
            voteCount = 0;

        }

        private void FillNumSRC()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "SELECT * FROM evotingapplication.election where electionID = '"+tbxElecId.Text+"'; ";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                myReader = cmddb.ExecuteReader();

                while (myReader.Read())
                {
                    string sNumSRC = myReader.GetInt32("numSRC").ToString();
                    tbxNumSRC.Text = sNumSRC;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillStudentData()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "SELECT * FROM evotingapplication.students where studentNumber = '"+tbxStudentNum.Text+"'; ";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                myReader = cmddb.ExecuteReader();

                while (myReader.Read())
                {
                    string sAge = myReader.GetInt32("age").ToString();
                    string sFaculty = myReader.GetString("faculty");
                    string sGender = myReader.GetString("gender");
                    string sYearOfStudy = myReader.GetString("yearOfStudy");
                    tbxStudentAge.Text = sAge;
                    tbxStudentFaculty.Text = sFaculty;
                    tbxStudentGender.Text = sGender;
                    tbxStudentYearOfStudy.Text = sYearOfStudy;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadBallot_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT candID, initials, lastName, faculty, age, image FROM evotingapplication.candidate where electionID = '"+tbxElecId.Text+"';", myConn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = SelectCommand;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                
                
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                btnLoadBallot.Visible = false;
                btnVote.Visible = true;
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            //    tbxCandID.Text = row.Cells["candID"].Value.ToString();
            //    tbxInitials.Text = row.Cells["initials"].Value.ToString();
            //    tbxLastName.Text = row.Cells["lastName"].Value.ToString();
            //    tbxFaculty.Text = row.Cells["faculty"].Value.ToString();
            //    tbxAge.Text = row.Cells["age"].Value.ToString();


            //}
        }

        private void lblFaculty_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ballot_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string candID = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string initials = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string lastName = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string faculty = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                string age = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;

                tbxCandID.Text = candID;
                tbxInitials.Text = initials;
                tbxLastName.Text = lastName;
                tbxFaculty.Text = faculty;
                tbxAge.Text = age;

            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "insert into evotingapplication.votes (electionID, candID, studentNumber, studentAge, studentFaculty, studentGender, studentYearOfStudy)"
            + "values ('" + tbxElecId.Text + "', '" + tbxCandID.Text + "', '" + tbxStudentNum.Text + "', '" + tbxStudentAge.Text + "', '" + tbxStudentFaculty.Text + "', '"+tbxStudentGender.Text+"', '"+tbxStudentYearOfStudy.Text+"'); ";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                    condb.Open();
                    myReader = cmddb.ExecuteReader();
                    MessageBox.Show("Vote Saved!", "Ballot");
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    voteCount = voteCount + 1;
                    CheckVoteCount();
                    while (myReader.Read())
                    {

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckVoteCount()
        {
            if (voteCount == Convert.ToInt32(tbxNumSRC.Text))
            {
                btnVote.Visible = false;
                btnFinished.Visible = true;
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "update evotingapplication.approvedstudents set voted ='yes' where studentNumber='"+tbxStudentNum.Text+"' and electionID='"+tbxElecId+"'; ";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                myReader = cmddb.ExecuteReader();
                DialogResult result = MessageBox.Show("Thank You for Voting", "Ballot", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    VoterLogin vl = new VoterLogin(tbxElecId.Text);
                    vl.ShowDialog();
                    this.Hide();

                }

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
}
