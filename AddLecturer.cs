using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Collegexxx
{
    internal class AddLecturer:DAO
    {
        public void AddLec(string fn, string sn, string dob, string cy, string cse, int hours)
        {
            string insert = "INSERT INTO Lecturer(Firstname, Surname, DOB, County, Course, Hours) VALUES(@fn,@sn,@dob,@cy,@cse,@hrs)";
            SqlCommand cmd = new SqlCommand(insert, OpenCon());
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@cse", cse);
            cmd.Parameters.AddWithValue("@hrs", hours);

            cmd.ExecuteNonQuery();
            CloseCon();

        }
    }
}
