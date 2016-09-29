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
    public partial class VotingResults : Form
    {
        public VotingResults(string elecID)
        {
            InitializeComponent();
            lblElecID.Text = elecID;
            chart1.Visible = false;
            chart2.Visible = false;
            
        }

        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart2.Visible = false;
            int electionID = Convert.ToInt32(lblElecID.Text);
            

            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "CALL `evotingapplication`.`new_procedure`('"+electionID+"');";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                myReader = cmddb.ExecuteReader();

                while (myReader.Read())
                {
                    this.chart1.Series["Votes"].Points.AddXY(myReader.GetString("lastName"), myReader.GetInt32("Vote Count"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAvgAge_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            chart2.Visible = true;
            int electionID = Convert.ToInt32(lblElecID.Text);
            
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "CALL `evotingapplication`.`new_procedure2`('"+electionID+"');";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                myReader = cmddb.ExecuteReader();

                while (myReader.Read())
                {
                    this.chart2.Series["Votes"].Points.AddXY(myReader.GetString("lastName"), myReader.GetInt32("Average Age"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGender_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ElectionStartup es = new ElectionStartup();
            es.ShowDialog();
            this.Hide();
        }
    }
}
