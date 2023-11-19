using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collegexxx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AddStudent ads = new AddStudent();
        AddLecturer al = new AddLecturer();

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(Counties));
            cboCourse.DataSource = Enum.GetValues(typeof(Courses));
            cboLecCounty.DataSource = Enum.GetValues(typeof(Counties));
            cboLecCourse.DataSource = Enum.GetValues(typeof(Courses));
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToDB_Click(object sender, EventArgs e)
        {
            //Collect Variables
            string fn=txtName.Text;
            string sn=txtSurname.Text;
            string dob=dtp1.Text;
            string cy=cboCounty.SelectedItem.ToString();
            string cse=cboCourse.SelectedItem.ToString();

            //Call a method
            ads.AddStu(fn,sn,dob,cy,cse);

            //Tidy Up
            txtName.Clear();
            txtSurname.Clear();
        }

        private void btnAddLec_Click(object sender, EventArgs e)
        {
            //Collect Variables
            string fn = txtLecFN.Text;
            string sn = txtLecSN.Text;
            string dob = dtpLecDOB.Text;
            string cy = cboLecCounty.SelectedItem.ToString();
            string cse = cboLecCourse.SelectedItem.ToString();
            int hours = int.Parse(txtLecHours.Text);
            //Call a method
            al.AddLec(fn, sn, dob, cy, cse, hours);

            //Tidy Up
            txtName.Clear();
            txtSurname.Clear();
            txtLecHours.Clear();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewPeople vp =new ViewPeople();
            vp.Show();
        }
    }
}
