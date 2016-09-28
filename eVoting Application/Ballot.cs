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
        public Ballot()
        {
            InitializeComponent();
            FillStudentData();

        }

        private void FillStudentData()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "SELECT * FROM evotingapplication.students where studentNumber = '210010011'; ";
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
                    tbxElecId.Text = "2";
                    tbxStudentNum.Text = "210010011";
                    
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
            MySqlCommand SelectCommand = new MySqlCommand("SELECT candID, initials, lastName, faculty, age FROM evotingapplication.candidate where electionID = 2;", myConn);

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
