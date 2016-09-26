﻿using System;
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
    public partial class Add_Candidates : Form
    {
        //public static int electID;
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
            string Query = "SELECT count(*) as numCand FROM evotingapplication.candidate;";
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
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "insert into evotingapplication.candidate (studentNum, initials, lastName, faculty, age, gender, yearOfStudy, electionID) values ('"+tbxStudentNum.Text+"', '"+tbxInitials.Text+"', '"+tbxLastName.Text+"', '"+cbxFaculty.Text+"', '"+tbxAge.Text+"', '"+cbxGender.Text+"', '"+cbxYearOfStudy.Text+"', '"+lblElecID.Text+"'); ";
            MySqlConnection condb = new MySqlConnection(myConnection);
            MySqlCommand cmddb = new MySqlCommand(Query, condb);
            MySqlDataReader myReader;
            try
            {
                condb.Open();
                if (Convert.ToInt32(tbxAge.Text) < 18 || Convert.ToInt32(tbxAge.Text) > 100)
                {
                    MessageBox.Show("Please enter an age between 18 and 100");
                }
                else
                {
                    myReader = cmddb.ExecuteReader();
                    MessageBox.Show("Candidate Added");
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
}
