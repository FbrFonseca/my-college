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
    public partial class ViewPeople : Form
    {
        public ViewPeople()
        {
            InitializeComponent();
        }

        AddLecturer al = new AddLecturer();
        AddStudent  ads = new AddStudent();

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ads.ShowStu();
        }

        private void btnShowLecturers_Click(object sender, EventArgs e)
        {

        }
    }
}
