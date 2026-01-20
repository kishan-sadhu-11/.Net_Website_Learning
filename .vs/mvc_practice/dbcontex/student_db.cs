using System.Data.SqlClient;
using mvc_practice.Models;

namespace mvc_practice.dbcontext
{
    public class studnt_db
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

        public void student_add(Student s)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "INSERT INTO STUDENT (Email, Password) VALUES (@Email, @Password)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Email", s.Email);
                cmd.Parameters.AddWithValue("@Password", s.Password);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}