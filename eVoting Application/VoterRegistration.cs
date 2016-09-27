using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eVoting_Application
{
    public partial class VoterRegistration : Form
    {
        public VoterRegistration(string studentNum, string electionID)
        {
            InitializeComponent();
            lblElecID.Text = electionID;
            lblStudentNum.Text = studentNum;
        }
    }
}
