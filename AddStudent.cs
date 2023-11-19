using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Collegexxx
{
    internal class AddStudent:DAO
    {
        SqlDataAdapter da;
        DataTable dt;
        public void AddStu(string fn, string sn, string dob, string cy, string cse)
        {
            string insert = "INSERT INTO Student(Firstname, Surname, DOB, County, Course) Values(@fn, @sn, @dob, @cy, @cse)";
            SqlCommand cmd = new SqlCommand(insert, OpenCon());
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@cse", cse);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public DataTable ShowStu()
        {
            string select = "SELECT * FROM Student";
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = new SqlCommand(select, OpenCon());
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
